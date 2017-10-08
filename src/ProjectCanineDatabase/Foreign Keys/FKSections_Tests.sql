ALTER TABLE [dbo].[Sections]
	ADD CONSTRAINT [FKSections_Tests]
	FOREIGN KEY (Test)
	REFERENCES [Tests] (Id)
