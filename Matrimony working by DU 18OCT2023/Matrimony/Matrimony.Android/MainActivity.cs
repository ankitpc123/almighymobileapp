using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Acr.UserDialogs;
using FFImageLoading.Forms.Platform;
using FFImageLoading;
using FFImageLoading.Svg.Forms;
using CarouselView.FormsPlugin.Android;
using Android.Gms.Common;
using Xamarin.Essentials;
using PanCardView.Droid;

namespace Matrimony.Droid
{
    [Activity(Label = "Matrimony", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        const string TAG = "MainActivity";

        internal static readonly string CHANNEL_ID = "my_notification_channel";
        internal static readonly int NOTIFICATION_ID = 100;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            

            UserDialogs.Init(this);
            var config = new FFImageLoading.Config.Configuration()
            {

                VerboseLogging = false,

                VerbosePerformanceLogging = false,

                VerboseMemoryCacheLogging = false,

                VerboseLoadingCancelledLogging = false,

                Logger = new CustomLogger(),

            };

            ImageService.Instance.Initialize(config);

            Rg.Plugins.Popup.Popup.Init(this);//popup
            Xamarin.FormsMaps.Init(this, savedInstanceState);
            global::Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            CarouselViewRenderer.Init();

           

            CardsViewRenderer.Preserve();

            CachedImageRenderer.Init(true);

            CachedImageRenderer.InitImageViewHandler();

            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(true);
            var ignore = typeof(SvgCachedImage);

            LoadApplication(new App());

            CreateNotificationChannel();

            IsPlayServicesAvailable();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public override void OnBackPressed()
        {
            if (Rg.Plugins.Popup.Popup.SendBackPressed(base.OnBackPressed))
            {
                // Do something if there are some pages in the `PopupStack`
            }
            else
            {
                // Do something if there are not any pages in the `PopupStack`
            }
        }

        public bool IsPlayServicesAvailable()
        {
            string msgText;

            var resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
            if (resultCode != ConnectionResult.Success)
            {  if (GoogleApiAvailability.Instance.IsUserResolvableError(resultCode))
                {
                    msgText = GoogleApiAvailability.Instance.GetErrorString(resultCode);
                }
                else
                {
                    msgText = "This device is not supported";
                    Finish();
                }

                return false;
            }

            msgText = "Google Play Services is available.";
            return true;
        }


        void CreateNotificationChannel()
        {
            if (Build.VERSION.SdkInt < BuildVersionCodes.O)
            {
                // Notification channels are new in API 26 (and not a part of the
                // support library). There is no need to create a notification 
                // channel on older versions of Android.
                return;
            }

            var channel = new NotificationChannel(CHANNEL_ID, "FCM Notifications", NotificationImportance.Default)
            {
                Description = "Firebase Cloud Messages appear in this channel"
            };

            var notificationManager = (NotificationManager)GetSystemService(NotificationService);
            notificationManager.CreateNotificationChannel(channel);
        }
    }

    public class CustomLogger : FFImageLoading.Helpers.IMiniLogger
    {
        public void Debug(string message)
        {
            Console.WriteLine(message);
        }

        public void Error(string errorMessage)

        {

            Console.WriteLine(errorMessage);

        }



        public void Error(string errorMessage, Exception ex)

        {

            Error(errorMessage + System.Environment.NewLine + ex.ToString());

        }

    }
}