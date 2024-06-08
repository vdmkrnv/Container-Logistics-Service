using Domain;
using Services.Services.Contracts.Container;

namespace Services.Repositories.Abstractions;

/// <summary>
/// Репозиторий для контейнеров
/// </summary>
public interface IContainerRepository : IRepository<Container>
{
    /// <summary>
    /// Обновление статуса занятости контейнера
    /// </summary>
    /// <param name="updatingContainerStatusDto">обновляемый контейнер</param>
    public Task UpdateEngagedStatus(UpdatingContainerStatusDto updatingContainerStatusDto);
}