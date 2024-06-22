using Infrastructure;

namespace WebApi.Settings;

/// <summary>
/// Настройки RabbitMQ
/// </summary>
public class RmqSettings : IRmqSettings
{
     /// <summary>
     /// Хост
     /// </summary>
     public string Host { get; set; }
    
     /// <summary>
     /// Виртуальный хост
     /// </summary>
     public string VHost { get; set; }
     
     /// <summary>
     /// Логин
     /// </summary>
     public string Login { get; set; }
     
     /// <summary>
     /// Пароль
     /// </summary>
     public string Password { get; set; }
}