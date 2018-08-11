using Android.App;
using Android.OS;

namespace TGXFExampleApp.Droid
{
    [Activity(Label = "TGXF Example App", 
              Icon = "@mipmap/icon", 
              Theme = "@style/MainTheme") 
              ]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

