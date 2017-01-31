CREATE TABLE [dbo].[Parties]
(
	[PartyId] INT NOT NULL PRIMARY KEY Identity, 
    [PartyTypeCode] NVARCHAR(50) NULL, 
	[FullName] NVARCHAR(200) NULL,
    [GovtIDTC] INT NULL, 
    [GovtID] NVARCHAR(100) NULL, 
    [OrganizationTC] INT NULL,
	[ResidentState] NVARCHAR(200) NULL,
	[ResidentCountry] NVARCHAR(200) NULL, 
    [TC_PartyTypeCode] BIGINT NULL
)
