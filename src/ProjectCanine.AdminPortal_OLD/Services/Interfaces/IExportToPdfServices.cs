using System;
using System.Collections.Generic;
using ProjectCanine.AdminPortal_OLD.ViewModels;

namespace ProjectCanine.AdminPortal_OLD.Services
{
	public interface IExportToPdfServices
	{
		List<ExportGridRow> GetExportableTests();
		ExportGridRow GetExportableTest(Guid testResultId);
	}
}
