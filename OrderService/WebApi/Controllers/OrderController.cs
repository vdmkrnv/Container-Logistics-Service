using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Abstractions;
using Services.Services.Contracts;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _service;
    private readonly IMapper _mapper;

    public OrderController(IOrderService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    
    [HttpGet]
    public async Task<OrderDto> Get(Guid id)
    {
        return await _service.GetAsync(id);
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreatingOrderDto creatingOrderDto)
    {
        _service.AddAsync(creatingOrderDto);
        return Ok();
    }
}