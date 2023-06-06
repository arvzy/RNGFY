using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace RNGFY
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button diceBtn = FindViewById<Button>(Resource.Id.buttonDice);
            Button htBtn = FindViewById<Button>(Resource.Id.buttonHT);
            Button rngBtn = FindViewById<Button>(Resource.Id.buttonRN);

            diceBtn.Click += (s, e) =>
            {
                Intent intent = new Intent(this, typeof(DiceActivity));
                StartActivity(intent);
            };

            htBtn.Click += (s, e) => 
            {
                Intent intent = new Intent(this, typeof(HTActivity));
                StartActivity(intent);
            };

            rngBtn.Click += (s, e) =>
            {
               Intent intent = new Intent(this, typeof(RNGActivity));
               StartActivity(intent);
            };
        }
    }
}