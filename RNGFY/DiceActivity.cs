using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNGFY
{
    [Activity(Label = "Activity1")]
    public class DiceActivity : Activity
    {

        TextView diceValue;
        Button rollBtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.dice_layout);

            diceValue = FindViewById<TextView>(Resource.Id.diceValue);
            rollBtn = FindViewById<Button>(Resource.Id.rollButton);

            rollBtn.Click += rollBtn_Clicked;
        }

        public async void rollBtn_Clicked(object sender, EventArgs e)
        {

            Random random = new Random();

            int dicenumber = random.Next(1, 6);

            diceValue.SetTextSize(Android.Util.ComplexUnitType.Px, 90);
            diceValue.Text = "Rolling...";

            await Task.Delay(TimeSpan.FromSeconds(3));

            diceValue.SetTextSize(Android.Util.ComplexUnitType.Px, 150);
            diceValue.Text = dicenumber.ToString();
        }
    }
}