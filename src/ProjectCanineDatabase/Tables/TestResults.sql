CREATE TABLE [dbo].[TestResults]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
	[Handler] INT NOT NULL,
	[Dog] INT NOT NULL,
	[PassedTest] BIT NULL,
	[TestDate] DATETIME NOT NULL,
	[ScoringExaminer] INT NOT NULL,
	[HandsOnExaminer] INT NOT NULL,
	[CertificationType] INT NULL,
	[EquipmentRestrictions] INT NULL,
	[ScoringExaminerSignature] VARBINARY(MAX) NULL,
	[HandsOnSignature] VARBINARY(MAX) NULL,
	[HandlerSignature] VARBINARY(MAX) NULL
)
