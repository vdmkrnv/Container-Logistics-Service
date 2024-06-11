namespace Infrastructure;

/// <summary>
/// Сервис для работы с RabbitMQ.
/// </summary>
public class RabbitMqService : IRabbitMqService
{
    /// <summary>
    /// Опубликовать сообщение.
    /// </summary>
    /// <param name="message">Объект сообщения</param>
    /// <typeparam name="T">Тип сообщения</typeparam>
    public Task PublishAsync<T>(T message)
    {
        throw new NotImplementedException();
    }
}