using System;

public class Application
{
	// This is the main entry point of the application.
	static void Main(string[] args)
	{
		try
		{
			UIKit.UIApplication.Main(args, null, typeof(IOS.AppDelegate));
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToLogString());
		}
	}
}