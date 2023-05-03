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
                .ForMember(d => d.Id, o => o.MapFrom(c => c.PublicId));
        }
    }
}