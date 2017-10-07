CREATE TABLE [dbo].[TestResultsAnswers]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
	[TestResult] INT NOT NULL,
	[Question] INT NOT NULL,
	[Answer] VARCHAR(2) NOT NULL,
	[YesNo] BIT NOT NULL DEFAULT 0
)
