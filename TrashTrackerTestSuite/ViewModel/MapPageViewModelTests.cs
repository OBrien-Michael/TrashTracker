using System;
using TrashTracker.Model;
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

			// Act
			var viewModel = new MapPageViewModel(trashPinService);

			// Assert
			Assert.Equal(viewModel.TrashPins.Count,trashPinService.TrashPinList.Count);
		}

		[Fact]
		public void ShowLowSeverityPins()
		{
			// Arrange
			TrashPinService trashPinService = new TrashPinService();

			var viewModel = new MapPageViewModel(trashPinService);

			// Act
			viewModel.ShowLowSeverityPins();

			// Assert
			Assert.All(viewModel.TrashPins, trashPin => Assert.Equal(Severity.Low, trashPin.Severity));
		}

		[Fact]
		public void ShowMediumSeverityPins()
		{
			// Arrange
			TrashPinService trashPinService = new TrashPinService();

			var viewModel = new MapPageViewModel(trashPinService);

			// Act
			viewModel.ShowMediumSeverityPins();

			// Assert
			Assert.All(viewModel.TrashPins, trashPin => Assert.Equal(Severity.Medium, trashPin.Severity));
		}

		[Fact]
		public void ShowHighSeverityPins()
		{
			// Arrange
			TrashPinService trashPinService = new TrashPinService();

			var viewModel = new MapPageViewModel(trashPinService);

			// Act
			viewModel.ShowHighSeverityPins();

			// Assert
			Assert.All(viewModel.TrashPins, trashPin => Assert.Equal(Severity.High, trashPin.Severity));
		}

		[Fact]
		public void ShowAllPins()
		{
			// Arrange
			TrashPinService trashPinService = new TrashPinService();

			var viewModel = new MapPageViewModel(trashPinService);

			// Act
			viewModel.ShowAllPins();

			// Assert
			Assert.Equal(viewModel.TrashPins, trashPinService.TrashPinList);
		}
	}
}
