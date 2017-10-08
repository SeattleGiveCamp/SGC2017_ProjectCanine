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
                        FontSize = 20
                    },
                    new Label {
                        Text = "This is an application for testing a canine " +
                            "for ___? Please click the Select Test button to continue." },
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
