namespace ConsumoViajes.App.Models;

/// <summary>
/// Contenedor de todos los resultados generados por la calculadora de viajes.
/// Mantiene tanto los totales como el detalle de cada tramo para mostrarlo en la UI.
/// </summary>
public class ResultadoViaje
{
    /// <summary>Distancia recorrida en ciudad (Km).</summary>
    public double DistanciaCiudad { get; set; }

    /// <summary>Distancia recorrida en carretera (Km).</summary>
    public double DistanciaCarretera { get; set; }

    /// <summary>Combustible usado en el tramo de ciudad (Galones).</summary>
    public double GalonesCiudad { get; set; }

    /// <summary>Combustible usado en el tramo de carretera (Galones).</summary>
    public double GalonesCarretera { get; set; }

    /// <summary>Combustible total requerido, ya con el ajuste por peso (Galones).</summary>
    public double GalonesTotales { get; set; }

    /// <summary>Costo total estimado del viaje.</summary>
    public double CostoTotal { get; set; }

    /// <summary>Rendimiento promedio real del viaje (Km/Galón).</summary>
    public double RendimientoPromedio { get; set; }

    /// <summary>Porcentaje del tanque que se consumirá en el viaje (0 a 100+).</summary>
    public double PorcentajeTanque { get; set; }

    /// <summary>Número de pasajeros adicionales al conductor.</summary>
    public int PasajerosExtra { get; set; }

    /// <summary>Factor multiplicador aplicado por el peso (1 + 1.5% * pasajeros extra).</summary>
    public double FactorPeso { get; set; }
}
