using System;
using Xamarin.Forms;

namespace XamTrainDayTwo
{
    public partial class ConTemplateEx : ContentPage
    {
        bool originalTemplate = true;
        ControlTemplate tealTemplate;
        ControlTemplate aquaTemplate;
        public ConTemplateEx()
        {
            InitializeComponent();
            tealTemplate = (ControlTemplate)Application.Current.Resources["TealTemplate"];
            aquaTemplate = (ControlTemplate)Application.Current.Resources["AquaTemplate"];
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            originalTemplate = !originalTemplate;
            contentView.ControlTemplate = (originalTemplate) ? tealTemplate : aquaTemplate;
        }

    }
}
