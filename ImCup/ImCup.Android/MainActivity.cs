﻿using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using FFImageLoading.Forms;
using FFImageLoading.Forms.Droid;
using Microsoft.Azure.Engagement;
using Microsoft.Azure.Engagement.Xamarin;
using Microsoft.Azure.Engagement.Xamarin.Activity;
using Android.Util;
using Gcm.Client;
using Plugin.Permissions;
using Microsoft.WindowsAzure.MobileServices;
[assembly: UsesFeature("android.hardware.camera", Required = false)]
[assembly: UsesFeature("android.hardware.camera.autofocus", Required = false)]
namespace ImCup.Droid {
    [Activity (Label = "@string/app_name", Theme = "@style/MyTheme", MainLauncher = true, ScreenOrientation = ScreenOrientation.ReverseLandscape)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity  {
        public static MainActivity instance;
        protected override void OnCreate( Bundle bundle ) {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            instance = this;

            base.OnCreate (bundle);

            // Initialization for Azure Mobile Apps
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
            // This MobileServiceClient has been configured to communicate with the Azure Mobile App and
            // Azure Gateway using the application url. You're all set to start working with your Mobile App!
            



            global::Xamarin.Forms.Forms.Init (this, bundle);

            //RequestWindowFeature (WindowFeatures.NoTitle);
            //Window.SetFlags (WindowManagerFlags.Fullscreen, WindowManagerFlags.Fullscreen);

            CachedImageRenderer.Init ();
            LoadApplication (new App ());
            EngagementConfiguration engagementConfiguration = new EngagementConfiguration ();
            engagementConfiguration.ConnectionString = "Endpoint=imcup.device.mobileengagement.windows.net;SdkKey=f55890b27cd5a2afcb0c46478fe31eb5;AppId=nei000342";
            EngagementAgent.Init (engagementConfiguration);
            EngagementAgent.SendEvent("Happy");

            RegisterWithGCM();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        protected override void OnResume() {
            EngagementAgent.StartActivity (EngagementAgentUtils.BuildEngagementActivityName (Java.Lang.Class.FromType (this.GetType ())), null);
            base.OnResume ();
        }
        private void RegisterWithGCM()
        {
            // Check to ensure everything's set up right
            GcmClient.CheckDevice(this);
            GcmClient.CheckManifest(this);

            // Register for push notifications
            Log.Info("MainActivity", "Registering...");
            GcmClient.Register(this, Constants.SenderID);
        }
        protected override void OnPause() {
            EngagementAgent.EndActivity ();
            base.OnPause ();
        }
    }
}