using ProjectCanine.AdminPortal.Data;
using ProjectCanine.AdminPortal.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectCanine.AdminPortal.Services
{
	public class EquipmentRestrictionServices : IEquipmentRestrictionServices
	{
		private readonly ICanineProjDbContext dbContext;

		public EquipmentRestrictionServices(ICanineProjDbContext dbCtx)
		{
			dbContext = dbCtx ?? throw new ArgumentNullException(nameof(dbCtx));

			// lets see what SQL is getting generated.
			dbContext.Database.Log = DbContextLogCallback;
		}
		
		public List<EquipmentRestrictionGridRow> GetEquipmentRestrictions()
		{
			var results = new List<EquipmentRestrictionGridRow>();

			try
			{
				var query = from equipmentRestrictions in dbContext.EquipmentRestrictions
							select new EquipmentRestrictionGridRow
							{
								Id = equipmentRestrictions.Id,
								Name = equipmentRestrictions.Name
							};

				foreach (var row in query)
				{
					results.Add(row);
				}
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Exception: {e.Message}");
			}
			return results;
		}

		public EquipmentRestrictionGridRow GetEquipmentRestriction(Guid Id)
		{
			var result = new EquipmentRestrictionGridRow();

			try
			{
				var query = from equipmentRestrictions in dbContext.EquipmentRestrictions
							where equipmentRestrictions.Id == Id
							select new EquipmentRestrictionGridRow
							{
								Id = equipmentRestrictions.Id,
								Name = equipmentRestrictions.Name
							};

				result = query.FirstOrDefault() ?? new EquipmentRestrictionGridRow();
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Exception: {e.Message}");
			}
			return result;
		}

		private void DbContextLogCallback(string logstr)
		{
			Debug.WriteLine(logstr);
		}
	}
}