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
using TutorXAndroid.Resources.layout;

namespace TutorXAndroid
{
    [Activity(Label = "Activity1", Theme = "@android:style/Theme.NoTitleBar")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource

            SetContentView(Resource.Layout.Activity1);
            Button ChooseAppointment = FindViewById<Button>(Resource.Id.ChooseAppointment);
            ChooseAppointment.Click += delegate
            {
                StartActivity(typeof(CourseSelection));
            };
            Button Back = FindViewById<Button>(Resource.Id.BackButton);
            Back.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
        }
    }
}