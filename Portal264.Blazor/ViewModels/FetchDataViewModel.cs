using Portal264.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portal264.Blazor.ViewModels
{
    public interface IFetchDataViewModel
    {
        string DisplayOtherTemperatureScaleLong { get; }

        IBasicForecastViewModel BasicForecastViewModel { get; }

        string DisplayPremiumToggleMessage { get; }

        Task RetrieveForecastsAsync();

        void TogglePremiumMembership();

        void ToggleTemperatureScale();
    }

    public class FetchDataViewModel : IFetchDataViewModel
    {
        private IFetchDataModel _fetchDataModel;
        private bool _displayFahrenheit;
        private IBasicForecastViewModel _basicForecastViewModel;
        private bool _isPremiumMember;

        public string DisplayOtherTemperatureScaleLong
        {
            get
            {
                return _displayFahrenheit ? "Celsius" : "Fahrenheit";
            }
        }

        public IBasicForecastViewModel BasicForecastViewModel
        {
            get => _basicForecastViewModel;
            private set => _basicForecastViewModel = value;
        }

        public string DisplayPremiumToggleMessage => _isPremiumMember ? "Change to Basic" : "Change to Premium";

        public FetchDataViewModel(IFetchDataModel fetchDataModel, IBasicForecastViewModel basicForecastViewModel)
        {
            Console.WriteLine("FetchDataViewModel Constructor Executing");
            _fetchDataModel = fetchDataModel;
            _basicForecastViewModel = basicForecastViewModel;
            _displayFahrenheit = true;
            _isPremiumMember = false;
        }

        public async Task RetrieveForecastsAsync()
        {
            await _fetchDataModel.RetrieveForecastsAsync();
            List<IWeatherForecast> newForecasts = new List<IWeatherForecast>();
            foreach (IWeatherForecast forecast in _fetchDataModel.WeatherForecasts)
            {
                IWeatherForecast newForecast = new WeatherForecast();
                newForecast.Date = forecast.Date;
                newForecast.Summary = forecast.Summary;
                newForecast.TemperatureC = forecast.TemperatureC;
                newForecasts.Add(forecast);
            }
            _basicForecastViewModel.WeatherForecasts = newForecasts.ToArray();
            Console.WriteLine("FetchDataViewModel Forecasts Retrieved");
        }

        public void ToggleTemperatureScale()
        {
            _displayFahrenheit = !_displayFahrenheit;
            _basicForecastViewModel.ToggleTemperatureScale();
        }
        public void TogglePremiumMembership()
        {
            _isPremiumMember = !_isPremiumMember;
        }
    }
}
