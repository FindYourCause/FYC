CREATE TABLE [dbo].[FYC_DEF_Country] (
    [ID]                   BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]                 NVARCHAR (150) NULL,
    [TwoCharCountryCode]   NVARCHAR (50)  NULL,
    [ThreeCharCountryCode] NVARCHAR (50)  NULL,
    [Description]          NVARCHAR (500) NULL,
    [IsActive]             BIT            CONSTRAINT [DF_FYC_DEF_Country_IsActive] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_FYC_DEF_Country] PRIMARY KEY CLUSTERED ([ID] ASC)
);

