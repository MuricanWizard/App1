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
    [Activity(Label = "ChemistrySelection")]
    public class ChemistrySelection : Activity
    {
        WebView chemview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ChemistrySelection);


            Button Back = FindViewById<Button>(Resource.Id.BackButton);
            Back.Click += delegate
            {
                StartActivity(typeof(CourseSelection));
            };

            chemview = FindViewById<WebView>(Resource.Id.csv);
            chemview.SetWebViewClient(new WebViewClient());

            chemview.Settings.JavaScriptEnabled = true;
            chemview.LoadUrl("https://calendar.google.com/calendar/selfsched?sstoken=UUlaRjBiSHJBNWJIfGRlZmF1bHR8ZGNmNzE1YWQxM2Y4NTRhY2I4ZTJjZjM0N2M3ZGQyNzA");

        }
    }
}