using WebApi.Models.ApiModels;

namespace WebApi.Models.Response;

public class GetOrdersInPeriodResponse
{
    public List<OrderApiFullModel> Orders { get; set; }
}