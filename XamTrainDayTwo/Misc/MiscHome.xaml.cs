
using Xamarin.Forms;

namespace XamTrainDayTwo.Misc
{
    public partial class MiscHome : TabbedPage
    {
        public MiscHome()
        {
            InitializeComponent();
            Children.Add(new OrientationEx() { Title = "Orientation" });
        }
    }
}
