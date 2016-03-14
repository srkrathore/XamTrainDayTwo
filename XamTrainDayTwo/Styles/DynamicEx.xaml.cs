using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTrainDayTwo
{
	public partial class DynamicEx : ContentPage
	{
		bool originalStyle = true;
		public DynamicEx ()
		{
			InitializeComponent ();
			Resources ["MyDynamicStyle"] = Resources ["RedStyle"];
		}

		public void OnClickMeClicked (object sender, EventArgs args){

			if (originalStyle) {
				Resources ["MyDynamicStyle"] = Resources ["PageExplicitStyle"];
				originalStyle = false;
			} else {
				Resources ["MyDynamicStyle"] = Resources ["RedStyle"];
				originalStyle = true;
			}

		}
	}
}

