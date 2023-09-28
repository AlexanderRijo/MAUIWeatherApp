using Newtonsoft.Json;
using WeatherAppMAUI.Infrastructure.Abstractions;

namespace WeatherAppMAUI.Infrastructure.Services.Weathers
{
    public class WeatherServices : IWeatherServices
    {
        private const string SearchWeathersEndpoint = "https://api.openweathermap.org/data/2.5/weather?q={0}&appid=23089bd900735acc7f2898643aa20c65&lang=es&units=metric";

        public async Task<WeatherResponse> GetWeathers(string weatherCity) 
        {
            WeatherResponse result = new WeatherResponse();

            var url = string.Format(SearchWeathersEndpoint, weatherCity);

            using (HttpClient client = new HttpClient()) 
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                var response = await client.SendAsync(request);
                var json = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<WeatherResponse>(json);
            
            }

            return result;


        } 
    }
}
