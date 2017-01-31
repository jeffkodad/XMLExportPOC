CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [FirstName] NVARCHAR(200) NULL, 
    [MiddleName] NVARCHAR(200) NULL, 
    [LastName] NVARCHAR(200) NULL, 
	[Suffix] NVARCHAR(50) NULL,
    [Gender] NVARCHAR(50) NULL, 
    [BirthDate] NVARCHAR(50) NULL, 
    [Age] INT NULL, 
    [TC_Gender] INT NULL, 
    [PollNumber] NCHAR(10) NULL, 
    [PartyID] NCHAR(10) NULL, 
    [FileName] NVARCHAR(50) NULL
)
