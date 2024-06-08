using Domain;
using Microsoft.EntityFrameworkCore;
using Services.Repositories.Abstractions;
using Services.Services.Contracts.Container;

namespace Infrastructure.Repositories.Implementations;

/// <summary>
/// Репозиторий контейнеров
/// </summary>
public class ContainerRepository : Repository<Container>, IContainerRepository
{
    public ContainerRepository(DbContext dbContext) : base(dbContext) { }

    /// <summary>
    /// Обновление статуса контейнера
    /// </summary>
    /// <param name="updatingContainerStatusDto">DTO обновляемого контейнера</param>
    public async Task UpdateEngagedStatus(UpdatingContainerStatusDto updatingContainerStatusDto)
    {
        throw new NotImplementedException();
    }
}