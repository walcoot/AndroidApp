﻿using System.Threading;
using Android.App;
using Android.OS;

namespace Project
{
    [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
	public class SplashActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			Thread.Sleep(2500); 
			StartActivity(typeof(MainActivity));
		}
	}
}

