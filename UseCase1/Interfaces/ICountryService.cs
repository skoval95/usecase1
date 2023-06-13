using UseCase1.Models;

namespace UseCase1.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetCountriesAsync();
    }
}
