
using Xamarin.Forms;

namespace XamTrainDayTwo.Views
{
    public partial class ImagesHome : TabbedPage
    {
        public ImagesHome()
        {
            InitializeComponent();
            Children.Add(new LocalImagesEx { Title = "Local" });
            Children.Add(new EmbeddedImagesEx { Title = "Embedded" });
            Children.Add(new DownloadImagesEx { Title = "Downloaded" });
        }
    }
}
