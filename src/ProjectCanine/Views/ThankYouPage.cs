using System;

using Xamarin.Forms;

namespace ProjectCanine
{
    public class ThankYouPage : ContentPage
    {
        public ThankYouPage()
        {
			Title = "Thank You!";
			Icon = "tab_about.png";
			Content = new StackLayout
			{
				Padding = 20,
				Spacing = 20,
				Children = {
					new Label {
						Text = "Thank You!",
						FontSize = 20
					},
					new Label {
						Text = "If you want to test again, press button below." },
					SelectTestButton()
				}
			};
        }

		public Button SelectTestButton()
		{
			Button selectTestButton = new Button
			{
				Text = "Take Another Test"
			};

			selectTestButton.Clicked += OnSelectTestButtonClicked;

			return selectTestButton;
		}

		void OnSelectTestButtonClicked(object sender, EventArgs args)
		{
			Navigation.PushAsync(new ChooseTestPage());
		}
    }
}

