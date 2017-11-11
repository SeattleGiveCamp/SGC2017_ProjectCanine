using System;
using System.Runtime.Serialization;

namespace ProjectCanine.Core.Models
{
	[DataContract]
	public class TestResultAnswer
	{
		[DataMember]
		public Guid Id { get; set; } // Id (Primary key)

		[DataMember]
		public Guid TestResult { get; set; } // TestResult

		[DataMember]
		public Guid Question { get; set; } // Question

		[DataMember]
		public string Answer { get; set; } // Answer (length: 2)

		[DataMember]
		public bool YesNo { get; set; } = false; // YesNo
	}
}