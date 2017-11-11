namespace UWP
{
	using Zebble;

	partial class App : Zebble.UWP.BaseApplication
	{
		public App()
		{
			UnhandledException += App_UnhandledException;
		}

		void App_UnhandledException(object sender, Windows.UI.Xaml.UnhandledExceptionEventArgs args)
		{
			var error = args.Exception;
		}

		protected override StartUp CreateStartUp() => new UI.StartUp();

		//protected override void SuspendApplicationState()
		//{
		//    // TODO: Saves application state and stop any background activity.
		//}        
	}
}