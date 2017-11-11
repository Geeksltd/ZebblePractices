namespace Android
{
	using System;
	using Android.App;
	using Android.Widget;
	using Android.OS;
	using Zebble.AndroidOS;
	using Zebble;
	using Content.PM;

	[Activity(Label = "Android", Icon = "@drawable/icon",
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
		ScreenOrientation = ScreenOrientation.Portrait,
		WindowSoftInputMode = Views.SoftInput.AdjustPan
		)]
	public class MainActivity : BaseActivity
	{
		static MainActivity()
		{
			UIRuntime.GetEntryAssembly = () => typeof(MainActivity).Assembly;
		}

		protected override async void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.Main);

			Setup.Start(FindViewById<FrameLayout>(Resource.Id.Main_Layout), this).RunInParallel();

			await (StartUp.Current = new UI.StartUp()).Run();
		}
	}
}
