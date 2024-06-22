using System.Text;
using System.Text.Json;
using RabbitMQ.Client;

namespace Infrastructure;

/// <summary>
/// Сервис шины RabbitMQ.
/// </summary>
public class RabbitMqBus : IRabbitMqBus
{
    private readonly RabbitConnectionService _connectionService;
    private readonly IRmqSettings _settings;
    
    public RabbitMqBus(RabbitConnectionService connection)
    {
        _connectionService = connection;
    }
    /// <summary>
    /// Опубликовать сообщение.
    /// </summary>
    /// <param name="message">Объект сообщения</param>
    /// <typeparam name="T">Тип сообщения</typeparam>
    public Task<bool> PublishAsync<T>(IList<T> message, string queueName, string exchangeName, string routingKey)
    {
        try
        {
            using var conn = _connectionService.GetConnection(_settings);
            using var channel = conn.CreateModel();
        
            channel.QueueDeclare(queue: queueName, 
                durable: true, 
                exclusive: false, 
                autoDelete: false, 
                arguments: null);
        
            var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message));
        
            var properties = channel.CreateBasicProperties();
            properties.Persistent = true;
        
            channel.BasicPublish(exchange: exchangeName,
                routingKey: routingKey,
                basicProperties: properties,
                body: body);

            return Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return Task.FromResult(false);
        }
    }
}