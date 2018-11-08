CREATE TABLE [dbo].[FYC_DEF_State] (
    [ID]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CountryID]   BIGINT         NULL,
    [Name]        NVARCHAR (150) NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PK_FYC_DEF_State] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_FYC_DEF_State_FYC_DEF_Country] FOREIGN KEY ([CountryID]) REFERENCES [dbo].[FYC_DEF_Country] ([ID])
);

