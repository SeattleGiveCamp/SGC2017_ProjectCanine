using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SimpleInjector;


namespace ProjectCanine.AdminPortal.Controllers
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