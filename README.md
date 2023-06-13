# UC#1
### Application description
Sample .NET Web API application that optimize data collected from an API (https://restcountries.com/v3.1/all) to efficiently process and transform it into usable format for further representation.
The program allows you to filter countries by name and population. Also the program allows you to sort them and limit the number of returned countries in the list.

### Application setup
1. Install .NET 6 SDK
1. Clone the app repository with your favorite GIT client
1. Open the solution
1. Run the app.

### Examples
Substitute {your_port} parameter with yours.

1. Returns all the data:`http://localhost:{your_port}/api/country`
1. Returns the data filtered by name:`http://localhost:{your_port}/api/country?nameFilter={your_filter}`
1. Returns the data filtered by population(in millions):`http://localhost:{your_port}/api/country?population={your_population}`
1. Returns the ordered data. Valid keywords: ascend and descend (in other cases sorting is not applied):`http://localhost:{your_port}/api/country?sort={ascend/descend}`
1. Returns the top 'n' items. :`http://localhost:{your_port}/api/country?top={your_number}`
1. Also you may combine parameters: `http://localhost:{your_port}/api/country?nameFilter={your_filter}&population={your_population}&sort=sort={ascend/descend}&top={your_number}`