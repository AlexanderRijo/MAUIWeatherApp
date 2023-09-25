namespace WeatherAppMAUI.Infrastructure.Services.Weathers.Models
{
    public class ResultDto
    {
        public string name { get; set; }
        public SysDto sys { get; set; }
        public MainDto main { get; set; }
    }

    public class SysDto
    {
        public string country { get; set; }
    }

    public class MainDto
    {
        public int humidity { get; set; }
    }
}
