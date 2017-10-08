ALTER TABLE [dbo].[Questions]
	ADD CONSTRAINT [FKQuestions_Sections]
	FOREIGN KEY (Section)
	REFERENCES [Sections] (Id)
