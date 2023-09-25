using Newtonsoft.Json;
using WeatherAppMAUI.Infrastructure.Services.Weathers.Models;

namespace WeatherAppMAUI.Infrastructure.Services.Weathers
{
    public class WeatherResponse
    {
  
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

   
}
