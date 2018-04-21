﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TutorXAndroid.Resources.layout
{
    [Activity(Label = "TravisSelection")]
    public class TravisSelection : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.TravisSelection);


            Button Back = FindViewById<Button>(Resource.Id.BackButton);
            Back.Click += delegate
            {
                StartActivity(typeof(CourseSelection));
            };
        }
    }
}