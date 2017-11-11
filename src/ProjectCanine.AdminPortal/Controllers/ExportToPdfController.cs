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
using ProjectCanine.AdminPortal.ViewModels;


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

		// GET: ExportToPdf/Details/{Guid}
		public ActionResult Details(Guid TestResultId)
		{
			if (TestResultId == Guid.Empty)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}

			ExportGridRow egr = exportServices.GetExportableTest(TestResultId);

			if (egr == null)
			{
				return HttpNotFound();
			}

			return View(egr);
		}

		// in case Deletion wants to be added to the page.
		//// GET: TestResults/Delete/5
		//public async Task<ActionResult> Delete(Guid? id)
		//{
		//    if (id == null)
		//    {
		//        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
		//    }
		//    TestResult testResult = await dbContext.TestResults.FindAsync(id);
		//    if (testResult == null)
		//    {
		//        return HttpNotFound();
		//    }
		//    return View(testResult);
		//}

		//// POST: TestResults/Delete/5
		//[HttpPost, ActionName("Delete")]
		//[ValidateAntiForgeryToken]
		//public async Task<ActionResult> DeleteConfirmed(Guid id)
		//{
		//    TestResult testResult = await dbContext.TestResults.FindAsync(id);
		//    dbContext.TestResults.Remove(testResult);
		//    await dbContext.SaveChangesAsync();
		//    return RedirectToAction("Index");
		//}

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
