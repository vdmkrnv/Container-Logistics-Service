using AutoMapper;
using Domain;
using Services.Services.Contracts.ContainerType;

namespace Services.Services.Implementations.Mapping;

/// <summary>
/// Профиль маппинга типов контейнеров
/// </summary>
public class ContainerTypeMappingProfile : Profile
{
    public ContainerTypeMappingProfile()
    {
        CreateMap<ContainerType, ContainerTypeDto>();
        
        CreateMap<ContainerTypeDto, ContainerType>()
            .ForMember(d => d.IsDeleted, map => map.Ignore());

        CreateMap<UpdatingContainerTypeDto, ContainerType>()
            .ForMember(d => d.IsDeleted, map => map.Ignore());
        
        CreateMap<CreatingContainerTypeDto, ContainerType>()
            .ForMember(d => d.Id, map => map.Ignore())
            .ForMember(d => d.IsDeleted, map => map.Ignore());

        CreateMap<DeletingContainerTypeDto, ContainerType>()
            .ForMember(d => d.Name, map => map.Ignore())
            .ForMember(d => d.PricePerDay, map => map.Ignore())
            .ForMember(d => d.IsDeleted, map => map.Ignore());
    }
}