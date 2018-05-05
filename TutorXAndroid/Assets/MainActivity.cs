using Android.App;
using Android.Widget;
using Android.OS;
using TutorXAndroid.Assets;

namespace TutorXAndroid
{
    [Activity(Label = "TutorXAndroid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button Student = FindViewById<Button>(Resource.Id.Student);
            Student.Click += delegate
            {
                StartActivity(typeof(Activity1));
            };
            Button Tutor = FindViewById<Button>(Resource.Id.Tutor);
            Tutor.Click += delegate
            {
                StartActivity(typeof(MainTutor));
            };
        }
    }
}

