CREATE TABLE [dbo].[AssiduityDetailDataLink] (
    [id]        INT            IDENTITY (1, 1) NOT NULL,
    [dtCreate]  DATETIME       CONSTRAINT [DF_AssiduityDetailDataLink_dtCreate] DEFAULT (getdate()) NOT NULL,
    [dtUpdate]  DATETIME       NULL,
    [idMaster]  INT            NOT NULL,
    [detailTrx] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_AssiduityDetailDataLink] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_AssiduityDetailDataLink_AssiduityMasterDataLink] FOREIGN KEY ([idMaster]) REFERENCES [dbo].[AssiduityMasterDataLink] ([id]) ON DELETE CASCADE
);

