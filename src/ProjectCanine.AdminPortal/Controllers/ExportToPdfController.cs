using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;

using Microsoft.Ajax.Utilities;

using ProjectCanine.AdminPortal.Data;
using ProjectCanine.AdminPortal.Data.Entities;
using ProjectCanine.AdminPortal.Services;


namespace ProjectCanine.AdminPortal.Controllers
{
    public class ExportToPdfController : Controller
    {
	    private readonly ICanineProjDbContext dbContext;
	    private readonly IExportToPdfServices exportServices;

		public ExportToPdfController(
		    ICanineProjDbContext dbCtx,
			IExportToPdfServices exportSvcs)
	    {
		    if (dbCtx == null)
		    {
			    throw new ArgumentNullException(nameof(dbCtx));
		    }
		    dbContext = dbCtx;

		    if (exportSvcs == null)
		    {
			    throw new ArgumentNullException(nameof(exportSvcs));
		    }
		    exportServices = exportSvcs;
	    }

        // GET: TestResults
        public async Task<ActionResult> Index()
        {
	        var viewModel = exportServices.GetExportableTests();

            return View(viewModel);
        }

        // GET: TestResults/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestResult testResult = await dbContext.TestResults.FindAsync(id);
            if (testResult == null)
            {
                return HttpNotFound();
            }
            return View(testResult);
        }

        // GET: TestResults/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestResults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Handler,Dog,PassedTest,TestDate,ScoringExaminer,HandsOnExaminer,CertificationType,EquipmentRestrictions,ScoringExaminerSignature,HandsOnSignature,HandlerSignature")] TestResult testResult)
        {
            if (ModelState.IsValid)
            {
                testResult.Id = Guid.NewGuid();
                dbContext.TestResults.Add(testResult);
                await dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(testResult);
        }

        // GET: TestResults/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestResult testResult = await dbContext.TestResults.FindAsync(id);
            if (testResult == null)
            {
                return HttpNotFound();
            }
            return View(testResult);
        }

        // POST: TestResults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Handler,Dog,PassedTest,TestDate,ScoringExaminer,HandsOnExaminer,CertificationType,EquipmentRestrictions,ScoringExaminerSignature,HandsOnSignature,HandlerSignature")] TestResult testResult)
        {
            if (ModelState.IsValid)
            {
                dbContext.Entry(testResult).State = EntityState.Modified;
                await dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(testResult);
        }

        // GET: TestResults/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestResult testResult = await dbContext.TestResults.FindAsync(id);
            if (testResult == null)
            {
                return HttpNotFound();
            }
            return View(testResult);
        }

        // POST: TestResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            TestResult testResult = await dbContext.TestResults.FindAsync(id);
            dbContext.TestResults.Remove(testResult);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dbContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
