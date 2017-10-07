using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ProjectCanine
{
	[DataContract]
	public class Question : Entity
	{
		[DataMember]
		public int Test { get; set; }

		[DataMember]
		public string Text { get; set; }

		[DataMember]
		public bool MustPass { get; set; }

		[DataMember]
		public int SectionNumber { get; set; }

		[DataMember]
		public int QuestionNumber { get; set; }

		[DataMember]
		public bool HasYesNo { get; set; }
	}
}
