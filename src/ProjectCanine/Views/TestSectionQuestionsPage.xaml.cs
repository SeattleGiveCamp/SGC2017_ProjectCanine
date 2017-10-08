using System;
using System.Collections.Generic;
using ProjectCanine.Core.Models;

using Xamarin.Forms;

namespace ProjectCanine
{
    public partial class TestSectionQuestionsPage : ContentPage
    {
        TestSectionQuestionsViewModel viewModel;

		// Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public TestSectionQuestionsPage()
		{
			InitializeComponent();

			var item = new Section
			{
                Title = "Section Title",
                SectionNumber = 1,
                Description = "Section Description",
                Questions = new List<Question>()
			};

            viewModel = new TestSectionQuestionsViewModel(item);
			BindingContext = viewModel;
		}

        public TestSectionQuestionsPage(TestSectionQuestionsViewModel viewModel)
		{
			InitializeComponent();

			BindingContext = this.viewModel = viewModel;
		}

		async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
		{
            // don't do anything here for now.
            return;
		}
    }
}
