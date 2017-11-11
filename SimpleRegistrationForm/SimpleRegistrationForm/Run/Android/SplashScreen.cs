using Android.App;
using Android.OS;

namespace Android
{
	[Activity(Label = "Application",
		MainLauncher = true,
		NoHistory = true,
		Theme = "@style/Theme.Splash",
		Icon = "@drawable/icon")]
	public class SplashScreen : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			StartActivity(typeof(MainActivity));
		}
	}
}