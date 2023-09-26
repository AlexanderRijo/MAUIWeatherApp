using WeatherAppMAUI.Infrastructure.Mappers.Base;
using WeatherAppMAUI.Infrastructure.Services.Weathers;
using WeatherAppMAUI.Infrastructure.Services.Weathers.Models;
using WeatherAppMAUI.Models;

namespace WeatherAppMAUI.Infrastructure.Mappers
{
    public class WeatherMapper : BaseMapper<WeatherResponse, WeatherCity>
    {
        protected override WeatherCity MapImpl(WeatherResponse source)
        {
            var result = new WeatherCity
            {
                Weather = source.weather.Select(c => new Weather
                {
                    Main = c.main,
                    Description = c.description,
                    Icon = c.icon,
                }),
                Main = Gettemp(source.main),
                Wind = Getwind(source.wind),
                Name = source.name
            };

            return result;
        }

        private static Main Gettemp (MainDto main) 
        {
            return new Main
            {
                Temp = main.temp,
                Feels_like = main.feels_like,
                Temp_min = main.temp_min,
                Temp_max = main.temp_max,  
                Humidity = main.humidity,

            };
        }

        private static Wind Getwind (WindDto wind) 
        {
            return new Wind
            {
                Speed = wind.speed,
            };
        
        }
    }
}
