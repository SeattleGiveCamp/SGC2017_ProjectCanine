using System;
using System.Collections.ObjectModel;
using ProjectCanine.Core.Models;
using System.Collections.Generic;
using MvvmHelpers;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace ProjectCanine
{

    public class FrontPageQuestion : ObservableObject
    {
        public string Title { get; set; }
		public List<String> Items { get; set; }

        string selectedItem;
        public string SelectedItem
        {
            get => selectedItem;
            set => SetProperty(ref selectedItem, value);
        }
    }

    public class TestFrontPageViewModel : ViewModelBase
    {
        public FrontPageQuestion Question1 { get; }
        
        public Test TestObject { get; set; }

        //public String CertificationTitle { get; set; }

        public Page Page { get; set; }
        public TestFrontPageViewModel(Page page, Test item = null)
        {
            Page = page;
            Title = item?.ShortName;
            TestObject = item;
            ContinueCommand = new Command(async () => await ExecuteContinueCommand());

            Question1 = new FrontPageQuestion
            {
                Title = "Type of Certification",
                Items = new List<String>()
                {
                    "New adult certification",
                    "Junior handler certification (under 18 yrs of age)",
                    "Adult recertification",
                    "Puppy-to-adult dog certification"
                }
            };
        }

        public Command ContinueCommand { get; }

        async Task ExecuteContinueCommand()
        {
            if(string.IsNullOrWhiteSpace(Question1.SelectedItem))
            {
                await Page.DisplayAlert("Unanswered Question", $"Please fill in {Question1.Title}", "OK");
                return;
            }


            await Page.Navigation.PushAsync(new SelectTestSectionPage());
        }
    }
}
