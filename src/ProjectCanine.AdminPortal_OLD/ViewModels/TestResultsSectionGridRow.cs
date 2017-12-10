using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectCanine.AdminPortal_OLD.ViewModels
{
	public class TestResultSectionGridRow
	{
		public Guid Id { get; set; }

		[Display(Name = "TestResult")]
		public int TestResult { get; set; }

		[Display(Name = "Section Number")]
		public int SectionNumber { get; set; }

		[Display(Name = "Title")]
		public string Title { get; set; }

		[Display(Name = "Notes")]
		public String Notes { get; set; }
		
		[Display(Name = "Test Results Answers")]
		public List<TestResultsAnswerGridRow> TestResultsAnswers { get; set; }
	}
}
