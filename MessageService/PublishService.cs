using EasyNetQ;
using RabbitMQ.Client;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MessageService
{
    public class PublishService
    {
        public static async Task PublishAsync<T>(T msg) where T : class
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                await bus.PubSub.PublishAsync<T>(msg);

                Console.WriteLine($"\nPublishing message of type {msg.GetType().Name}...");
            }
        }

        public static void PublishRabbit<T>(string queueName, params T[] objs) where T : class
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: queueName,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                foreach(T obj in objs)
                {
                    string message = System.Text.Json.JsonSerializer.Serialize(obj);
                    // string message = await System.Text.Json.JsonSerializer.SerializeAsync(obj);
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                                         routingKey: queueName,
                                         basicProperties: null,
                                         body: body);
                    Console.WriteLine($" [x] Sent {message}");
                }
            }
        }
    }
}

