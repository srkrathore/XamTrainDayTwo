using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTrainDayTwo
{
	public partial class ControlsExHome : ContentPage
	{
		public ControlsExHome ()
		{
			InitializeComponent ();
            string[] aSourceList = { "Red", "Greem", "Yellow", "Orange", "Magenta" };
            ddlExample.ItemsSource = aSourceList;
        }
        void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlExample.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            var vItem = ddlExample.SelectedItem;
            lblSelectedVal.Text = vItem.ToString();

        }

    }
}

