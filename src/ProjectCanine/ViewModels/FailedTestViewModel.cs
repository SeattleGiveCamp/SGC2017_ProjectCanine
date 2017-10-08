using System;
using System.Collections.ObjectModel;
using ProjectCanine.Core.Models;
using System.Collections.Generic;
using MvvmHelpers;
using Xamarin.Forms;
using System.Threading.Tasks;


namespace ProjectCanine.ViewModels
{
    public class FailedTestViewModel : ViewModelBase
    {
        public LongQuestionData MoreInfo { get; }

        public Test TestObject { get; set; }
        public MCQuestionData YesNo { get; set; }

		public Page Page { get; set; }
        public FailedTestViewModel(Page page, Test item = null)
        {
			Page = page;
			Title = item?.ShortName;
			TestObject = item;

            YesNo = new MCQuestionData
            {
                Title = "Eligible to retest?",
                Items = new List<MCItem> {
                    new MCItem("Yes"),
                    new MCItem("No")
                }
            };

			CompleteTestCommand = new Command(async () => await ExecuteCompleteTestCommand());

			
            MoreInfo = new LongQuestionData
			{
				Title = "Please provide more info"
			};

		}

		public Command CompleteTestCommand { get; }

		async Task ExecuteCompleteTestCommand()
		{
			
			//var vm = new TestSectionViewModel(TestObject);
            await Page.Navigation.PushAsync(new ThankYouPage());
		}
    }
}

