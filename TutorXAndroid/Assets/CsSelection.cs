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
//using Xamarin.Forms;
using Android.Webkit;

namespace TutorXAndroid.Resources.layout
{
    [Activity(Label = "CsSelection", Theme ="@android:style/Theme.NoTitleBar")]
    public class CsSelection : Activity
    {
        WebView csv;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.CsSelection);


            Android.Widget.Button Back = FindViewById<Android.Widget.Button>(Resource.Id.BackButton);
            Back.Click += delegate
            {
                StartActivity(typeof(CourseSelection));
            };

            csv = FindViewById<WebView>(Resource.Id.csv);
            csv.SetWebViewClient(new WebViewClient());
        }
    }
}