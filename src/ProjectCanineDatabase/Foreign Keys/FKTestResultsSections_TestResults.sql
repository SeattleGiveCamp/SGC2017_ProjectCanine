ALTER TABLE [dbo].[TestResultsSections]
	ADD CONSTRAINT [FKTestResultsSections_TestResults]
	FOREIGN KEY (TestResult)
	REFERENCES [TestResults] (Id)
