using Domain;

namespace Services.Repositories.Abstractions;

/// <summary>
/// Интерфейс IRepository - описывает общие CRUD методы для репозиториев.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRepository<T> where T : BaseEntity
{
    /// <summary>
    /// Получить все записи из БД.
    /// </summary>
    /// <returns>Список сущностей</returns>
    public Task<List<T>> GetAllAsync();
    
    /// <summary>
    /// Получить конкретную запись из БД по id.
    /// </summary>
    /// <param name="id">id сущности</param>
    /// <returns></returns>
    public Task<T?> GetAsync(Guid id);
    
    /// <summary>
    /// Добавить запись в БД.
    /// </summary>
    /// <param name="entity">добавляемая сущность</param>
    /// <returns></returns>
    public Task AddAsync(T entity);
    
    /// <summary>
    /// Обновить запись в БД.
    /// </summary>
    /// <param name="entity">обновляемая сущность</param>
    public Task UpdateAsync(T entity);
    
    /// <summary>
    /// Удалить запись из БД.
    /// </summary>
    /// <param name="id">id удаляемой сущности</param>
    public Task DeleteAsync(Guid id);
}