ALTER TABLE [dbo].[TestResultsAnswers]
	ADD CONSTRAINT [FKTestResultsAnswers_Questions]
	FOREIGN KEY (Question)
	REFERENCES [Questions] (Id)
