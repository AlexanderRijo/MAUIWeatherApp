using WeatherAppMAUI.Infrastructure.Services.Weathers;

namespace WeatherAppMAUI.Infrastructure.Abstractions
{
    public interface IWeatherServices
    {
        Task<WeatherResponse> GetWeathers(string weatherCity);
    }
}
