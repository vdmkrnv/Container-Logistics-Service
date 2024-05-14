using Services.Services.Contracts;

namespace Services.Repositories.Abstractions;

/// <summary>
/// Репозиторий для заказов
/// </summary>
public interface IOrderRepository
{
    Task<OrderDto> GetByIdAsync(Guid id);
    
    Task AddAsync(CreatingOrderDto creatingOrderDto);
    
    Task CancelAsync(CancelingOrderDto cancelingOrderDto);
}