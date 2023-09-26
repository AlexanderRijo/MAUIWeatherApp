using System.Windows.Input;
using WeatherAppMAUI.ViewModels.Base;

namespace WeatherAppMAUI.ViewModels
{
    public class WeatherViewModel : BaseViewModel
    {
        private string _cityName;

        public WeatherViewModel()
        {
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
            await Shell.Current.GoToAsync($"WeatherDetail?name={CityName}");
        }

       
    }
}
