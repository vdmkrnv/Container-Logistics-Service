using Domain;
using Services.Services.Contracts;

namespace Services.Repositories.Abstractions;

/// <summary>
/// Репозиторий для заказов
/// </summary>
public interface IOrderRepository : IRepository<Order>
{
    /// <summary>
    /// Создание заказа
    /// </summary>
    /// <param name="creatingOrderDto">DTO создаваемого заказа</param>
    Task AddAsync(CreatingOrderDto creatingOrderDto);
    
    /// <summary>
    /// Отмена заказа
    /// </summary>
    /// <param name="cancelingOrderDto">отменяемый заказ</param>
    Task CancelAsync(CancelingOrderDto cancelingOrderDto);
}