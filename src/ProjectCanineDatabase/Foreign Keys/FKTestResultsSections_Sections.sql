ALTER TABLE [dbo].[TestResultsSections]
	ADD CONSTRAINT [FKTestResultsSections_Sections]
	FOREIGN KEY (Section)
	REFERENCES [Sections] (Id)
