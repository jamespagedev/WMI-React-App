using API.DTOs;
using API.Models;
using AutoMapper;

namespace API.Profiles
{
    public class CountriesProfile : Profile
    {
        public CountriesProfile()
        {
            CreateMap<CountryModel, CountryReadDto>();
        }
    }
}