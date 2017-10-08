CREATE TABLE [dbo].[TestResults]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[Test] UNIQUEIDENTIFIER NOT NULL,
	[Handler] UNIQUEIDENTIFIER NOT NULL,
	[Dog] UNIQUEIDENTIFIER NOT NULL,
	[PassedTest] BIT NULL,
	[ReasonForFailure] VARCHAR(5000) NULL,
	[Notes] VARCHAR(5000) NULL,
	[PassedConnectingCanines] BIT NOT NULL DEFAULT 0,
	[ShadowVisitRequirement] BIT NULL,
	[EligibleToRetest] BIT NOT NULL DEFAULT 0,
	[TestDate] DATETIME NOT NULL,
	[ScoringExaminer] UNIQUEIDENTIFIER NOT NULL,
	[HandsOnExaminer] UNIQUEIDENTIFIER NOT NULL,
	[CertificationType] UNIQUEIDENTIFIER NULL,
	[EquipmentRestrictions] UNIQUEIDENTIFIER NULL,
	[OtherRestrictions] VARCHAR(300) NULL,
	[PracticeLabRequirement] BIT NOT NULL DEFAULT 0,
	[ScoringExaminerSignature] VARBINARY(MAX) NULL,
	[HandsOnSignature] VARBINARY(MAX) NULL,
	[HandlerSignature] VARBINARY(MAX) NULL
)
