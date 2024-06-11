namespace Services.Services.Contracts.Container;

/// <summary>
/// DTO обновляемого контейнера
/// </summary>
public class UpdatingContainerDto
{
    /// <summary>
    /// Идентификатор контейнера.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Номер ISO
    /// </summary>
    public string IsoNumber { get; set; }

    /// <summary>
    /// Идентификатор типа контейнера
    /// </summary>
    public Guid TypeId { get; set; }
}