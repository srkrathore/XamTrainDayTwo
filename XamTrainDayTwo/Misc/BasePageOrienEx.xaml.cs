
using Xamarin.Forms;

namespace XamTrainDayTwo.Misc
{
    public partial class BasePageOrienEx : BaseContentPage
    {
        public BasePageOrienEx()
        {
            InitializeComponent();
        }

        protected override void OnOrientationChanged(OrientationValue newOrientation)
        {
            if (newOrientation == OrientationValue.Landscape)
                lblOrientation.Text = "Device is in Ladscape Mode";
            else
                lblOrientation.Text = "Device is in Potrait Mode";
        }
    }

    public class BaseContentPage : ContentPage
    {
        private double _width, _height;

        protected enum OrientationValue
        {
            Portrait,
            Landscape
        }

        protected virtual void OnOrientationChanged(OrientationValue newOrientation) { }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width != _width || height != _height)
            {
                _width = width;
                _height = height;

                OnOrientationChanged(width > height ? OrientationValue.Landscape : OrientationValue.Portrait);
            }
        }
    }
}
