CREATE TABLE [dbo].[Tests]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
	[ShortName] VARCHAR(30) NOT NULL,
	[Name] VARCHAR(500) NOT NULL,
	[LastEditedBy] int NOT NULL,
	[LastEditedDate] DATETIME NOT NULL DEFAULT GetDate()
);
GO

ALTER TABLE [dbo].[Tests] ADD CONSTRAINT FK_Tests_Examiners
FOREIGN KEY (LastEditedBy) REFERENCES [dbo].Examiners (Id);
GO
