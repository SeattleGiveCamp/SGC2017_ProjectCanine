using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectCanine.AdminPortal_OLD.ViewModels
{
	public class EquipmentRestrictionGridRow
	{
		public Guid Id { get; set; }

		[Display(Name = "Name")]
		public string Name { get; set; }
	}
}
