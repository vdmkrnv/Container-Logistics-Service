namespace Infrastructure;

/// <summary>
/// Интерфейс сервиса RabbitMQ.
/// </summary>
public interface IRabbitMqService
{
    /// <summary>
    /// Опубликовать сообщение.
    /// </summary>
    /// <param name="message">Объект сообщения</param>
    /// <typeparam name="T">Тип сообщения</typeparam>
    public Task PublishAsync<T>(T message);
}