using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco.Api.MessageService
{
    public class SubscribeResquest
    {
        public async static Task Subscribe()
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                bus.PubSub.Subscribe<Message>("APITest", HandleMessage);

                Console.WriteLine("Subscribed");

                // await PublishRequest.Publish();

                await Task.Delay(1000);

                // Console.ReadLine();
            }

            static void HandleMessage(Message msg)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Got message: {0}", msg.Text);
                Console.WriteLine($"{msg.Number} | {msg.Date} | {msg.Cash}");
                Console.ResetColor();
            }
        }
    }
}
