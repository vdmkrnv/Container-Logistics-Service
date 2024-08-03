using Asp.Versioning;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Services.Models.Request;
using Services.Services.Interfaces;
using WebApi.Models;
using WebApi.Models.ApiModels;
using WebApi.Models.Request;
using WebApi.Models.Response;

namespace WebApi.Controllers;

/// <summary>
/// Контроллер заказов
/// </summary>
[ApiController]
[Route("api/v{v:apiVersion}/orders")]
[ApiVersion(1)]
public class OrderController(
    IMapper mapper,
    IOrderService orderService) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<CommonResponse<GetAllOrdersResponse>>> GetAll(
        [FromQuery] int page,
        [FromQuery] int pageSize)
    {
        var orders = await orderService.GetAll(
            new GetAllOrdersModel { Page = page, PageSize = pageSize });
        var response = new CommonResponse<GetAllOrdersResponse>
            { Data = new GetAllOrdersResponse { Orders = mapper.Map<List<OrderApiModel>>(orders) } };

        return response;
    }
    
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<CommonResponse<GetOrderByIdResponse>>> GetById(
        [FromRoute] GetOrderByIdRequest request)
    {
        var order = await orderService.GetById(mapper.Map<GetOrderByIdModel>(request));
        var response = new CommonResponse<GetOrderByIdResponse> 
            { Data = mapper.Map<GetOrderByIdResponse>(order) };

        return response;
    }
    
    [HttpGet("clients/{clientId:guid}")]
    public async Task<ActionResult<CommonResponse<GetOrdersByClientIdResponse>>> GetByClientId(
        [FromRoute] GetOrdersByClientIdRequest request)
    {
        var orders = await orderService.GetByClientId(mapper.Map<GetOrdersByClientIdModel>(request));
        var response = new CommonResponse<GetOrdersByClientIdResponse>
            { Data = new GetOrdersByClientIdResponse { Orders = mapper.Map<List<OrderApiModel>>(orders) } };
        
        return response;
    }

    [HttpPost]
    public async Task<ActionResult<CommonResponse<CreateOrderResponse>>> Create(
        CreateOrderRequest request)
    {
        var id = await orderService.Create(mapper.Map<CreateOrderModel>(request));
        var response = new CreatedResult(
            nameof(Create),
            new CommonResponse<CreateOrderResponse>
                { Data = new CreateOrderResponse { Id = id } }
        );
        
        return response;
    }

    [HttpPut]
    public async Task<ActionResult<CommonResponse<UpdateOrderResponse>>> Update(
        UpdateOrderRequest request)
    {
        var order = await orderService.Update(mapper.Map<UpdateOrderModel>(request));
        var response = new CommonResponse<UpdateOrderResponse> 
            { Data = mapper.Map<UpdateOrderResponse>(order) };
        
        return response;
    }

    [HttpDelete("{id:guid}")]
    public async Task<ActionResult<CommonResponse<DeleteOrderResponse>>> Delete(
        [FromRoute] DeleteOrderRequest request)
    {
        var order = await orderService.Delete(mapper.Map<DeleteOrderModel>(request));
        var response = new CommonResponse<DeleteOrderResponse> 
            { Data = mapper.Map<DeleteOrderResponse>(order) };
        
        return response;
    }
}