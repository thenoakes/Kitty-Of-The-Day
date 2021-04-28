using UIKit;
using System;

namespace Hello.ViewControllers
{
    public partial class PopoverVC : UIViewController
    {
        #region Constructors

        public PopoverVC(IntPtr handle) : base(handle) { }

        public PopoverVC() : base("PopoverVC", null) { }

        #endregion 

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Click handler for 'Close' button
            cancelKittyButton.Clicked += (object Sender, EventArgs e) =>
            {
                DismissViewController(true, null);
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}
