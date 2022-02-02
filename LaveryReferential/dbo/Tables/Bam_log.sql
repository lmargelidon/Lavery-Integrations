CREATE TABLE [dbo].[Bam_log] (
    [id]             INT              IDENTITY (1, 1) NOT NULL,
    [dtCreate]       DATETIME         CONSTRAINT [DF_Bam_log_dtCreate] DEFAULT (getdate()) NOT NULL,
    [dtUpdate]       DATETIME         NULL,
    [refGuid]        UNIQUEIDENTIFIER NOT NULL,
    [comment]        NVARCHAR (MAX)   NULL,
    [dtEvent]        DATETIME         NULL,
    [EventLevel]     NVARCHAR (64)    NOT NULL,
    [User]           NVARCHAR (64)    NOT NULL,
    [CategoryType]   NVARCHAR (64)    NOT NULL,
    [CategoryName]   NVARCHAR (64)    CONSTRAINT [DF_Bam_log_ListenerName] DEFAULT (N'Service') NOT NULL,
    [Computer]       NVARCHAR (64)    NOT NULL,
    [Module]         NVARCHAR (64)    NOT NULL,
    [ClassName]      NVARCHAR (64)    NOT NULL,
    [MethodName]     NVARCHAR (64)    NOT NULL,
    [pipeline]       NVARCHAR (64)    CONSTRAINT [DF_Bam_log_pipeline] DEFAULT ('') NOT NULL,
    [fk_Environment] INT              CONSTRAINT [DF_Bam_log_fk_Environment] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_Bam_log] PRIMARY KEY CLUSTERED ([id] ASC)
);

