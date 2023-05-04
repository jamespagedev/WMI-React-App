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
            return await _context.Cars!.Include(c => c.Country).OrderBy(c => c.CreatedOn).ThenBy(c => c.WMI).ToListAsync();
        }

        public async Task<IEnumerable<CarModel>> Search(string? searchValue, string country)
        {
            IQueryable<CarModel> query = _context.Cars!.Include(c => c.Country).OrderBy(c => c.CreatedOn).ThenBy(c => c.WMI);
            
            if (!string.IsNullOrEmpty(searchValue))
            {
                query = query.Where(e => e.Name!.ToLower().Contains(searchValue.ToLower()) ||
                    e.VehicleType!.ToLower().Contains(searchValue.ToLower()) ||
                    e.WMI!.ToLower().Contains(searchValue.ToLower())
                );
            }
            
            if (country.ToLower() != "view all")
            {
                query = query.Where(e => e.Country != null && e.Country.Name.ToLower() == country.ToLower());
            }
            
            return await query.ToListAsync();
        }
    }
}