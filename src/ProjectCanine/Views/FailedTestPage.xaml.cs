using System;
using System.Collections.Generic;
using ProjectCanine.Core.Models;
using ProjectCanine.ViewModels;
using Xamarin.Forms;

namespace ProjectCanine
{
    public partial class FailedTestPage : ContentPage
    {
        FailedTestViewModel viewModel;
		FailedTestViewModel ViewModel => viewModel ?? (viewModel = BindingContext as FailedTestViewModel);


		// Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
		public FailedTestPage()
		{
			InitializeComponent();

			var item = new Test
			{
				ShortName = "Item 1",
				Name = "This is an item description."
			};

			viewModel = new FailedTestViewModel(this, item);
			BindingContext = viewModel;
		}

        public FailedTestPage(Test item = null)
		{
			InitializeComponent();

            viewModel = new FailedTestViewModel(this, item);
			BindingContext = viewModel;
		}

	}
}
