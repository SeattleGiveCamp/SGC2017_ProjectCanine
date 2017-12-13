using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectCanine.AdminPortal.Models;

namespace ProjectCanine.AdminPortal.Controllers
{
	public class EquipmentRestrictionsController : Controller
	{
		private ProjectCanine2Entities db = new ProjectCanine2Entities();

		// GET: EquipmentRestrictions
		public ActionResult Index()
		{
			return View(db.EquipmentRestrictions.ToList());
		}

		// GET: EquipmentRestrictions/Details/5
		public ActionResult Details(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			EquipmentRestriction equipmentRestriction = db.EquipmentRestrictions.Find(id);
			if (equipmentRestriction == null)
			{
				return HttpNotFound();
			}
			return View(equipmentRestriction);
		}

		// GET: EquipmentRestrictions/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: EquipmentRestrictions/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,Name")] EquipmentRestriction equipmentRestriction)
		{
			if (ModelState.IsValid)
			{
				equipmentRestriction.Id = Guid.NewGuid();
				db.EquipmentRestrictions.Add(equipmentRestriction);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(equipmentRestriction);
		}

		// GET: EquipmentRestrictions/Edit/5
		public ActionResult Edit(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			EquipmentRestriction equipmentRestriction = db.EquipmentRestrictions.Find(id);
			if (equipmentRestriction == null)
			{
				return HttpNotFound();
			}
			return View(equipmentRestriction);
		}

		// POST: EquipmentRestrictions/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,Name")] EquipmentRestriction equipmentRestriction)
		{
			if (ModelState.IsValid)
			{
				db.Entry(equipmentRestriction).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(equipmentRestriction);
		}

		// GET: EquipmentRestrictions/Delete/5
		public ActionResult Delete(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			EquipmentRestriction equipmentRestriction = db.EquipmentRestrictions.Find(id);
			if (equipmentRestriction == null)
			{
				return HttpNotFound();
			}
			return View(equipmentRestriction);
		}

		// POST: EquipmentRestrictions/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(Guid id)
		{
			EquipmentRestriction equipmentRestriction = db.EquipmentRestrictions.Find(id);
			db.EquipmentRestrictions.Remove(equipmentRestriction);
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
