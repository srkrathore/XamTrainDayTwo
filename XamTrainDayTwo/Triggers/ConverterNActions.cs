using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamTrainDayTwo.Triggers
{
    public class FadeTriggerAction : TriggerAction<VisualElement>
    {
        public FadeTriggerAction()
        {
        }

        public int StartsFrom { set; get; }

        protected override void Invoke(VisualElement visual)
        {

            visual.Animate("0", new Animation((d) => {
                var val = StartsFrom == 1 ? d : 1 - d;
                // so i was aiming for a different color, but then i liked the pink :)
                visual.BackgroundColor = Color.FromRgb(1, val, 1);
            }),
            length: 1000, // milliseconds
            easing: Easing.Linear);
        }
    }
    public class NumericValidationTriggerAction : TriggerAction<Entry>
    {
        protected override void Invoke(Entry entry)
        {
            double result;
            bool isValid = Double.TryParse(entry.Text, out result);
            entry.TextColor = isValid ? Color.Default : Color.Red;
        }
    }
    /// <summary>
    /// Converts an Entry's Text.Length into a 'flag'
    ///  * Entry is empty, returns 1
    /// 
    /// </summary>
    public class MultiTriggerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if ((int)value > 0)
                return true;    // data has been entered
            else
                return false;   // input is empty
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
