using Domain;
using Services.Services.Contracts;

namespace Services.Repositories.Abstractions;

/// <summary>
/// Репозиторий для заказов
/// </summary>
public interface IOrderRepository : IRepository<Order>
{
    /// <summary>
    /// Отмена заказа
    /// </summary>
    /// <param name="cancelingOrderDto">отменяемый заказ</param>
    Task<bool> CancelAsync(CancelingOrderDto cancelingOrderDto);
}