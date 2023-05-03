using API.Data;
using API.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Cars : ControllerBase
{
        private readonly ILogger<Cars> _logger;
        private readonly ICarRepo _repository;
        private readonly IMapper _mapper;

        public Cars(ILogger<Cars> logger, ICarRepo repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetAllCars")]
        public async Task<ActionResult<IEnumerable<CarReadDto>>> Get()
        {
            var cars = await _repository.GetAllCars();
            return Ok(_mapper.Map<IEnumerable<CarReadDto>>(cars));
        }

        [HttpGet("{id}", Name = "GetCarById")]
        public async Task<ActionResult<CarReadDto>> Get(string id)
        {
            var car = await _repository.GetCarById(id);
            if (car != null)
            {
                return Ok(_mapper.Map<CarReadDto>(car));
            }
            return NotFound();
        }
}
