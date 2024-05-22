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

        /*
        //Test pins to load on the map
        public List<TrashPin> TrashPinList =
		[
			new TrashPin
		    {
			    Id = 1,
				Name = "Trash Pin 1 Low",
				Description = "This is a trash pin",
				Location = new Location(52.57465,-9.10040),
				Image = "image1.jpg",
				Severity = Severity.Low,
				ReportedBy = 0,
				ReportedOn = new DateTime(2024, 1, 25, 10, 30, 50),
			},
			new TrashPin
			{
				Id = 2,
				Name = "Trash Pin 2 Medium",
				Description = "This is a trash pin",
				Location = new Location(52.57471,-9.10084),
				Image = "image1.jpg",
				Severity = Severity.Medium,
				ReportedBy = 0,
				ReportedOn = new DateTime(2024, 2, 25, 10, 30, 50),
			},
			new TrashPin
			{
				Id = 3,
				Name = "Trash Pin 3 High",
				Description = "This is a trash pin",
				Location = new Location(52.57428,-9.10125),
				Image = "image1.jpg",
				Severity = Severity.High,
				ReportedBy = 0,
				ReportedOn = new DateTime(2024, 3, 25, 10, 30, 50),
			},
			new TrashPin
			{
				Id = 4,
				Name = "Trash Pin 4 CleanedWithinWeek",
				Description = "This is a trash pin",
				Location = new Location(52.57465,-9.10040),
				Image = "image1.jpg",
				Severity = Severity.Low,
				ReportedBy = 0,
				ReportedOn = new DateTime(2024, 4, 25, 10, 30, 50),
				CleanedBy = 1,
				CleanedOn = new DateTime(2024, 5, 13, 10, 30, 50),
			},
			new TrashPin
			{
				Id = 5,
				Name = "Trash Pin 5 Cleaned>Week<Month",
				Description = "This is a trash pin",
				Location = new Location(52.57452,-9.09981),
				Image = "image1.jpg",
				Severity = Severity.Low,
				ReportedBy = 0,
				ReportedOn = new DateTime(2024, 5, 1, 10, 30, 50),
			},
			new TrashPin
			{
				Id = 6,
				Name = "Trash Pin 6 Cleaned>Month",
				Description = "This is a trash pin",
				Location = new Location(52.57414,-9.10025),
				Image = "image1.jpg",
				Severity = Severity.Low,
				ReportedBy = 0,
				ReportedOn = new DateTime(2024, 2, 25, 10, 30, 50),
			}
		];
        */

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
