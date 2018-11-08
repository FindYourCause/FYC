CREATE TABLE [dbo].[FYC_DEF_City] (
    [ID]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (150) NULL,
    [Description] NVARCHAR (500) NULL,
    [StateID]     BIGINT         NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PK_FYC_DEF_City] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_FYC_DEF_City_FYC_DEF_State] FOREIGN KEY ([StateID]) REFERENCES [dbo].[FYC_DEF_State] ([ID])
);

