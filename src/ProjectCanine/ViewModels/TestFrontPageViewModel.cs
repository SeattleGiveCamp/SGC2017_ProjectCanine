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
        public MCQuestionData ShadowVisitQuestion { get; }

        public LongQuestionData OtherRestrictions { get; }

        public ShortQuestionData HandlerName { get; }
        public ShortQuestionData CanineName { get; }
        public ShortQuestionData ScoringExaminer { get; }
        public ShortQuestionData HandsOnExaminer { get; }
		public ShortQuestionData Date { get; }
              
        public Test TestObject { get; set; }

        public Page Page { get; set; }
        public TestFrontPageViewModel(Page page, Test item = null)
        {
            Page = page;
            Title = item?.ShortName;
            TestObject = item;
            ContinueCommand = new Command(async () => await ExecuteContinueCommand());

            HandlerName = new ShortQuestionData
            {
                Title = "Handler Name"
            };

			CanineName = new ShortQuestionData
			{
				Title = "Canine Name"
			};

			ScoringExaminer = new ShortQuestionData
			{
				Title = "Scoring Examiner"
			};

			HandsOnExaminer = new ShortQuestionData
			{
				Title = "Hands-On Examiner"
			};

			Date = new ShortQuestionData
			{
				Title = "Date"
			};

            OtherRestrictions = new LongQuestionData
            {
                Title = "Other Restrictions"
            };

			CertificationQuestion = new MCQuestionData
            {
                Title = "Type of Certification",
                Items = new List<MCItem>()
                {
                    new MCItem("New adult certification"),
                    new MCItem("Junior handler certification (under 18 yrs of age)"),
                    new MCItem("Adult recertification"),
                    new MCItem("Puppy-to-adult dog certification")
                }
            };

			CanineEquipmentQuestion = new MCQuestionData
			{
				Title = "Canine Equipment Restriction",
                Items = new List<MCItem>()
				{
                    new MCItem("Flat Collar"),
                    new MCItem("Harness (any type)"),
                    new MCItem("Head Halter"),
                    new MCItem("Martingale Collar")
				}
			};

			PracticeLabQuestion = new MCQuestionData
			{
				Title = "Practice Lab Requirement",
                Items = new List<MCItem>()
				{
                    new MCItem("Yes"),
                    new MCItem("No")
				}
			};

         
			ShadowVisitQuestion = new MCQuestionData
			{
				Title = "*Shadow Visit Requirement (*Oregon)",
                Items = new List<MCItem>()
				{
                    new MCItem("Both shadows"),
                    new MCItem("Second Shadow only"),
                    new MCItem("NA")
				}
			};


		}

        public Command ContinueCommand { get; }

        async Task ExecuteContinueCommand()
        {
            if(string.IsNullOrWhiteSpace(CertificationQuestion.SelectedItem?.Text) ||
               string.IsNullOrWhiteSpace(CanineEquipmentQuestion.SelectedItem?.Text) ||
               string.IsNullOrWhiteSpace(PracticeLabQuestion.SelectedItem?.Text) ||
               string.IsNullOrWhiteSpace(HandlerName.Text) ||
               string.IsNullOrWhiteSpace(CanineName.Text) || 
               string.IsNullOrWhiteSpace(ScoringExaminer.Text)||
               string.IsNullOrWhiteSpace(HandsOnExaminer.Text) ||
               string.IsNullOrWhiteSpace(Date.Text))
            {
                await Page.DisplayAlert("Unanswered Question", $"Please answer all the questions.", "OK");
                return;
            }

            var vm = new TestSectionViewModel(Page, TestObject);
            await Page.Navigation.PushAsync(new SelectTestSectionPage(vm));
        }
    }
}
