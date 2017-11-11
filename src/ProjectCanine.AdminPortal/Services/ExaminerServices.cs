using ProjectCanine.AdminPortal.Data;
using ProjectCanine.AdminPortal.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectCanine.AdminPortal.Services
{
	public class ExaminerServices : IExaminerServices
	{
		private readonly ICanineProjDbContext dbContext;

		public ExaminerServices(ICanineProjDbContext dbCtx)
		{
			dbContext = dbCtx ?? throw new ArgumentNullException(nameof(dbCtx));

			// lets see what SQL is getting generated.
			dbContext.Database.Log = DbContextLogCallback;
		}
		
		public List<ExaminerGridRow> GetExaminers()
		{
			var results = new List<ExaminerGridRow>();

			try
			{
				var query = from examiners in dbContext.Examiners
							select new ExaminerGridRow
							{
								Id = examiners.Id,
								FirstName = examiners.FirstName,
								LastName = examiners.LastName
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

		public ExaminerGridRow GetExaminer(Guid Id)
		{
			var result = new ExaminerGridRow();

			try
			{
				var query = from examiners in dbContext.Examiners
							where examiners.Id == Id
							select new ExaminerGridRow
							{
								Id = examiners.Id,
								FirstName = examiners.FirstName,
								LastName = examiners.LastName
							};

				result = query.FirstOrDefault() ?? new ExaminerGridRow();
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