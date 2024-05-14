using Services.Services.Contracts.Container;
using Services.Services.Contracts.DownTime;

namespace Services.Services.Contracts;

/// <summary>
/// DTO создаваемого заказа
/// </summary>
public class CreatingOrderDto
{
    public Guid ClientId { get; set; }
    
    public DateTime DateStart { get; set; }
    
    public DateTime DateEnd { get; set; }
    
    public Guid HubStartId { get; set; }
    
    public Guid HubEndId { get; set; }
    
    public double Price { get; set; }
    
    public ICollection<ContainerDto> Containers { get; set; }
    
    public ICollection<DownTimeDto> DownTimes { get; set; }
}