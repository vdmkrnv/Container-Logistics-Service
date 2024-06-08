using AutoMapper;
using Services.Repositories.Abstractions;
using Services.Services.Abstractions;
using Services.Services.Contracts.Container;

namespace Services.Services.Implementations;


/// <summary>
/// Сервис контейнеров
/// </summary>
public class ContainerService : IContainerService
{
    private readonly IContainerRepository _repository;
    private readonly IMapper _mapper;

    public ContainerService(IContainerRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    /// <summary>
    /// Обновление статуса контейнера
    /// </summary>
    /// <param name="updatingContainerStatusDto">DTO обновляемгого контейнера</param>
    public Task UpdateAsync(UpdatingContainerStatusDto updatingContainerStatusDto)
    {
        throw new NotImplementedException();
    }
}