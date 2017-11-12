using ProjectCanine.AdminPortal.Data;
using ProjectCanine.AdminPortal.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectCanine.AdminPortal.Services
{
	public class TestResultServices : ITestResultServices
	{
		private readonly ICanineProjDbContext dbContext;

		public TestResultServices(ICanineProjDbContext dbCtx)
		{
			dbContext = dbCtx ?? throw new ArgumentNullException(nameof(dbCtx));

			// lets see what SQL is getting generated.
			dbContext.Database.Log = DbContextLogCallback;
		}
		
		public List<TestResultGridRow> GetTestResults()
		{
			var testResultsList = new List<TestResultGridRow>();

			try
			{
				var testResultsQuery = from testResults in dbContext.TestResults
					join tests in dbContext.Tests on testResults.Test equals tests.Id
					join handlers in dbContext.Handlers on testResults.Handler equals handlers.Id
					join dogs in dbContext.Dogs on testResults.Dog equals dogs.Id
					join scoringExaminers in dbContext.Examiners on testResults.ScoringExaminer equals scoringExaminers.Id
					join handsOnExaminers in dbContext.Examiners on testResults.HandsOnExaminer equals handsOnExaminers.Id
					orderby testResults.TestDate descending
					select new TestResultGridRow
					{
						Id = testResults.Id,
						ShortName = tests.ShortName,
						Handler = handlers.FirstName + " " + handlers.LastName,
						Dog = dogs.Name,
						Passed = testResults.PassedTest,
						TestDate = testResults.TestDate,
						ScoringExaminer = scoringExaminers.FirstName + " " + scoringExaminers.LastName,
						HandsOnExaminer = handsOnExaminers.FirstName + " " + handsOnExaminers.LastName
					};

				testResultsList = testResultsQuery.ToList();
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Exception: {e.Message}");
			}
			return testResultsList;
		}

		public TestResultGridRow GetTestResult(Guid Id)
		{
			var testResult = new TestResultGridRow();

			// Get the test
			try
			{
				var testResultQuery = from testResults in dbContext.TestResults
					join tests in dbContext.Tests on testResults.Test equals tests.Id
					join handlers in dbContext.Handlers on testResults.Handler equals handlers.Id
					join dogs in dbContext.Dogs on testResults.Dog equals dogs.Id
					join scoringExaminers in dbContext.Examiners on testResults.ScoringExaminer equals scoringExaminers.Id
					join handsOnExaminers in dbContext.Examiners on testResults.HandsOnExaminer equals handsOnExaminers.Id
					join certificationTypes in dbContext.CertificationTypes on testResults.CertificationType equals certificationTypes.Id
					join equipmentRestrictions in dbContext.EquipmentRestrictions on testResults.EquipmentRestrictions equals equipmentRestrictions.Id
					orderby testResults.TestDate descending
					select new TestResultGridRow
					{
						Id = testResults.Id,
						ShortName = tests.ShortName,
						Handler = handlers.FirstName + " " + handlers.LastName,
						Dog = dogs.Name,
						Passed = testResults.PassedTest,
						ResaonForFailure = testResults.ReasonForFailure,
						Notes = testResults.Notes,
						ShadowVisitRequirement = testResults.ShadowVisitRequirement,
						EligibleToRetest = testResults.EligibleToRetest,
						TestDate = testResults.TestDate,
						ScoringExaminer = scoringExaminers.FirstName + " " + scoringExaminers.LastName,
						HandsOnExaminer = handsOnExaminers.FirstName + " " + handsOnExaminers.LastName,
						CertificationType = certificationTypes.Name,
						EquipmentRestrictions = equipmentRestrictions.Name,
						OtherRestrictions = testResult.OtherRestrictions,
						PracticeLabRequirement = testResults.PracticeLabRequirement
					};
				testResult = testResultQuery.FirstOrDefault() ?? new TestResultGridRow();

				//// Get the sections
				var testResultsSectionsList = new List<TestResultSectionGridRow>();
				var testResultsSectionsQuery = from testResultsSections in dbContext.TestResultsSections
					join sections in dbContext.Sections on testResultsSections.Section equals sections.Id
					where testResultsSections.TestResult == Id
					orderby sections.SectionNumber ascending
					select new TestResultSectionGridRow
					{
						Id = testResultsSections.Id,
						SectionNumber = sections.SectionNumber,
						Title = sections.Title,
						Notes = testResultsSections.Notes
					};
				testResultsSectionsList = testResultsSectionsQuery.ToList();

				// Get the questions per section
				foreach (var testResultsSection in testResultsSectionsList)
				{
					var testResultsAsnwersQuery = from testResultsAnswers in dbContext.TestResultsAnswers
						join questions in dbContext.Questions on testResultsAnswers.Question equals questions.Id
						where questions.Section == testResultsSection.Id
						orderby questions.QuestionNumber ascending
						select new TestResultsAnswerGridRow
						{
							Id = testResultsAnswers.Id,
							Text = questions.Text,
							MustPass = questions.MustPass,
							QuestionNumber = questions.QuestionNumber,
							Answer = testResultsAnswers.Answer,
							YesNo = questions.HasYesNo ? (bool?)testResultsAnswers.YesNo : null
						};

					// Add the questions to the section
					testResultsSection.TestResultsAnswers = testResultsAsnwersQuery.ToList();
				}

				// Add the sections to the test
				testResult.TestResultsSections = testResultsSectionsList;
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Exception: {e.Message}");
			}
			return testResult;
		}

		private void DbContextLogCallback(string logstr)
		{
			Debug.WriteLine(logstr);
		}
	}
}