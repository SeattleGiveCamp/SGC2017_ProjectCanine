using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;
using ProjectCanine.Core.Models;


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

        public SelectTestSectionPage(TestSectionViewModel vm = null) {
            InitializeComponent();
            viewModel = vm;

            BindingContext = viewModel;
        }

		async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
		{
			var item = args.SelectedItem as Section;
			if (item == null)
				return;

			await Navigation.PushAsync(new TestSectionQuestionsPage(new TestSectionQuestionsViewModel(item)));

			// Manually deselect item
			ItemsListView.SelectedItem = null;
		}

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FailedTestPage());
        }
    }
}