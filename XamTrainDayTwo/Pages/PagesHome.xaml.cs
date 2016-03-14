using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTrainDayTwo
{
	public partial class PagesHome : ContentPage
	{
		public PagesHome ()
		{
			InitializeComponent ();
		}

		public void OnContentClicked (object sender, EventArgs args){

			Navigation.PushAsync(new ContentPageEx());

		}
		public void OnTabbedClicked (object sender, EventArgs args){

			Navigation.PushAsync(new TabbedPageEx());

		}
		public void OnCarsoulClicked (object sender, EventArgs args){

			Navigation.PushAsync(new CarouselPageEx());

		}
		public void OnMasterClicked (object sender, EventArgs args){

			Navigation.PushAsync(new MasterDetailEx());

		}
		public void OnStackClicked (object sender, EventArgs args){

			Navigation.PushAsync(new StackEx());

		}
		public void OnRelativeClicked (object sender, EventArgs args){

			Navigation.PushAsync(new RelativeEx());

		}
		public void OnAbsClicked (object sender, EventArgs args){

			Navigation.PushAsync(new AbsoluteEx());

		}
	}
}

