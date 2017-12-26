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
    [AuthorizeRoles("Users", "SuperUsers")]
    public class TestResultsController : Controller
	{
		private ProjectCanine2Entities db = new ProjectCanine2Entities();

		// GET: TestResults
		public ActionResult Index()
		{
			var testResults = db.TestResults.Include(t => t.CertificationType1).Include(t => t.Dog1).Include(t => t.EquipmentRestriction).Include(t => t.Examiner).Include(t => t.Examiner1).Include(t => t.Handler1).Include(t => t.Test1);
			return View(testResults.ToList());
		}

		// GET: TestResults/Details/5
		public ActionResult Details(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			TestResult testResult = db.TestResults.Find(id);
			if (testResult == null)
			{
				return HttpNotFound();
			}
			return View(testResult);
		}

		// GET: TestResults/Create
		public ActionResult Create()
		{
			ViewBag.CertificationType = new SelectList(db.CertificationTypes, "Id", "Name");
			ViewBag.Dog = new SelectList(db.Dogs, "Id", "Name");
			ViewBag.EquipmentRestrictions = new SelectList(db.EquipmentRestrictions, "Id", "Name");
			ViewBag.HandsOnExaminer = new SelectList(db.Examiners, "Id", "FirstName");
			ViewBag.ScoringExaminer = new SelectList(db.Examiners, "Id", "FirstName");
			ViewBag.Handler = new SelectList(db.Handlers, "Id", "FirstName");
			ViewBag.Test = new SelectList(db.Tests, "Id", "ShortName");
			return View();
		}

		// POST: TestResults/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,Test,Handler,Dog,PassedTest,ReasonForFailure,Notes,PassedConnectingCanines,ShadowVisitRequirement,EligibleToRetest,TestDate,ScoringExaminer,HandsOnExaminer,CertificationType,EquipmentRestrictions,OtherRestrictions,PracticeLabRequirement,ScoringExaminerSignature,HandsOnSignature,HandlerSignature")] TestResult testResult)
		{
			if (ModelState.IsValid)
			{
				testResult.Id = Guid.NewGuid();
				db.TestResults.Add(testResult);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			ViewBag.CertificationType = new SelectList(db.CertificationTypes, "Id", "Name", testResult.CertificationType);
			ViewBag.Dog = new SelectList(db.Dogs, "Id", "Name", testResult.Dog);
			ViewBag.EquipmentRestrictions = new SelectList(db.EquipmentRestrictions, "Id", "Name", testResult.EquipmentRestrictions);
			ViewBag.HandsOnExaminer = new SelectList(db.Examiners, "Id", "FirstName", testResult.HandsOnExaminer);
			ViewBag.ScoringExaminer = new SelectList(db.Examiners, "Id", "FirstName", testResult.ScoringExaminer);
			ViewBag.Handler = new SelectList(db.Handlers, "Id", "FirstName", testResult.Handler);
			ViewBag.Test = new SelectList(db.Tests, "Id", "ShortName", testResult.Test);
			return View(testResult);
		}

		// GET: TestResults/Edit/5
		public ActionResult Edit(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			TestResult testResult = db.TestResults.Find(id);
			if (testResult == null)
			{
				return HttpNotFound();
			}
			ViewBag.CertificationType = new SelectList(db.CertificationTypes, "Id", "Name", testResult.CertificationType);
			ViewBag.Dog = new SelectList(db.Dogs, "Id", "Name", testResult.Dog);
			ViewBag.EquipmentRestrictions = new SelectList(db.EquipmentRestrictions, "Id", "Name", testResult.EquipmentRestrictions);
			ViewBag.HandsOnExaminer = new SelectList(db.Examiners, "Id", "FirstName", testResult.HandsOnExaminer);
			ViewBag.ScoringExaminer = new SelectList(db.Examiners, "Id", "FirstName", testResult.ScoringExaminer);
			ViewBag.Handler = new SelectList(db.Handlers, "Id", "FirstName", testResult.Handler);
			ViewBag.Test = new SelectList(db.Tests, "Id", "ShortName", testResult.Test);
			return View(testResult);
		}

		// POST: TestResults/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,Test,Handler,Dog,PassedTest,ReasonForFailure,Notes,PassedConnectingCanines,ShadowVisitRequirement,EligibleToRetest,TestDate,ScoringExaminer,HandsOnExaminer,CertificationType,EquipmentRestrictions,OtherRestrictions,PracticeLabRequirement,ScoringExaminerSignature,HandsOnSignature,HandlerSignature")] TestResult testResult)
		{
			if (ModelState.IsValid)
			{
				db.Entry(testResult).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			ViewBag.CertificationType = new SelectList(db.CertificationTypes, "Id", "Name", testResult.CertificationType);
			ViewBag.Dog = new SelectList(db.Dogs, "Id", "Name", testResult.Dog);
			ViewBag.EquipmentRestrictions = new SelectList(db.EquipmentRestrictions, "Id", "Name", testResult.EquipmentRestrictions);
			ViewBag.HandsOnExaminer = new SelectList(db.Examiners, "Id", "FirstName", testResult.HandsOnExaminer);
			ViewBag.ScoringExaminer = new SelectList(db.Examiners, "Id", "FirstName", testResult.ScoringExaminer);
			ViewBag.Handler = new SelectList(db.Handlers, "Id", "FirstName", testResult.Handler);
			ViewBag.Test = new SelectList(db.Tests, "Id", "ShortName", testResult.Test);
			return View(testResult);
		}

		// GET: TestResults/Delete/5
		public ActionResult Delete(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			TestResult testResult = db.TestResults.Find(id);
			if (testResult == null)
			{
				return HttpNotFound();
			}
			return View(testResult);
		}

		// POST: TestResults/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(Guid id)
		{
			TestResult testResult = db.TestResults.Find(id);
			db.TestResults.Remove(testResult);
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
