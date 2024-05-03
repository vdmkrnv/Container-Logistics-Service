namespace Domain;

public class DownTime : BaseEntity
{
    public DateTime DateStart { get; set; }
    
    public DateTime DateEnd { get; set; }
    
    public Guid HubId { get; set; }
}