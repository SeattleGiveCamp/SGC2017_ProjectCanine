using System;
using System.Collections.Generic;

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

			var item = new Test
			{
				ShortName = "Item 1",
				Name = "This is an item description."
			};

            viewModel = new TestSectionQuestionsViewModel(item);
			BindingContext = viewModel;
		}

        public TestSectionQuestionsPage(TestSectionQuestionsViewModel viewModel)
		{
			InitializeComponent();

			BindingContext = this.viewModel = viewModel;
		}
    }
}
