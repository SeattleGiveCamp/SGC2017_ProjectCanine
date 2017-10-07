CREATE TABLE [dbo].[TestResults]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
	[HandlersId] int not null,
	[DogsId]	int not null,
	[PassFail]	bit not null,
	[TestDate]	datetime not null,
	[PrimaryExaminer]	int not null,
	[SecondaryExaminer]	int not null
)
