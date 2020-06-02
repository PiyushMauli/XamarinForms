using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Media;
using Android.Support.V4.App;
using PushNotifications.Droid;
using Xamarin.Forms;

[assembly:Dependency(typeof(NotifiationHelper))]
namespace PushNotifications.Droid
{
    class NotifiationHelper : INotification
    {
        private Context mContext;
        private NotificationManager mNotificationManager;
        private NotificationCompat.Builder mBuilder;
        public static String NOTIFICATION_CHANNEL_ID = "10023";

        public NotifiationHelper()
        {
            mContext = global::Android.App.Application.Context;
        }

        public void CreateNotification(string title, string message)
        {
            try
            {
                
                mBuilder = new NotificationCompat.Builder(mContext);
                mBuilder.SetContentTitle(title)
                    .SetAutoCancel(true).
                    SetContentTitle(title).
                    SetContentText(message).
                    SetChannelId(NOTIFICATION_CHANNEL_ID).
                    SetPriority((int)NotificationPriority.High).
                    SetVibrate(new long[0]).
                    SetVisibility((int)NotificationVisibility.Public).
                    SetSmallIcon(Resource.Drawable.icon);

                NotificationManager notificationManager = mContext.GetSystemService(Context.NotificationService) as NotificationManager;

                if (global::Android.OS.Build.VERSION.SdkInt >= global::Android.OS.BuildVersionCodes.O)
                {
                    NotificationImportance importance = global::Android.App.NotificationImportance.High;

                    NotificationChannel notificationChannel = new NotificationChannel(NOTIFICATION_CHANNEL_ID, title, importance);
                    notificationChannel.EnableLights(true);
                    notificationChannel.EnableVibration(true);
                    notificationChannel.SetShowBadge(true);
                    notificationChannel.Importance = NotificationImportance.High;
                    notificationChannel.SetVibrationPattern(new long[] { 100, 200, 300 });
                    if (notificationManager != null)
                    {
                        mBuilder.SetChannelId(NOTIFICATION_CHANNEL_ID);
                        notificationManager.CreateNotificationChannel(notificationChannel);
                    }
                }
                notificationManager.Notify(0, mBuilder.Build());
            }
            catch(Exception e)
            {
                //
            }
        }


    }
}