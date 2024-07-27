namespace BusModels;

public class OrderUpdated
{
    public List<Guid> ContainerIds { get; set; }
    
    public Guid OrderId { get; set; }
    
    public DateTime EngagedUntil { get; set; }
}