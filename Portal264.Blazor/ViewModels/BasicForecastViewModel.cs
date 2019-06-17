using Portal264.Blazor.Models;
using System;
using System.Threading.Tasks;

namespace Portal264.Blazor.ViewModels
{
    public delegate Task ToggleDelegate(DateTime selectedDay);

    public interface IBasicForecastViewModel
    {
        string DisplayTemperatureScaleShort { get; }

        IWeatherForecast[] WeatherForecasts { get; set; }

        int DisplayTemperature(int temperature);

        void ToggleTemperatureScale();

        ToggleDelegate ToggleForecastDelegate { get; set; }

        Task ToggleForecast(DateTime selectedDate);
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

        public ToggleDelegate ToggleForecastDelegate { get; set; }

        public async Task ToggleForecast(DateTime selectedDate)
        {
            await ToggleForecastDelegate(selectedDate);
        }
    }
}
