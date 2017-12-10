using System.Web;
using System.Web.Mvc;

namespace ProjectCanine.AdminPortal_OLD
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
