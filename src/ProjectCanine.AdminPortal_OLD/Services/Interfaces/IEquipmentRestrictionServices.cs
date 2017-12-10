using System;
using System.Collections.Generic;
using ProjectCanine.AdminPortal_OLD.ViewModels;

namespace ProjectCanine.AdminPortal_OLD.Services
{
	public interface IEquipmentRestrictionServices
	{
		List<EquipmentRestrictionGridRow> GetEquipmentRestrictions();
		EquipmentRestrictionGridRow GetEquipmentRestriction(Guid Id);
	}
}
