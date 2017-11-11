using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectCanine.AdminPortal.ViewModels
{
	public class SectionGridRow
	{
		public Guid Id { get; set; }

		[Display(Name = "SectionNumber")]
		public int SectionNumber { get; set; }

		[Display(Name = "Title")]
		public string Title { get; set; }

		[Display(Name = "Description")]
		public String Description { get; set; }
		
		[Display(Name = "Last Edited By")]
		public String LastEditedBy { get; set; }

		[Display(Name = "Last Edited Date")]
		public DateTime LastEditedDate { get; set; }

		[Display(Name = "Questions")]
		public List<QuestionGridRow> Questions { get; set; }
	}
}
