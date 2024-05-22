using AutoMapper;
using Services.Repositories.Abstractions;
using Services.Services.Abstractions;
using Services.Services.Contracts.Container;

namespace Services.Services.Implementations;

public class ContainerService : IContainerService
{
    private readonly IContainerRepository _repository;
    private readonly IMapper _mapper;

    public ContainerService(IContainerRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public Task UpdateAsync(UpdatingContainerDto updatingContainerDto)
    {
        throw new NotImplementedException();
    }
}