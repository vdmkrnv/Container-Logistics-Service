using AutoMapper;
using Domain;
using Services.Repositories.Abstractions;
using Services.Services.Abstractions;
using Services.Services.Contracts;

namespace Services.Services.Implementations;

/// <summary>
/// Сервис заказов
/// </summary>
public class OrderService : IOrderService
{
    private readonly IOrderRepository _repository;
    private readonly IMapper _mapper;

    public OrderService(IOrderRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    /// <summary>
    /// Добавление нового заказа
    /// </summary>
    /// <param name="creatingOrderDto">DTO создаваемого заказа</param>
    public async Task<bool> AddAsync(CreatingOrderDto creatingOrderDto)
    {
        var order = _mapper.Map<CreatingOrderDto, Order>(creatingOrderDto);
        order.Id = Guid.NewGuid();
        
        return await _repository.AddAsync(order);
    }

    /// <summary>
    /// Получение заказа по id
    /// </summary>
    /// <param name="id">Идентификатор заказа</param>
    /// <returns>DTO заказа</returns>
    public async Task<OrderDto> GetAsync(Guid id)
    {
        var order = await _repository.GetAsync(id);
        var orderDto = _mapper.Map<Order, OrderDto>(order);

        return orderDto;
    }

    /// <summary>
    /// Отмена заказа
    /// </summary>
    /// <param name="cancelingOrderDto">DTO отменяемого заказа</param>
    public async Task<bool> CancelAsync(CancelingOrderDto cancelingOrderDto)
    {
        return await _repository.CancelAsync(cancelingOrderDto);
    }
}