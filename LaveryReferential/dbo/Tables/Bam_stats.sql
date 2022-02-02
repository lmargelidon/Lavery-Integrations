CREATE TABLE [dbo].[Bam_stats] (
    [id]                   INT              IDENTITY (1, 1) NOT NULL,
    [dtCreate]             DATETIME         CONSTRAINT [DF_Bam_stats_dtCreate] DEFAULT (getdate()) NOT NULL,
    [dtUpdate]             DATETIME         NULL,
    [refGuid]              UNIQUEIDENTIFIER NOT NULL,
    [elapse_millisecondes] INT              NOT NULL,
    [CategoryName]         NVARCHAR (50)    CONSTRAINT [DF_Bam_stats_CategoryName] DEFAULT (N'Service') NOT NULL,
    [fk_Environment]       INT              CONSTRAINT [DF_Bam_stats_Environment] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_Bam_stats] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Bam_stats_Environment] FOREIGN KEY ([fk_Environment]) REFERENCES [dbo].[Environment] ([id])
);

