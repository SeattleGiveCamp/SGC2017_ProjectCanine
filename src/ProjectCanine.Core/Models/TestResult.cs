using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ProjectCanine.Core.Models
{
	[DataContract]
	public class TestResult
	{
		[DataMember]
		public Guid Id { get; set; } // Id (Primary key)

		[DataMember]
		public Guid Test { get; set; } // Test

		[DataMember]
		public Guid Handler { get; set; } // Handler

		[DataMember]
		public Guid Dog { get; set; } // Dog

		[DataMember]
		public bool? PassedTest { get; set; } // PassedTest

		[DataMember]
		public string ReasonForFailure { get; set; } // ReasonForFailure (length: 5000)

		[DataMember]
		public string Notes { get; set; } // Notes (length: 5000)

		[DataMember]
		public bool PassedConnectingCanines { get; set; } = false; // PassedConnectingCanines

		[DataMember]
		public bool? ShadowVisitRequirement { get; set; } // ShadowVisitRequirement

		[DataMember]
		public bool EligibleToRetest { get; set; } = false; // EligibleToRetest

		[DataMember]
		public DateTime TestDate { get; set; } // TestDate

		[DataMember]
		public Guid ScoringExaminer { get; set; } // ScoringExaminer

		[DataMember]
		public Guid HandsOnExaminer { get; set; } // HandsOnExaminer

		[DataMember]
		public Guid? CertificationType { get; set; } // CertificationType

		[DataMember]
		public Guid? EquipmentRestrictions { get; set; } // EquipmentRestrictions

		[DataMember]
		public string OtherRestrictions { get; set; } // OtherRestrictions (length: 300)

		[DataMember]
		public bool PracticeLabRequirement { get; set; } = false; // PracticeLabRequirement

		[DataMember]
		public byte[] ScoringExaminerSignature { get; set; } // ScoringExaminerSignature

		[DataMember]
		public byte[] HandsOnSignature { get; set; } // HandsOnSignature

		[DataMember]
		public byte[] HandlerSignature { get; set; } // HandlerSignature	

		[DataMember]
		public List<TestResultAnswer> TestResultAnswers { get; set; }

		[DataMember]
		public List<TestResultSection> TestResultSections { get; set; }
	}
}