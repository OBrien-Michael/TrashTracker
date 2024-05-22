using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TrashTracker.Model;
using TrashTracker.Services;

namespace TrashTracker.ViewModel
{
    [QueryProperty(nameof(Location), "location")]
    public partial class CreateNewTrashPinModalViewModel : ObservableObject
    {
        [ObservableProperty] Location location;
        [ObservableProperty] private string name;
        [ObservableProperty] private string description;
        [ObservableProperty] private string severity;

        private TrashPinService trashPinService;

        // Constructor for the CreateNewTrashPinModalViewModel to bring in the trashPinService
        public CreateNewTrashPinModalViewModel(TrashPinService trashPinService)
        {
            this.trashPinService = trashPinService;
        }

        [RelayCommand]
        void ReturnToMap()
        {
            Shell.Current.GoToAsync("..");
        }



        [RelayCommand]
        public void CreateTrashPin()
        {
            if (location == null) {
                // If the location is null, return to the map page
                Shell.Current.GoToAsync("..");
                return;
            }

            // Parse the Severity string to the Severity enum
            Severity parsedSeverity;
            if (severity == "Low")
            {
                parsedSeverity = Model.Severity.Low;
            }
            else if (severity == "Medium")
            {
                parsedSeverity = Model.Severity.Medium;
            }
            else if (severity == "High")
            {
                parsedSeverity = Model.Severity.High;
            }
            else
            {
                parsedSeverity = Model.Severity.Low;
            }


            TrashPin trashPin = new TrashPin(name,description,location,parsedSeverity,0)
			{
                Name = name,
                Description = description,
                Location = location,
                Severity = parsedSeverity,
                ReportedBy = 0,
                ReportedOn = DateTime.Now
            };

            
            // Save the TrashPin object to the list of trash pins
            trashPinService.AddTrashPin(trashPin);


            // Return to the map page
            Shell.Current.GoToAsync("..");
        }


    }
}
