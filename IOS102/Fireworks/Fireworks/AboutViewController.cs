using Foundation;
using System;
using UIKit;

namespace Fireworks
{
    public partial class AboutViewController : UIViewController
    {
        partial void ButtonClose_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        public AboutViewController (IntPtr handle) : base (handle)
        {
        }
    }
}