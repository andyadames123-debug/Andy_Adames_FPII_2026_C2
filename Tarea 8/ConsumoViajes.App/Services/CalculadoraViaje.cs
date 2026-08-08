using ConsumoViajes.App.Models;

namespace ConsumoViajes.App.Services;

/// <summary>
/// Motor de cálculo del viaje. Esta clase es 100% independiente de la interfaz
/// gráfica (arquitectura limpia): recibe los datos de entrada y devuelve un
/// <see cref="ResultadoViaje"/> con todos los valores calculados.
/// </summary>
public class CalculadoraViaje
{
    /// <summary>
    /// Porcentaje extra de consumo (+1.5%) que se aplica por cada pasajero
    /// adicional al conductor, para simular el mayor peso del vehículo.
    /// </summary>
    private const double AjustePorPasajeroAdicional = 0.015;

    /// <summary>
    /// Calcula el costo y el consumo de un viaje completo.
    /// </summary>
    /// <param name="vehiculo">Vehículo seleccionado por el usuario.</param>
    /// <param name="distanciaTotal">Distancia total del viaje en Km.</param>
    /// <param name="porcentajeCiudad">Porcentaje (0-100) del trayecto en ciudad.</param>
    /// <param name="precioCombustible">Precio del combustible por Galón.</param>
    /// <param name="ocupantes">Número de personas en el vehículo (mínimo 1: el conductor).</param>
    /// <returns>Resultado con los totales y el detalle por tramo.</returns>
    public ResultadoViaje Calcular(
        Vehiculo vehiculo,
        double distanciaTotal,
        double porcentajeCiudad,
        double precioCombustible,
        int ocupantes)
    {
        ValidarEntrada(vehiculo, distanciaTotal, porcentajeCiudad, precioCombustible, ocupantes);

        // 1. Distribución del trayecto según el porcentaje de ciudad.
        double distanciaCiudad = distanciaTotal * porcentajeCiudad / 100.0;
        double distanciaCarretera = distanciaTotal - distanciaCiudad;

        // 2. Combustible (galones) requerido por cada tramo:
        //    Galones_Tramo = Distancia_Tramo / Consumo_Vehiculo
        double galonesCiudad = distanciaCiudad / vehiculo.ConsumoCiudad;
        double galonesCarretera = distanciaCarretera / vehiculo.ConsumoCarretera;
        double galonesBase = galonesCiudad + galonesCarretera;

        // 3. Ajuste por peso: +1.5% por cada pasajero adicional al conductor.
        int pasajerosExtra = Math.Max(0, ocupantes - 1);
        double factorPeso = 1.0 + AjustePorPasajeroAdicional * pasajerosExtra;
        double galonesTotales = galonesBase * factorPeso;

        // 4. Costo total y rendimiento resultante.
        double costoTotal = galonesTotales * precioCombustible;
        double rendimientoPromedio = galonesTotales > 0
            ? distanciaTotal / galonesTotales
            : 0;

        // 5. Comparativa contra el tanque del vehículo seleccionado.
        double porcentajeTanque = vehiculo.CapacidadTanque > 0
            ? galonesTotales / vehiculo.CapacidadTanque * 100.0
            : 0;

        return new ResultadoViaje
        {
            DistanciaCiudad = distanciaCiudad,
            DistanciaCarretera = distanciaCarretera,
            GalonesCiudad = galonesCiudad,
            GalonesCarretera = galonesCarretera,
            GalonesTotales = galonesTotales,
            CostoTotal = costoTotal,
            RendimientoPromedio = rendimientoPromedio,
            PorcentajeTanque = porcentajeTanque,
            PasajerosExtra = pasajerosExtra,
            FactorPeso = factorPeso,
        };
    }

    /// <summary>
    /// Validaciones básicas de entrada. Lanza una excepción descriptiva si
    /// algún valor no es válido, protegiendo la lógica de división por cero.
    /// </summary>
    private static void ValidarEntrada(
        Vehiculo vehiculo,
        double distanciaTotal,
        double porcentajeCiudad,
        double precioCombustible,
        int ocupantes)
    {
        ArgumentNullException.ThrowIfNull(vehiculo);

        if (distanciaTotal <= 0)
            throw new ArgumentException("La distancia total del viaje debe ser mayor que 0.");

        if (porcentajeCiudad is < 0 or > 100)
            throw new ArgumentException("El porcentaje de ciudad debe estar entre 0 y 100.");

        if (precioCombustible <= 0)
            throw new ArgumentException("El precio del combustible debe ser mayor que 0.");

        if (ocupantes < 1)
            throw new ArgumentException("Debe haber al menos 1 ocupante (el conductor).");

        if (vehiculo.ConsumoCiudad <= 0 || vehiculo.ConsumoCarretera <= 0)
            throw new ArgumentException($"El vehículo '{vehiculo.Nombre}' tiene consumos inválidos.");

        if (vehiculo.CapacidadTanque <= 0)
            throw new ArgumentException($"El vehículo '{vehiculo.Nombre}' tiene una capacidad de tanque inválida.");
    }
}
