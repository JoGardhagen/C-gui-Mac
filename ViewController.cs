using System;

using AppKit;
using Foundation;

namespace myApp
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
        partial void clickMeButton(NSObject sender)
        {
            infoLabel.StringValue = "Yes! U Clicked me";
            Console.WriteLine("U clicked me :D");
        }
    }
}
