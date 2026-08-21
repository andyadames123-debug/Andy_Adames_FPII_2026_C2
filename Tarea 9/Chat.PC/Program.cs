using System.Text;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Protocol;

const string BROKER = "broker.hivemq.com";
const int PUERTO = 1883;
const string TOPICO_CELULAR_A_PC = "chat/celular_a_pc";
const string TOPICO_PC_A_CELULAR = "chat/pc_a_celular";

var factory = new MqttFactory();
using var cliente = factory.CreateMqttClient();
var saliendo = false;

var opciones = new MqttClientOptionsBuilder()
    .WithTcpServer(BROKER, PUERTO)
    .WithClientId($"ChatPC_{Guid.NewGuid():N}")
    .WithCleanSession()
    .Build();

// Mensajes entrantes: los que envía el celular y los que publica la propia consola.
cliente.ApplicationMessageReceivedAsync += e =>
{
    string texto = Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment);
    string emisor = e.ApplicationMessage.Topic == TOPICO_CELULAR_A_PC ? "Celular" : "PC";

    Console.WriteLine($"[{emisor}] {texto}");
    return Task.CompletedTask;
};

// Suscripción en cada (re)conexión.
cliente.ConnectedAsync += async e =>
{
    await cliente.SubscribeAsync(new MqttTopicFilterBuilder().WithTopic(TOPICO_CELULAR_A_PC).Build());
    await cliente.SubscribeAsync(new MqttTopicFilterBuilder().WithTopic(TOPICO_PC_A_CELULAR).Build());
    Console.WriteLine("Conectado y suscrito a chat/celular_a_pc y chat/pc_a_celular.");
    Console.WriteLine("Escriba un mensaje y presione Enter ('salir' para terminar).");
};

// Reconexión automática.
cliente.DisconnectedAsync += async e =>
{
    if (saliendo)
    {
        return;
    }

    Console.WriteLine("Desconectado. Reintentando...");
    await Task.Delay(3000);
    try
    {
        await cliente.ConnectAsync(opciones);
    }
    catch
    {
        // El siguiente DisconnectedAsync reintentará de nuevo.
    }
};

Console.WriteLine($"Conectando a {BROKER}:{PUERTO}...");
await cliente.ConnectAsync(opciones);

// Bucle principal: leer texto del usuario y publicarlo en chat/pc_a_celular.
while (true)
{
    string? texto = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(texto))
    {
        continue;
    }

    if (texto.Equals("salir", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }

    var mensaje = new MqttApplicationMessageBuilder()
        .WithTopic(TOPICO_PC_A_CELULAR)
        .WithPayload(texto)
        .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
        .Build();

    await cliente.PublishAsync(mensaje);
}

Console.WriteLine("Finalizando...");
saliendo = true;
await cliente.DisconnectAsync();
