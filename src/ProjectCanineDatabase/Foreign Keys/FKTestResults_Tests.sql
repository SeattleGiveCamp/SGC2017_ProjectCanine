ALTER TABLE [dbo].[TestResults]
	ADD CONSTRAINT [FKTestResults_Tests]
	FOREIGN KEY (Test)
	REFERENCES [Tests] (Id)
