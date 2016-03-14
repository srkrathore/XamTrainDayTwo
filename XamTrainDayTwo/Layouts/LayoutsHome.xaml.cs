using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTrainDayTwo
{
	public partial class LayoutsHome : ContentPage
	{
		public LayoutsHome ()
		{
			InitializeComponent ();
		}

		public void OnStackComplexClicked (object sender, EventArgs args){

			Navigation.PushAsync(new StackComplexEx());

		}
		public void OnStackSimpleClicked (object sender, EventArgs args){

			Navigation.PushAsync(new StackEx());

		}
		public void OnGridClicked (object sender, EventArgs args){

			Navigation.PushAsync(new GridEx());

		}
		public void OnRelativeSimpClicked (object sender, EventArgs args){

			Navigation.PushAsync(new RelativeSimple());

		}
		public void OnRelativeCompClicked (object sender, EventArgs args){

			Navigation.PushAsync(new RelativeEx());

		}
		public void OnAbsCompClicked (object sender, EventArgs args){

			Navigation.PushAsync(new AbsoluteEx());

		}
		public void OnAbsSimpleClicked (object sender, EventArgs args){

			Navigation.PushAsync(new AbsSimple());

		}

	}
}

