using System;

using Xamarin.Forms;
using ProjectCanine.Core.Models;


namespace ProjectCanine
{
    public partial class TestFrontPage : ContentPage
    {
        TestFrontPageViewModel viewModel;

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public TestFrontPage()
        {
            InitializeComponent();

            var item = new Test
            {
                ShortName = "Item 1",
                Name = "This is an item description."
            };

            viewModel = new TestFrontPageViewModel(item);
            BindingContext = viewModel;

        }

        public TestFrontPage(TestFrontPageViewModel viewModel)
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
