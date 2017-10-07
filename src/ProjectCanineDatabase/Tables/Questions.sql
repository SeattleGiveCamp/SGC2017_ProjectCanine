﻿CREATE TABLE [dbo].[Questions]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
	[Test] INT NOT NULL,
	[Text] VARCHAR(1000) NOT NULL,
	[MustPass] BIT NOT NULL DEFAULT 0,
	[SectionNumber] INT NOT NULL,
	[QuestionNumber] INT NOT NULL,
	[HasYesNo] BIT NOT NULL DEFAULT 0,
	[LastEditedBy] VARCHAR(255) NULL,
	[LastEditedDate] DATETIME NOT NULL DEFAULT GetDate()
);
GO
ALTER TABLE [dbo].[Questions] ADD CONSTRAINT FK_Questions_Tests
	FOREIGN KEY (Test) REFERENCES [dbo].[Tests] (Id);
GO