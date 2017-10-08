using System;
using System.Collections.Generic;
using ProjectCanine.AdminPortal.ViewModels;


namespace ProjectCanine.AdminPortal.Services
{
	public interface IExportToPdfServices
	{
		List<ExportGridRow> GetExportableTests();
		ExportGridRow GetExportableTest(Guid testResultId);
	}
}
