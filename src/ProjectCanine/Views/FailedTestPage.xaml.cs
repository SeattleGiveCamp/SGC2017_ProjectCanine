using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProjectCanine
{
    public partial class FailedTestPage : ContentPage
    {
        public FailedTestPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ThankYouPage());
        }
    }
}
