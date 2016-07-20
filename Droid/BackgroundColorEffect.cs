using System;
using XamTrainDayTwo.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportEffect(typeof(BackgroundColorEffect), "BackgroundColorEffect")]
namespace XamTrainDayTwo.Droid
{
    public class BackgroundColorEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                Control.SetBackgroundColor(Android.Graphics.Color.LightGreen);
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