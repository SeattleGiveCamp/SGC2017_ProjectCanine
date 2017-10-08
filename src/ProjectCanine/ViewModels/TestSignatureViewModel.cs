using System;

using System.Collections.ObjectModel;
using ProjectCanine.Core.Models;
using System.Collections.Generic;
using MvvmHelpers;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace ProjectCanine.ViewModels
{
    public class TestSignatureViewModel : ViewModelBase
    {
        public SignatureQuestionData ScoringExaminerSignature { get; }
		public SignatureQuestionData HandsOnExaminerSignature { get; }
		public SignatureQuestionData ExamineeSignature { get; }
		
		public ShortQuestionData Date { get; }

		public Test TestObject { get; set; }

		public Page Page { get; set; }
		public TestSignatureViewModel(Page page, Test item = null)
		{
			Page = page;
			Title = item?.ShortName;
			TestObject = item;
			CompleteTestCommand = new Command(async () => await ExecuteCompleteTestCommand());

			ScoringExaminerSignature = new SignatureQuestionData
			{
				Title = "Scoring Examiner Signature"
			};

			HandsOnExaminerSignature = new SignatureQuestionData
			{
				Title = "Hands-on Examiner Signature"
			};

			ExamineeSignature = new SignatureQuestionData
			{
				Title = "Examinee Signature"
			};
            			
			Date = new ShortQuestionData
			{
				Title = "Date"
			};


		}

		public Command CompleteTestCommand { get; }

		async Task ExecuteCompleteTestCommand()
		{

			await Page.Navigation.PushAsync(new ThankYouPage());
		}
    }
}
