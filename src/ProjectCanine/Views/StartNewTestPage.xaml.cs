using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ProjectCanine
{
    public partial class StartNewTestPage : ContentPage
    {
        TestItemsViewModel viewModel;

        public StartNewTestPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new TestItemsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Test;
            if (item == null)
                return;

            await Navigation.PushAsync(new TestFrontPage(new TestFrontPageViewModel(item)));

            // Manually deselect item
            ItemsListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
