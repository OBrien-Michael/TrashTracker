using System;
using TrashTracker.Model;
using TrashTracker.Services;
using Xunit;

namespace TrashTrackerTestSuite.Services
{
	public class TrashPinServiceTests
	{
		[Fact]
		public void GetAllTrashPins()
		{
			// Arrange
			var service = new TrashPinService();

			// Act
			var result = service.GetAllTrashPins();

			// Assert
			Assert.Equal(service.TrashPinList,result);
		}

		[Fact]
		public void GetTrashPinsByLowSeverity()
		{
			// Arrange
			var service = new TrashPinService();
			Severity severity = Severity.Low;

			// Act
			var result = service.GetTrashPinsBySeverity(
				severity);

			// Assert
			Assert.Equal(result.First().Severity,Severity.Low);
		}

		[Fact]
		public void AddTrashPin()
		{
			// Arrange
			var service = new TrashPinService();
			var newTrashPin = new TrashPin
			{
				Id = 7,
				Name = "Trash Pin 7",
				Description = "This is a new trash pin",
				Location = new Location(52.57414, -9.10025),
				Image = "image1.jpg",
				Severity = Severity.Low,
				ReportedBy = 0,
				ReportedOn = new DateTime(2024, 2, 25, 10, 30, 50),
			};

			// Act
			service.AddTrashPin(newTrashPin);

			// Assert
			Assert.Contains(newTrashPin, service.TrashPinList);
		}

	}
}
