using System;
using System.Runtime.Serialization;

namespace ProjectCanine.Core.Models
{
	[DataContract]
	public class TestResultSection
	{
		[DataMember]
		public Guid Id { get; set; } // Id (Primary key)

		[DataMember]
		public Guid TestResult { get; set; } // TestResult

		[DataMember]
		public Guid Section { get; set; } // Section

		[DataMember]
		public string Notes { get; set; } // Notes (length: 5000)
	}
}
