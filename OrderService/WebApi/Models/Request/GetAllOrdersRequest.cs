namespace WebApi.Models.Request;

public class GetAllOrdersRequest
{
    public int Page { get; set; }
    
    public int PageSize { get; set; }
}