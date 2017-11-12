using System;
using System.Collections.Generic;
using ProjectCanine.AdminPortal.ViewModels;

namespace ProjectCanine.AdminPortal.Services
{
	public interface IExaminerServices
	{
		List<ExaminerGridRow> GetExaminers();
		ExaminerGridRow GetExaminer(Guid Id);
	}
}
