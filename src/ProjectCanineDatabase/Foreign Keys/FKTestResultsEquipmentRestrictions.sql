ALTER TABLE [dbo].[TestResults]
	ADD CONSTRAINT [FKTestResultsEquipmentRestrictions]
	FOREIGN KEY (EquipmentRestrictions)
	REFERENCES [EquipmentRestrictions] (Id)
