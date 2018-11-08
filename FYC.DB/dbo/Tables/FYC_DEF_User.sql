CREATE TABLE [dbo].[FYC_DEF_User] (
    [ID]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [Email]       NVARCHAR (200) NULL,
    [Password]    NVARCHAR (200) NULL,
    [Mobile]      NVARCHAR (20)  NULL,
    [IsActive]    BIT            NULL,
    [RoleID]      INT            NULL,
    [CreatedDate] DATETIME       NULL,
    CONSTRAINT [PK_FYC_DEF_User] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_FYC_DEF_User_FYC_SYS_Role] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[FYC_SYS_Role] ([ID])
);

