using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Database;
using TrashTracker.Model;
using TrashTracker.Services;
using TrashTracker.View;

namespace TrashTracker.ViewModel
{
	public partial class MapPageViewModel1 : ObservableObject
	{

        private TrashPinService trashPinService;


		[ObservableProperty] public ObservableCollection<TrashPin> _trashPins;


		//Constructor for the MapPageViewModel
		public MapPageViewModel(TrashPinService trashPinService)
		{
			_trashPins = new ObservableCollection<TrashPin>();
			this.trashPinService = trashPinService;

        }


        //Method to load pins from the TrashPinService
        public async Task LoadPins()
        {
            var trashPins = await trashPinService.GetAllTrashPins();
            foreach (TrashPin trashPin in trashPins)
            {
                TrashPins.Add(trashPin);
            }
        }

        //Methods to filter pins on the map based on severity
        [RelayCommand]
        public async Task ShowLowSeverityPins()
        {
            TrashPins.Clear();
            var trashPins = await trashPinService.GetTrashPinsBySeverity(Severity.Low);
            foreach (TrashPin trashPin in trashPins)
            {
                TrashPins.Add(trashPin);
            }
            OnPropertyChanged(nameof(TrashPins));
        }

        [RelayCommand]
        public async Task ShowMediumSeverityPins()
        {
            TrashPins.Clear();
            var trashPins = await trashPinService.GetTrashPinsBySeverity(Severity.Medium);
            foreach (TrashPin trashPin in trashPins)
            {
                TrashPins.Add(trashPin);
            }
            OnPropertyChanged(nameof(TrashPins));
        }

        [RelayCommand]
        public async Task ShowHighSeverityPins()
        {
            TrashPins.Clear();
            var trashPins = await trashPinService.GetTrashPinsBySeverity(Severity.High);
            foreach (TrashPin trashPin in trashPins)
            {
                TrashPins.Add(trashPin);
            }
            OnPropertyChanged(nameof(TrashPins));
        }

        //Method to clear all filters and load all pins
        [RelayCommand]
        public async Task ShowAllPins()
        {
            TrashPins.Clear();
            await LoadPins();
        }

    }
}
