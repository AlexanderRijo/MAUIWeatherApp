namespace WeatherAppMAUI.Models
{
    public class WeatherCity
    {
        public IEnumerable<Weather> Weather { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public string Name { get; set; }
    }
}
