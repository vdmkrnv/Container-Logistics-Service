using Services.Services.Contracts.Container;
using Services.Services.Contracts.DownTime;

namespace Services.Services.Contracts;

/// <summary>
/// DTO заказа
/// </summary>
public class OrderDto
{
    public Guid Id { get; set; }
    
    public Guid ClientId { get; set; }
    
    public DateTime DateStart { get; set; }
    
    public DateTime DateEnd { get; set; }
    
    public Guid HubStartId { get; set; }
    
    public Guid HubEndId { get; set; }
    
    public double Price { get; set; }
    
    public IEnumerable<ContainerDto>? Containers { get; set; }
    
    public IEnumerable<DownTimeDto>? DownTimes { get; set; }
}