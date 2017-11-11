using System;
using System.Collections.Generic;
using ProjectCanine.AdminPortal.ViewModels;

namespace ProjectCanine.AdminPortal.Services
{
	public interface ITestServices
	{
		List<TestGridRow> GetTests();
		TestGridRow GetTest(Guid Id);
	}
}
