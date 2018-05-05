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
    [Activity(Label = "SignUp")]
    public class SignUp : Activity
    {
        WebView signUp;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SignUp);

            Button Back = FindViewById<Button>(Resource.Id.BackButton);
            Back.Click += delegate
            {
                StartActivity(typeof(MainTutor));
            };

            signUp = FindViewById<WebView>(Resource.Id.csv);
            signUp.SetWebViewClient(new WebViewClient());

            signUp.Settings.JavaScriptEnabled = true;
            signUp.LoadUrl("https://goo.gl/forms/nGaHKJp5TwzxwD483");

        }
    }
}