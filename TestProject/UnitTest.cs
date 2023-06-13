using UseCase1.Models;
using UseCase1.Services;

namespace TestProject
{
    public class UnitTest
    {
        private const int million = 1000000;

        private readonly List<Country> countries = new List<Country>
        {
            new Country
            {
                Name = new CountryName
                {
                    Common = "QwEr2"
                },
                Population = 2 * million
            },
            new Country
            {
                Name = new CountryName
                {
                    Common = "AbCd1"
                },
                Population = 10 * million
            },
            new Country
            {
                Name = new CountryName
                {
                    Common = "APOZX1"
                },
                Population = 100 * million
            },

        };

        [Theory]
        [InlineData("QwEr2")]
        [InlineData("abcd")]
        [InlineData("zx")]
        public void CountriesService_FilterCountriesByName_ReturnsFilteredCountries(string filter)
        {
            // arrange & act
            var result = CountryService.GetFilteredCountriesByName(countries, filter);

            // assert
            Assert.Single(result);
        }

        [Theory]
        [InlineData(1,0)]
        [InlineData(3, 1)]
        [InlineData(11,2)]
        [InlineData(101,3)]
        public void CountriesService_FilterCountriesByPopulation_ReturnsFilteredCountries(
            int population, int expectedCount)
        {
            // arrange & act
            var result = CountryService.GetFilteredCountriesByPopulation(countries, population);

            // assert
            Assert.Equal(expectedCount, result.Count());
        }

        [Theory]
        [InlineData(true, 1)]
        [InlineData(false, 0)]
        public void CountriesService_SortCountries_ReturnsOrderedListOfCountries(
            bool asc, int expectedCountryIndex)
        {
            // arrange & act
            var result = CountryService.GetOrderedCountriesByName(countries, asc);

            // assert
            Assert.Equal(countries[expectedCountryIndex], result.First());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void CountriesService_GetLimitedNumberOfCountries_ReturnsValidNumberOfCountries(
            int top)
        {
            // arrange & act
            var result = CountryService.GetLimitedNumberOfCountries(countries, top);

            // assert
            Assert.Equal(top, result.Count());
        }

    }
}