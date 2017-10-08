using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ProjectCanine.Core.Models
{
    public class Person : IEntity
	{
		[DataMember]
		public Guid Id { get; set; }

		[DataMember]
		public string FirstName { get; set; }

		[DataMember]
		public string LastName { get; set; }
	}
}
