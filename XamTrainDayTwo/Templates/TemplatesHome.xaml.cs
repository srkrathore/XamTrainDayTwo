using Xamarin.Forms;

namespace XamTrainDayTwo
{
    public partial class TemplatesHome : TabbedPage
    {
        public TemplatesHome()
        {
            InitializeComponent();
            Children.Add(new ConTemplateEx { Title = "Control Template" });

        }
    }
}
