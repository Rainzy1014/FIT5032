CREATE TABLE [dbo].[Users](
	[Id] int IDENTITY(1,1) NOT NULL,
	[Email] nvarchar(max) NOT NULL,
	[Location] nvarchar(max) NOT NULL,
	[UserId] nvarchar(max) NOT NULL,
	PRIMARY KEY (Id)
);
GO
