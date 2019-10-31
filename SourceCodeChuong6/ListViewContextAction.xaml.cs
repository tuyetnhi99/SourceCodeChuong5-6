using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chaper6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewContextAction : ContentPage
    {
        public ListViewContextAction()
        {
            InitializeComponent();
        }
        public async void MoreClicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = (ListItem)(mi.CommandParameter);
            await DisplayAlert("Clicked", item.Title.ToString() + " More button was clicked", "OK");
        }
        public async void DeleteClicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = (ListItem)mi.CommandParameter;
            await DisplayAlert("Clicked", item.Title.ToString() + " Delete button  was clicked", "OK");
        }
        public class ListItem
        {
            public string Title { get; set; }
        }
    }
}