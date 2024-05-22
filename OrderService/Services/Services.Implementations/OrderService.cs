using AutoMapper;
using Domain;
using Services.Repositories.Abstractions;
using Services.Services.Abstractions;
using Services.Services.Contracts;

namespace Services.Services.Implementations;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _repository;
    private readonly IMapper _mapper;

    public OrderService(IOrderRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<bool> AddAsync(CreatingOrderDto creatingOrderDto)
    {
        var order = _mapper.Map<CreatingOrderDto, Order>(creatingOrderDto);
        order.Id = Guid.NewGuid();
        
        return await _repository.AddAsync(order);
    }

    public async Task<OrderDto> GetAsync(Guid id)
    {
        var order = await _repository.GetAsync(id);
        var orderDto = _mapper.Map<Order, OrderDto>(order);

        return orderDto;
    }

    public async Task<bool> CancelAsync(CancelingOrderDto cancelingOrderDto)
    {
        return await _repository.CancelAsync(cancelingOrderDto);
    }
}