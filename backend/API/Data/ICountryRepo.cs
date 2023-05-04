using API.Models;

namespace API.Data
{
    public interface ICountryRepo
    {
        Task<IEnumerable<CountryModel>> GetAllCountries();
    }
}