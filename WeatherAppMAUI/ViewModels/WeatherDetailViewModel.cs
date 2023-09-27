using WeatherAppMAUI.Infrastructure.Abstractions;
using WeatherAppMAUI.Infrastructure.Mappers;
using WeatherAppMAUI.ViewModels.Base;

namespace WeatherAppMAUI.ViewModels
{

    public class WeatherDetailViewModel : BaseViewModel
    {
        private readonly IWeatherServices _weatherServices;


        public WeatherDetailViewModel(IWeatherServices weatherServices)
        {
            _weatherServices = weatherServices;
            /* LoadData();*/
        }


    }


    /*  private async void LoadData()
      {
          var response = await _weatherServices.GetWeathers(CityName);
          var results = BackendToModelMapper.GetWeatherCities(response);
      }*/




}
