using Microsoft.AspNetCore.Blazor.Hosting;

namespace Portal264.Blazor
{
    // todo next tutoral https://itnext.io/refactoring-the-simple-blazor-mvvm-client-adventures-in-dependency-injection-e9866d194ee9
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
