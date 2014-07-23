USE [master]
GO

IF  EXISTS (
	SELECT name 
		FROM sys.databases 
		WHERE name = N'TestDB'
)
DROP DATABASE TestDB
GO

Create Database TestDB
GO

Use [TestDB]
GO

CREATE TABLE [dbo].[College](
	[CollegeID] [int] NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
CONSTRAINT [PK_COLLEGE] PRIMARY KEY CLUSTERED 
(
	[CollegeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

Create Proc [dbo].[usp_College_Insert]
(
	@CollegeID int,
	@Name nvarchar(20)
)
AS 
INSERT INTO 
[College]([CollegeID],[Name])
VALUES( @CollegeID,@Name)
GO

Create Proc [dbo].[usp_College_LoadAll]
AS 
select  [CollegeID],[Name] from College
GO

Create Proc [dbo].[usp_College_Delete]
(
	@CollegeID int
)
AS
Begin Transaction T

Delete From [College]
Where 
CollegeID = @CollegeID 
GO

Create Proc [dbo].[usp_College_LoadByID]
(
	@CollegeID int
)
AS
select  [CollegeID],[Name] from College where CollegeID = @CollegeID 
GO

Create Proc [dbo].[usp_College_Update]
(
	@CollegeID int,
	@Name nvarchar(20)
)
AS
Update  [College] Set 
[Name] = @Name
where 
CollegeID = @CollegeID 
GO

INSERT INTO [College] ([CollegeID],[Name]) values (1,'电子工程学院')
GO
INSERT INTO [College] ([CollegeID],[Name]) values (2,'计信学院')
GO
INSERT INTO [College] ([CollegeID],[Name]) values (3,'物理学院')
GO
INSERT INTO [College] ([CollegeID],[Name]) values (4,'化工学院')
GO
INSERT INTO [College] ([CollegeID],[Name]) values (5,'美术学院')
GO