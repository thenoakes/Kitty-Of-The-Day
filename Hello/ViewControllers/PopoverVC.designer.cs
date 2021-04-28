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
    [Register ("PopoverVC")]
    partial class PopoverVC
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem cancelKittyButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (cancelKittyButton != null) {
                cancelKittyButton.Dispose ();
                cancelKittyButton = null;
            }
        }
    }
}