using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Portal264.Blazor.Models
{
    public interface IFullForecastModel
    {
        Task<IWeatherDotGovForecast> RetrieveFullForecast();
    }
    public interface IBasicForecastModel
    {
        Task<IWeatherForecast[]> RetrieveBasicForecast();
    }

    public class DailyForecastModel : IFullForecastModel, IBasicForecastModel
    {
        private HttpClient _httpClient;

        public DailyForecastModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IWeatherDotGovForecast> RetrieveFullForecast()
        {
            var forecast = await RetrieveForecast();
            return forecast;
        }

        private async Task<IWeatherDotGovForecast> RetrieveForecast()
        {
            return await _httpClient.GetJsonAsync<WeatherDotGovForecast>
              ("https://api.weather.gov/gridpoints/ALY/59,14/forecast");
        }

        public async Task<IWeatherForecast[]> RetrieveBasicForecast()
        {
            var forecast = await RetrieveForecast();
            var basicForecast = (from Period p in forecast.properties.periods
                                 where p.number % 2 == 0
                                 select new WeatherForecast
                                 {
                                     Date = p.startTime,
                                     TemperatureC = (int)((p.temperature - 32) * 5 / 9),
                                     Summary = p.shortForecast
                                 }).ToArray();
            return basicForecast;
        }

    }
}
