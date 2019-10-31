using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chaper6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListViewStrings_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListViewStrings());
        }

        private void ListViewDataModel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListViewDataModel());
        }

        private void ListViewImageCell_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListViewImageCell());
        }

        private void ListViewCustom_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListViewCustom());
        }

        private void ListViewButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListViewButton());
        }

        private void ListViewContextAction_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListViewContextAction());
        }

        private void ListViewGrouped_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListViewGrouped());
        }

        private void ListViewGroupedTemplate_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListViewGroupedTemplate());
        }
    }
}
