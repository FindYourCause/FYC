CREATE TABLE [dbo].[FYC_TRAN_CauseAttachment] (
    [ID]             BIGINT         IDENTITY (1, 1) NOT NULL,
    [AttachmentName] NVARCHAR (150) NULL,
    [Description]    NVARCHAR (500) NULL,
    [CauseID]        BIGINT         NULL,
    [CreatedBy]      BIGINT         NULL,
    [CreatedDate]    DATETIME       NULL,
    [ModifiedBy]     BIGINT         NULL,
    [ModifiedDate]   DATETIME       NULL,
    CONSTRAINT [PK_FYC_TRAN_CauseAttachment] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_FYC_TRAN_CauseAttachment_FYC_TRAN_Cause] FOREIGN KEY ([CauseID]) REFERENCES [dbo].[FYC_TRAN_Cause] ([ID])
);

