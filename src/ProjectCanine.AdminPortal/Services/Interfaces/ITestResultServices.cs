using System;
using System.Collections.Generic;
using ProjectCanine.AdminPortal.ViewModels;

namespace ProjectCanine.AdminPortal.Services
{
	public interface ITestResultServices
	{
		List<TestResultGridRow> GetTestResults();
		TestResultGridRow GetTestResult(Guid Id);
	}
}
