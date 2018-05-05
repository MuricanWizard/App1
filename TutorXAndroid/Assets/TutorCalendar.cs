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
using Android.Webkit;

namespace TutorXAndroid.Assets
{
    [Activity(Label = "TutorCalendar", Theme = "@android:style/Theme.NoTitleBar")]
    public class TutorCalendar : Activity
    {
        WebView tutorCalendar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.TutorCalendar);

            Button Back = FindViewById<Button>(Resource.Id.BackButton);
            Back.Click += delegate
            {
                StartActivity(typeof(MainTutor));
            };

            tutorCalendar = FindViewById<WebView>(Resource.Id.csv);
            tutorCalendar.SetWebViewClient(new WebViewClient());

            tutorCalendar.Settings.JavaScriptEnabled = true;
            tutorCalendar.LoadUrl("https://www.google.com/calendar");

        }
    }
}