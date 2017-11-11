using ProjectCanine.AdminPortal.Data;
using ProjectCanine.AdminPortal.Services;
using ProjectCanine.AdminPortal.ViewModels;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace ProjectCanine.AdminPortal.Controllers
{
	public class ExportToPdfController : Controller
	{
		private readonly ICanineProjDbContext dbContext;
		private readonly IExportToPdfServices exportServices;

		public ExportToPdfController(ICanineProjDbContext dbCtx, IExportToPdfServices exportSvcs)
		{
			dbContext = dbCtx ?? throw new ArgumentNullException(nameof(dbCtx));
			exportServices = exportSvcs ?? throw new ArgumentNullException(nameof(exportSvcs));
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
