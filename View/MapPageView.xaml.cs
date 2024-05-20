using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using TrashTracker.ViewModel;

namespace TrashTracker.View;

public partial class MapPageView : ContentPage
{

	public MapPageView(MapPageViewModel mapPageViewModel)
	{
		InitializeComponent();
		BindingContext = mapPageViewModel;

		//Move the map to a specific location in Ireland
		MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Location(52.57465, -9.10040), 
			Distance.FromMiles(500)));
	}

	//When map is clicked, write the location to the console
	void OnMapClicked(object sender, MapClickedEventArgs e)
	{
		System.Diagnostics.Debug.WriteLine($"MapClick: {e.Location.Latitude}, {e.Location.Longitude}");
	}
}