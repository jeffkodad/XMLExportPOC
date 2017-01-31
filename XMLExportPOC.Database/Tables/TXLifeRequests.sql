CREATE TABLE [dbo].[TXLifeRequests]
(
	[TXLifeRequestId] INT NOT NULL PRIMARY KEY Identity, 
    [PollNumber] NVARCHAR(50) NULL, 
    [TransType] NVARCHAR(50) NULL, 
    [TC_TransType] INT NULL, 
    [TransRefGUID] BIGINT NULL, 
    [TransExeDate] NVARCHAR(50) NULL, 
    [TransExeTime] NVARCHAR(50) NULL, 
    [FileName] NVARCHAR(50) NULL
)
