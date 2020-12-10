using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco.Api.MessageService
{
    public static class PublishRequest
    {
        static Random random = new Random();

        public async static Task Publish()
        {
            var msg = new Message();
            int count = 0;
            //{
            //    Text = "TextyMan",
            //    Number = 15,
            //    Cash = 1499.99
            //};

            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                while (count < 5)
                {
                    msg.Text = $"Texty {random.NextDouble()}";
                    msg.Number = random.Next(1, 500);
                    msg.Date = DateTime.Now;
                    msg.Cash = random.NextDouble();
                    bus.PubSub.Publish(msg);
                    Console.WriteLine($"Published {++count} messages");
                    await Task.Delay(1000);
                }
            }
        }
    }
}
