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
    [Activity(Label = "MathSelection")]
    public class MathSelection : Activity
    {
        WebView mathview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MathSelection);


            Button Back = FindViewById<Button>(Resource.Id.BackButton);
            Back.Click += delegate
            {
                StartActivity(typeof(CourseSelection));
            };

            mathview = FindViewById<WebView>(Resource.Id.csv);
            mathview.SetWebViewClient(new WebViewClient());

            mathview.Settings.JavaScriptEnabled = true;
            mathview.LoadUrl("https://calendar.google.com/calendar/selfsched?sstoken=UUlaRjBiSHJBNWJIfGRlZmF1bHR8ZGNmNzE1YWQxM2Y4NTRhY2I4ZTJjZjM0N2M3ZGQyNzA");

        }
    }
}