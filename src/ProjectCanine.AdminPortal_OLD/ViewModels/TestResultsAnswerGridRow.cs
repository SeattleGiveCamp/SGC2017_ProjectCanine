using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectCanine.AdminPortal_OLD.ViewModels
{
	public class TestResultsAnswerGridRow
	{
		public Guid Id { get; set; }

		[Display(Name = "Text")]
		public String Text { get; set; }

		[Display(Name = "Must Pass")]
		public bool MustPass { get; set; }

		[Display(Name = "Question Number")]
		public int QuestionNumber { get; set; }

		[Display(Name = "Answer")]
		public string Answer { get; set; }

		[Display(Name = "Yes No")]
		public bool? YesNo { get; set; }
	}
}
