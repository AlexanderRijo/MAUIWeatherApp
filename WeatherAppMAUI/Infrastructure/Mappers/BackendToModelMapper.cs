using WeatherAppMAUI.Infrastructure.Services.Weathers;
using WeatherAppMAUI.Models;

namespace WeatherAppMAUI.Infrastructure.Mappers
{
    public class BackendToModelMapper
    {
        public static WeatherCity GetWeatherCities(WeatherResponse city) 
        {
            if (city == null ) 
            {
                return null;
            
            }

            var mapper = new WeatherMapper();
            return mapper.Map(city);

        }
    }
}
