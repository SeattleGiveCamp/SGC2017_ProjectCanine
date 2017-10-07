using System;

using Xamarin.Forms;

namespace ProjectCanine.Views
{
    public class ChooseTestPage : TabbedPage
    {
        public ChooseTestPage()
        {
            Children.Add(new StartNewTestPage());
            Children.Add(new ResumeSavedTestPage());

            Title = CurrentPage.Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();

            Title = CurrentPage.Title;
        }
    }
}
