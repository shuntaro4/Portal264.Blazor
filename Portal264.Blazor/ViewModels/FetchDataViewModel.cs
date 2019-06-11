using Portal264.Blazor.Models;
using System;

namespace Portal264.Blazor.ViewModels
{
    public interface IFetchDataViewModel
    {
        WeatherForecast[] WeatherForecasts { get; set; }
    }

    public class FetchDataViewModel : IFetchDataViewModel
    {
        private WeatherForecast[] _weatherForecasts;
        public WeatherForecast[] WeatherForecasts
        {
            get => _weatherForecasts;
            set => _weatherForecasts = value;
        }
        public FetchDataViewModel()
        {
            Console.WriteLine("FetchDataViewModel Constructor Executing");
        }
    }
}
