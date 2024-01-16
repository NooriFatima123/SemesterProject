CREATE TABLE [dbo].[List]
(
	
	[ListId] INT NOT NULL IDENTITY PRIMARY KEY, 
    [Title] NVARCHAR(200) NULL, 
    [UserId] INT NULL, 
    [CreatedOn] DATETIME NULL

    CONSTRAINT [FK_List_User] FOREIGN KEY ([UserId]) REFERENCES [User]([UserId])
)
