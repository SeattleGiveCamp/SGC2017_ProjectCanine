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
				var query = from tr in dbContext.Tests
							select new TestGridRow
							{
								Id = tr.Id,
								ShortName = tr.ShortName,
								Name = tr.Name,
								LastEditedBy = tr.LastEditedBy,
								LastEditedDate = tr.LastEditedDate
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
				var query = from tr in dbContext.Tests
							select new TestGridRow
							{
								Id = tr.Id,
								ShortName = tr.ShortName,
								Name = tr.Name,
								HandlerSignaturePrompt = tr.HandlerSignaturePrompt,
								LastEditedBy = tr.LastEditedBy,
								LastEditedDate = tr.LastEditedDate
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