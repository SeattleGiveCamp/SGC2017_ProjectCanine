using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ProjectCanine
{
	[DataContract]
    public class Entity 
    {
		[DataMember]
		public int Id { get; set; }

		[DataMember]
		public string LastEditedBy { get; set; }

		[DataMember]
		public DateTime LastEditedDate { get; set; }
	}
}
