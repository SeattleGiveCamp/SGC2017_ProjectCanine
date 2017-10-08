CREATE TABLE [dbo].[Tests]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[ShortName] VARCHAR(30) NOT NULL,
	[Name] VARCHAR(500) NOT NULL,
	[HandlerSignatureText] VARCHAR(1000) NOT NULL,
	[LastEditedBy] UNIQUEIDENTIFIER NOT NULL,
	[LastEditedDate] DATETIME NOT NULL DEFAULT GetDate()
)
GO

ALTER TABLE [dbo].[Tests] ADD CONSTRAINT FK_Tests_Examiners
FOREIGN KEY (LastEditedBy) REFERENCES [dbo].Examiners (Id);
GO
