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

namespace ImCup.Droid
{
    public static class Constants
    {
        public const string SenderID = "19281040683"; // Google API Project Number
        public const string ListenConnectionString = "Endpoint=sb://dishpushes.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=wSIJtAFB9kVwO6eT/bTO5KU5izkfjTs0lFC7YK0KxiI=";
        public const string NotificationHubName = "dichPush";
    }
}