using System;
using System.Collections.Generic;
using ProjectCanine.AdminPortal_OLD.ViewModels;

namespace ProjectCanine.AdminPortal_OLD.Services
{
	public interface ITestServices
	{
		List<TestGridRow> GetTests();
		TestGridRow GetTest(Guid Id);
	}
}
