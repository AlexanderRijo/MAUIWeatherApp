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
        private UriImageSource _iconSource;
        private WeatherCity _weatherCity;
        private bool isFrameVisible;

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

        public UriImageSource IconSource 
        { 
            get => _iconSource;
            set => SetProperty( ref _iconSource, value);
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

        public bool IsFrameVisible
        {
            get { return isFrameVisible; }
            set
            {
                if (isFrameVisible != value)
                {
                    isFrameVisible = value;
                    OnPropertyChanged(nameof(IsFrameVisible));
                }
            }
        }

        public ICommand SearchCommand { get; }

      
        private async Task PerformSearchCommand() 
        {
            var response = await _weatherServices.GetWeathers(CityName);
            var results = BackendToModelMapper.GetWeatherCities(response);
            WeatherCity = results;
            IconSource = GetIcon();
            IsFrameVisible = true;


        }

        // url: https://openweathermap.org/img/wn/10d@2x.png

        private UriImageSource GetIcon()
        {
            string imageUrl = "https://openweathermap.org/img/wn/" + WeatherCity.Weather[0].Icon + "@2x.png";

             UriImageSource IconSource  = new UriImageSource
            {
                Uri = new Uri(imageUrl),
                CachingEnabled = true,
                CacheValidity = TimeSpan.FromDays(1)

            };

            return IconSource;
        }


    }
}
