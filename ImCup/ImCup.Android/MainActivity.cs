using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace ImCup.Droid {
    [Activity (Label = "@string/app_name", Theme = "@style/MyTheme", MainLauncher = true, ScreenOrientation = ScreenOrientation.Landscape)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity {
        protected override void OnCreate( Bundle bundle ) {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            

            base.OnCreate (bundle);

            global::Xamarin.Forms.Forms.Init (this, bundle);

            //RequestWindowFeature (WindowFeatures.NoTitle);
            //Window.SetFlags (WindowManagerFlags.Fullscreen, WindowManagerFlags.Fullscreen);

            LoadApplication (new App ());
        }
    }
}