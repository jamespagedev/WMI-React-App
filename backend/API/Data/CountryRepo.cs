using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class CountryRepo : ICountryRepo
    {
        private readonly AppDbContext _context;

        public CountryRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CountryModel>> GetAllCountries()
        {
            return await _context.Countries!.OrderBy(c => c.Name).ToListAsync();
        }
    }
}