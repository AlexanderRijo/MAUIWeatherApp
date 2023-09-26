using WeatherAppMAUI.Infrastructure.Mappers;
using WeatherAppMAUI.Models;
using WeatherAppMAUI.ViewModels.Base;

namespace WeatherAppMAUI.ViewModels
{
    public class WeatherDetailViewModel : BaseViewModel
    {
        private WeatherCity _weatherCity;

        public WeatherDetailViewModel()
        {
         
        }

        public WeatherCity WeatherCity 
        {
            get => _weatherCity;
            set => SetProperty(ref _weatherCity, value);
        }

    }
}
