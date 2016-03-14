using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTrainDayTwo
{
	public partial class StylesHome : ContentPage
	{
		public StylesHome ()
		{
			InitializeComponent ();
		}

		public void OnImplicitClicked (object sender, EventArgs args){

			Navigation.PushAsync(new ImplicitEx());

		}

		public void OnExplicitClicked (object sender, EventArgs args){

			Navigation.PushAsync(new ExplicitEx());

		}

		public void OnGlobalClicked (object sender, EventArgs args){

			Navigation.PushAsync(new GlobalEx());

		}

		public void OnDynamicClicked (object sender, EventArgs args){

			Navigation.PushAsync(new TriggerEx());

		}
	}
}

