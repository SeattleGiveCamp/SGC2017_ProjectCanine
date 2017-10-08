ALTER TABLE [dbo].[TestResults]
	ADD CONSTRAINT [FKTestResults_Handlers]
	FOREIGN KEY (Handler)
	REFERENCES [Handlers] (Id)
