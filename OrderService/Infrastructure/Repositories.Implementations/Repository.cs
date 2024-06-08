using Domain;
using Microsoft.EntityFrameworkCore;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations;

/// <summary>
/// Основной репозиторий для работы с сущностями
/// </summary>
/// <typeparam name="T">Тип сущности</typeparam>
public abstract class Repository<T> : IRepository<T> 
    where T : BaseEntity
{
    protected readonly DbContext DbContext;

    public Repository(DbContext dbContext)
    {
        DbContext = dbContext;
    }
    
    /// <summary>
    /// Получить все записи из БД.
    /// </summary>
    /// <returns>Список сущностей</returns>
    public virtual async Task<List<T>> GetAllAsync()
    {
        return await DbContext.Set<T>().ToListAsync();
    }

    /// <summary>
    /// Получить конкретную запись из БД по id.
    /// </summary>
    /// <param name="id">id сущности</param>
    /// <returns>Запись из БД</returns>
    public virtual async Task<T?> GetAsync(Guid id)
    {
        return await DbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
    }

    /// <summary>
    /// Добавить запись в БД.
    /// </summary>
    /// <param name="entity">добавляемая сущность</param>
    public virtual async Task<bool> AddAsync(T entity)
    {
        entity.Id = Guid.NewGuid();
        await DbContext.Set<T>().AddAsync(entity);
        await DbContext.SaveChangesAsync();
        
        return true;
    }
    
    /// <summary>
    /// Обновить запись в БД.
    /// </summary>
    /// <param name="entity">обновляемая сущность</param>
    public virtual async Task<bool> UpdateAsync(T entity)
    {
        var obj = await DbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == entity.Id);
        if (obj != null)
        {
            obj = entity;
            await DbContext.SaveChangesAsync();
            return true;
        }
        
        return false;
    }

    /// <summary>
    /// Удалить запись из БД.
    /// </summary>
    /// <param name="id">id удаляемой сущности</param>
    public virtual async Task<bool> DeleteAsync(Guid id)
    {
        var entity = await DbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        if (entity != null)
        {
            DbContext.Set<T>().Remove(entity);
            await DbContext.SaveChangesAsync();
            return true;
        }

        return false;
    }
}