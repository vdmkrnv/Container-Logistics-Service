using Services.Services.Contracts.ContainerType;

namespace Services.Services.Abstractions;

/// <summary>
/// Интерфейс сервиса типов контейнеров
/// </summary>
public interface IContainerTypeService
{
    /// <summary>
    /// Добавить тип контейнеров.
    /// </summary>
    /// <param name="creatingContainerTypeDto">DTO создаваемого типа</param>
    Task<bool> AddAsync(CreatingContainerTypeDto creatingContainerTypeDto);

    /// <summary>
    /// Обновление типа контейнеров.
    /// </summary>
    /// <param name="updatingContainerTypeDto">DTO обновляемого контейнера</param>
    Task<bool> UpdateAsync(UpdatingContainerTypeDto updatingContainerTypeDto);

    /// <summary>
    /// Получить все типы контейнеров.
    /// </summary>
    /// <returns>Коллекция DTO типа контейнера</returns>
    Task<List<ContainerTypeDto>> GetAllAsync();
}