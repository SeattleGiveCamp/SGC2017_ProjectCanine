using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectCanine.AdminPortal.ViewModels
{
	public class QuestionGridRow
	{
		public Guid Id { get; set; }

		[Display(Name = "Text")]
		public String Text { get; set; }

		[Display(Name = "MustPass")]
		public bool MustPass { get; set; }

		[Display(Name = "QuestionNumber")]
		public int QuestionNumber { get; set; }
		
		[Display(Name = "HasYesNo")]
		public bool HasYesNo { get; set; }

		[Display(Name = "Last Edited By")]
		public String LastEditedBy { get; set; }

		[Display(Name = "Last Edited Date")]
		public DateTime LastEditedDate { get; set; }
	}
}
