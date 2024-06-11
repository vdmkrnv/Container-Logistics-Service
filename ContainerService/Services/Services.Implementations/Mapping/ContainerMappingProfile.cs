using AutoMapper;
using Domain;
using Services.Services.Contracts.Container;

namespace Services.Services.Implementations.Mapping;


/// <summary>
/// Профиль маппинга контейнеров
/// </summary>
public class ContainerMappingProfile : Profile
{
    public ContainerMappingProfile()
    {
        CreateMap<Container, ContainerDto>();

        CreateMap<ContainerDto, Container>()
            .ForMember(d => d.Type, map => map.Ignore())
            .ForMember(d => d.IsEngaged, map => map.Ignore())
            .ForMember(d => d.EngagedUntil, map => map.Ignore())
            .ForMember(d => d.IsDeleted, map => map.Ignore());

        CreateMap<CreatingContainerDto, Container>()
            .ForMember(d => d.Id, map => map.Ignore())
            .ForMember(d => d.IsEngaged, map => map.Ignore())
            .ForMember(d => d.EngagedUntil, map => map.Ignore())
            .ForMember(d => d.IsDeleted, map => map.Ignore());

        CreateMap<UpdatingContainerDto, Container>()
            .ForMember(d => d.Type, map => map.Ignore())
            .ForMember(d => d.IsEngaged, map => map.Ignore())
            .ForMember(d => d.EngagedUntil, map => map.Ignore())
            .ForMember(d => d.IsDeleted, map => map.Ignore());
        
        CreateMap<DeletingContainerDto, Container>()
            .ForMember(d => d.IsoNumber, map => map.Ignore())
            .ForMember(d => d.TypeId, map => map.Ignore())
            .ForMember(d => d.Type, map => map.Ignore())
            .ForMember(d => d.IsEngaged, map => map.Ignore())
            .ForMember(d => d.EngagedUntil, map => map.Ignore())
            .ForMember(d => d.IsDeleted, map => map.Ignore());
    }
}