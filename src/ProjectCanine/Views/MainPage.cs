using System;

using Xamarin.Forms;

namespace ProjectCanine
{
    public class MainPage : ContentPage
	{
		public MainPage()
		{
			Title = "About";
			Icon = "tab_about.png";
            Content = new StackLayout
            {
                Padding = 20,
                Spacing = 20,
                Children = {
                    new Label {
                        Text = "Welcome!",
                        FontSize = 20,
                        FontAttributes= FontAttributes.Bold,
                        HorizontalTextAlignment = TextAlignment.Center
                    },
                    new Label {
                        FontSize = 16,
                        Text = "This is an application for testing a canine " +
                            "Please click the Select Test button to continue." ,
                        HorizontalTextAlignment = TextAlignment.Center},
                    SelectTestButton()
				}
			};
		}

        public Button SelectTestButton() {
			Button selectTestButton = new Button
			{
				Text = "Select Test"
			};

            selectTestButton.Clicked += OnSelectTestButtonClicked;

            return selectTestButton;
        }

        void OnSelectTestButtonClicked(object sender, EventArgs args) {
            Navigation.PushAsync(new ChooseTestPage());
        }
	}
}
