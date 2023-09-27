using WeatherAppMAUI.Infrastructure.Abstractions;
using WeatherAppMAUI.Infrastructure.Services.Weathers;
using WeatherAppMAUI.ViewModels;
using WeatherAppMAUI.Views;

namespace WeatherAppMAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()

            .UsePrism(prism =>
            {
                //Registro de páginas 
                prism.RegisterTypes(types =>
                {
                    types.RegisterForNavigation<WeatherView, WeatherViewModel>();
                    types.RegisterForNavigation<WeatherDetailView, WeatherDetailViewModel>();
                              
                })

                //Inyección de dependencias 
                .ConfigureServices(services =>
                {
                    services.AddSingleton<IWeatherServices, WeatherServices>();
                })

                // Página de inicio de la aplicación 
                .OnAppStart(async (start) =>
                {
                    await start.NavigateAsync("WeatherView");
                });

            })

            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
