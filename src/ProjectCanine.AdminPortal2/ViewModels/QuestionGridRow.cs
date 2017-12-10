using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectCanine.AdminPortal2.ViewModels
{
	public class QuestionGridRow
	{
		public Guid Id { get; set; }

		[Display(Name = "Text")]
		public String Text { get; set; }

		[Display(Name = "Must Pass")]
		public bool MustPass { get; set; }

		[Display(Name = "Question Number")]
		public int QuestionNumber { get; set; }

		[Display(Name = "Has Yes No Portion")]
		public bool HasYesNo { get; set; }

		[Display(Name = "Last Edited By")]
		public String LastEditedBy { get; set; }

		[Display(Name = "Last Edited Date")]
		public DateTime LastEditedDate { get; set; }
	}
}
