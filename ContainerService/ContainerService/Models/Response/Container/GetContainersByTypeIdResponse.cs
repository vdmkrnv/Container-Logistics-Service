using Services.Models.Response.Container;

namespace WebApi.Models.Response.Container;

public class GetContainersByTypeIdResponse
{
    public List<ContainerApiModel> Containers { get; set; }
}