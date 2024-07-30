using WebApi.Models.ApiModels;

namespace WebApi.Models.Response;

public class GetOrdersByClientIdResponse
{
    public List<OrderApiModel> Orders { get; set; }
}