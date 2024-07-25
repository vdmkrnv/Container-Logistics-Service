using Services.Models.Response;

namespace WebApi.Models.Response;

public class GetAllOrdersResponse
{
    public List<OrderModel> Orders { get; set; }
}