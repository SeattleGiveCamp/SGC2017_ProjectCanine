using System;
using System.Collections.ObjectModel;
using ProjectCanine.Core.Models;
using System.Collections.Generic;
using MvvmHelpers;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace ProjectCanine
{
    public class TestFrontPageViewModel : ViewModelBase
    {
        public MCQuestionData CertificationQuestion { get; }
        public MCQuestionData CanineEquipmentQuestion { get; }
        public MCQuestionData PracticeLabQuestion { get; }
        public MCQuestionData ShadoVisitQuestion { get; }
        
        public Test TestObject { get; set; }

        //public String CertificationTitle { get; set; }

        public Page Page { get; set; }
        public TestFrontPageViewModel(Page page, Test item = null)
        {
            Page = page;
            Title = item?.ShortName;
            TestObject = item;
            ContinueCommand = new Command(async () => await ExecuteContinueCommand());

            CertificationQuestion = new MCQuestionData
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

			CanineEquipmentQuestion = new MCQuestionData
			{
				Title = "Canine Equipment Restriction",
				Items = new List<String>()
				{
					"Flat Collar",
					"Harness (any type)",
					"Head Halter",
					"Martingale Collar"
				}
			};

			PracticeLabQuestion = new MCQuestionData
			{
				Title = "Practice Lab Requirement",
				Items = new List<String>()
				{
					"Yes",
					"No"
				}
			};

         
			ShadoVisitQuestion = new MCQuestionData
			{
				Title = "*Shadow Visit Requirement (*Oregon)",
				Items = new List<String>()
				{
					"Both shadows",
					"Second Shadow only",
                    "NA"
				}
			};


		}

        public Command ContinueCommand { get; }

        async Task ExecuteContinueCommand()
        {
            if(string.IsNullOrWhiteSpace(CertificationQuestion.SelectedItem) ||
               string.IsNullOrWhiteSpace(CanineEquipmentQuestion.SelectedItem) ||
               string.IsNullOrWhiteSpace(PracticeLabQuestion.SelectedItem)
              )
            {
                await Page.DisplayAlert("Unanswered Question", $"Please answer all the questions.", "OK");
                return;
            }

            var vm = new TestSectionViewModel(TestObject);
            await Page.Navigation.PushAsync(new SelectTestSectionPage(vm));
        }
    }
}
