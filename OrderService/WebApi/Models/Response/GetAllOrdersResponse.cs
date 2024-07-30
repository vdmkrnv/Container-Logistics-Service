using WebApi.Models.ApiModels;

namespace WebApi.Models.Response;

public class GetAllOrdersResponse
{
    public List<OrderApiModel> Orders { get; set; }
}