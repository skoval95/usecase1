using System.Net.Mime;

using EnsureThat;
using Microsoft.AspNetCore.Mvc;

using UseCase1.Interfaces;
using UseCase1.Models;

namespace UseCase1.Controllers
{
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        private readonly ICountryService countryService;
        public CountryController(ICountryService countryService)
        {
            this.countryService = Ensure.Any.IsNotNull(countryService, nameof(countryService));
        }

        [HttpGet]
        public Task<IEnumerable<Country>> Get(
            [FromQuery] string? name = null,
            [FromQuery] int? population = null,
            [FromQuery] string? sort = null,
            [FromQuery] int? top = null)
        {
            return countryService.GetCountriesAsync();
        }
    }
}
