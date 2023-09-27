using Prism.Navigation;
using System.Windows.Input;
using WeatherAppMAUI.ViewModels.Base;

namespace WeatherAppMAUI.ViewModels
{
    public class WeatherViewModel : BaseViewModel
    {
        private string _cityName;
        private readonly INavigationService _navigationService;

        public WeatherViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            SearchCommand = new Command(async () => await NavigateToWeatherDetailView()); 
        }
       
        public string CityName 
        { 
            get => _cityName;
            set => SetProperty(ref _cityName, value);
        }

        public ICommand SearchCommand { get; }

      
        private async Task NavigateToWeatherDetailView() 
        {
            await _navigationService.NavigateAsync("WeatherDetailView");
        }

       
    }
}
