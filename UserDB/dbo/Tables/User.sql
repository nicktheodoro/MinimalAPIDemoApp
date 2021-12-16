﻿CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Age] INT NOT NULL, 
    [RoleId] INT NOT NULL,
    CONSTRAINT FK_User_Role FOREIGN KEY (RoleId)
        REFERENCES dbo.[Role] (Id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
)
