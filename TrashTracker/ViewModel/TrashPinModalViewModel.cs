using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TrashTracker.Model;

namespace TrashTracker.ViewModel
{
    [QueryProperty(nameof(TrashPin), "trashPin")]
    public partial class TrashPinModalViewModel : ObservableObject
    {
        [ObservableProperty] TrashPin trashPin;


        [RelayCommand]
        void ReturnToMap()
        {
            Shell.Current.GoToAsync("..");
        }

    }
}
