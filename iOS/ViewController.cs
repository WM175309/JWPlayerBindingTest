using System;
using JWPlayer;
using UIKit;

namespace StupidStupidTest.iOS
{
	public partial class ViewController : UIViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			JWConfig config = new JWConfig("http://content.jwplatform.com/videos/f3FPINhF.mp4");
			config.Size = new CoreGraphics.CGSize(100, 100);

			JWPlayerController player = new JWPlayerController(config);

			this.View.AddSubview(player.View);

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}

		public override void ViewWillAppear(bool animated)
		{
		}
	}
}
