using System.Text.Json;
using ConsumoViajes.App.Models;

namespace ConsumoViajes.App.Data;

/// <summary>
/// Repositorio encargado de la persistencia de los perfiles de vehículos.
/// Guarda los datos en un archivo JSON dentro de la carpeta de datos locales
/// de la aplicación, de modo que los vehículos creados por el usuario sobreviven
/// entre ejecuciones sin depender de una base de datos externa.
/// </summary>
public class VehiculoRepository
{
    private const string CarpetaDatos = "ConsumoViajes";
    private const string ArchivoDatos = "vehiculos.json";

    private readonly string _rutaArchivo;

    public VehiculoRepository()
    {
        string carpeta = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            CarpetaDatos);

        Directory.CreateDirectory(carpeta);
        _rutaArchivo = Path.Combine(carpeta, ArchivoDatos);
    }

    /// <summary>
    /// Devuelve la lista de vehículos guardados. Si aún no existe ningún registro,
    /// siembra el perfil por defecto (Daihatsu Mira) para que la app siempre arranque
    /// con al menos un vehículo configurado.
    /// </summary>
    public List<Vehiculo> CargarTodos()
    {
        if (!File.Exists(_rutaArchivo))
        {
            var porDefecto = CrearPerfilPorDefecto();
            GuardarTodos(porDefecto);
            return porDefecto;
        }

        try
        {
            string json = File.ReadAllText(_rutaArchivo);
            var lista = JsonSerializer.Deserialize<List<Vehiculo>>(json) ?? new List<Vehiculo>();

            // Si el archivo existe pero está vacío, se vuelve a sembrar el perfil por defecto.
            if (lista.Count == 0)
            {
                lista.AddRange(CrearPerfilPorDefecto());
                GuardarTodos(lista);
            }

            return lista;
        }
        catch
        {
            // Ante un archivo corrupto se devuelve una lista vacía (nunca se bloquea la app).
            return new List<Vehiculo>();
        }
    }

    /// <summary>
    /// Guarda la lista completa de vehículos en el archivo JSON.
    /// </summary>
    public void GuardarTodos(List<Vehiculo> vehiculos)
    {
        var opciones = new JsonSerializerOptions { WriteIndented = true };
        File.WriteAllText(_rutaArchivo, JsonSerializer.Serialize(vehiculos, opciones));
    }

    /// <summary>
    /// Perfil por defecto preconfigurado en el código: un Daihatsu Mira con
    /// consumo económico de ciudad y carretera.
    /// </summary>
    private static List<Vehiculo> CrearPerfilPorDefecto()
    {
        return new List<Vehiculo>
        {
            new Vehiculo
            {
                Nombre = "Daihatsu Mira",
                ConsumoCiudad = 28,   // Km/Galón en ciudad
                ConsumoCarretera = 40, // Km/Galón en carretera
                CapacidadTanque = 9,   // Galones
            },
        };
    }
}
