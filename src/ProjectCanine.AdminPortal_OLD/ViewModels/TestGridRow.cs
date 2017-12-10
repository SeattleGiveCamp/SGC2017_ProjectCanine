using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectCanine.AdminPortal_OLD.ViewModels
{
	public class TestGridRow
	{
		public Guid Id { get; set; }

		[Display(Name = "Short Name")]
		public string ShortName { get; set; }

		[Display(Name = "Name")]
		public string Name { get; set; }

		[Display(Name = "Handler Signature Prompt")]
		public String HandlerSignaturePrompt { get; set; }

		[Display(Name = "Last Edited By")]
		public String LastEditedBy { get; set; }

		[Display(Name = "Last Edited Date")]
		public DateTime LastEditedDate { get; set; }

		[Display(Name = "Sections")]
		public List<SectionGridRow> Sections { get; set; }
	}
}
