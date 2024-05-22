using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TrashTracker.Model;
using TrashTracker.Services;
using TrashTracker.View;

namespace TrashTracker.ViewModel
{
	public partial class MapPageViewModel : ObservableObject
	{

		private TrashPinService trashPinService;


		[ObservableProperty] public ObservableCollection<TrashPin> _trashPins;


		//Constructor for the MapPageViewModel
		public MapPageViewModel(TrashPinService trashPinService)
		{
			_trashPins = new ObservableCollection<TrashPin>();
			this.trashPinService = trashPinService;
			LoadPins();
		}


		//Method to load pins from the TrashPinService
		public void LoadPins()
		{
			var trashPins = trashPinService.GetAllTrashPins();
			foreach (TrashPin trashPin in trashPins)
			{
				TrashPins.Add(trashPin);
			}
		}

        [ObservableProperty]
        TrashPin selectedTrashPin;

        public void TrashPinSelectedPopup(TrashPin selectedTrashPin)
        {
            if (selectedTrashPin == null) return;
            Shell.Current.GoToAsync($"{nameof(TrashPinModalView)}",
                new Dictionary<string, object>
                {
                    {"Id", selectedTrashPin}
                });
            selectedTrashPin = null;
        }


    }
}
