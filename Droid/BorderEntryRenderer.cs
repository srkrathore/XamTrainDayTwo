using Xamarin.Forms;
using XamTrainDayTwo;
using XamTrainDayTwo.Droid;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderedEntry), typeof(BorderEntryRenderer))]
namespace XamTrainDayTwo.Droid
{
    public class BorderEntryRenderer : EntryRenderer
    {
        //public BorderEntryRenderer()
        //{
        //    Background = Android.Graphics.Drawables.Drawable.CreateFromPath("@drawable/EntryBorder.xml");
        //}
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
            }
        }
    }
}