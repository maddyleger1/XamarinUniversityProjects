using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

namespace TipCalculator_Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            outputTip = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotal = FindViewById<TextView>(Resource.Id.outputTotal);

            calculateButton.Click += OnCalculateClick;
        }

        void OnCalculateClick(object sender, EventArgs e)
        {
            var tip = double.Parse(inputBill.Text) * .15;
            outputTip.Text = tip.ToString();
            outputTotal.Text = (double.Parse(inputBill.Text) + tip).ToString();

        }

        EditText inputBill;
        Button calculateButton;
        TextView outputTip;
        TextView outputTotal;
    }
}

