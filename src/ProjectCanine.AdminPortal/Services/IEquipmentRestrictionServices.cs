using System;
using System.Collections.Generic;
using ProjectCanine.AdminPortal.ViewModels;

namespace ProjectCanine.AdminPortal.Services
{
	public interface IEquipmentRestrictionServices
	{
		List<EquipmentRestrictionGridRow> GetEquipmentRestrictions();
		EquipmentRestrictionGridRow GetEquipmentRestriction(Guid Id);
	}
}
