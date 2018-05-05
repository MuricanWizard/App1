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

namespace TutorXAndroid.Assets
{
    [Activity(Label = "MainTutor", Theme = "@android:style/Theme.NoTitleBar")]
    public class MainTutor : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.TutorMain);

            Button openCalendar = FindViewById<Button>(Resource.Id.openCalendar);
            openCalendar.Click += delegate
            {
                StartActivity(typeof(TutorCalendar));
            };

            Button signUp = FindViewById<Button>(Resource.Id.signUp);
            signUp.Click += delegate
            {
                StartActivity(typeof(SignUp));
            };
            Button Back = FindViewById<Button>(Resource.Id.BackButton);
            Back.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
        }
    }
}