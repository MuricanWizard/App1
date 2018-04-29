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
using Xamarin.Forms;

namespace TutorXAndroid.Resources.layout
{
    [Activity(Label = "CsSelection")]
    public class CsSelection : Activity
    {
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

            var browser = new WebView
            {
                Source = "http://xamarin.com"
            };
        }
    }
}