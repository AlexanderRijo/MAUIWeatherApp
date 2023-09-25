using WeatherAppMAUI.Infrastructure.Mappers.Base;
using WeatherAppMAUI.Infrastructure.Services.Weathers;
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
                }).ToArray(),

                Main = new Main
                {
                   Temp = source.main.temp,
                   Feels_like = source.main.feels_like,
                   Temp_min = source.main.temp_min,
                   Temp_max = source.main.temp_max,
                   Humidity = source.main.humidity

                }, 

                Wind = new Wind 
                {
                    Speed = source.wind.speed
                },

                Name = source.name
            };

            return result;
        }
    }
}
