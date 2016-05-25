using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XamTrainDayTwo.Views
{
    public partial class GroupedListEx : ContentPage
    {
        private ObservableCollection<GroupedVeggieModel> grouped { get; set; }
        public GroupedListEx()
        {
            InitializeComponent();
            grouped = new ObservableCollection<GroupedVeggieModel>();
            var veggieGroup = new GroupedVeggieModel() { LongName = "vegetables", ShortName = "v" };
            var fruitGroup = new GroupedVeggieModel() { LongName = "fruit", ShortName = "f" };
            veggieGroup.Add(new VeggieModel() { Name = "celery", IsReallyAVeggie = true, Comment = "try ants on a log" });
            veggieGroup.Add(new VeggieModel() { Name = "tomato", IsReallyAVeggie = false, Comment = "pairs well with basil" });
            veggieGroup.Add(new VeggieModel() { Name = "zucchini", IsReallyAVeggie = true, Comment = "zucchini bread > bannana bread" });
            veggieGroup.Add(new VeggieModel() { Name = "peas", IsReallyAVeggie = true, Comment = "like peas in a pod" });
            fruitGroup.Add(new VeggieModel() { Name = "banana", IsReallyAVeggie = false, Comment = "available in chip form factor" });
            fruitGroup.Add(new VeggieModel() { Name = "strawberry", IsReallyAVeggie = false, Comment = "spring plant" });
            fruitGroup.Add(new VeggieModel() { Name = "cherry", IsReallyAVeggie = false, Comment = "topper for icecream" });
            grouped.Add(veggieGroup); grouped.Add(fruitGroup);
            lstView.ItemsSource = grouped;
        }
    }

    public class VeggieModel
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public bool IsReallyAVeggie { get; set; }
        public string Image { get; set; }
        public VeggieModel()
        {
        }
    }

    public class GroupedVeggieModel : ObservableCollection<VeggieModel>
    {
        public string LongName { get; set; }
        public string ShortName { get; set; }
    }
}
