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
    [Activity(Label = "PsySelection", Theme = "@android:style/Theme.NoTitleBar")]
    public class PsySelection : Activity
    {
        WebView psyview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.PsySelection);


            Button Back = FindViewById<Button>(Resource.Id.BackButton);
            Back.Click += delegate
            {
                StartActivity(typeof(CourseSelection));
            };

            psyview = FindViewById<WebView>(Resource.Id.csv);
            psyview.SetWebViewClient(new WebViewClient());

            
            psyview.Settings.JavaScriptEnabled = true;
            psyview.LoadUrl("https://calendar.google.com/calendar/selfsched?sstoken=UUlaRjBiSHJBNWJIfGRlZmF1bHR8ZGNmNzE1YWQxM2Y4NTRhY2I4ZTJjZjM0N2M3ZGQyNzA");

        }
    }
}