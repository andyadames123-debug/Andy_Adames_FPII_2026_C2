using System;
using System.Text;
using System.Windows.Forms;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using Newtonsoft.Json;

namespace Tarea_2._1
{
    public partial class LoteTech : Form
    {
        // Estructura para leer los números que mande el Servidor en JSON
        public class SorteoData
        {
            public int numero1 { get; set; }
            public int numero2 { get; set; }
            public int numero3 { get; set; }
        }

        private IMqttClient mqttClient;
        private string miClienteId;

        // Variables globales para guardar los números que mande el servidor
        private int numeroGanador1 = -1;
        private int numeroGanador2 = -1;
        private int numeroGanador3 = -1;

        public LoteTech()
        {
            InitializeComponent();
            miClienteId = "LoteTech_Client_" + Guid.NewGuid().ToString().Substring(0, 5);
            ConectarMQTT();
        }

        private async void ConectarMQTT()
        {
            try
            {
                var factory = new MqttFactory();
                mqttClient = factory.CreateMqttClient();

                var options = new MqttClientOptionsBuilder()
                    .WithTcpServer("test.mosquitto.org", 1883)
                    .WithClientId(miClienteId)
                    .WithCleanSession()
                    .Build();

                mqttClient.UseApplicationMessageReceivedHandler(e =>
                {
                    string topico = e.ApplicationMessage.Topic;
                    string payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);

                    // CUANDO EL SERVIDOR PUBLICA LOS NÚMEROS EN JSON
                    if (topico == "granpremio/sorteo")
                    {
                        var datosSorteo = JsonConvert.DeserializeObject<SorteoData>(payload);

                        // Guardamos los números del servidor en nuestras variables
                        numeroGanador1 = datosSorteo.numero1;
                        numeroGanador2 = datosSorteo.numero2;
                        numeroGanador3 = datosSorteo.numero3;

                        // Los mostramos en pantalla
                        this.Invoke((Action)(() => {
                            textPrimera.Text = numeroGanador1.ToString();
                            textSegunda.Text = numeroGanador2.ToString();
                            textTercera.Text = numeroGanador3.ToString();

                            // Llamamos automáticamente a revisar si con estos números ganamos
                            CalcularPremioLocal();
                        }));
                    }
                });

                await mqttClient.ConnectAsync(options);
                await mqttClient.SubscribeAsync("granpremio/sorteo");

                MessageBox.Show("¡Cliente Conectado con éxito y esperando sorteo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión en el Cliente:\n" + ex.Message);
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textPrimera.Text) ||
                string.IsNullOrWhiteSpace(textSegunda.Text) ||
                string.IsNullOrWhiteSpace(textTercera.Text))
            {
                MessageBox.Show("Por favor, digite sus números primero antes de enviar la jugada.");
                return;
            }

 
            if (mqttClient != null && mqttClient.IsConnected)
            {
                string mensajeJugada = $"{miClienteId} ha realizado su jugada.";

                var msg = new MqttApplicationMessageBuilder()
                    .WithTopic("granpremio/jugadas")
                    .WithPayload(mensajeJugada)
                    .Build();

                await mqttClient.PublishAsync(msg);
                MessageBox.Show("¡Jugada registrada en el sistema! Espere a que el Servidor publique el sorteo.");
            }
            else
            {
                MessageBox.Show("El cliente no está conectado a MQTT.");
            }
        }

        private void CalcularPremioLocal()
        {
            try
            {

                double apuestaBase = 100;
                double totalGanado = 0;
                bool ganoAlgo = false;

                int miNumero1 = Convert.ToInt32(textPrimera.Text);
                int miNumero2 = Convert.ToInt32(textSegunda.Text);
                int miNumero3 = Convert.ToInt32(textTercera.Text);

                if (miNumero1 == numeroGanador1) { totalGanado += apuestaBase * 1000; ganoAlgo = true; }
                if (miNumero2 == numeroGanador2) { totalGanado += apuestaBase * 100; ganoAlgo = true; }
                if (miNumero3 == numeroGanador3) { totalGanado += apuestaBase * 10; ganoAlgo = true; }

                if (ganoAlgo)
                {
                    textPremio.Text = "RD$ " + totalGanado.ToString();
                    MessageBox.Show($"¡Felicidades! Te sacaste: RD$ {totalGanado}");
                }
                else
                {
                    textPremio.Text = "RD$ 0.00";
                    MessageBox.Show("No hubo suerte esta vez. Sigue intentando.");
                }
            }
            catch
            {
                // Si da error al calcular es porque las cajas estaban vacías cuando llegó el sorteo
                textPremio.Text = "Error al calcular";
            }
        }

        private void button_10_Click(object sender, EventArgs e)
        {
            textApuesta.Text = "10";
        }

        private void button_100_Click(object sender, EventArgs e)
        {
            textApuesta.Text = "100";
        }

        private void button_1000_Click(object sender, EventArgs e)
        {
            textApuesta.Text = "1000";
        }
    }
}