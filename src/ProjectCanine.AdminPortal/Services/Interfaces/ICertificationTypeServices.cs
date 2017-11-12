using System;
using System.Collections.Generic;
using ProjectCanine.AdminPortal.ViewModels;

namespace ProjectCanine.AdminPortal.Services
{
	public interface ICertificationTypeServices
	{
		List<CertificationTypeGridRow> GetCertificationTypes();
		CertificationTypeGridRow GetCertificationType(Guid Id);
	}
}
