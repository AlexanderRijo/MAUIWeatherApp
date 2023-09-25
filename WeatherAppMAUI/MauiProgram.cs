﻿using Microsoft.Extensions.Logging;
using WeatherAppMAUI.Infrastructure.Abstractions;
using WeatherAppMAUI.Infrastructure.Services.Weathers;
using WeatherAppMAUI.ViewModels;

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

		builder.Services.AddSingleton<WeatherView>();
        builder.Services.AddSingleton<WeatherViewModel>();
		builder.Services.AddSingleton<IWeatherServices, WeatherServices>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}