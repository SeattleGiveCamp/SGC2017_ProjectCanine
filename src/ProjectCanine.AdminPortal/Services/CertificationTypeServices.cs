using ProjectCanine.AdminPortal.Data;
using ProjectCanine.AdminPortal.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectCanine.AdminPortal.Services
{
	public class CertificationTypeServices : ICertificationTypeServices
	{
		private readonly ICanineProjDbContext dbContext;

		public CertificationTypeServices(ICanineProjDbContext dbCtx)
		{
			dbContext = dbCtx ?? throw new ArgumentNullException(nameof(dbCtx));

			// lets see what SQL is getting generated.
			dbContext.Database.Log = DbContextLogCallback;
		}
		
		public List<CertificationTypeGridRow> GetCertificationTypes()
		{
			var results = new List<CertificationTypeGridRow>();

			try
			{
				var query = from certificationTypes in dbContext.CertificationTypes
							select new CertificationTypeGridRow
							{
								Id = certificationTypes.Id,
								Name = certificationTypes.Name
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

		public CertificationTypeGridRow GetCertificationType(Guid Id)
		{
			var result = new CertificationTypeGridRow();

			try
			{
				var query = from certificationTypes in dbContext.CertificationTypes
							where certificationTypes.Id == Id
							select new CertificationTypeGridRow
							{
								Id = certificationTypes.Id,
								Name = certificationTypes.Name
							};

				result = query.FirstOrDefault() ?? new CertificationTypeGridRow();
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