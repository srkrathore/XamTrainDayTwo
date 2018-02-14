using System;
using Xamarin.Forms;

namespace XamTrainDayTwo
{
    public partial class DynamicEx : ContentPage
	{
		bool originalStyle = true;
		public DynamicEx ()
		{
			InitializeComponent ();         
            Resources ["MyStyle"] = Resources ["RedStyle"];
		}

		public void OnClickMeClicked (object sender, EventArgs args){

			if (originalStyle) {
				Resources ["MyStyle"] = Resources ["PageExplicitStyle"];
				originalStyle = false;
			} else {
				Resources ["MyStyle"] = Resources ["RedStyle"];
				originalStyle = true;
			}

		}
	}
}

