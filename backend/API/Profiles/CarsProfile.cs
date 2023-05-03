using API.DTOs;
using API.Models;
using AutoMapper;

namespace API.Profiles
{
    public class CarsProfile : Profile
    {
        public CarsProfile()
        {
            CreateMap<CarModel, CarReadDto>()
                .ForMember(crd => crd.Id, o => o.MapFrom(cm => cm.PublicId))
                .ForMember(crd => crd.Country, o => o.MapFrom(cm => cm.Country!.Name));
        }
    }
}