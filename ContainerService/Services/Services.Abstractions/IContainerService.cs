using Services.Services.Contracts.Container;

namespace Services.Services.Abstractions;

/// <summary>
/// Интерфейс сервиса контейнеров.
/// </summary>
public interface IContainerService
{
    /// <summary>
    /// Добавить контейнер.
    /// </summary>
    /// <param name="creatingContainerDto">DTO создаваемого контейнера</param>
    Task<bool> AddAsync(CreatingContainerDto creatingContainerDto);

    /// <summary>
    /// Получить контейнер.
    /// </summary>
    /// <param name="id">Id получаемого контейнера</param>
    /// <returns>DTO контейнера</returns>
    Task<ContainerDto> GetAsync(Guid id);

    /// <summary>
    /// Получить все определенного типа.
    /// </summary>
    /// <returns>Коллекция DTO контейнера</returns>
    Task<List<ContainerDto>> GetAllByTypeAsync(SearchingContainerDto searchingContainerDto);
    
    /// <summary>
    /// Обновление контейнера.
    /// </summary>
    /// <param name="updatingContainerDto">DTO изменяемого контейнера</param>
    Task<bool> UpdateAsync(UpdatingContainerDto updatingContainerDto);
    
    /// <summary>
    /// Обновление статуса контейнера.
    /// </summary>
    /// <param name="updatingContainerStatusDto">DTO обновляемого статуса контейнера</param>
    Task<bool> UpdateContainerStatusAsync(List<UpdatingContainerStatusDto> updatingContainerStatusDto);
}