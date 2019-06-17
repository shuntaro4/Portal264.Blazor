using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace Portal264.Blazor.Models
{
    public interface IFetchDataModel
    {
        IWeatherForecast[] WeatherForecasts { get; }

        Task RetrieveForecastsAsync();

        WeatherDotGovForecast RealWeatherForecast { get; }

        Task RetrieveRealForecastAsync();
    }

    public class FetchDataModel : IFetchDataModel
    {
        private HttpClient _http;

        private IWeatherForecast[] _weatherForecasts;

        public IWeatherForecast[] WeatherForecasts
        {
            get => _weatherForecasts;
            private set => _weatherForecasts = value;
        }

        private WeatherDotGovForecast _realWeatherForecast;

        public WeatherDotGovForecast RealWeatherForecast { get => _realWeatherForecast; private set => _realWeatherForecast = value; }

        public FetchDataModel(HttpClient http)
        {
            _http = http;
        }

        public async Task RetrieveForecastsAsync()
        {
            _weatherForecasts = await _http.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }

        public async Task RetrieveRealForecastAsync()
        {
            _realWeatherForecast = await _http.GetJsonAsync<WeatherDotGovForecast>
              ("https://api.weather.gov/gridpoints/ALY/59,14/forecast");
        }
    }
}

