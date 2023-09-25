using WeatherAppMAUI.Infrastructure.Services.Weathers;

namespace WeatherAppMAUI.Infrastructure.Abstractions
{
    public interface IWeatherServices
    {
        Task<WeatherResponse> GetWeathers(double latitude, double longitude);
    }
}
