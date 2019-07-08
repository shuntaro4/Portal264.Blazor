using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Portal264.Blazor.ViewModels;

namespace Portal264.Blazor
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ILoginViewModel, LoginViewModel>();
            services.AddTransient<INewsViewModel, NewsViewModel>();
            services.AddTransient<IConcertsViewModel, ConcertsViewModel>();

            // I don't know how to pass the value to ConcertViewModel Constructor.
            // So, I created ConcertViewModel object in Concert.razor.cs.
            // services.AddTransient<IConcertViewModel, ConcertViewModel>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
