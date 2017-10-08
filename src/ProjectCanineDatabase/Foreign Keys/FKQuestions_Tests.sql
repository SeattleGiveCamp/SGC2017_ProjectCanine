ALTER TABLE [dbo].[Questions]
	ADD CONSTRAINT [FKQuestions_Tests]
	FOREIGN KEY (Test)
	REFERENCES [Tests] (Id)