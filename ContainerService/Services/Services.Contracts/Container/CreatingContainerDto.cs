using Services.Services.Contracts.ContainerType;

namespace Services.Services.Contracts.Container;

/// <summary>
/// DTO создаваемого контейнера
/// </summary>
public class CreatingContainerDto
{
    /// <summary>
    /// Номер ISO
    /// </summary>
    public string IsoNumber { get; set; }

    /// <summary>
    /// Идентификатор типа контейнера
    /// </summary>
    public Guid TypeId { get; set; }
    
    /// <summary>
    /// Свойство для доступа к типу контейнера (для EFCore)
    /// </summary>
    public ContainerTypeDto Type { get; set; }
}