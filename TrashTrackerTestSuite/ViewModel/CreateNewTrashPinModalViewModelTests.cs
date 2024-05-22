using System;
using System.Diagnostics;
using TrashTracker.Model;
using TrashTracker.Services;
using TrashTracker.ViewModel;
using Xunit;

namespace TrashTrackerTestSuite.ViewModel
{
	public class CreateNewTrashPinModalViewModelTests
	{
		/*
		[Fact]
		public void CreateTrashPin()
		{
			// Arrange
			var testTrashPinService = new TrashPinService();
			var viewModel = new CreateNewTrashPinModalViewModel(testTrashPinService);
			viewModel.Name = "Test Pin";
			viewModel.Description = "Test Description";
			viewModel.Location = new Location(52.57414, -9.10025);
			viewModel.Severity = "Low";

			// Act
			viewModel.CreateTrashPin();

			// Assert
			Assert.Equal("Test Pin", testTrashPinService.TrashPinList.Last().Name);
			Assert.Equal("Test Description", testTrashPinService.TrashPinList.Last().Description);
			Assert.Equal(new Location(52.57414, -9.10025), testTrashPinService.TrashPinList.Last().Location);
			Assert.Equal(Severity.Low, testTrashPinService.TrashPinList.Last().Severity);
		}
		*/

	}
}
