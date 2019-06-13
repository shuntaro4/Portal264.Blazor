using Portal264.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portal264.Blazor.ViewModels
{
    public interface IFetchDataViewModel
    {
        IWeatherForecast[] WeatherForecasts { get; set; }

        string DisplayTemperatureScaleShort { get; }

        string DisplayOtherTemperatureScaleLong { get; }

        int DisplayTemperature(int temperature);

        Task RetrieveForecastsAsync();

        void ToggleTemperatureScale();
    }

    public class FetchDataViewModel : IFetchDataViewModel
    {
        private IWeatherForecast[] _weatherForecasts;

        public IWeatherForecast[] WeatherForecasts
        {
            get => _weatherForecasts;
            set => _weatherForecasts = value;
        }

        private IFetchDataModel _fetchDataModel;

        private bool _displayFahrenheit;

        public string DisplayTemperatureScaleShort
        {
            get
            {
                return _displayFahrenheit ? "F" : "C";
            }
        }

        public string DisplayOtherTemperatureScaleLong
        {
            get
            {
                return !_displayFahrenheit ? "Fahrenheit" : "Celsius";
            }
        }

        public FetchDataViewModel(IFetchDataModel fetchDataModel)
        {
            Console.WriteLine("FetchDataViewModel Constructor Executing");
            _fetchDataModel = fetchDataModel;
        }

        public async Task RetrieveForecastsAsync()
        {
            await _fetchDataModel.RetrieveForecastsAsync();
            List<IWeatherForecast> newForecasts = new List<IWeatherForecast>();
            foreach (IWeatherForecast forecast in _fetchDataModel.WeatherForecasts)
            {
                IWeatherForecast newForecast = new WeatherForecast
                {
                    Date = forecast.Date,
                    Summary = forecast.Summary,
                    TemperatureC = forecast.TemperatureC
                };
                newForecasts.Add(forecast);
            }
            _weatherForecasts = newForecasts.ToArray();

            Console.WriteLine("FetchDataViewModel Forecasts Retrieved");
        }

        public int DisplayTemperature(int temperature)
        {
            return _displayFahrenheit ? 32 + (int)(temperature / 0.5556) : temperature;
        }

        public void ToggleTemperatureScale()
        {
            _displayFahrenheit = !_displayFahrenheit;
        }
    }
}
