using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.Input;
using TrashTracker.Model;
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

    //When the map appears, load the pins
    protected override void OnAppearing()
    {
        base.OnAppearing();
        ((MapPageViewModel)BindingContext).LoadPins();
    }



	//When map is clicked, take the user to the CreateNewTrashPinModal passing the Location as an argument
	void OnMapClicked(object sender, MapClickedEventArgs e)
	{
        Shell.Current.GoToAsync($"{nameof(CreateNewTrashPinModalView)}",
            new Dictionary<string, object>
            {
                {"location", e.Location}
            });
    }

    //When a pin is clicked, navigate to the TrashPinModalView
    private void Pin_OnInfoWindowClicked(object? sender, PinClickedEventArgs e)
    {
        //Retrieve the pin that was clicked
        Pin mapPin = (Pin)sender;

        //Retrieve the TrashPin object that was bound to the pin
        TrashPin trashPin = (TrashPin)mapPin.BindingContext;

        //Navigate to the TrashPinModalView, passing the TrashPin object as a parameter
        Shell.Current.GoToAsync($"{nameof(TrashPinModalView)}",
            new Dictionary<string, object>
            {
                {"trashPin", trashPin}
            });
    }
}
