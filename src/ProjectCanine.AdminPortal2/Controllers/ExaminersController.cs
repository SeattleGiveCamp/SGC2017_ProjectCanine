using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectCanine.AdminPortal2.Models;

namespace ProjectCanine.AdminPortal2.Controllers
{
	public class ExaminersController : Controller
	{
		private ProjectCanine2Entities db = new ProjectCanine2Entities();

		// GET: Examiners
		public ActionResult Index()
		{
			return View(db.Examiners.ToList());
		}

		// GET: Examiners/Details/5
		public ActionResult Details(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Examiner examiner = db.Examiners.Find(id);
			if (examiner == null)
			{
				return HttpNotFound();
			}
			return View(examiner);
		}

		// GET: Examiners/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Examiners/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,FirstName,LastName")] Examiner examiner)
		{
			if (ModelState.IsValid)
			{
				examiner.Id = Guid.NewGuid();
				db.Examiners.Add(examiner);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(examiner);
		}

		// GET: Examiners/Edit/5
		public ActionResult Edit(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Examiner examiner = db.Examiners.Find(id);
			if (examiner == null)
			{
				return HttpNotFound();
			}
			return View(examiner);
		}

		// POST: Examiners/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,FirstName,LastName")] Examiner examiner)
		{
			if (ModelState.IsValid)
			{
				db.Entry(examiner).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(examiner);
		}

		// GET: Examiners/Delete/5
		public ActionResult Delete(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Examiner examiner = db.Examiners.Find(id);
			if (examiner == null)
			{
				return HttpNotFound();
			}
			return View(examiner);
		}

		// POST: Examiners/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(Guid id)
		{
			Examiner examiner = db.Examiners.Find(id);
			db.Examiners.Remove(examiner);
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
