namespace Services.Services.Contracts.ContainerType;

/// <summary>
/// DTO создаваемого типа контейнеров
/// </summary>
public class CreatingContainerTypeDto
{
    /// <summary>
    /// Имя типа
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///  Цена за день аренды
    /// </summary>
    public double PricePerDay { get; set; }
}