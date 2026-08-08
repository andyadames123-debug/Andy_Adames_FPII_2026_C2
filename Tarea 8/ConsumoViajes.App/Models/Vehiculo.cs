namespace ConsumoViajes.App.Models;

/// <summary>
/// Representa un perfil de vehículo guardado en la aplicación.
/// Los consumos se expresan en Km/Galón y la capacidad del tanque en Galones,
/// de modo que todas las unidades del programa son coherentes entre sí.
/// </summary>
public class Vehiculo
{
    /// <summary>Identificador único del vehículo.</summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>Nombre o modelo del vehículo (Ej: "Daihatsu Mira").</summary>
    public string Nombre { get; set; } = string.Empty;

    /// <summary>Consumo base en ciudad (Km por Galón).</summary>
    public double ConsumoCiudad { get; set; }

    /// <summary>Consumo base en carretera (Km por Galón).</summary>
    public double ConsumoCarretera { get; set; }

    /// <summary>Capacidad del tanque (Galones).</summary>
    public double CapacidadTanque { get; set; }

    /// <summary>
    /// Permite mostrar el vehículo directamente en el ComboBox usando su nombre.
    /// </summary>
    public override string ToString() => Nombre;
}
