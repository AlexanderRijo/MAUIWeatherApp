using WeatherAppMAUI.Infrastructure.Abstractions;
using WeatherAppMAUI.ViewModels.Base;

namespace WeatherAppMAUI.ViewModels
{
    public class WeatherViewModel : BaseViewModel
    {
        private readonly IWeatherServices _weatherServices;

        public WeatherViewModel(IWeatherServices weatherServices)
        {
            _weatherServices = weatherServices;
            LoadData();
        }

        private async void LoadData() 
        {
            var response = await _weatherServices.GetWeathers("ciudad real");
        }
    }
}
