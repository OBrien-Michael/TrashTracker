using System;
using TrashTracker.Services;
using Xunit;

namespace TrashTrackerTestSuite.Services
{
	public class TrashPinServiceTests
	{
		[Fact]
		public void GetAllTrashPins_ExpectListsToBeEqual()
		{
			// Arrange
			var service = new TrashPinService();

			// Act
			var result = service.GetAllTrashPins();

			// Assert
			Assert.Equal(service.TrashPinList,result);
		}
	}
}
