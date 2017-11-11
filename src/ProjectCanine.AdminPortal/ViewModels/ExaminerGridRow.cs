using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectCanine.AdminPortal.ViewModels
{
	public class ExaminerGridRow
	{
		public Guid Id { get; set; }

		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		public string LastName { get; set; }
	}
}
