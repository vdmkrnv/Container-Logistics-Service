namespace Services.Services.Contracts.ContainerType;

/// <summary>
/// DTO обновляемого контейнера
/// </summary>
public class UpdatingContainerTypeDto
{
    /// <summary>
    /// Идентификатор типа контейнера
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Имя типа
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///  Цена за день аренды
    /// </summary>
    public double PricePerDay { get; set; }
}