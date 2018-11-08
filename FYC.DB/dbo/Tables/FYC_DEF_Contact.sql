CREATE TABLE [dbo].[FYC_DEF_Contact] (
    [ID]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (150) NULL,
    [LastName]    NVARCHAR (150) NULL,
    [MiddleName]  NVARCHAR (150) NULL,
    [Address1]    NVARCHAR (500) NULL,
    [Address2]    NVARCHAR (500) NULL,
    [CityID]      BIGINT         NULL,
    [UserID]      BIGINT         NULL,
    [Phone]       NVARCHAR (20)  NULL,
    [CreatedDate] DATETIME       NULL,
    CONSTRAINT [PK_FYC_DEF_Contact] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_FYC_DEF_Contact_FYC_DEF_City] FOREIGN KEY ([CityID]) REFERENCES [dbo].[FYC_DEF_City] ([ID]),
    CONSTRAINT [FK_FYC_DEF_Contact_FYC_DEF_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[FYC_DEF_User] ([ID])
);

