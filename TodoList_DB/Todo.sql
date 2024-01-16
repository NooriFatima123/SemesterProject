CREATE TABLE [dbo].[Todo]
(
	[ItemId] INT NOT NULL IDENTITY PRIMARY KEY, 
    [Title] NVARCHAR(100) NULL, 
    [Desc] NVARCHAR(MAX) NULL, 
    [CreatedOn] DATETIME NULL, 
    [ModifyOn] DATETIME NULL, 
    [ListId] INT NULL, 
    [IsDeleted] BIT NULL DEFAULT 0, 
    [IsCompleted] BIT NULL DEFAULT 0
    CONSTRAINT [FK_Todo_List] FOREIGN KEY ([ListId]) REFERENCES [List]([ListId])
)
