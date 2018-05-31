--Add NoMatch and SingleMatch columns	
ALTER TABLE [dbo].[Configuration]
ADD ThrowValidationFaultException bit
GO

UPDATE [dbo].[Configuration]
SET ThrowValidationFaultException = 0

GO