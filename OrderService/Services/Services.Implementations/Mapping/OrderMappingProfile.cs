using AutoMapper;
using Domain;
using Services.Services.Contracts;

namespace Services.Services.Implementations.Mapping;

/// <summary>
/// Профиль автомаппера для сущности заказа
/// </summary>
public class OrderMappingProfile : Profile
{
    public OrderMappingProfile()
    {
        CreateMap<CreatingOrderDto, Order>()
            .ForMember(d => d.Id, map => map.Ignore())
            .ForMember(d => d.IsCanceled, map => map.Ignore())
            .ForMember(d => d.Costs, map => map.Ignore());
        
        CreateMap<Order, OrderDto>();
    }
}