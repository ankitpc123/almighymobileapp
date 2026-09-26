using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Media;
using Android.Support.V4.App;
using Firebase.Messaging;

using Matrimony.Droid;

namespace FirebaseMessagingQuickstart
{
    [Service(Exported = true)]
    [IntentFilter (new [] { "com.google.firebase.MESSAGING_EVENT" })]
    public class MyFirebaseMessagingService : FirebaseMessagingService
    {
        const string TAG = "MyFirebaseMsgService";

        /**
         * Called when message is received.
         */

        // [START receive_message]
        public override void OnMessageReceived (RemoteMessage message)
        {
            // TODO(developer): Handle FCM messages here.
            // If the application is in the foreground handle both data and notification messages here.
            // Also if you intend on generating your own notifications as a result of a received FCM
            // message, here is where that should be initiated. See sendNotification method below.
            Android.Util.Log.Debug (TAG, "From: " + message.From);
            Android.Util.Log.Debug (TAG, "Notification Message Body: " + message.GetNotification ().Body);
            SendNotification("", message.Data);
        }

        void SendNotification(string messageBody, IDictionary<string, string> data)
        {
            var intent = new Intent(this, typeof(MainActivity));
            intent.AddFlags(ActivityFlags.ClearTop);
            foreach (var key in data.Keys)
            {
                intent.PutExtra(key, data[key]);
            }

            var pendingIntent = PendingIntent.GetActivity(this, MainActivity.NOTIFICATION_ID, intent, PendingIntentFlags.OneShot);

            //var notificationBuilder = new NotificationCompat.Builder(this, MainActivity.CHANNEL_ID)
            //                          .SetSmallIcon(Resource.Drawable.appicons)
            //                          .SetContentTitle("Jain Service")
            //                          .SetContentText("First Notification")
            //                          .SetAutoCancel(true)
            //                          .SetContentIntent(pendingIntent);

            var notificationBuilder = new NotificationCompat.Builder(this)
                                      .SetSmallIcon(Resource.Drawable.appicons)
                                      .SetContentTitle("Jain Service")
                                      .SetContentText("First Notification")
                                      .SetAutoCancel(true)
                                      .SetContentIntent(pendingIntent);

            var notificationManager = NotificationManagerCompat.From(this);
            notificationManager.Notify(MainActivity.NOTIFICATION_ID, notificationBuilder.Build());
        }


    }

}

