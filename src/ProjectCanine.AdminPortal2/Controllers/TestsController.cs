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
	public class TestsController : Controller
	{
		private ProjectCanine2Entities db = new ProjectCanine2Entities();

		// GET: Tests
		public ActionResult Index()
		{
			var tests = db.Tests.Include(t => t.Examiner);
			return View(tests.ToList());
		}

		// GET: Tests/Details/5
		public ActionResult Details(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Test test = db.Tests.Find(id);
			if (test == null)
			{
				return HttpNotFound();
			}
			return View(test);
		}

		// GET: Tests/Create
		public ActionResult Create()
		{
			ViewBag.LastEditedBy = new SelectList(db.Examiners, "Id", "FirstName");
			return View();
		}

		// POST: Tests/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,ShortName,Name,HandlerSignaturePrompt,LastEditedBy,LastEditedDate")] Test test)
		{
			if (ModelState.IsValid)
			{
				test.Id = Guid.NewGuid();
				db.Tests.Add(test);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			ViewBag.LastEditedBy = new SelectList(db.Examiners, "Id", "FirstName", test.LastEditedBy);
			return View(test);
		}

		// GET: Tests/Edit/5
		public ActionResult Edit(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Test test = db.Tests.Find(id);
			if (test == null)
			{
				return HttpNotFound();
			}
			ViewBag.LastEditedBy = new SelectList(db.Examiners, "Id", "FirstName", test.LastEditedBy);
			return View(test);
		}

		// POST: Tests/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,ShortName,Name,HandlerSignaturePrompt,LastEditedBy,LastEditedDate")] Test test)
		{
			if (ModelState.IsValid)
			{
				db.Entry(test).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			ViewBag.LastEditedBy = new SelectList(db.Examiners, "Id", "FirstName", test.LastEditedBy);
			return View(test);
		}

		// GET: Tests/Delete/5
		public ActionResult Delete(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Test test = db.Tests.Find(id);
			if (test == null)
			{
				return HttpNotFound();
			}
			return View(test);
		}

		// POST: Tests/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(Guid id)
		{
			Test test = db.Tests.Find(id);
			db.Tests.Remove(test);
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
