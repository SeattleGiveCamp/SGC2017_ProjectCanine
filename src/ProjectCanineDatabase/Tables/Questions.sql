CREATE TABLE [dbo].[Questions]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
	[Test] INT NOT NULL,
	[Text] VARCHAR(1000) NOT NULL,
	[MustPass] BIT NOT NULL DEFAULT 0,
	[SectionNumber] INT NOT NULL,
	[QuestionNumber] INT NOT NULL,
	[HasYesNo] BIT NOT NULL DEFAULT 0,
	[LastEditedBy] INT NULL,
	[LastEditedDate] DATETIME NULL DEFAULT GetDate()
)
