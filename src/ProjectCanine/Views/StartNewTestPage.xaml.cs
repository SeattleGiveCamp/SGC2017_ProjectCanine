using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectCanine.Core.Models;


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
            
            var page = new TestFrontPage(item);
            var vm = new TestFrontPageViewModel(page, item);
            page.BindingContext = vm;

            await Navigation.PushAsync(page);

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
