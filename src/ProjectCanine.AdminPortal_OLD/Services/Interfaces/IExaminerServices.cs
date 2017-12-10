using System;
using System.Collections.Generic;
using ProjectCanine.AdminPortal_OLD.ViewModels;

namespace ProjectCanine.AdminPortal_OLD.Services
{
	public interface IExaminerServices
	{
		List<ExaminerGridRow> GetExaminers();
		ExaminerGridRow GetExaminer(Guid Id);
	}
}
