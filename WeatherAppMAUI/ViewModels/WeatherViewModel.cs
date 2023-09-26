using System.Windows.Input;
using WeatherAppMAUI.Infrastructure.Abstractions;
using WeatherAppMAUI.Infrastructure.Mappers;
using WeatherAppMAUI.Infrastructure.Services.Weathers;
using WeatherAppMAUI.ViewModels.Base;
using WeatherAppMAUI.Views;

namespace WeatherAppMAUI.ViewModels
{
    public class WeatherViewModel : BaseViewModel
    {
        private readonly IWeatherServices _weatherServices;
        private string _cityName;

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

        public ICommand SearchCommand { get; }

      
        private async Task PerformSearchCommand() 
        {
            var response = await _weatherServices.GetWeathers(CityName);
            var results = BackendToModelMapper.GetWeatherCities(response);
            await Shell.Current.GoToAsync($"{nameof(WeatherDetailView)}");
        }

       
    }
}
