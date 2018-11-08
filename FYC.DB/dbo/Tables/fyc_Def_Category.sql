CREATE TABLE [dbo].[fyc_Def_Category] (
    [CategoryID]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [CategoryName] NVARCHAR (250) NULL,
    [Description]  NVARCHAR (500) NULL,
    [IsActive]     BIT            NULL,
    [CreatedBY]    BIGINT         NULL,
    [CreatedDate]  DATE           NULL,
    [ModifiedBY]   BIGINT         NULL,
    [ModifiedDate] DATE           NULL,
    CONSTRAINT [PK_tbl_FYCCategory] PRIMARY KEY CLUSTERED ([CategoryID] ASC)
);

