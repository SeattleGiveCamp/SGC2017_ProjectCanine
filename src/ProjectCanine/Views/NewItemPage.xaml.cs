using System;

using Xamarin.Forms;

namespace ProjectCanine
{
    public partial class NewItemPage : ContentPage
    {
        public CanineTest Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Item = new CanineTest
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
