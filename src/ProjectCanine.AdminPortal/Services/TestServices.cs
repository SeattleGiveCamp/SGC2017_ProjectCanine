using ProjectCanine.AdminPortal.Data;
using ProjectCanine.AdminPortal.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectCanine.AdminPortal.Services
{
	public class TestServices : ITestServices
	{
		private readonly ICanineProjDbContext dbContext;

		public TestServices(ICanineProjDbContext dbCtx)
		{
			dbContext = dbCtx ?? throw new ArgumentNullException(nameof(dbCtx));

			// lets see what SQL is getting generated.
			dbContext.Database.Log = DbContextLogCallback;
		}
		
		public List<TestGridRow> GetTests()
		{
			var results = new List<TestGridRow>();

			try
			{
				var query = from tests in dbContext.Tests
							join examiners in dbContext.Examiners on tests.LastEditedBy equals examiners.Id
							select new TestGridRow
							{
								Id = tests.Id,
								ShortName = tests.ShortName,
								Name = tests.Name,
								LastEditedBy = examiners.FirstName + " " + examiners.LastName,
								LastEditedDate = tests.LastEditedDate
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

		public TestGridRow GetTest(Guid Id)
		{
			var result = new TestGridRow();

			try
			{
				var query = from tests in dbContext.Tests
							join examiners in dbContext.Examiners on tests.LastEditedBy equals examiners.Id
							where tests.Id == Id
							select new TestGridRow
							{
								Id = tests.Id,
								ShortName = tests.ShortName,
								Name = tests.Name,
								HandlerSignaturePrompt = tests.HandlerSignaturePrompt,
								LastEditedBy = examiners.FirstName + " " + examiners.LastName,
								LastEditedDate = tests.LastEditedDate
							};

				result = query.FirstOrDefault() ?? new TestGridRow();
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