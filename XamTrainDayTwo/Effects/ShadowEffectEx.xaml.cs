using System;
using Xamarin.Forms;

namespace XamTrainDayTwo.Effects
{
    public partial class ShadowEffectEx : ContentPage
    {
        bool isLabelTeal = false;
        public ShadowEffectEx()
        {
            InitializeComponent();
        }
        void OnButtonClicked(object sender, EventArgs args)
        {
            if (isLabelTeal)
            {
                ShadowEffect.SetColor(label, Device.OnPlatform(Color.Black, Color.White, Color.Red));
                isLabelTeal = false;
            }
            else
            {
                ShadowEffect.SetColor(label, Color.Teal);
                isLabelTeal = true;
            }
        }
    }
}
