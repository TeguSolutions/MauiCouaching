using CommunityToolkit.Maui;
using MauiCouaching.Pages;
using MauiCouaching.Services;

namespace MauiCouaching;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        var s = builder.Services;

        #region Page & VM Registrations

        s.AddTransient<AppInitializationPage>();
        s.AddTransient<AppInitializationVM>();

        s.AddTransient<MainPage>();
        s.AddTransient<MainVM>();

        s.AddTransient<DataPage>();
        s.AddTransient<DataVM>();

        #endregion

        #region Other Services

        s.AddSingleton<DatabaseService>();

        #endregion

		return builder.Build();
	}
}
