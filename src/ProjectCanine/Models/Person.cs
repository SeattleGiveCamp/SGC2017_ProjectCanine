using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ProjectCanine
{
    public class Person
	{
		[DataMember]
		public int Id { get; set; }

		[DataMember]
		public string FirstName { get; set; }

		[DataMember]
		public string LastName { get; set; }
	}
}
