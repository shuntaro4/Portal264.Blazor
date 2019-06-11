using Portal264.Blazor.Models;
using System;
using System.Threading.Tasks;

namespace Portal264.Blazor.ViewModels
{
    public interface IFetchDataViewModel
    {
        WeatherForecast[] WeatherForecasts { get; set; }

        Task RetrieveForecastsAsync();
    }

    public class FetchDataViewModel : IFetchDataViewModel
    {
        private WeatherForecast[] _weatherForecasts;
        public WeatherForecast[] WeatherForecasts
        {
            get => _weatherForecasts;
            set => _weatherForecasts = value;
        }
        private IFetchDataModel _fetchDataModel;

        public FetchDataViewModel(IFetchDataModel fetchDataModel)
        {
            Console.WriteLine("FetchDataViewModel Constructor Executing");
            _fetchDataModel = fetchDataModel;
        }

        public async Task RetrieveForecastsAsync()
        {
            _weatherForecasts = await _fetchDataModel.RetrieveForecastsAsync();
            Console.WriteLine("FetchDataViewModel Forecasts Retrieved");
        }
    }
}
