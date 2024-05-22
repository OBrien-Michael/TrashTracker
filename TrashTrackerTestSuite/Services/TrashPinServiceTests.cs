using System;
using TrashTracker.Model;
using TrashTracker.Services;
using Xunit;

namespace TrashTrackerTestSuite.Services
{
	public class TrashPinServiceTests
	{
		[Fact]
		public async Task GetAllTrashPins()
		{
			// Arrange
			var service = new TrashPinService();

			// Act
			var result = await service.GetAllTrashPins();

			// Assert
			Assert.IsType<TrashPin>(result.First());
		}

		[Fact]
		public async Task GetTrashPinsByLowSeverity()
		{
			// Arrange
			var service = new TrashPinService();
			Severity severity = Severity.Low;

			// Act
			var result = await service.GetTrashPinsBySeverity(severity);

			// Assert
			Assert.Equal(result.First().Severity, Severity.Low);
		}

		[Fact]
		public async Task AddTrashPin()
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
			await service.AddTrashPin(newTrashPin);

			// Assert
			var allPins = await service.GetAllTrashPins();
			Assert.Contains(allPins, pin => pin.Id == newTrashPin.Id);
		}

	}
}
