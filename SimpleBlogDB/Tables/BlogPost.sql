CREATE TABLE [dbo].[BlogPost]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NULL, 
    [Content] NVARCHAR(MAX) NULL, 
    [Author] NVARCHAR(50) NULL, 
    [CreatedAt] DATETIME NULL
)
