using WeatherAppMAUI.Infrastructure.Abstractions;
using WeatherAppMAUI.Infrastructure.Mappers;
using WeatherAppMAUI.ViewModels.Base;

namespace WeatherAppMAUI.ViewModels
{
    [QueryProperty("CityName", "name")]
    public class WeatherDetailViewModel : BaseViewModel
    {
        private readonly IWeatherServices _weatherServices;
        private string _cityName;

        public WeatherDetailViewModel(IWeatherServices weatherServices)
        {
            _weatherServices = weatherServices;
            LoadData();
        }

        public string CityName
        {
            get => CityName;
            set
            {
                CityName = value;
                OnPropertyChanged();
            }

        }

        private async void LoadData()
        {
            var response = await _weatherServices.GetWeathers(CityName);
            var results = BackendToModelMapper.GetWeatherCities(response);
        }



    }
}
