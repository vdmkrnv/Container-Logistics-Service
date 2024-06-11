namespace Services.Services.Contracts.Container;


/// <summary>
/// DTO удаляемого контейнера
/// </summary>
public class DeletingContainerDto
{
    /// <summary>
    /// Идентификатор типа контейнера
    /// </summary>
    public Guid TypeId { get; set; }
}