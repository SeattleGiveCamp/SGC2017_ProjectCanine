using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ProjectCanine.AdminPortal.Data;
using ProjectCanine.AdminPortal.ViewModels;

namespace ProjectCanine.AdminPortal.Services
{
	public class ExportToPdfServices : IExportToPdfServices
	{
		private readonly ICanineProjDbContext dbContext;

		public ExportToPdfServices(
			ICanineProjDbContext dbCtx)
		{
			if (dbCtx == null)
			{
				throw new ArgumentNullException(nameof(dbCtx));
			}
			dbContext = dbCtx;
		}


		public async Task<ExportGridData> GetExportableTests()
		{
			var results = new ExportGridData();

			var rawData = dbContext.TestResults.OrderByDescending(x => x.TestDate);


			return results;
		}

	}
}