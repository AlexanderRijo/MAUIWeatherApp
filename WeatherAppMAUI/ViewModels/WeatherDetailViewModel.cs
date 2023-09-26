using WeatherAppMAUI.Models;
using WeatherAppMAUI.ViewModels.Base;

namespace WeatherAppMAUI.ViewModels
{
    public class WeatherDetailViewModel : BaseViewModel
    {
        private WeatherCity _weatherCity;

        public WeatherDetailViewModel()
        {
            _weatherCity = new WeatherCity();
        }

        public WeatherCity WeatherCity 
        {
            get => _weatherCity;
            set => SetProperty(ref _weatherCity, value);
        }

        

    }
}
