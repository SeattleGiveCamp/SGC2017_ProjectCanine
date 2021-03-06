﻿using System;

using Xamarin.Forms;
using ProjectCanine.Core.Models;


namespace ProjectCanine
{
    public partial class TestFrontPage : ContentPage
    {
        TestFrontPageViewModel viewModel;
        TestFrontPageViewModel ViewModel  => viewModel ?? (viewModel = BindingContext as TestFrontPageViewModel);


        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public TestFrontPage()
        {
            InitializeComponent();

            var item = new Test
            {
                ShortName = "Item 1",
                Name = "This is an item description."
            };

            viewModel = new TestFrontPageViewModel(this, item);
            BindingContext = viewModel;
        }

        public TestFrontPage(Test item = null)
        {
            InitializeComponent();

            viewModel = new TestFrontPageViewModel(this, item);
            BindingContext = viewModel;
        }

    }
}
