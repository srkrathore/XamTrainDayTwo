using Xamarin.Forms;

namespace XamTrainDayTwo.Misc
{
    public partial class OrienEventEx : ContentPage
    {
        public OrienEventEx()
        {
            InitializeComponent();
        }
        protected override void OnSizeAllocated(double width, double height)
        {
            if (width > height)
            {
                lblOrientation.Text = "Device in Lanscape Mode";
            }
            else
                lblOrientation.Text = "Device in Potriat Mode";

        }
    }
}
