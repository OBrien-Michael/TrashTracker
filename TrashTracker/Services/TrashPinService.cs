using System.Collections.ObjectModel;
using Firebase.Database;
using Firebase.Database.Query;
using TrashTracker.Model;

namespace TrashTracker.Services
{
    public class TrashPinService
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://project-trashtracker-default-rtdb.europe-west1.firebasedatabase.app/");

        public ObservableCollection<TrashPin> TrashPinList { get; set; } = new ObservableCollection<TrashPin>();

		public TrashPinService()
		{

        }

        //Return all TrashPins
        public async Task<List<TrashPin>> GetAllTrashPins()
        {
            return (await firebaseClient
                .Child("TrashPins")
                .OnceAsync<TrashPin>()).Select(item => new TrashPin
            {
                Id = item.Object.Id,
                Location = item.Object.Location,
                Name = item.Object.Name,
                Description = item.Object.Description,
                Severity = item.Object.Severity,
                ReportedBy = item.Object.ReportedBy,
                ReportedOn = item.Object.ReportedOn
            }).ToList();
        }

        //Returns a list of TrashPins with the specified severity
        public async Task<List<TrashPin>> GetTrashPinsBySeverity(Severity severity)
        {
            var allPins = await GetAllTrashPins();
            return allPins.Where(pin => pin.Severity == severity).ToList();
        }

        //Add a TrashPin to the TrashPinList
        public async Task AddTrashPin(TrashPin trashPin)
        {
            await firebaseClient
                .Child("TrashPins")
                .PostAsync(trashPin);
        }
    }
}
