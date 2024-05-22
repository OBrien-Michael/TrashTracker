using TrashTracker.ViewModel;

namespace TrashTracker.View;

public partial class CreateNewTrashPinModalView : ContentPage
{
	public CreateNewTrashPinModalView(CreateNewTrashPinModalViewModel createNewTrashPinModalViewModel)
	{
		InitializeComponent();
        BindingContext = createNewTrashPinModalViewModel;
	}
}
