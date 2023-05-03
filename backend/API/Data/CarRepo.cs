using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class CarRepo : ICarRepo
    {
        
        private readonly AppDbContext _context;
        public CarRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CarModel>> GetAllCars()
        {
            return await _context.Cars!.OrderBy(c => c.CreatedOn).ThenBy(c => c.WMI).ToListAsync();
        }

        public async Task<CarModel?> GetCarById(string id)
        {
            return await _context.Cars!.FirstOrDefaultAsync(c => c.PublicId == id);
        }
    }
}