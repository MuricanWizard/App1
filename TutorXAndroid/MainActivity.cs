using Android.App;
using Android.Widget;
using Android.OS;

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
        }
    }
}

