using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

using ProjectCanine.AdminPortal.Data;
using ProjectCanine.AdminPortal.Data.Entities;
using ProjectCanine.AdminPortal.Dtos;
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

			// lets see what SQL is getting generated.
			dbContext.Database.Log = DbContextLogCallback;
		}


		public async Task<ExportGridData> GetExportableTests()
		{
			var results = new ExportGridData();

			//var rawData = dbContext.TestResults.OrderByDescending(x => x.TestDate);

			//var query = from g in context.Groups
			//			join m in context.Members on g.Id equals m.GroupId into members
			//			select new
			//			{
			//				Group = g,
			//				MemberCount = members.Count(),
			//			};

			var query = from tr in dbContext.TestResults
				join hndlr in dbContext.Handlers on tr.Handler equals hndlr.Id
				join dog in dbContext.Dogs on tr.Dog equals dog.Id
				select new ExportGridRow
				{
					HandlerName = hndlr.FirstName.Trim() + " " + hndlr.LastName,
					DogName = dog.Name.Trim(),
					TestDate = tr.TestDate
				};

			foreach (var row in query)
			{
				results.ExportGridRows.Add(row);
			}

			return results;
		}


		private void DbContextLogCallback(string logstr)
		{
			Debug.WriteLine(logstr);
		}

	}
}