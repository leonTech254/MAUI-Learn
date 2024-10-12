using Android.App;
using Android.Content;
using Android.OS;
using System.Threading;
using System.Threading.Tasks;

namespace MauiApp1.Platforms.Android.Services
{
    [Service]
    public class PersistentBackgroundService : Service
    {
        private CancellationTokenSource _cancellationTokenSource;

        public override void OnCreate()
        {
            base.OnCreate();

            // Create a notification channel for Android 8.0 and above
            if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            {
                var channelId = "persistent_service_channel";
                var channelName = "Persistent Background Service";
                var channelDescription = "Channel for persistent background service notifications";
                var channelImportance = NotificationImportance.Default;

                var channel = new NotificationChannel(channelId, channelName, channelImportance)
                {
                    Description = channelDescription
                };

                var notificationManager = (NotificationManager)GetSystemService(NotificationService);
                notificationManager.CreateNotificationChannel(channel);
            }
        }

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            _cancellationTokenSource = new CancellationTokenSource();

            // Start your background task here
            Task.Run(async () => {
                // Wait for 5 minutes (300,000 milliseconds)
                await Task.Delay(300000, _cancellationTokenSource.Token);

                // Send a notification after 5 minutes
                SendNotification("Persistent Background Service", "The service is still running in the background.");

                while (!_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    // Perform your task
                    Thread.Sleep(1000); // Simulate work
                }
            });

            return StartCommandResult.Sticky; // Service will be restarted if it gets killed
        }

        private void SendNotification(string title, string message)
        {
            var notificationManager = (NotificationManager)GetSystemService(NotificationService);

            var notification = new Notification.Builder(this, "persistent_service_channel")
                .SetContentTitle(title)
                .SetContentText(message)
                .SetSmallIcon(Resource.Drawable.ic_call_answer) // Use your app's icon
                //.SetPriority(NotificationPriority.)
                .Build();

            notificationManager.Notify(1, notification); // Unique ID for the notification
        }

        public override void OnDestroy()
        {
            // Clean up any resources if necessary
            _cancellationTokenSource.Cancel();
            base.OnDestroy();
        }

        public override IBinder OnBind(Intent intent)
        {
            // Return null because we do not provide binding
            return null;
        }
    }
}
