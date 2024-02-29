using CommunityToolkit.Maui;
using MyApp.Home.Service;
using MyApp.Home.ViewModels;
using MyApp.Home.Views;
using MyApp.Utils.Configurations;
using Refit;

namespace MyApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiCommunityToolkit()
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                    fonts.AddFont("BwModelica-Bold.otf", "BwModelicaBold");
                    fonts.AddFont("BwModelica-ExtraBold.otf", "BwModelicaExtraBold");
                    fonts.AddFont("BwModelica-Regular.otf", "BwModelicaRegular");
                });

            //REFIT DI
            builder.Services.AddRefitClient<IService>()
                .ConfigureHttpClient(HttpClientConfiguration.ConfigureHttpClient);

            //VIEWMODEL & VIEW DI
            builder.Services.AddTransient<HomeViewModel>();
            builder.Services.AddTransient<HomeView>();

            return builder.Build();
        }
    }
}
