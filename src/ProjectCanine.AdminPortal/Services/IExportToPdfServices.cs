using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectCanine.AdminPortal.ViewModels;


namespace ProjectCanine.AdminPortal.Services
{
	public interface IExportToPdfServices
	{
		Task<ExportGridData> GetExportableTests();
	}
}
