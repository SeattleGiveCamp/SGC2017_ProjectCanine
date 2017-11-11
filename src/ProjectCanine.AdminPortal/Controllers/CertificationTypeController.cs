using ProjectCanine.AdminPortal.Data;
using ProjectCanine.AdminPortal.Services;
using ProjectCanine.AdminPortal.ViewModels;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProjectCanine.AdminPortal.Controllers
{
	public class CertificationTypeController : Controller
	{
		private readonly ICanineProjDbContext dbContext;
		private readonly ICertificationTypeServices certificationTypeServices;

		public CertificationTypeController(ICanineProjDbContext dbCtx, ICertificationTypeServices certificationTypeSvcs)
		{
			dbContext = dbCtx ?? throw new ArgumentNullException(nameof(dbCtx));
			certificationTypeServices = certificationTypeSvcs ?? throw new ArgumentNullException(nameof(certificationTypeSvcs));
		}

		// GET: TestResults
		public async Task<ActionResult> Index()
		{
			var viewModel = certificationTypeServices.GetCertificationTypes();

			return View(viewModel);
		}

		// GET: ExportToPdf/Details/{Guid}
		public ActionResult Details(Guid id)
		{
			if (id == Guid.Empty)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}

			CertificationTypeGridRow certificationTypeGridRow = certificationTypeServices.GetCertificationType(id);

			if (certificationTypeGridRow == null)
			{
				return HttpNotFound();
			}

			return View(certificationTypeGridRow);
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
