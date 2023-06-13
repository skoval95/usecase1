using EnsureThat;

using UseCase1.Interfaces;
using UseCase1.Models;

namespace UseCase1.Services
{
    public class CountryService : ICountryService
    {
        private const int million = 1000000;
        private readonly HttpClient httpClient;

        public CountryService(HttpClient httpClient)
        {
            this.httpClient = Ensure.Any.IsNotNull(httpClient, nameof(httpClient));
        }

        public async Task<IEnumerable<Country>> GetAllCountriesAsync()
        {
            var requestUri = "v3.1/all";
            var response = await httpClient.GetAsync(requestUri);
            var result = await response.Content.ReadFromJsonAsync<IEnumerable<Country>>();
            return result ?? Enumerable.Empty<Country>();
        }

        public static IEnumerable<Country> GetFilteredCountriesByName(IEnumerable<Country> countries, string nameFilter)
            => countries.Where(c => c.Name.Common.Contains(nameFilter, StringComparison.InvariantCultureIgnoreCase));

        public static IEnumerable<Country> GetFilteredCountriesByPopulation(IEnumerable<Country> countries, int populationInMillions)
            => countries.Where(c => c.Population < populationInMillions * million);

        public static IEnumerable<Country> GetOrderedCountriesByName(IEnumerable<Country> countries, bool ascend)
            => ascend ? countries.OrderBy(c => c.Name.Common) : countries.OrderByDescending(c => c.Name.Common);

        public static IEnumerable<Country> GetLimitedNumberOfCountries(IEnumerable<Country> countries, int limit)
            => countries.Take(limit);
    }
}
