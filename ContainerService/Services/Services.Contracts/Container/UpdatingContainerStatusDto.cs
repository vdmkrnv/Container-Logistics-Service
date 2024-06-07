namespace Services.Services.Contracts.Container;

/// <summary>
/// DTO обновляемого статус контейнера
/// </summary>
public class UpdatingContainerStatusDto
{
    /// <summary>
    /// Идентификатор контейнера
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Статус занятости контейнера
    /// </summary>
    public bool IsEngaged { get; set; }
	
    /// <summary>
    /// До какого числа занят контейнер
    /// </summary>
    public DateTime EngagedUntil { get; set; }
}