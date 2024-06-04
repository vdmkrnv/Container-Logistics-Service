using Domain;
using Services.Services.Contracts;

namespace Services.Services.Abstractions;

/// <summary>
/// Интерфейс сервиса заказов.
/// </summary>
public interface IOrderService
{
    /// <summary>
    /// Добавить заказ.
    /// </summary>
    /// <param name="Order"></param>
    Task<bool> AddAsync(CreatingOrderDto creatingOrderDto);

    /// <summary>
    /// Получить заказ.
    /// </summary>
    /// <param name="id">id получаемого заказ</param>
    /// <returns>DTO заказа</returns>
    Task<OrderDto> GetAsync(Guid id);

    /// <summary>
    /// Отменить заказ.
    /// </summary>
    /// <param name="cancelingOrderDto">DTO отменяемого заказа</param>
    Task<bool> CancelAsync(CancelingOrderDto cancelingOrderDto);
}