

namespace Structural_Patterns.Proxy
{
    public class WeatherServiceCachingProxy : IWeatherService
    {
        private readonly IWeatherService _weatherService;
        private readonly Dictionary<string, (string data, DateTime timestamp)> _cache;
        private readonly TimeSpan _cacheDuration;
        public WeatherServiceCachingProxy(IWeatherService weatherService, TimeSpan cacheDuration)
        {
            _weatherService = weatherService;
            _cache = new Dictionary<string, (string data, DateTime timestamp)>();
            _cacheDuration = cacheDuration;
        }

        public string GetWeather(string Location)
        {
            if (_cache.ContainsKey(Location))
            {
                var (data, timestamp) = _cache[Location];
                if (DateTime.Now - timestamp < _cacheDuration)
                {
                    Console.WriteLine("Returning cached weather data...");
                    return data;
                }
            }

            var weatherData = _weatherService.GetWeather(Location);
            _cache[Location] = (weatherData, DateTime.Now);
            return weatherData;
        }
    }
}
