CREATE TABLE [dbo].[FYC_SYS_Role] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Role]        NVARCHAR (100) NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            CONSTRAINT [DF_FYC_SYS_Role_IsActive] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_FYC_SYS_Role] PRIMARY KEY CLUSTERED ([ID] ASC)
);

