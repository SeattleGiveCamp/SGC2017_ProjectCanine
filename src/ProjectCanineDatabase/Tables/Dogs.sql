﻿CREATE TABLE [dbo].[Dogs]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT (NEWID()),
	[Name] VARCHAR(200) NOT NULL
)
