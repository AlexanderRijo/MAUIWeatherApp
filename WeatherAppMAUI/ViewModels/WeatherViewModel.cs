using System.ComponentModel;
using System.Windows.Input;
using WeatherAppMAUI.Infrastructure.Abstractions;
using WeatherAppMAUI.Infrastructure.Mappers;
using WeatherAppMAUI.Models;
using WeatherAppMAUI.ViewModels.Base;

namespace WeatherAppMAUI.ViewModels
{
    public class WeatherViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private readonly IWeatherServices _weatherServices;
        private string _cityName;
        private WeatherCity _weatherCity;

        public WeatherViewModel(IWeatherServices weatherServices)
        {
            _weatherServices = weatherServices;
            SearchCommand = new Command(async () => await PerformSearchCommand()); 
        }

       
        public string CityName 
        { 
            get => _cityName;
            set => SetProperty(ref _cityName, value);
        }

        public WeatherCity WeatherCity
        {
            get => _weatherCity;
            set
            {
                if (_weatherCity != value)
                {
                    _weatherCity = value;
                    OnPropertyChanged(nameof(WeatherCity));
                }
            }

        }

        public ICommand SearchCommand { get; }

      
        private async Task PerformSearchCommand() 
        {
            var response = await _weatherServices.GetWeathers(CityName);
            var results = BackendToModelMapper.GetWeatherCities(response);
            WeatherCity = results;
        }

       
    }
}
