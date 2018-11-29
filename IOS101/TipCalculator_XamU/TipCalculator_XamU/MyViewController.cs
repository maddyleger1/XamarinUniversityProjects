using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using CoreGraphics;

namespace TipCalculator_XamU
{
    class MyViewController : UIViewController
    {

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.View.BackgroundColor = UIColor.Purple;

            UITextField totalAmount = new UITextField()
            {
                Frame = new CGRect(20, 28, View.Bounds.Width - 40, 35),
                KeyboardType = UIKeyboardType.DecimalPad,
                BorderStyle = UITextBorderStyle.RoundedRect,
                Placeholder = "Enter Total Amount",
            };

            UIButton calcButton = new UIButton(UIButtonType.Custom)
            {
                Frame = new CGRect(20, 71, View.Bounds.Width - 40, 45),
                BackgroundColor = UIColor.FromRGB(0, 0.5f, 0),
            };
            calcButton.SetTitle("Caulculate", UIControlState.Normal);

            UILabel resultLabel = new UILabel(frame: new CGRect(20, 124, View.Bounds.Width - 40, 40))
            {
                TextColor = UIColor.Blue,
                TextAlignment = UITextAlignment.Center,
                Font = UIFont.SystemFontOfSize(24),
                Text = "Tip is $0.00",
            };

            UIView[] views = { totalAmount, calcButton, resultLabel };
            View.AddSubviews(views);

            calcButton.TouchUpInside += (s, e) =>
            {
                totalAmount.ResignFirstResponder();
                double amt = 0;
                Double.TryParse(totalAmount.Text, out amt);
                resultLabel.Text = string.Format("Tip is {0:C}", amt*.2);
            };
        }
    }
}