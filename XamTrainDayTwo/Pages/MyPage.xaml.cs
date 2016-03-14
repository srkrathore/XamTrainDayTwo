using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTrainDayTwo
{
	public partial class MyPage : TabbedPage
	{
		public MyPage ()
		{
			InitializeComponent ();
			Children.Add (new MasterPage());
			Children.Add (new ContentPageEx ());
		}
	}
}

