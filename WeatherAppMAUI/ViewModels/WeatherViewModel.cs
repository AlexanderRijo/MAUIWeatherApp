using System.Windows.Input;
using WeatherAppMAUI.Infrastructure.Abstractions;
using WeatherAppMAUI.ViewModels.Base;

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
        }

       
    }
}
