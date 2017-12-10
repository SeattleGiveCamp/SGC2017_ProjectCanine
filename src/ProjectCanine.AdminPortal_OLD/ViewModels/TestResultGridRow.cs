using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectCanine.AdminPortal_OLD.ViewModels
{
	public class TestResultGridRow
	{
		public Guid Id { get; set; }

		[Display(Name = "Short Name")]
		public string ShortName { get; set; }

		[Display(Name = "Handler")]
		public string Handler { get; set; }

		[Display(Name = "Dog")]
		public string Dog { get; set; }

		[Display(Name = "Passed")]
		public bool? Passed { get; set; }

		[Display(Name = "Resaon For Failure")]
		public string ResaonForFailure { get; set; }

		[Display(Name = "Notes")]
		public string Notes { get; set; }

		[Display(Name = "Shadow Visit Requirement")]
		public bool? ShadowVisitRequirement { get; set; }

		[Display(Name = "Eligible To Retest")]
		public bool EligibleToRetest { get; set; }

		[Display(Name = "Test Date")]
		public DateTime TestDate { get; set; }

		[Display(Name = "Scoring Examiner")]
		public string ScoringExaminer { get; set; }

		[Display(Name = "Hands On Examiner")]
		public string HandsOnExaminer { get; set; }

		[Display(Name = "Certification Type")]
		public string CertificationType { get; set; }

		[Display(Name = "Equipment Restrictions")]
		public string EquipmentRestrictions { get; set; }

		[Display(Name = "Other Restrictions")]
		public string OtherRestrictions { get; set; }

		[Display(Name = "Practice Lab Requirement")]
		public bool PracticeLabRequirement { get; set; }

		[Display(Name = "Test Results Sections")]
		public List<TestResultSectionGridRow> TestResultsSections { get; set; }
	}
}
