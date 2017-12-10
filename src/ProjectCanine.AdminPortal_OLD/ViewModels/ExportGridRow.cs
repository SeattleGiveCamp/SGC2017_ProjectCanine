using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectCanine.AdminPortal_OLD.ViewModels
{
	public class ExportGridRow
	{
		public Guid TestResultId { get; set; }

		[Display(Name = "Handler Name")]
		public string HandlerName { get; set; }

		[Display(Name = "Dog Name")]
		public string DogName { get; set; }

		[Display(Name = "Test Date")]
		public DateTime TestDate { get; set; }
	}
}
