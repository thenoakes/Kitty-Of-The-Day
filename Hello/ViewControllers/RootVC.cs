using UIKit;
using System;
using Foundation;

namespace Hello.ViewControllers
{
    public partial class RootVC : UIViewController
    {
        #region Constructors

        public RootVC(IntPtr handle) : base(handle) { }

        public RootVC() : base("RootVC", null) { }

        #endregion

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // View setup
            rootViewNavbar.Title = "Kitty of the Day";
            rootViewInfoText.Lines = 0;

            // Click handler for 'Kitty of the Day' button
            rootViewButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                PerformSegue("defaultRootViewSegue", sender as NSObject);
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}

