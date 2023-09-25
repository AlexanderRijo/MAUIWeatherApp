using Newtonsoft.Json;
using WeatherAppMAUI.Infrastructure.Services.Weathers.Models;

namespace WeatherAppMAUI.Infrastructure.Services.Weathers
{
    public class WeatherResponse
    {
         public WeatherDto[] Weather { get; set; }
         public MainDto main { get; set; }
         public WindDto wind { get; set; }
         public string name { get; set; }
        
    }

   
}
