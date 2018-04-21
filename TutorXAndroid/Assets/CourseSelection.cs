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
            Button Csci = FindViewById<Button>(Resource.Id.Csci);
            Csci.Click += delegate
            {
                StartActivity(typeof(CsSelection));
            };
            Button Math = FindViewById<Button>(Resource.Id.Math);
            Math.Click += delegate
            {
                StartActivity(typeof(MathSelection));
            };
            Button Biology = FindViewById<Button>(Resource.Id.Biology);
            Biology.Click += delegate
            {
                StartActivity(typeof(BiologySelection));
            };
            Button Writing = FindViewById<Button>(Resource.Id.Writing);
            Writing.Click += delegate
            {
                StartActivity(typeof(WritingSelection));
            };
            Button Chemistry = FindViewById<Button>(Resource.Id.Chemistry);
            Chemistry.Click += delegate
            {
                StartActivity(typeof(ChemistrySelection));
            };
            Button Physics = FindViewById<Button>(Resource.Id.Physics);
            Physics.Click += delegate
            {
                StartActivity(typeof(PhysicsSelection));
            };
            Button Psy = FindViewById<Button>(Resource.Id.Psy);
            Psy.Click += delegate
            {
                StartActivity(typeof(PsySelection));
            };
            Button Engr = FindViewById<Button>(Resource.Id.Engr);
            Engr.Click += delegate
            {
                StartActivity(typeof(EngrSelection));
            };
            Button Lit = FindViewById<Button>(Resource.Id.Lit);
            Lit.Click += delegate
            {
                StartActivity(typeof(LitSelection));
            };
            Button Spch = FindViewById<Button>(Resource.Id.Spch);
            Spch.Click += delegate
            {
                StartActivity(typeof(SpchSelection));
            };
            Button Travis = FindViewById<Button>(Resource.Id.Travis);
            Travis.Click += delegate
            {
                StartActivity(typeof(TravisSelection));
            };
            Button Back = FindViewById<Button>(Resource.Id.BackButton);
            Back.Click += delegate
            {
                StartActivity(typeof(Activity1));
            };
        }
    }
}