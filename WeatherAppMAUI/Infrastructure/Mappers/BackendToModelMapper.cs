using WeatherAppMAUI.Infrastructure.Services.Weathers;
using WeatherAppMAUI.Models;

namespace WeatherAppMAUI.Infrastructure.Mappers
{
    public class BackendToModelMapper
    {
        public static IEnumerable<WeatherCity> GetWeatherCities(IEnumerable<WeatherResponse> city) 
        {
            if (city is null || !city.Any()) 
            {
                return Enumerable.Empty<WeatherCity>();
            
            }

            var mapper = new WeatherMapper();
            return city.Select(r => mapper.Map(r));

        }
    }
}
