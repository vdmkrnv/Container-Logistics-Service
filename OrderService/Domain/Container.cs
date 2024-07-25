namespace Domain;

/// <summary>
/// Контейнер
/// </summary>
public class Container 
{
    public Guid Id { get; set; }
    
    public Guid OrderId { get; set; }
    
    /// <summary>
    /// ISO номер контейнера
    /// </summary>
    public string IsoNumber { get; set; }
    
    /// <summary>
    /// Id типа контейнера
    /// </summary>
    public int TypeId { get; set; }
    
    /// <summary>
    /// Статус занятости контейнера
    /// </summary>
    public bool IsEngaged { get; set; }
    
    /// <summary>
    /// До какого числа занят контейнер
    /// </summary>
    public DateTime? EngagedUntil { get; set; }
    
    public bool IsDeleted { get; set; }
}
