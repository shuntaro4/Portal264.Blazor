using System.Net.Http;
using System.Threading.Tasks;

namespace Portal264.Blazor.Models
{
    public interface IFetchDataModel
    {
        IWeatherForecast[] WeatherForecasts { get; }
        IWeatherDotGovForecast RealWeatherForecast { get; }
        IWeatherDotGovForecast HourlyWeatherForecast { get; }

        Task RetrieveForecastsAsync();
        Task RetrieveHourlyForecastAsync();
        Task RetrieveRealForecastAsync();
    }

    public class FetchDataModel : IFetchDataModel
    {
        private HttpClient _http;
        private IWeatherForecast[] _weatherForecasts;
        private IWeatherDotGovForecast _realWeatherForecast;
        private IWeatherDotGovForecast _hourlyWeatherForecast;
        private IFullForecastModel _dailyForecast;
        private IBasicForecastModel _basicForecast;

        public IWeatherForecast[] WeatherForecasts
        {
            get => _weatherForecasts;
            private set => _weatherForecasts = value;
        }

        public IWeatherDotGovForecast RealWeatherForecast
        {
            get => _realWeatherForecast;
            private set => _realWeatherForecast = value;
        }

        public IWeatherDotGovForecast HourlyWeatherForecast
        {
            get => _hourlyWeatherForecast;
            private set => _hourlyWeatherForecast = value;
        }

        public FetchDataModel(HttpClient http, IFullForecastModel dailyForecast, IBasicForecastModel basicForecast)
        {
            _http = http;
            _dailyForecast = dailyForecast;
            _basicForecast = basicForecast;
        }

        public async Task RetrieveForecastsAsync()
        {
            if (_weatherForecasts == null)
            {
                _weatherForecasts = await
                   _basicForecast.RetrieveBasicForecast();
            }
        }

        public async Task RetrieveRealForecastAsync()
        {
            if (_realWeatherForecast == null)
            {
                _realWeatherForecast = await
                   _dailyForecast.RetrieveFullForecast();
            }
        }

        public async Task RetrieveHourlyForecastAsync()
        {
            if (_hourlyWeatherForecast == null)
            {
                _realWeatherForecast = await
                    _dailyForecast.RetrieveFullForecast();
            }
        }
    }
}

