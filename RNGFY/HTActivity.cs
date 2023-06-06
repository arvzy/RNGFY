using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Random = System.Random;

namespace RNGFY
{
    [Activity(Label = "Activity1")]
    public class HTActivity : Activity
    {
        string[] HTArray = { "Heads", "Tails" };
        TextView outcomeView;
        Button flipBtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.headsortails_layout);

            flipBtn = FindViewById<Button>(Resource.Id.flipButton);
            outcomeView = FindViewById<TextView>(Resource.Id.theOutcome);

            flipBtn.Click += flipBtn_Clicked;
        }
        
        public async void flipBtn_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();

            int randomArrayVal = random.Next(HTArray.Length);

            string outcome = HTArray[randomArrayVal];

            outcomeView.Text = "Flipping...";
            outcomeView.SetTextSize(Android.Util.ComplexUnitType.Px, 90);

            await Task.Delay(TimeSpan.FromSeconds(3));


            outcomeView.SetTextSize(Android.Util.ComplexUnitType.Px, 150);
            outcomeView.Text = outcome;
        }
    }
}