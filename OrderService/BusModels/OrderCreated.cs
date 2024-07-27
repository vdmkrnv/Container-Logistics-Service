
namespace BusModels;

public class OrderCreated
{
    public List<Guid> ContainerIds { get; set; }
    
    public Guid OrderId { get; set; }
    
    public DateTime EngagedUntil { get; set; }
}