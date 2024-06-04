namespace Services.Services.Contracts.Container;

/// <summary>
/// DTO контейнера
/// </summary>
public class ContainerDto
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// ISO номер контейнера
    /// </summary>
    public string IsoNumber { get; set; }
}