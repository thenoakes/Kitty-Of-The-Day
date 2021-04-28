using UIKit;
using System;
using Foundation;
using ObjCRuntime;

namespace Hello.ViewControllers
{
    public partial class StackVC : UIViewController
    {
        private NSTimer timer;
        private int timeRemaining = 4;
        private Selector timeSelector = new Selector("updateTime");

        /// <summary>
        /// Runs the updateTime() method every second to count down to the segue
        /// </summary>
        private void countdownToSegue()
        {
            timer = NSTimer.CreateScheduledTimer(1, this, timeSelector, null, true);
        }

        /// <summary>
        /// Cancels the timer and segues to the kitty popover
        /// </summary>
        private void doSegue()
        {
            timer.Invalidate();
            PerformSegue("popoverSegue", this);
        }

        /// <summary>
        /// Reduces the countdown timer by one until it hits zero, then perform segue
        /// </summary>
        [Export("updateTime")]
        private void updateTime()
        {
            stackViewCountdown.Text = timeRemaining.ToString();

            if (timeRemaining != 0)
            {
                timeRemaining -= 1;
            }
            else
            {
                doSegue();
            }
        }

        #region Constructors

        public StackVC(IntPtr handle) : base(handle) { }

        public StackVC() : base("StackVC", null) { }

        #endregion

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // View setup
            stackViewNavbar.Title = "Stack View";
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            // Reset the time
            stackViewCountdown.Text = "5";
            timeRemaining = 4;
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            // Start the countdown
            countdownToSegue();
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            // Cancel the countdown
            timer.Invalidate();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}

