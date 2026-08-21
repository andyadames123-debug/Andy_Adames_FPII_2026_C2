using System.Text;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Protocol;

namespace Chat.Mobile;

public partial class MainPage : ContentPage
{
    private const string BROKER = "broker.hivemq.com";
    private const int PUERTO = 1883;
    private const string TOPICO_CELULAR_A_PC = "chat/celular_a_pc";
    private const string TOPICO_PC_A_CELULAR = "chat/pc_a_celular";

    private readonly IMqttClient _cliente;
    private readonly MqttClientOptions _opciones;

    public MainPage()
    {
        InitializeComponent();

        var factory = new MqttFactory();
        _cliente = factory.CreateMqttClient();

        _opciones = new MqttClientOptionsBuilder()
            .WithTcpServer(BROKER, PUERTO)
            .WithClientId($"ChatMobile_{Guid.NewGuid():N}")
            .WithCleanSession()
            .Build();

        _cliente.ConnectedAsync += OnConectadoAsync;
        _cliente.DisconnectedAsync += OnDesconectadoAsync;
        _cliente.ApplicationMessageReceivedAsync += OnMensajeRecibidoAsync;
    }

    private async Task OnConectadoAsync(MqttClientConnectedEventArgs e)
    {
        await _cliente.SubscribeAsync(
            new MqttTopicFilterBuilder().WithTopic(TOPICO_PC_A_CELULAR).Build());

        MainThread.BeginInvokeOnMainThread(() =>
        {
            LblEstado.Text = "Conectado";
            LblEstado.TextColor = Colors.Green;
            BtnConectar.IsEnabled = false;
            BtnEnviar.IsEnabled = true;
        });
    }

    private async Task OnDesconectadoAsync(MqttClientDisconnectedEventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            LblEstado.Text = "Desconectado";
            LblEstado.TextColor = Colors.Red;
            BtnConectar.IsEnabled = true;
            BtnEnviar.IsEnabled = false;
        });

        await Task.Delay(3000);
        if (!_cliente.IsConnected)
        {
            try
            {
                await _cliente.ConnectAsync(_opciones);
            }
            catch
            {
                // El siguiente evento DisconnectedAsync reintentará de nuevo.
            }
        }
    }

    private Task OnMensajeRecibidoAsync(MqttApplicationMessageReceivedEventArgs e)
    {
        string texto = Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment);

        // Actualizar la UI siempre desde el hilo principal.
        MainThread.BeginInvokeOnMainThread(() =>
        {
            EditorChat.Text += $"[PC] {texto}{Environment.NewLine}";
        });

        return Task.CompletedTask;
    }

    private async void OnConectarClicked(object? sender, EventArgs e)
    {
        BtnConectar.IsEnabled = false;
        LblEstado.Text = "Conectando...";

        try
        {
            await _cliente.ConnectAsync(_opciones);
        }
        catch (Exception ex)
        {
            LblEstado.Text = $"Error: {ex.Message}";
            LblEstado.TextColor = Colors.Red;
            BtnConectar.IsEnabled = true;
        }
    }

    private async void OnEnviarClicked(object? sender, EventArgs e)
    {
        string texto = EntradaMensaje.Text?.Trim() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(texto))
        {
            return;
        }

        await _cliente.PublishAsync(new MqttApplicationMessageBuilder()
            .WithTopic(TOPICO_CELULAR_A_PC)
            .WithPayload(texto)
            .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
            .Build());

        EditorChat.Text += $"[Yo] {texto}{Environment.NewLine}";
        EntradaMensaje.Text = string.Empty;
    }
}
