using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Portal264.Blazor.Models;
using Portal264.Blazor.ViewModels;

namespace Portal264.Blazor
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IFetchDataViewModel, FetchDataViewModel>();
            services.AddTransient<IFetchDataModel, FetchDataModel>();
            services.AddTransient<IBasicForecastViewModel, BasicForecastViewModel>();

            services.AddTransient<IFullForecastModel, DailyForecastModel>();
            services.AddTransient<IFullForecastModel, HourlyForecastModel>();

            services.AddTransient<IBasicForecastModel, DailyForecastModel>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
