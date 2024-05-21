using System;
using TrashTracker.Services;
using TrashTracker.ViewModel;
using Xunit;

namespace TrashTrackerTestSuite.ViewModel
{
	public class MapPageViewModelTests
	{
		[Fact]
		public void LoadPins_ExpectPinsToBeLoaded()
		{
			// Arrange

			TrashPinService trashPinService = new TrashPinService();

			var viewModel = new MapPageViewModel(trashPinService);

			// Act
			viewModel.LoadPins();

			// Assert
			Assert.NotNull(viewModel.TrashPins);
		}
	}
}
