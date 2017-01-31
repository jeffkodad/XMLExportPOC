CREATE TABLE [dbo].[Organization]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[DBA] NVARCHAR(200) NULL, 
    [PartyId] INT NULL, 
    [OrgForm] NVARCHAR(50) NULL, 
    [TC_OrgForm] INT NULL, 
    [FileName] NVARCHAR(100) NULL
)
