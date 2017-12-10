using System;
using System.Collections.Generic;
using ProjectCanine.AdminPortal_OLD.ViewModels;

namespace ProjectCanine.AdminPortal_OLD.Services
{
	public interface ICertificationTypeServices
	{
		List<CertificationTypeGridRow> GetCertificationTypes();
		CertificationTypeGridRow GetCertificationType(Guid Id);
	}
}
