using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ProjectCanine
{
	public partial class SelectTestSectionPage : ContentPage
	{
		TestSectionViewModel viewModel;

		public SelectTestSectionPage()
		{
			InitializeComponent();

			BindingContext = viewModel = new TestSectionViewModel();
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

		async void AddItem_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new NewItemPage());
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (viewModel.Items.Count == 0)
				viewModel.LoadItemsCommand.Execute(null);
		}
	}
}