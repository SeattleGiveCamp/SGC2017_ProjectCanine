ALTER TABLE [dbo].[TestResults]
	ADD CONSTRAINT [FKTestResults_EquipmentRestrictions]
	FOREIGN KEY (EquipmentRestrictions)
	REFERENCES [EquipmentRestrictions] (Id)
