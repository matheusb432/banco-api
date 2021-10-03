using EasyNetQ;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace MessageService
{
    public class SubscribeService
    {
        public async static Task SubscribeAsync<T>() where T : class
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                await bus.PubSub.SubscribeAsync<T>("APIQueue", HandleMessage);

                Console.WriteLine("\nSubscribed");

                await Task.Delay(1000);

                // Console.ReadLine();
            }
        }

        public static void HandleMessage<T>(T msg) where T : class
        {
            //foreach (T msg in msgs)
            //{
            Console.WriteLine($"Handling {msg.GetType().Name}...");
            foreach (PropertyInfo prop in msg.GetType().GetProperties())
            {
                Console.WriteLine($"{prop.Name} = {prop.GetValue(msg, null)}");
            }
            Console.WriteLine();
            //}
        }
    }
}