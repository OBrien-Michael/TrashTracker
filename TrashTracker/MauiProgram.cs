using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Maps;
using Microsoft.Extensions.Logging;
using TrashTracker.Services;
using TrashTracker.View;
using TrashTracker.ViewModel;

namespace TrashTracker
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				// Initialize the .NET MAUI Community Toolkit by adding the below line of code
				.UseMauiCommunityToolkit()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});

			// Register services
			builder.Services.AddSingleton<TrashPinService>();

			// Register views and view models
			builder.Services.AddSingleton<MapPageView>();
			builder.Services.AddSingleton<MapPageViewModel>();

            builder.Services.AddSingleton<TrashPinModalView>();
            builder.Services.AddSingleton<TrashPinModalViewModel>();


			//Checks to see what platform the app is running on and uses the appropriate map renderer
#if IOS || ANDROID
			builder.UseMauiMaps();
#endif

#if WINDOWS
			// Initialize the .NET MAUI Community Toolkit Maps by adding the below line of code
			builder.UseMauiCommunityToolkitMaps("tCuaPDhl0FsChmMe662r~lpUgHRzQp4OZaGfn4qIhIw~ArwKowzyFh8fT4r8oHDkjF4h0enfpwwIQDgqJiT1IvT2VMYcFHUwuCxeT0-L3CIY");
#endif

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
