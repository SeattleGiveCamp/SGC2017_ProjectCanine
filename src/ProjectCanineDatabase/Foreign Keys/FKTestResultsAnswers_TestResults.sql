ALTER TABLE [dbo].[TestResultsAnswers]
	ADD CONSTRAINT [FKTestResultsAnswers_TestResults]
	FOREIGN KEY (TestResult)
	REFERENCES [TestResults] (Id)
