using System;
using XamTrainDayTwo.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportEffect(typeof(BackgroundColorEffect), "BackgroundColorEffect")]
namespace XamTrainDayTwo.iOS
{
    public class BackgroundColorEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }

        protected override void OnDetached()
        {

        }
    }
}
