ALTER TABLE [dbo].[OtherRestrictions]
	ADD CONSTRAINT [FKOtherRestrictions_TestResult]
	FOREIGN KEY (TestResult)
	REFERENCES [TestResults] (Id)
