using System;

using UIKit;

namespace XamActionSheet.Sample
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var handler = new DoActionSheetHandler(Console.WriteLine);

            var button = new UIButton(UIButtonType.System);
            button.Title(UIControlState.Normal);

            var buttons = new UIButton[] {
                button
            };

            var sheet = new DoActionSheet();
            sheet.ShowC("Cancel", buttons, handler);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

