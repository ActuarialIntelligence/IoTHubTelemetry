using System;
using System.Linq;
using System.Text;
using Microsoft.Azure.Devices;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;

namespace IoTTelemetry
{
    public static class Telemetry
    {
        static ServiceClient serviceClient;
        static string connectionString = "{iot hub connection string}";
        static DeviceClient s_deviceClient;

        private static async void ReceiveC2dAsync()
        {
            Console.WriteLine("\nReceiving cloud to device messages from service");
            while (true)
            {

                Microsoft.Azure.Devices.Client.Message receivedMessage 
                    = await s_deviceClient.ReceiveAsync();
                if (receivedMessage == null) continue;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Received message: {0}",
                Encoding.ASCII.GetString(receivedMessage.GetBytes()));
                Console.ResetColor();

                await s_deviceClient.CompleteAsync(receivedMessage);
            }


        }

        private async static Task SendCloudToDeviceMessageAsync()
        {
            var commandMessage = new
             Microsoft.Azure.Devices.Message(Encoding.ASCII.GetBytes("Cloud to device message."));
            await serviceClient.SendAsync("myDevice", commandMessage);
        }

        private async static void ReceiveFeedbackAsync()
        {
            var feedbackReceiver = serviceClient.GetFeedbackReceiver();

            Console.WriteLine("\nReceiving c2d feedback from service");
            while (true)
            {
                var feedbackBatch = await feedbackReceiver.ReceiveAsync();
                if (feedbackBatch == null) continue;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Received feedback: {0}",
                  string.Join(", ", feedbackBatch.Records.Select(f => f.StatusCode)));
                Console.ResetColor();

                await feedbackReceiver.CompleteAsync(feedbackBatch);
            }
        }
    }
}
