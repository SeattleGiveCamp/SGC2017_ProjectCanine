ALTER TABLE [dbo].[Tests]
	ADD CONSTRAINT [FKTests_Examiners]
	FOREIGN KEY (LastEditedBy)
	REFERENCES [Examiners] (Id)
