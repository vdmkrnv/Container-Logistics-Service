using Domain;
using Microsoft.EntityFrameworkCore;
using Services.Repositories.Abstractions;
using Services.Services.Contracts.Container;

namespace Infrastructure.Repositories.Impementations;

/// <summary>
/// Репозиторий контейнеров.
/// </summary>
public class ContainerRepository : Repository<Container>, IContainerRepository
{
    public ContainerRepository(DbContext dbContext) : base(dbContext) { }

    /// <summary>
    /// Получить все контейнеры по типу.
    /// </summary>
    /// <param name="searchingContainerDto">DTO искомого контейнера по типу</param>
    /// <returns>Коллекцию DTO контейнеров</returns>
    public Task<List<ContainerDto>> GetAllByTypeAsync(SearchingContainerDto searchingContainerDto)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Обновление статуса контейнера.
    /// </summary>
    /// <param name="updatingContainerStatusDto">DTO обновляемого статуса контейнера</param>
    public Task<bool> UpdateContainerStatusAsync(List<UpdatingContainerStatusDto> updatingContainerStatusDto)
    {
        throw new NotImplementedException();
    }
}