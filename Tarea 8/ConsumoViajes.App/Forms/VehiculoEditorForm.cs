using ConsumoViajes.App.Models;

namespace ConsumoViajes.App.Forms;

/// <summary>
/// Ventana para crear o editar un perfil de vehículo.
/// </summary>
public partial class VehiculoEditorForm : Form
{
    /// <summary>Vehículo que se está creando o editando.</summary>
    public Vehiculo Vehiculo { get; private set; }

    public VehiculoEditorForm(Vehiculo? vehiculo = null)
    {
        InitializeComponent();

        if (vehiculo is null)
        {
            // Modo "nuevo": se crea una instancia vacía que se llenará al guardar.
            Vehiculo = new Vehiculo();
            Text = "Nuevo vehículo";
        }
        else
        {
            // Modo "editar": se cargan los valores actuales en el formulario.
            Vehiculo = vehiculo;
            Text = "Editar vehículo";
            txtNombre.Text = vehiculo.Nombre;
            numConsumoCiudad.Value = (decimal)vehiculo.ConsumoCiudad;
            numConsumoCarretera.Value = (decimal)vehiculo.ConsumoCarretera;
            numCapacidad.Value = (decimal)vehiculo.CapacidadTanque;
        }
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        // Validación básica: el nombre es obligatorio.
        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            MessageBox.Show(
                "Debe indicar el nombre o modelo del vehículo.",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txtNombre.Focus();
            return;
        }

        // Se copian los valores validados (los NumericUpDown ya restringen el rango)
        // de vuelta al modelo, y se cierra la ventana con resultado OK.
        Vehiculo.Nombre = txtNombre.Text.Trim();
        Vehiculo.ConsumoCiudad = (double)numConsumoCiudad.Value;
        Vehiculo.ConsumoCarretera = (double)numConsumoCarretera.Value;
        Vehiculo.CapacidadTanque = (double)numCapacidad.Value;

        DialogResult = DialogResult.OK;
    }
}
