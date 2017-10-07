using System;

using Xamarin.Forms;

namespace ProjectCanine
{
    public partial class TestFrontPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public TestFrontPage()
        {
            InitializeComponent();

            var item = new CanineTest
            {
                ShortName = "Item 1",
                Name = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;

        }

        public TestFrontPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        void HandleContinue_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SelectTestSectionPage());
        }
    }
}
