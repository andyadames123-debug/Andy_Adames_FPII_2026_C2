using ConsumoViajes.App.Data;
using ConsumoViajes.App.Models;
using ConsumoViajes.App.Services;

namespace ConsumoViajes.App.Forms;

/// <summary>
/// Ventana principal de la aplicación: permite seleccionar un vehículo guardado,
/// ingresar los datos del viaje y ver los resultados del cálculo.
/// </summary>
public partial class MainForm : Form
{
    private readonly VehiculoRepository _repositorio;
    private readonly CalculadoraViaje _calculadora = new();
    private List<Vehiculo> _vehiculos = new();

    /// <summary>
    /// Bandera que impide recalcular mientras se está construyendo el formulario,
    /// porque durante InitializeComponent los controles aún no están listos.
    /// </summary>
    private bool _construyendo = true;

    public MainForm()
    {
        InitializeComponent();
        _repositorio = new VehiculoRepository();
        CargarVehiculos();
        _construyendo = false;

        ActualizarPorcentaje();
        CalcularViaje(); // muestra un resultado de referencia al abrir la app
    }

    #region Gestión de vehículos

    /// <summary>Carga la lista de vehículos desde el repositorio y refresca el ComboBox.</summary>
    private void CargarVehiculos()
    {
        _vehiculos = _repositorio.CargarTodos();

        cmbVehiculo.Items.Clear();
        cmbVehiculo.Items.AddRange(_vehiculos.ToArray());
        if (cmbVehiculo.Items.Count > 0)
        {
            cmbVehiculo.SelectedIndex = 0;
        }

        ActualizarEstadoBotones();
    }

    /// <summary>Habilita/deshabilita los botones de edición según exista una selección.</summary>
    private void ActualizarEstadoBotones()
    {
        bool haySeleccion = VehiculoSeleccionado is not null;
        btnEditarVehiculo.Enabled = haySeleccion;
        btnEliminarVehiculo.Enabled = haySeleccion;
    }

    private Vehiculo? VehiculoSeleccionado => cmbVehiculo.SelectedItem as Vehiculo;

    private void btnNuevoVehiculo_Click(object? sender, EventArgs e)
    {
        using var editor = new VehiculoEditorForm();
        if (editor.ShowDialog(this) == DialogResult.OK)
        {
            _vehiculos.Add(editor.Vehiculo);
            GuardarYRefrescar(editor.Vehiculo);
        }
    }

    private void btnEditarVehiculo_Click(object? sender, EventArgs e)
    {
        var vehiculo = VehiculoSeleccionado;
        if (vehiculo is null)
        {
            return;
        }

        using var editor = new VehiculoEditorForm(vehiculo);
        if (editor.ShowDialog(this) == DialogResult.OK)
        {
            GuardarYRefrescar(editor.Vehiculo);
        }
    }

    private void btnEliminarVehiculo_Click(object? sender, EventArgs e)
    {
        var vehiculo = VehiculoSeleccionado;
        if (vehiculo is null)
        {
            return;
        }

        var confirmacion = MessageBox.Show(
            $"¿Eliminar el vehículo '{vehiculo.Nombre}'?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmacion == DialogResult.Yes)
        {
            _vehiculos.Remove(vehiculo);
            GuardarYRefrescar(null);
        }
    }

    /// <summary>Persiste la lista y recoloca la selección en el vehículo indicado.</summary>
    private void GuardarYRefrescar(Vehiculo? seleccion)
    {
        _repositorio.GuardarTodos(_vehiculos);
        CargarVehiculos();

        if (seleccion is not null)
        {
            int indice = _vehiculos.IndexOf(seleccion);
            if (indice >= 0 && indice < cmbVehiculo.Items.Count)
            {
                cmbVehiculo.SelectedIndex = indice;
            }
        }
    }

    private void cmbVehiculo_SelectedIndexChanged(object? sender, EventArgs e)
    {
        ActualizarEstadoBotones();
        CalcularViaje();
    }

    #endregion

    #region Cálculo

    private void trkCiudad_Scroll(object? sender, EventArgs e)
    {
        ActualizarPorcentaje();
        CalcularViaje();
    }

    private void numDatos_ValueChanged(object? sender, EventArgs e)
    {
        CalcularViaje();
    }

    private void btnCalcular_Click(object? sender, EventArgs e)
    {
        CalcularViaje();
    }

    /// <summary>Actualiza la etiqueta que muestra la proporción Ciudad / Carretera.</summary>
    private void ActualizarPorcentaje()
    {
        int pctCiudad = trkCiudad.Value;
        int pctCarretera = 100 - pctCiudad;
        lblPctMix.Text = $"{pctCiudad}% Ciudad / {pctCarretera}% Carretera";
    }

    /// <summary>
    /// Ejecuta el cálculo con los datos actuales y muestra los resultados.
    /// Las validaciones de los controles (rangos, mínimos) ya evitan la mayoría
    /// de los errores; aquí solo se muestran los valores calculados.
    /// </summary>
    private void CalcularViaje()
    {
        if (_construyendo)
        {
            return;
        }

        var vehiculo = VehiculoSeleccionado;
        if (vehiculo is null)
        {
            lblCostoValor.Text = "—";
            lblCombustibleValor.Text = "—";
            lblRendimientoValor.Text = "—";
            lblTanqueValor.Text = "—";
            lblDetalle.Text = "Seleccione un vehículo para comenzar.";
            prbTanque.Value = 0;
            return;
        }

        try
        {
            var r = _calculadora.Calcular(
                vehiculo,
                distanciaTotal: (double)numDistancia.Value,
                porcentajeCiudad: trkCiudad.Value,
                precioCombustible: (double)numPrecio.Value,
                ocupantes: (int)numOcupantes.Value);

            // Resultados principales.
            lblCostoValor.Text = $"RD$ {r.CostoTotal.ToString("#,##0.00")}";
            lblCombustibleValor.Text = $"{r.GalonesTotales.ToString("#,##0.00")} galones";
            lblRendimientoValor.Text = $"{r.RendimientoPromedio.ToString("#,##0.00")} Km/Galón";

            // Comparativa contra el tanque del vehículo seleccionado.
            lblTanqueValor.Text = $"{r.PorcentajeTanque.ToString("#,##0.##")}%";
            prbTanque.Value = (int)Math.Min(100, r.PorcentajeTanque);

            // Detalle por tramo y ajuste por peso.
            lblDetalle.Text = $"Tramo ciudad: {r.DistanciaCiudad.ToString("#,##0.##")} Km → {r.GalonesCiudad.ToString("#,##0.##")} gal | " +
                              $"Tramo carretera: {r.DistanciaCarretera.ToString("#,##0.##")} Km → {r.GalonesCarretera.ToString("#,##0.##")} gal | " +
                              $"Ajuste por peso: +{r.PasajerosExtra * 1.5:#.#}% (factor {r.FactorPeso.ToString("0.##")})";
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "No se pudo calcular el viaje: " + ex.Message,
                "Error de cálculo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    #endregion
}
