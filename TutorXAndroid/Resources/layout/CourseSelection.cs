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

namespace TutorXAndroid.Resources.layout
{
    [Activity(Label = "CourseSelection")]
    public class CourseSelection : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.CourseSelection);
        }
    }
}