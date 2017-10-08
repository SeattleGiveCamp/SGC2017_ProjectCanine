ALTER TABLE [dbo].[TestResults]
	ADD CONSTRAINT [FKTestResults_Examiners_HandsOn]
	FOREIGN KEY (HandsOnExaminer)
	REFERENCES [Examiners] (Id)
