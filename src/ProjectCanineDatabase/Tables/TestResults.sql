CREATE TABLE [dbo].[TestResults]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
	[HandlersId] INT NOT NULL,
	[DogsId] INT NOT NULL,
	[PassFail] BIT NOT NULL,
	[TestDate] DATETIME NOT NULL,
	[PrimaryExaminer] INT NOT NULL,
	[SecondaryExaminer] INT NOT NULL
)
