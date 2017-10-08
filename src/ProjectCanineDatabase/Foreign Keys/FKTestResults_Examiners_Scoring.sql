ALTER TABLE [dbo].[TestResults]
	ADD CONSTRAINT [FKTestResults_Examiners_Scoring]
	FOREIGN KEY (ScoringExaminer)
	REFERENCES [Examiners] (Id)
