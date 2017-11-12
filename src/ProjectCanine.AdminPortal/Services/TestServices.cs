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
			var testsList = new List<TestGridRow>();

			try
			{
				var testQuery = from tests in dbContext.Tests
					join examiners in dbContext.Examiners on tests.LastEditedBy equals examiners.Id
					select new TestGridRow
					{
						Id = tests.Id,
						ShortName = tests.ShortName,
						Name = tests.Name,
						LastEditedBy = examiners.FirstName + " " + examiners.LastName,
						LastEditedDate = tests.LastEditedDate
					};
				testsList = testQuery.ToList();
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Exception: {e.Message}");
			}
			return testsList;
		}

		public TestGridRow GetTest(Guid Id)
		{
			var test = new TestGridRow();

			// Get the test
			try
			{
				var testQuery = from tests in dbContext.Tests
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
				test = testQuery.FirstOrDefault() ?? new TestGridRow();

				// Get the sections
				var sectionsList = new List<SectionGridRow>();
				var sectionsQuery = from sections in dbContext.Sections
					join examiners in dbContext.Examiners on sections.LastEditedBy equals examiners.Id
					where sections.Test == Id
					orderby sections.SectionNumber ascending
					select new SectionGridRow
					{
						Id = sections.Id,
						SectionNumber = sections.SectionNumber,
						Title = sections.Title,
						Description = sections.Description,
						LastEditedBy = examiners.FirstName + " " + examiners.LastName,
						LastEditedDate = sections.LastEditedDate
					};
				sectionsList = sectionsQuery.ToList();

				// Get the questions per section
				foreach (var section in sectionsList)
				{
					var questionsQuery = from questions in dbContext.Questions
						join examiners in dbContext.Examiners on questions.LastEditedBy equals examiners.Id
						where questions.Section == section.Id
						orderby questions.QuestionNumber ascending
						select new QuestionGridRow
						{
							Id = questions.Id,
							Text = questions.Text,
							MustPass = questions.MustPass,
							QuestionNumber = questions.QuestionNumber,
							HasYesNo = questions.HasYesNo,
							LastEditedBy = examiners.FirstName + " " + examiners.LastName,
							LastEditedDate = questions.LastEditedDate
							};

					// Add the questions to the section
					section.Questions = questionsQuery.ToList();
				}

				// Add the sections to the test
				test.Sections = sectionsList;
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Exception: {e.Message}");
			}
			return test;
		}

		private void DbContextLogCallback(string logstr)
		{
			Debug.WriteLine(logstr);
		}
	}
}