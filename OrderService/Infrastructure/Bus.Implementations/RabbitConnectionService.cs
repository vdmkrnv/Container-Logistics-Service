using RabbitMQ.Client;

namespace Infrastructure;

/// <summary>
/// Сервис конфигурации RabbitMQ.
/// </summary>
public class RabbitConnectionService
{
    /// <summary>
    /// Получить соединение с RabbitMQ.
    /// </summary>
    /// <param name="settings">Настройки RabbitMQ</param>
    /// <returns>Соединение с RabbitMQ</returns>
    public IConnection GetConnection(IRmqSettings settings)
    {
        var factory = new ConnectionFactory
        {
            HostName = settings.Host,
            VirtualHost = settings.VHost,
            UserName = settings.Login,
            Password = settings.Password
        };
        return factory.CreateConnection();
    }
}