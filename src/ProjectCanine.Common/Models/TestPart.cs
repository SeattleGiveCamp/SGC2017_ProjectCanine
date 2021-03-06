﻿using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ProjectCanine.Common.Models
{
	[DataContract]
    public class TestPart : IEntity
    {
		[DataMember]
		public int Id { get; set; }

		[DataMember]
		public int LastEditedBy { get; set; }	// Examiner.Id

		[DataMember]
		public DateTime LastEditedDate { get; set; }

		[DataMember]
		public Examiner Examiner { get; set; }
	}
}
