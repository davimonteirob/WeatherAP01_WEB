namespace WeatherAPI_WEB.ModelsAPI
{
    public class WeatherResponse
    {
        public MainInfo Main { get; set; }
        public Weather[] Weather { get; set; }
    }
}
