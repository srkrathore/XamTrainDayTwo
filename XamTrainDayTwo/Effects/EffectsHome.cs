
using Xamarin.Forms;

namespace XamTrainDayTwo.Effects
{
    public class EffectsHome : TabbedPage
    {
        public EffectsHome()
        {
            Title = "Effects Home";
            Children.Add(new ShadowEffectEx { Title = "Shadow" });
            Children.Add(new BgColoEffectEx { Title = "Background Color" });
            Children.Add(new FocusEx { Title = "Focus" });

        }
    }
}
