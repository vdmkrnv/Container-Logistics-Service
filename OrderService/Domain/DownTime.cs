namespace Domain;

/// <summary>
/// Время простоя
/// </summary>
public class DownTime : BaseEntity
{
    /// <summary>
    /// Дата начала простоя
    /// </summary>
    public DateTime DateStart { get; set; }
    
    /// <summary>
    /// Дата конца простоя
    /// </summary>
    public DateTime DateEnd { get; set; }
    
    /// <summary>
    /// Id хаба
    /// </summary>
    public Guid HubId { get; set; }
}