CREATE TABLE [dbo].[fyc_Def_Beneficiary] (
    [BeneficiaryID]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [BeneficiaryName] NVARCHAR (250) NULL,
    [Description]     NVARCHAR (500) NULL,
    [IsActive]        BIT            NULL,
    [ContactNumber]   BIGINT         NULL,
    [EmailID]         NVARCHAR (50)  NULL,
    [BeneficiaryType] NVARCHAR (250) NULL,
    [IDCard]          NVARCHAR (30)  NULL,
    [ProfilePicture]  NVARCHAR (100) NULL,
    [Attachment]      NVARCHAR (100) NULL,
    [CreatedDate]     DATE           NULL,
    [Extra]           NCHAR (10)     NULL,
    [Extra2]          NCHAR (10)     NULL,
    CONSTRAINT [PK_tbl_FYCBeneficiary] PRIMARY KEY CLUSTERED ([BeneficiaryID] ASC)
);

