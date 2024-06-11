

namespace Structural_Patterns.Proxy
{
    public class WeatherService : IWeatherService
    {
        public string GetWeather(string Location)
        {
            // Simulate getting the data from Api Call
            Console.WriteLine("Fetching weather data from the API...");
            return $"Weather data for {Location} at {DateTime.Now}";
        }
    }
}
