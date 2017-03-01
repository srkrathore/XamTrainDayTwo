using Xamarin.Forms;

namespace XamTrainDayTwo
{
    public partial class AppHeader : ContentView
	{

		public AppHeader ()
		{
			InitializeComponent ();
		}

        public Label HeaderLabel { get { return lblHeader; } set { lblHeader = value; } }
        public string SubHeaderText { get { return lblSubHeader.Text; } set { lblSubHeader.Text = value; } }
    }
}

