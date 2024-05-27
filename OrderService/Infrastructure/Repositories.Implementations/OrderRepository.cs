using Domain;
using Microsoft.EntityFrameworkCore;
using Services.Repositories.Abstractions;
using Services.Services.Contracts;

namespace Infrastructure.Repositories.Implementations;

/// <summary>
/// Репозиторий заказов
/// </summary>
public class OrderRepository : Repository<Order>, IOrderRepository
{
    public OrderRepository(DbContext dbContext) : base(dbContext) { }

    /// <summary>
    /// Отмена заказа
    /// </summary>
    /// <param name="cancelingOrderDto">DTO отменяемого заказа</param>
    public async Task<bool> CancelAsync(CancelingOrderDto cancelingOrderDto)
    {
        var order = await DbContext.Set<Order>().FirstOrDefaultAsync(x => x.Id == cancelingOrderDto.Id);
        if (order != null)
        {
            order.IsCanceled = true;
            DbContext.SaveChangesAsync();
            return true;
        }

        return false;
    }
}