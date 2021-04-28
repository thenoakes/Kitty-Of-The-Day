// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Hello.ViewControllers
{
    [Register ("RootVC")]
    partial class RootVC
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton rootViewButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel rootViewInfoText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UINavigationItem rootViewNavbar { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (rootViewButton != null) {
                rootViewButton.Dispose ();
                rootViewButton = null;
            }

            if (rootViewInfoText != null) {
                rootViewInfoText.Dispose ();
                rootViewInfoText = null;
            }

            if (rootViewNavbar != null) {
                rootViewNavbar.Dispose ();
                rootViewNavbar = null;
            }
        }
    }
}