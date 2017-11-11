namespace IOS
{
	using System.Threading.Tasks;
	using Foundation;
	using Zebble;

	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
	public partial class AppDelegate : Zebble.IOS.BaseAppDelegate
	{
		readonly MainScreen Screen = new MainScreen();

		protected override async Task Initialize()
		{
			var window = new Zebble.IOS.PrimaryWindow(Screen);
			await window.Configure();
			Window = window;

			await (StartUp.Current = new UI.StartUp()).Run();

			InitializeComponents();

			IsReady = true;
		}
	}
}