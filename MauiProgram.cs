using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Maps;
using Microsoft.Extensions.Logging;

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
				// Initialise Maui Maps for Android and iOS by adding the below line of code
				//.UseMauiMaps()
				// Initialize the .NET MAUI Community Toolkit Maps by adding the below line of code
				//BingMaps Key
				.UseMauiCommunityToolkitMaps("tCuaPDhl0FsChmMe662r~lpUgHRzQp4OZaGfn4qIhIw~ArwKowzyFh8fT4r8oHDkjF4h0enfpwwIQDgqJiT1IvT2VMYcFHUwuCxeT0-L3CIY") 
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
}
