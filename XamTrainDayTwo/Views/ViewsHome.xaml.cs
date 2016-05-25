
using Xamarin.Forms;
using XamTrainDayTwo.Views;

namespace XamTrainDayTwo
{
    public partial class ViewsHome : TabbedPage
	{
        public ViewsHome()
        {
            InitializeComponent();
            Children.Add(new ListsHome { Title = "Lists" });
            //Children.Add(new SearchBarEx { Title = "Search Bar" });
        }
	}
}

