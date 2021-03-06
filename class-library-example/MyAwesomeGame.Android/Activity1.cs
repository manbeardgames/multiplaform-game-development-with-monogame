using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using MyAwesomeGame.Shared;

namespace MyAwesomeGame.Android
{
    [Activity(Label = "MyAwesomeGame.Android"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , AlwaysRetainTaskState = true
        , LaunchMode = LaunchMode.SingleInstance
        , ScreenOrientation = ScreenOrientation.FullUser
        , ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize | ConfigChanges.ScreenLayout)]
    public class Activity1 : Microsoft.Xna.Framework.AndroidGameActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var g = new Game1(Platforms.Android);
            SetContentView((View)g.Services.GetService(typeof(View)));
            g.Run();
        }
    }
}

