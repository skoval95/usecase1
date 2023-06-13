using System.Net.Mime;

using EnsureThat;
using Microsoft.AspNetCore.Mvc;

using UseCase1.Interfaces;
using UseCase1.Models;
using UseCase1.Services;

namespace UseCase1.Controllers
{
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        private const string ascendKeyWord = "ascend";
        private const string descendKeyWord = "descend";

        private readonly ICountryService countryService;
        public CountryController(ICountryService countryService)
        {
            this.countryService = Ensure.Any.IsNotNull(countryService, nameof(countryService));
        }

        [HttpGet]
        public async Task<IEnumerable<Country>> Get(
            [FromQuery(Name = "nameFilter")] string nameFilter = null,
            [FromQuery(Name = "population")] int? population = null,
            [FromQuery(Name = "sort")] string sort = null,
            [FromQuery(Name = "top")] int? top = null)
        {
            var result = await countryService.GetAllCountriesAsync();

            if (!string.IsNullOrWhiteSpace(nameFilter))
            {
                result = CountryService.GetFilteredCountriesByName(result, nameFilter);
            }

            if (population.HasValue)
            {
                result = CountryService.GetFilteredCountriesByPopulation(result, population.Value);
            }

            if (!string.IsNullOrWhiteSpace(sort)
                && (sort.Equals(ascendKeyWord) || sort.Equals(descendKeyWord)))
            {
                result = CountryService.GetOrderedCountriesByName(result, sort.Equals(ascendKeyWord));
            }

            if (top.HasValue)
            {
                result = CountryService.GetLimitedNumberOfCountries(result, top.Value);
            }

            return result;
        }
    }
}
