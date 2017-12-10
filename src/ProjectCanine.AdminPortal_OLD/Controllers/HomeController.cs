using System.Web.Mvc;

namespace ProjectCanine.AdminPortal_OLD.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Canine Project - Admin Portal";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Canine Project - Admin Portal - Contact page";

			return View();
		}
	}
}