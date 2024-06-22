namespace Infrastructure;

/// <summary>
/// Интерфейс для сервиса шины RabbitMQ.
/// </summary>
public interface IRabbitMqBus
{
    /// <summary>
    /// Опубликовать сообщение.
    /// </summary>
    /// <param name="message">Объект сообщения</param>
    /// <typeparam name="T">Тип сообщения</typeparam>
    public Task<bool> PublishAsync<T>(T message);
}