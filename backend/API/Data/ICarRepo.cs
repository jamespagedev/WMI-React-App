using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Data
{
    public interface ICarRepo
    {
        Task<IEnumerable<CarModel>> GetAllCars();
        Task<IEnumerable<CarModel>> Search(string? searchValue, string country);
    }
}