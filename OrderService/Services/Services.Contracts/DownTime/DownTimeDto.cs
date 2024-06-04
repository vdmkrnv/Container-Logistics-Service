namespace Services.Services.Contracts.DownTime;

/// <summary>
/// DTO времени простоя
/// </summary>
public class DownTimeDto
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
    /// Id Хаба
    /// </summary>
    public Guid HubId { get; set; }
}