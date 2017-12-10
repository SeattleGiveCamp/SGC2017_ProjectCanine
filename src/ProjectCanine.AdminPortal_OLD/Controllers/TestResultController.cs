using ProjectCanine.AdminPortal_OLD.Data;
using ProjectCanine.AdminPortal_OLD.Services;
using ProjectCanine.AdminPortal_OLD.ViewModels;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProjectCanine.AdminPortal_OLD.Controllers
{
	public class TestResultController : Controller
	{
		private readonly ICanineProjDbContext dbContext;
		private readonly ITestResultServices testResultServices;

		public TestResultController(ICanineProjDbContext dbCtx, ITestResultServices testResultSvcs)
		{
			dbContext = dbCtx ?? throw new ArgumentNullException(nameof(dbCtx));
			testResultServices = testResultSvcs ?? throw new ArgumentNullException(nameof(testResultSvcs));
		}

		// GET: TestResults
		public async Task<ActionResult> Index()
		{
			var viewModel = testResultServices.GetTestResults();

			return View(viewModel);
		}

		// GET: Test/Details/{Guid}
		public ActionResult Details(Guid id)
		{
			if (id == Guid.Empty)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}

			TestResultGridRow testResultGridRow = testResultServices.GetTestResult(id);

			if (testResultGridRow == null)
			{
				return HttpNotFound();
			}

			return View(testResultGridRow);
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
