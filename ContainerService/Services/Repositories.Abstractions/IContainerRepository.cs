using Domain;
using Services.Services.Contracts.Container;
using Services.Services.Contracts.ContainerType;

namespace Services.Repositories.Abstractions;

/// <summary>
/// Репозиторий для контейнеров.
/// </summary>
public interface IContainerRepository : IRepository<Container>
{
    /// <summary>
    /// Получить все контейнеры по типу.
    /// </summary>
    /// <param name="searchingContainerDto">DTO искомого контейнера</param>
    /// <returns>Коллекию DTO контейнера</returns>
    public Task<List<ContainerDto>> GetAllByTypeAsync(SearchingContainerDto searchingContainerDto);
    
    
    /// <summary>
    /// Обновление статуса контейнера.
    /// </summary>
    /// <param name="updatingContainerStatusDto">DTO контейнера обновляемого статуса</param>
    public Task<bool> UpdateContainerStatusAsync(
        List<UpdatingContainerStatusDto> updatingContainerStatusDto);
}