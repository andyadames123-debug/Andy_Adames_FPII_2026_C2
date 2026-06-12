using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
// Esta librería es la que transforma los datos a formato JSON
using Newtonsoft.Json;

namespace Tarea_2._1
{
    public partial class LoteTech : Form
    {
        private IMqttClient mqttClient;

        public LoteTech()
        {
            InitializeComponent();
            ConectarMQTT();
        }

        private async void ConectarMQTT()
        {
            try
            {
                var factory = new MqttFactory();
                mqttClient = factory.CreateMqttClient();

                // Creamos un ClientId único para que el broker de HiveMQ no bloquee la conexión
                string idUnicoServer = "LoteTech_Server_" + Guid.NewGuid().ToString().Substring(0, 5);

                var options = new MqttClientOptionsBuilder()
                    .WithTcpServer("test.mosquitto.org", 1883) // Cambiamos a Mosquitto que tiene rutas más abiertas
                    .WithClientId(idUnicoServer)
                    .WithCleanSession()
                    .Build(); ;

                await mqttClient.ConnectAsync(options);
                MessageBox.Show("¡Servidor Conectado a MQTT con éxito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión en el Servidor:\n" + ex.Message);
            }
        }

        // ================================================================
        // BOTÓN PUBLICAR - TOMA LOS 3 NÚMEROS Y LOS ENVÍA EN FORMATO JSON
        // ================================================================
        private async void buttonPublicar_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(textPrimera.Text) ||
                string.IsNullOrWhiteSpace(textSegunda.Text) ||
                string.IsNullOrWhiteSpace(textTercera.Text))
            {
                MessageBox.Show("Por favor, digite los 3 números en las cajas antes de publicar.");
                return;
            }

            try
            {
             
                int Numero1 = Convert.ToInt32(textPrimera.Text);
                int Numero2 = Convert.ToInt32(textSegunda.Text);
                int Numero3 = Convert.ToInt32(textTercera.Text);

                // 3. Verificar si el cliente MQTT está listo para enviar
                if (mqttClient != null && mqttClient.IsConnected)
                {
                    // Creamos la estructura del objeto
                    var datosSorteo = new
                    {
                        numero1 = Numero1,
                        numero2 = Numero2,
                        numero3 = Numero3
                    };

                    
                    string jsonSorteo = JsonConvert.SerializeObject(datosSorteo);

                    // Preparamos el mensaje para enviarlo al broker
                    var msg = new MqttApplicationMessageBuilder()
                        .WithTopic("granpremio/sorteo")
                        .WithPayload(jsonSorteo)
                        .Build();

                    // Se dispara el JSON a la nube
                    await mqttClient.PublishAsync(msg);
                    MessageBox.Show("¡Sorteo publicado con éxito en formato JSON!");
                }
                else
                {
                    MessageBox.Show("El servidor no está conectado a MQTT. Intentando reconectar...");
                    ConectarMQTT();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar o publicar: " + ex.Message);
            }
        }
    }
}