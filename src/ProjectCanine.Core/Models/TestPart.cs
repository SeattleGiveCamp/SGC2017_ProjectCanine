using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ProjectCanine.Core.Models
{
	[DataContract]
    public class TestPart : IEntity
    {
		[DataMember]
		public Guid Id { get; set; }

		[DataMember]
		public int LastEditedBy { get; set; }	// Examiner.Id

		[DataMember]
		public DateTime LastEditedDate { get; set; }

		[DataMember]
		public Examiner Examiner { get; set; }
	}
}
