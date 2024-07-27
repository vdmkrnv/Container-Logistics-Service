using Services.Models.Response;

namespace WebApi.Models.Response;

public class GetOrdersByClientIdResponse
{
    public List<OrderModel> Orders { get; set; }
}