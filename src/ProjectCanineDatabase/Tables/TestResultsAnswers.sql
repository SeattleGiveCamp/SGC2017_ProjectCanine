CREATE TABLE [dbo].[TestResultsAnswers]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
	[QuestionsId]	int not null,
	[TestResultsAnswersId]	int not null,
	[Answer]	varchar(2) not null,
	[YesNo]		bit not null DEFAULT 0
)
