using Microsoft.AspNetCore.Blazor.Hosting;

namespace Portal264.Blazor
{
    // Todo tutoral https://itnext.io/using-bing-maps-in-blazor-with-jsinterop-and-typescript-90e888e0e2fd
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>();
    }
}
