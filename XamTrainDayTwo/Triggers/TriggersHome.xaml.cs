using Xamarin.Forms;

namespace XamTrainDayTwo.Triggers
{
    public partial class TriggersHome : TabbedPage
    {
        public TriggersHome()
        {
            InitializeComponent();
            Children.Add(new PropertyTriggerEx { Title = "Property" });
            Children.Add(new DataTriggerEx { Title = "Data" });
            Children.Add(new EventTriggerEx { Title = "Event"});
            Children.Add(new MultiTriggerEx { Title = "Multi" });
            Children.Add(new EnterExitActionEx { Title = "EnterExit" });
        }
    }
}
