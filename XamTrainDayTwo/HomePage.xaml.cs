using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTrainDayTwo
{
	public partial class HomePage : MasterDetailPage
	{
		public HomePage ()
		{
			InitializeComponent ();
			MenuPage.ListView.ItemSelected += OnItemSelected;
		}

		void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MenuItem;
			if (item != null) {
				Detail = new NavigationPage ((Page)Activator.CreateInstance (item.TargetType));
				MenuPage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}
	
	}
}

