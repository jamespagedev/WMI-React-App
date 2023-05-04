using API.Data;
using API.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly ILogger<CountriesController> _logger;
        private readonly ICountryRepo _repository;
        private readonly IMapper _mapper;

        public CountriesController(ILogger<CountriesController> logger, ICountryRepo repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }
        
        [HttpGet(Name = "GetAllCountries")]
        public async Task<ActionResult<IEnumerable<CountryReadDto>>> Get()
        {
            var countries = await _repository.GetAllCountries();
            return Ok(_mapper.Map<IEnumerable<CountryReadDto>>(countries));
        }
    }
}