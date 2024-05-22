using TrashTracker.View;

namespace TrashTracker
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();
            Routing.RegisterRoute(nameof(TrashPinModalView), typeof(TrashPinModalView));
            Routing.RegisterRoute(nameof(CreateNewTrashPinModalView), typeof(CreateNewTrashPinModalView));
        }
	}
}
