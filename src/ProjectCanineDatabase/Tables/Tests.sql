CREATE TABLE [dbo].[Tests]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
	[ShortName] VARCHAR(30) NOT NULL,
	[Name] VARCHAR(500) NOT NULL,
	[TestVersion_DateTime] DATETIME NOT NULL,
	[LastEditedBy] INT NOT NULL,
	[LastEditedDate] DATETIME NOT NULL
)
