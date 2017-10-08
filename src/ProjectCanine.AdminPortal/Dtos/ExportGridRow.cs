using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectCanine.AdminPortal.Dtos
{
	public class ExportGridRow
	{
		public string HandlerName { get; set; }
		public string DogName { get; set; }
		public DateTime TestDate { get; set; }
	}
}
