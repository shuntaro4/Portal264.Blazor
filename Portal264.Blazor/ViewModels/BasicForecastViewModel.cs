using Portal264.Blazor.Models;

namespace Portal264.Blazor.ViewModels
{

    public interface IBasicForecastViewModel
    {
        string DisplayTemperatureScaleShort { get; }

        IWeatherForecast[] WeatherForecasts { get; set; }

        int DisplayTemperature(int temperature);

        void ToggleTemperatureScale();
    }

    public class BasicForecastViewModel : IBasicForecastViewModel
    {
        private IWeatherForecast[] _weatherForecasts;

        private bool _displayFahrenheit;

        public IWeatherForecast[] WeatherForecasts { get => _weatherForecasts; set => _weatherForecasts = value; }

        public string DisplayTemperatureScaleShort
        {
            get { return _displayFahrenheit ? "C" : "F"; }
        }

        public int DisplayTemperature(int temperature)
        {
            return _displayFahrenheit ? temperature : 32 + (int)(temperature / 0.5556);
        }

        public void ToggleTemperatureScale()
        {
            _displayFahrenheit = !_displayFahrenheit;
        }
    }
}
