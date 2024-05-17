using AutoMapper;
using Domain;
using Services.Services.Contracts.Container;

namespace Services.Services.Implementations.Mapping;

/// <summary>
/// Профиль автомаппера для сущности контейнера.
/// </summary>
public class ContainerMappingProfile : Profile
{
    public ContainerMappingProfile()
    {
        CreateMap<ContainerDto, UpdatingContainerDto>()
            .ForMember(d => d.IsEngaged, 
                map => map.Ignore());
    }
}