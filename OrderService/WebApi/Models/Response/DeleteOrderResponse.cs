using WebApi.Models.ApiModels;

namespace WebApi.Models.Response;

public class DeleteOrderResponse
{
    public Guid Id { get; set; }
    
    public Guid ClientId { get; set; }
    
    public DateTime DateStart { get; set; }
    
    public DateTime DateEnd { get; set; }
    
    public Guid HubStartId { get; set; }
    
    public Guid HubEndId { get; set; }
    
    public double Price { get; set; }
    
    public ICollection<ContainerApiModel> Containers { get; set; }
    
    public ICollection<DownTimeApiModel> DownTimes { get; set; }
}