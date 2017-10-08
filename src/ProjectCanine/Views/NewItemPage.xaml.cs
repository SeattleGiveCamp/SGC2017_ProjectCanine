using System;

using Xamarin.Forms;
using ProjectCanine.Common.Models;


namespace ProjectCanine
{
    public partial class NewItemPage : ContentPage
    {
        public Test Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Item = new Test
            {
                ShortName = "Item name",
                Name = "This is an item description."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopToRootAsync();
        }
    }
}
