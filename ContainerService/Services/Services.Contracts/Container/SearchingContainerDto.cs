namespace Services.Services.Contracts.Container;

/// <summary>
/// DTO искомого контейнера по типу
/// </summary>
public class SearchingContainerDto
{
    /// <summary>
    /// Идентификатор типа контейнера
    /// </summary>
    public Guid TypeId { get; set; }
}