// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace firstApp
{
	[Register ("firstAppViewController")]
	partial class firstAppViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton firstButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField Password { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField Username { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (firstButton != null) {
				firstButton.Dispose ();
				firstButton = null;
			}
			if (Password != null) {
				Password.Dispose ();
				Password = null;
			}
			if (Username != null) {
				Username.Dispose ();
				Username = null;
			}
		}
	}
}
