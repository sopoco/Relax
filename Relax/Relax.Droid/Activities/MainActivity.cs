using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Platform;
using Android.Content.PM;
using MvvmCross.Droid.Support.V7.AppCompat;
using Relax.Core.ViewModels;

namespace Relax.Activities
{
    [Activity(
        Label = "Relax",
        //Theme = "@style/AppTheme",
        LaunchMode = LaunchMode.SingleInstance,
        Name = "relax.droid.activities.MainActivity",
        ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.KeyboardHidden,
        ScreenOrientation = ScreenOrientation.Portrait,
        WindowSoftInputMode = SoftInput.AdjustResize | SoftInput.StateHidden
    )]
    class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
    {
        #region Android Lifecycle

        protected override void OnCreate(Bundle bundle)
        {
            Mvx.Trace("MainActivity.OnCreate()");
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            if (bundle == null)
                ViewModel.ShowMenu();
        }

        //protected override void OnStart()
        //{
        //    Mvx.Trace("MainActivity.OnStart()");
        //    base.OnStart();
        //}
        //protected override void OnResume()
        //{
        //    Mvx.Trace("MainActivity.OnResume()");
        //    base.OnResume();
        //}
        //protected override void OnPause()
        //{
        //    Mvx.Trace("MainActivity.OnPause()");
        //    base.OnPause();
        //}
        //protected override void OnStop()
        //{
        //    Mvx.Trace("MainActivity.OnStop()");
        //    base.OnStop();
        //}
        //protected override void OnRestart()
        //{
        //    Mvx.Trace("MainActivity.OnRestart()");
        //    base.OnRestart();
        //}
        //protected override void OnDestroy()
        //{
        //    Mvx.Trace("MainActivity.OnDestroy()");
        //    base.OnDestroy();
        //}
        #endregion



        //public override void OnBeforeFragmentChanging(IMvxCachedFragmentInfo fragmentInfo,
        //    Android.Support.V4.App.FragmentTransaction transaction) //activar animaciones al pasar de un fragment a otro
        //{
        //    transaction.SetCustomAnimations(Resource.Animation.slide_in, Resource.Animation.slide_out, Resource.Animation.slide_in, Resource.Animation.slide_out);

        //    base.OnBeforeFragmentChanging(fragmentInfo, transaction);
        //}
    }
}