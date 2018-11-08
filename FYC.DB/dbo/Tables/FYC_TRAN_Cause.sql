CREATE TABLE [dbo].[FYC_TRAN_Cause] (
    [ID]               BIGINT          IDENTITY (1, 1) NOT NULL,
    [Title]            NVARCHAR (150)  NULL,
    [Description]      NVARCHAR (1000) NULL,
    [IsOrganization]   BIT             NULL,
    [OrganizationName] NVARCHAR (150)  NULL,
    [Webiste]          NVARCHAR (150)  NULL,
    [CategoryID]       BIGINT          NULL,
    [UserID]           BIGINT          NULL,
    [CreatedBy]        BIGINT          NULL,
    [CreatedDate]      DATETIME        NULL,
    [ModifiedBy]       BIGINT          NULL,
    [ModifiedDate]     DATETIME        NULL,
    [IsActive]         BIT             NULL,
    CONSTRAINT [PK_FYC_TRAN_Cause] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_FYC_TRAN_Cause_Fyc_Def_Category] FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[FYC_DEF_Category] ([CategoryID]),
    CONSTRAINT [FK_FYC_TRAN_Cause_FYC_DEF_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[FYC_DEF_User] ([ID])
);

