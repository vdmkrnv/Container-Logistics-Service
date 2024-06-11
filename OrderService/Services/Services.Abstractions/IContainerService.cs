using Services.Services.Contracts.Container;

namespace Services.Services.Abstractions;

/// <summary>
/// Интерфейс сервиса контейнеров
/// </summary>
public interface IContainerService
{
    /// <summary>
    /// Обновить статус занятости контейнера
    /// </summary>
    /// <param name="updatingContainerStatusDto">DTO обновляемого статуса контейнера</param>
    Task<bool> UpdateAsync(UpdatingContainerStatusDto updatingContainerStatusDto);
}