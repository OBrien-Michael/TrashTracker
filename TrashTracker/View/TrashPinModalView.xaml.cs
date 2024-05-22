using CommunityToolkit.Maui.Views;
using TrashTracker.ViewModel;

namespace TrashTracker.View;

public partial class TrashPinModalView : ContentPage
{
    public TrashPinModalView(TrashPinModalViewModel trashPinModalViewModel)
    {
        InitializeComponent();
        BindingContext = trashPinModalViewModel;
    }
}
