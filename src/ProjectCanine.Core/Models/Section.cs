using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ProjectCanine.Core.Models
{
	[DataContract]
	public class Section : TestPart
	{
		[DataMember]
		public Guid Test { get; set; }

		[DataMember]
		public int SectionNumber { get; set; }

		[DataMember]
		public string Title { get; set; }

		[DataMember]
		public string Description { get; set; }

		[DataMember]
		public List<Question> Questions { get; set; }
	}
}
