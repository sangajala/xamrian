using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace firstApp
{
	public partial class firstAppViewController : UIViewController
	{
		public firstAppViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			firstButton.TouchUpInside += (object sender, EventArgs e) => { 

				if(Username.Text=="Aditya")
				{
					if(Password.Text=="Sharada")
					{
						var message = new UIAlertView();
						UIAlertView _error = new UIAlertView ("Success!", "You are a valid user", null, "Ok", null);

						_error.Show ();
					}
				}
				else
				{
					var message = new UIAlertView();
					UIAlertView _error = new UIAlertView ("Error", "Aditya dont know who is "+Password.Text, null, "Ok", null);

					_error.Show ();
				}
//				message.Title = "Are you sure?";
//				message.Message = "You cannot login";
//				message.Show();

			};
		
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

