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

namespace TutorXAndroid.Resources.layout
{
    [Activity(Label = "SpchSelection", Theme = "@android:style/Theme.NoTitleBar")]
    public class SpchSelection : Activity
    {
        WebView spchview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SpchSelection);


            Button Back = FindViewById<Button>(Resource.Id.BackButton);
            Back.Click += delegate
            {
                StartActivity(typeof(CourseSelection));
            };

            spchview = FindViewById<WebView>(Resource.Id.csv);
            spchview.SetWebViewClient(new WebViewClient());

            spchview.Settings.JavaScriptEnabled = true;
            spchview.LoadUrl("https://calendar.google.com/calendar/selfsched?sstoken=UUlaRjBiSHJBNWJIfGRlZmF1bHR8ZGNmNzE1YWQxM2Y4NTRhY2I4ZTJjZjM0N2M3ZGQyNzA");

        }
    }
}