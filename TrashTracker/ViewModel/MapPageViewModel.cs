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

        //Methods to filter pins on the map based on severity
        [RelayCommand]
        public void ShowLowSeverityPins()
        {
            TrashPins.Clear();
            var trashPins = trashPinService.GetTrashPinsBySeverity(Severity.Low);
            foreach (TrashPin trashPin in trashPins)
            {
                TrashPins.Add(trashPin);
            }
        }

        [RelayCommand]
        public void ShowMediumSeverityPins()
        {
            TrashPins.Clear();
            var trashPins = trashPinService.GetTrashPinsBySeverity(Severity.Medium);
            foreach (TrashPin trashPin in trashPins)
            {
                TrashPins.Add(trashPin);
            }
        }

        [RelayCommand]
        public void ShowHighSeverityPins()
        {
            TrashPins.Clear();
            var trashPins = trashPinService.GetTrashPinsBySeverity(Severity.High);
            foreach (TrashPin trashPin in trashPins)
            {
                TrashPins.Add(trashPin);
            }
        }

        //Method to clear all filters and load all pins
        [RelayCommand]
        public void ShowAllPins()
        {
            TrashPins.Clear();
            LoadPins();
        }

    }
}
