using Xamarin.Forms;

namespace XamTrainDayTwo
{
    public partial class AppHeader : ContentView
	{

		public AppHeader ()
		{
			InitializeComponent ();
		}

        public string HeaderText { get { return lblHeader.Text; } set { lblHeader.Text = value; } }
        public string SubHeaderText { get { return lblSubHeader.Text; } set { lblSubHeader.Text = value; } }
    }
}

