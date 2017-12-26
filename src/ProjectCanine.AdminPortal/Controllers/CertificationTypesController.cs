using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectCanine.AdminPortal.Models;
using ProjectCanine.AdminPortal.Infrastructure;

namespace ProjectCanine.AdminPortal.Controllers
{
    [AuthorizeRoles("Users","SuperUsers")]
    public class CertificationTypesController : Controller
	{
		private ProjectCanine2Entities db = new ProjectCanine2Entities();

		// GET: CertificationTypes
		public ActionResult Index()
		{
			return View(db.CertificationTypes.ToList());
		}

		// GET: CertificationTypes/Details/5
		public ActionResult Details(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			CertificationType certificationType = db.CertificationTypes.Find(id);
			if (certificationType == null)
			{
				return HttpNotFound();
			}
			return View(certificationType);
		}

		// GET: CertificationTypes/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: CertificationTypes/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,Name")] CertificationType certificationType)
		{
			if (ModelState.IsValid)
			{
				certificationType.Id = Guid.NewGuid();
				db.CertificationTypes.Add(certificationType);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(certificationType);
		}

		// GET: CertificationTypes/Edit/5
		public ActionResult Edit(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			CertificationType certificationType = db.CertificationTypes.Find(id);
			if (certificationType == null)
			{
				return HttpNotFound();
			}
			return View(certificationType);
		}

		// POST: CertificationTypes/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,Name")] CertificationType certificationType)
		{
			if (ModelState.IsValid)
			{
				db.Entry(certificationType).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(certificationType);
		}

		// GET: CertificationTypes/Delete/5
		public ActionResult Delete(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			CertificationType certificationType = db.CertificationTypes.Find(id);
			if (certificationType == null)
			{
				return HttpNotFound();
			}
			return View(certificationType);
		}

		// POST: CertificationTypes/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(Guid id)
		{
			CertificationType certificationType = db.CertificationTypes.Find(id);
			db.CertificationTypes.Remove(certificationType);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
