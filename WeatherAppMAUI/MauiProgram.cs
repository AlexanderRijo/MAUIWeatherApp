using Microsoft.Extensions.Logging;
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
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// Registro de vistas y viewModels
		builder.Services.AddSingleton<WeatherView>();
        builder.Services.AddSingleton<WeatherViewModel>();
		builder.Services.AddSingleton<WeatherDetailView>();
		builder.Services.AddSingleton<WeatherDetailViewModel>();

		// Inyección de dependencias
		builder.Services.AddSingleton<IWeatherServices, WeatherServices>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
