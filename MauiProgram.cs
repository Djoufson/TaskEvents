﻿using Microsoft.Extensions.Logging;

namespace TaskEvents;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.Services.AddSingleton<ViewModel>();
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<App>();
        builder.Services.AddSingleton<IJob, Job>();
        builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
