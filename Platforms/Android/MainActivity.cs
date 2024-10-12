using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using MauiApp1.Platforms.Android.Services;

namespace MauiApp1
{
    [Activity(Theme = "@style/Maui.SplashTheme",
              MainLauncher = true,
              LaunchMode = LaunchMode.SingleTop,
              ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create a foreground notification channel (for Android 8.0+)
            if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            {
                CreateNotificationChannel();
            }

            // Start the persistent background service when the app starts
            var intent = new Intent(this, typeof(PersistentBackgroundService));
            StartForegroundService(intent);  // For Android 8.0+ devices
        }

        private void CreateNotificationChannel()
        {
            var channelName = "Foreground Service Channel";
            var channelId = "foregroundServiceChannel";

            NotificationChannel channel = new NotificationChannel(channelId, channelName, NotificationImportance.Default)
            {
                Description = "Channel for the persistent background service"
            };

            var notificationManager = (NotificationManager)GetSystemService(NotificationService);
            notificationManager.CreateNotificationChannel(channel);
        }
    }
}
