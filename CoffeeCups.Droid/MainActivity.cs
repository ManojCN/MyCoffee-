using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Microsoft.Azure.Mobile;

namespace CoffeeCups.Droid
{
	[Activity (Label = "CoffeeCups", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{ 

            ToolbarResource = Resource.Layout.toolbar;
            TabLayoutResource = Resource.Layout.tabs;

            base.OnCreate (bundle);
			global::Xamarin.Forms.Forms.Init (this, bundle);

            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();

#if ENABLE_TEST_CLOUD
            //Mapping StyleID to element content descriptions
            Xamarin.Forms.Forms.ViewInitialized += (object sender, Xamarin.Forms.ViewInitializedEventArgs e) => {
            if (!string.IsNullOrWhiteSpace(e.View.StyleId)) {
            e.NativeView.ContentDescription = e.View.StyleId;
            }
            };
#endif
            MobileCenter.Configure("1d43bce7-b21b-4128-91c8-e50153b99e35");
            LoadApplication (new App ());
		}
	}
}
