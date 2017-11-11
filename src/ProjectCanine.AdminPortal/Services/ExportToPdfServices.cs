using ProjectCanine.AdminPortal.Data;
using ProjectCanine.AdminPortal.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectCanine.AdminPortal.Services
{
	public class ExportToPdfServices : IExportToPdfServices
	{
		private readonly ICanineProjDbContext dbContext;

		public ExportToPdfServices(ICanineProjDbContext dbCtx)
		{
			dbContext = dbCtx ?? throw new ArgumentNullException(nameof(dbCtx));

			// lets see what SQL is getting generated.
			dbContext.Database.Log = DbContextLogCallback;
		}

		public List<ExportGridRow> GetExportableTests()
		{
			var results = new List<ExportGridRow>();

			try
			{
				var query = from tr in dbContext.TestResults
							join hndlr in dbContext.Handlers on tr.Handler equals hndlr.Id
							join dog in dbContext.Dogs on tr.Dog equals dog.Id
							select new ExportGridRow
							{
								TestResultId = tr.Id,
								HandlerName = hndlr.FirstName + " " + hndlr.LastName,
								DogName = dog.Name,
								TestDate = tr.TestDate
							};

				foreach (var row in query)
				{
					results.Add(row);
				}
			}
			catch (Exception oEx)
			{
				Debug.WriteLine($"Exception: {oEx.Message}");
			}

			return results;
		}

		public ExportGridRow GetExportableTest(Guid testResultId)
		{
			var result = new ExportGridRow();

			try
			{
				var query = from tr in dbContext.TestResults
							join hndlr in dbContext.Handlers on tr.Handler equals hndlr.Id
							join dog in dbContext.Dogs on tr.Dog equals dog.Id
							where tr.Id.Equals(testResultId)
							select new ExportGridRow
							{
								TestResultId = tr.Id,
								HandlerName = hndlr.FirstName + " " + hndlr.LastName,
								DogName = dog.Name,
								TestDate = tr.TestDate
							};

				result = query.FirstOrDefault() ?? new ExportGridRow();
			}
			catch (Exception oEx)
			{
				Debug.WriteLine($"Exception: {oEx.Message}");
			}

			return result;
		}

		private void DbContextLogCallback(string logstr)
		{
			Debug.WriteLine(logstr);
		}
	}
}