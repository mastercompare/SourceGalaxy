using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;

namespace WeatherApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new WeatherApp.MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            AppCenter.Start("ios=8d77dbe3-f274-4c77-803d-4aa879f0a316;" + "uwp=761a9c1b-b3e5-40b3-a776-0426ada0f0a9;" +
                   "android=2a0ef0d5-ec86-4aa0-bcc6-1fbd3ac1362b;",typeof(Analytics), typeof(Crashes));

        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
