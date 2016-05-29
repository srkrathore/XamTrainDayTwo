using Xamarin.Forms;

namespace XamTrainDayTwo.Behaviors
{
    public class EmailVlidator : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }
        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            if (!args.NewTextValue.Contains("@"))
            {
                ((Entry)sender).Text = "";
            }
            //else ((Entry)sender).TextColor = Color.Default;
        }

    }
}
