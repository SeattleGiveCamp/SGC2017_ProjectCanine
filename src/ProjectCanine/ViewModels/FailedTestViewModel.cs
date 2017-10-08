using System;

using Xamarin.Forms;

namespace ProjectCanine.ViewModels
{
    public class FailedTestViewModel : ContentPage
    {
        public FailedTestViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Failed Examination" }
                }
            };
        }
    }
}

