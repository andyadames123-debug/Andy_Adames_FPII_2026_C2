using ConsumoViajes.App.Forms;

namespace ConsumoViajes.App;

/// <summary>
/// Punto de entrada de la aplicación de cálculo de consumo de viajes.
/// </summary>
static class Program
{
    [STAThread]
    static void Main()
    {
        // Inicializa los estilos visuales de la aplicación (Theme de Windows).
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}
