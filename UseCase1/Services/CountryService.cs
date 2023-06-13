using EnsureThat;

using UseCase1.Interfaces;
using UseCase1.Models;

namespace UseCase1.Services
{
    public class CountryService : ICountryService
    {
        private HttpClient httpClient;

        public CountryService(HttpClient httpClient)
        {
            this.httpClient = Ensure.Any.IsNotNull(httpClient, nameof(httpClient));
        }

        public async Task<IEnumerable<Country>> GetCountriesAsync()
        {
            var requestUri = "v3.1/all";
            var response = await httpClient.GetAsync(requestUri);
            return await response.Content.ReadFromJsonAsync<IEnumerable<Country>>();
        }
    }
}
