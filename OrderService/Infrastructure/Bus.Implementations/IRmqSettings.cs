namespace Infrastructure;

/// <summary>
/// Настройки RabbitMQ
/// </summary>
public interface IRmqSettings
{
    /// <summary>
    /// Хост
    /// </summary>
    string Host { get; set; }
    
    /// <summary>
    /// Виртуальный хост
    /// </summary>
    string VHost { get; set; }
     
    /// <summary>
    /// Логин
    /// </summary>
    string Login { get; set; }
     
    /// <summary>
    /// Пароль
    /// </summary>
    string Password { get; set; }
}