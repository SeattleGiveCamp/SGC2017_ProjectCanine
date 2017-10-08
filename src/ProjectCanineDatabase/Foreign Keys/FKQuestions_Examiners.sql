ALTER TABLE [dbo].[Questions]
	ADD CONSTRAINT [FKQuestions_Examiners]
	FOREIGN KEY (LastEditedBy)
	REFERENCES [Examiners] (Id)