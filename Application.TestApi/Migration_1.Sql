--Add NoMatch and SingleMatch columns	
ALTER TABLE [dbo].[Configuration]
ADD NoMatch bit,
	SingleMatch bit
GO

--Update Stored Procedure Insert operation to include NoMatch and SingleMatch values
ALTER PROCEDURE [dbo].[UpsertConfig]
	@Environment nvarchar(10),
	@Provider nvarchar(10),
	@TimeOut int,
	@StackTrace bit,
	@Exception bit,
	@NoMatch bit,
	@SingleMatch bit,
	@MultipleMatch bit,
	@NoTrace bit
AS 
SET NOCOUNT ON;
declare @EnvId int;
Select TOP 1 @EnvId = [ID] from [dbo].Environment where Name = @Environment
if (@EnvId IS NULL) BEGIN
	insert into [dbo].[Environment] values (@Environment)
	SET @EnvId=SCOPE_IDENTITY()
END
declare @ProviderId int;
Select TOP 1 @ProviderId = [ID] from [dbo].Provider where Name = @Provider and EnvID = @EnvId
if (@ProviderId IS NULL) BEGIN
	insert into [dbo].Provider values (@envId,@Provider)
	SET @ProviderId=SCOPE_IDENTITY()
END

Declare @ConfigId int;
Select TOP 1 @ConfigId = [ID] from [dbo].Configuration where ProviderId = @ProviderId
if (@ConfigId IS NOT NULL) BEGIN
	update [dbo].Configuration set TimeOutMs = @TimeOut, Exception = @Exception, StackTrace = @StackTrace, NoMatch = @NoMatch, 
	SingleMatch = @SingleMatch, MultipleMatch = @MultipleMatch, NoTrace = @NoTrace
END
else BEGIN
insert into [dbo].Configuration
(ProviderId, TimeOutMs, Exception, StackTrace, NoTrace, MultipleMatch, NoMatch, SingleMatch)
values
(@ProviderId,@TimeOut,@Exception,@StackTrace,@NoTrace,@MultipleMatch,@NoMatch,@SingleMatch)
END

GO