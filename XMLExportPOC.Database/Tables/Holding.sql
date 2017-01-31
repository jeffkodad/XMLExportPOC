CREATE TABLE [dbo].[Holding]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [PollNumber] NVARCHAR(50) NULL, 
    [HoldingTypeCode] NVARCHAR(100) NULL, 
    [HoldingStatus] NVARCHAR(50) NULL, 
    [TC_HoldingTypeCode] BIGINT NULL, 
    [AsOfDate] CHAR(10) NULL, 
    [FileName] NVARCHAR(50) NULL, 
    [TC_HoldingStatus] BIGINT NULL
)
