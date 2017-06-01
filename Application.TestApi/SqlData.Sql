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

/****** Object:  StoredProcedure [dbo].[UpsertConfiguration]    Script Date: 5/31/2017 6:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[UpsertConfiguration]
	@ProviderId int,
	@TimeOut int,
	@Exception bit,
	@StackTrace bit,
	@NoTrace bit,
	@MultipleMatch bit,
	@ID int output
AS
SET NOCOUNT ON;
Select TOP 1 @ID = [ID] from [dbo].Configuration where ProviderId = @providerId
if (@Id IS NOT NULL) BEGIN
	update [dbo].Configuration set TimeOutMs = @TimeOut, Exception = @Exception, StackTrace = @StackTrace, NoTrace = @NoTrace, MultipleMatch = @MultipleMatch
END
else BEGIN
insert into [dbo].Configuration values (@providerId,@TimeOut,@Exception,@StackTrace,@NoTrace,@MultipleMatch)
	SET @ID=SCOPE_IDENTITY()
END
return @ID

Select  * from  [dbo].[Configuration] with (NOLOCK) 
select * from Provider
select * from Environment

GO
 DECLARE @kill varchar(max) = '';
 SELECT @kill = @kill + 'BEGIN TRY KILL ' + CONVERT(varchar(5), spid) + ';' + ' END TRY BEGIN CATCH END CATCH ;' FROM master..sysprocesses 
EXEC (@kill)



