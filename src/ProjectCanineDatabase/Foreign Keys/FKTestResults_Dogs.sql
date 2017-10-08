ALTER TABLE [dbo].[TestResults]
	ADD CONSTRAINT [FKTestResults_Dogs]
	FOREIGN KEY (Dog)
	REFERENCES [Dogs] (Id)
