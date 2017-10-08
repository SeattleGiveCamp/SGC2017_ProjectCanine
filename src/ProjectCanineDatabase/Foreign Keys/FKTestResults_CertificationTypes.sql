ALTER TABLE [dbo].[TestResults]
	ADD CONSTRAINT [FKTestResults_CertificationTypes]
	FOREIGN KEY (CertificationType)
	REFERENCES [CertificationTypes] (Id)
