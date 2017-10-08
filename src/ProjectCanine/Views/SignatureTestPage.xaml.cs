using System;
using System.Collections.Generic;
using ProjectCanine.ViewModels;
using ProjectCanine.Core.Models;
using Xamarin.Forms;

namespace ProjectCanine
{
    public partial class SignatureTestPage : ContentPage
    {
		TestSignatureViewModel viewModel;
		TestSignatureViewModel ViewModel => viewModel ?? (viewModel = BindingContext as TestSignatureViewModel);

		public SignatureTestPage()
        {
            InitializeComponent();

            // The following might not be necessary 
			var item = new Test
			{
				ShortName = "Signature",
				Name = "Please sign"
			};

			viewModel = new TestSignatureViewModel(this, item);
			BindingContext = viewModel;
        }

		public SignatureTestPage(Test item = null)
		{
			InitializeComponent();

			viewModel = new TestSignatureViewModel(this, item);
			BindingContext = viewModel;
		}
    }
}
