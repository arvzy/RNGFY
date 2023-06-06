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
    public class RNGActivity : Activity
    {
        EditText input1, input2;
        TextView genNum;
        Button genBtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.randomnumber_layout);

            input1 = FindViewById<EditText>(Resource.Id.inputNum1);
            input2 = FindViewById<EditText>(Resource.Id.inputNum2);

            genNum = FindViewById<TextView>(Resource.Id.generatedNumber);

            genBtn = FindViewById<Button>(Resource.Id.genButton);

            genBtn.Click += generateNumber_Clicked;
        }

        public async void generateNumber_Clicked(object sender, EventArgs e)
        {
            if (input1.Text == "" || input2.Text == "")
            {
                Toast.MakeText(this, "Pick a range of numbers first!", ToastLength.Long).Show();
            }
            else
            {
                Random random = new Random();

                int range1 = int.Parse(input1.Text);
                int range2 = int.Parse(input2.Text);

                int rgn = random.Next(range1, range2 + 1);

                genNum.Text = "Generating...";

                await Task.Delay(TimeSpan.FromSeconds(1));

                genNum.Text = rgn.ToString();
            }
        }
    }
}