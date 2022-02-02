CREATE TABLE [dbo].[AssiduityMasterDataLink] (
    [id]             INT              IDENTITY (1, 1) NOT NULL,
    [dtCreate]       DATETIME         CONSTRAINT [DF_AssiduityMasterLink_dtCreate] DEFAULT (getdate()) NOT NULL,
    [idSource]       NVARCHAR (50)    CONSTRAINT [DF_AssiduityMasterLink_idSource] DEFAULT ((-1)) NOT NULL,
    [idTarget]       INT              NOT NULL,
    [dtUpdate]       DATETIME         NULL,
    [refCorrelation] UNIQUEIDENTIFIER CONSTRAINT [DF_AssiduityMasterLink_refCorrelation] DEFAULT (newid()) NOT NULL,
    [reference]      NCHAR (10)       CONSTRAINT [DF_AssiduityMasterLink_is_Deleted] DEFAULT ((0)) NOT NULL,
    [is_deleted]     BIT              NOT NULL,
    [trxSource]      NVARCHAR (50)    NOT NULL,
    [pendingRefId]   INT              NULL,
    [TimeStamp]      DATETIME         CONSTRAINT [DF_AssiduityMasterDataLink_TimeStamp] DEFAULT (getdate()) NOT NULL,
    [fk_environment] INT              CONSTRAINT [DF_AssiduityMasterDataLink_fk_environment] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_AssiduityMasterLink] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_AssiduityMasterDataLink_AssiduityMasterDataLink] FOREIGN KEY ([pendingRefId]) REFERENCES [dbo].[AssiduityMasterDataLink] ([id]),
    CONSTRAINT [FK_AssiduityMasterDataLink_Environment] FOREIGN KEY ([fk_environment]) REFERENCES [dbo].[Environment] ([id])
);

