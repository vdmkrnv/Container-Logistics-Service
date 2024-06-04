namespace Domain;

/// <summary>
/// Контейнер
/// </summary>
public class Container : BaseEntity
{
    /// <summary>
    /// ISO номер контейнера
    /// </summary>
    public string IsoNumber { get; set; }
    
    /// <summary>
    /// Id типа контейнера
    /// </summary>
    public Guid TypeId { get; set; }
    
    /// <summary>
    /// Статус занятости контейнера
    /// </summary>
    public bool IsEngaged { get; set; }
}
