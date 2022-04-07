using Microsoft.AspNetCore.Components.WebView.Maui;
using ATOLL.Data;
using Syncfusion.Blazor;


namespace ATOLL;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjA1MjI2QDMyMzAyZTMxMmUzMFZnc09NYmYydFl2cStVT09lOFIzMHlIbzY2RHc0cS9Jdk1LT294eFJjUFk9");	
		var builder = MauiApp.CreateBuilder();
		builder
			.RegisterBlazorMauiWebView()
			.UseMauiApp<App>()
			
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});
		builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
		builder.Services.AddBlazorWebView();
		builder.Services.AddSingleton<WeatherForecastService>();
		
		return builder.Build();
	}
}
