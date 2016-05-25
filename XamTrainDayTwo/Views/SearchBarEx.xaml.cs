using System;
using System.Linq;
using Xamarin.Forms;

namespace XamTrainDayTwo.Views
{
    public partial class SearchBarEx : ContentPage
    {
        string[] mListSource = new[] { "alpha", "beta", "gamma", "delta", "Eta", "Zeta", "meta", "epsilon" };
        public SearchBarEx()
        {
            InitializeComponent();
            this.BindingContext = mListSource;
        }
        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return; // has been set to null, do not 'process' tapped event
                                   // Debug.WriteLine("Tapped: " + e.Item);
                                   // ((ListView)sender).SelectedItem = null; // de-select the row
        }
        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {


            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                listView.ItemsSource = mListSource;
            else
                listView.ItemsSource = mListSource.Where(i => i.Contains(e.NewTextValue));


        }
    }
}
