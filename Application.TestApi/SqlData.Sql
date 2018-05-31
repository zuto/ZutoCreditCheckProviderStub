--Create Environment table

/****** Object:  Table [dbo].[Environment]    Script Date: 6/1/2017 11:49:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Environment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](10) NULL,
 CONSTRAINT [PK_Environment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--Create Table Provider
/****** Object:  Table [dbo].[Provider]    Script Date: 6/1/2017 11:50:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Provider](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EnvID] [int] NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Provider] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Provider]  WITH CHECK ADD  CONSTRAINT [FK_Provider_Environment] FOREIGN KEY([EnvID])
REFERENCES [dbo].[Environment] ([ID])
GO

ALTER TABLE [dbo].[Provider] CHECK CONSTRAINT [FK_Provider_Environment]
GO


--Create Configuration Table

/****** Object:  Table [dbo].[Configuration]    Script Date: 6/1/2017 11:48:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Configuration](
	[ProviderId] [int] NOT NULL,
	[TimeOutMs] [int] NOT NULL,
	[Exception] [bit] NOT NULL,
	[StackTrace] [bit] NOT NULL,
	[NoTrace] [bit] NOT NULL,
	[MultipleMatch] [bit] NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NoMatch] [bit] NULL,
	[SingleMatch] [bit] NULL,
	[RNILF04Score] [int] NULL,
	[FTILF04Score] [int] NULL,
	[RNILF01Score] [int] NULL,
	[INOSF04Score] [int] NULL,
	ThrowValidationFaultException BIT NOT NULL
 CONSTRAINT [PK_Configuration] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Configuration]  WITH CHECK ADD  CONSTRAINT [FK_Configuration_Provider] FOREIGN KEY([ProviderId])
REFERENCES [dbo].[Provider] ([ID])
GO

ALTER TABLE [dbo].[Configuration] CHECK CONSTRAINT [FK_Configuration_Provider]
GO

--Create Stored Procedure

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpsertConfig]
	@Environment nvarchar(10),
	@Provider nvarchar(10),
	@TimeOut int,
	@StackTrace bit,
	@Exception bit,
	@NoMatch bit,
	@SingleMatch bit,
	@MultipleMatch bit,
	@NoTrace bit,
	@RNILF04Score int,
	@FTILF04Score int,
	@RNILF01Score int,
	@INOSF04Score int,
	@ThrowValidationFaultException bit
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
	SingleMatch = @SingleMatch, MultipleMatch = @MultipleMatch, NoTrace = @NoTrace, 
	RNILF04Score = @RNILF04Score, FTILF04Score = @FTILF04Score, RNILF01Score = @RNILF01Score, INOSF04Score = @INOSF04Score, ThrowValidationFaultException = @ThrowValidationFaultException
END
else BEGIN
insert into [dbo].Configuration
(ProviderId, TimeOutMs, Exception, StackTrace, NoTrace, MultipleMatch, NoMatch, SingleMatch, RNILF04Score, FTILF04Score, RNILF01Score, INOSF04Score, ThrowValidationFaultException)
values
(@ProviderId,@TimeOut,@Exception,@StackTrace,@NoTrace,@MultipleMatch,@NoMatch,@SingleMatch,@RNILF04Score,@FTILF04Score,@RNILF01Score,@INOSF04Score, @ThrowValidationFaultException)
END

