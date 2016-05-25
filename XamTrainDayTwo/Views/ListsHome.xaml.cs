
using Xamarin.Forms;

namespace XamTrainDayTwo.Views
{
    public partial class ListsHome : TabbedPage
    {
        public ListsHome()
        {
            InitializeComponent();
            Children.Add(new BasicListEx { Title = "Basic" });
            Children.Add(new ListContextActionsEx { Title = "ContextAction"});
            Children.Add(new GroupedListEx { Title = "GroupedList" });
        }
    }
}
