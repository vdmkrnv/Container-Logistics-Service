using AutoMapper;
using Domain;
using Services.Services.Contracts.DownTime;

namespace Services.Services.Implementations.Mapping;

public class DownTimeMappingProfile : Profile
{
    public DownTimeMappingProfile()
    {
        CreateMap<DownTimeDto, DownTime>()
            .ForMember(d => d.Id, map => map.Ignore());

        CreateMap<DownTime, DownTimeDto>();
    }
}