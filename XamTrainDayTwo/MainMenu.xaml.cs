using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamTrainDayTwo.Triggers;

namespace XamTrainDayTwo
{
	public partial class MainMenu : ContentPage
	{
		public ListView ListView { get { return lstMenuItems; } }

		public MainMenu ()
		{
			InitializeComponent ();

			var vMenuItems = new List<MenuItem> ();
			vMenuItems.Add (new MenuItem {
				Title = "Pages",
				IconSource = "contacts.png",
				TargetType = typeof(PagesHome)
			});
			vMenuItems.Add (new MenuItem {
				Title = "Layouts",
				IconSource = "todo.png",
				TargetType = typeof(LayoutsHome)
			});
			vMenuItems.Add (new MenuItem {
				Title = "Views",
				IconSource = "reminders.png",
				TargetType = typeof(ViewsHome)
			});
			vMenuItems.Add (new MenuItem {
				Title = "Styles",
				IconSource = "reminders.png",
				TargetType = typeof(StylesHome)
			});
            vMenuItems.Add(new MenuItem
            {
                Title = "Triggers",
                IconSource = "reminders.png",
                TargetType = typeof(TriggersHome)
            });
            vMenuItems.Add (new MenuItem {
				Title = "Controls Examples",
				IconSource = "reminders.png",
				TargetType = typeof(ControlsExHome)
			});
			lstMenuItems.ItemsSource = vMenuItems;
		}
	}

	public class MenuItem
	{
		public string Title { get; set; }

		public string IconSource { get; set; }

		public Type TargetType { get; set; }
	}
}

