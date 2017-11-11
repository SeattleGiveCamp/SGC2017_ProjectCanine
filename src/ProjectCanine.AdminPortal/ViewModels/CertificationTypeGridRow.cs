using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectCanine.AdminPortal.ViewModels
{
	public class CertificationTypeGridRow
	{
		public Guid Id { get; set; }

		[Display(Name = "Name")]
		public string Name { get; set; }
	}
}
