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
	}
}
