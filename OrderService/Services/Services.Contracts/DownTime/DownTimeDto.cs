namespace Services.Services.Contracts.DownTime;

/// <summary>
/// DTO времени простоя
/// </summary>
public class DownTimeDto
{
    public DateTime DateStart { get; set; }
    
    public DateTime DateEnd { get; set; }
    
    public Guid HubId { get; set; }
}