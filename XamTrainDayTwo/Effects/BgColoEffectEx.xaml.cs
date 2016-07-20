
using Xamarin.Forms;

namespace XamTrainDayTwo.Effects
{
    public partial class BgColoEffectEx : ContentPage
    {
        public BgColoEffectEx()
        {
            InitializeComponent();
            entry.Effects.Add(Effect.Resolve("Xamarin.BackgroundColorEffect"));

        }
    }
}
