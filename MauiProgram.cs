using Microsoft.Extensions.Logging;
using RegistroEstudiantesMVVM.ViewModels;
using RegistroEstudiantesMVVM.Views;

namespace RegistroEstudiantesMVVM;

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

		builder.Services.AddSingleton<RegistroViewModel>();
		builder.Services.AddTransient<RegistroPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
