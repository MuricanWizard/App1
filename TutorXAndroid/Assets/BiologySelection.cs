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
    [Activity(Label = "BiologySelection")]
    public class BiologySelection : Activity
    {
        WebView bv;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.BiologySelection);


            Button Back = FindViewById<Button>(Resource.Id.BackButton);
            Back.Click += delegate
            {
                StartActivity(typeof(CourseSelection));
            };

            bv = FindViewById<WebView>(Resource.Id.csv);
            bv.SetWebViewClient(new WebViewClient());

            bv.Settings.JavaScriptEnabled = true;
            bv.LoadUrl("https://calendar.google.com/calendar/selfsched?sstoken=UUlaRjBiSHJBNWJIfGRlZmF1bHR8ZGNmNzE1YWQxM2Y4NTRhY2I4ZTJjZjM0N2M3ZGQyNzA");

            // Create your application here
        }
    }
}