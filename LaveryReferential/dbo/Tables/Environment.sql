CREATE TABLE [dbo].[Environment] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [dtCreate]    DATETIME       CONSTRAINT [DF_Environment_dtCreate] DEFAULT (getdate()) NOT NULL,
    [dtUpdate]    DATETIME       NULL,
    [Code]        NVARCHAR (16)  NOT NULL,
    [Designation] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Environment] PRIMARY KEY CLUSTERED ([id] ASC)
);

