CREATE TABLE [dbo].[CollisionTracker] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [dtCreate]    DATETIME      CONSTRAINT [DF_CollisionTracker_dtCreate] DEFAULT (getdate()) NOT NULL,
    [hashValue]   INT           CONSTRAINT [DF_CollisionTracker_hashValue] DEFAULT ((-1)) NOT NULL,
    [Stream]      NVARCHAR (50) NOT NULL,
    [SensInbound] BIT           CONSTRAINT [DF_CollisionTracker_SensInbound] DEFAULT ((1)) NOT NULL,
    [memid]       INT           NULL,
    [GuidE3]      NVARCHAR (50) NULL,
    CONSTRAINT [PK_CollisionTracker] PRIMARY KEY CLUSTERED ([id] ASC)
);

