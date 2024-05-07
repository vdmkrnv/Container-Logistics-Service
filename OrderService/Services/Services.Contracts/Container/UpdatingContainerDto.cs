namespace Services.Services.Contracts.Container;

/// <summary>
/// DTO обновляемого статуса занятости контейнера
/// </summary>
public class UpdatingContainerDto
{
    public Guid Id { get; set; }
    
    public bool IsEngaged { get; set; }
}