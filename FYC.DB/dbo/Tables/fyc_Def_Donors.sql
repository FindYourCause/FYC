CREATE TABLE [dbo].[fyc_Def_Donors] (
    [DonorID]        BIGINT         IDENTITY (1, 1) NOT NULL,
    [DonorName]      NVARCHAR (250) NULL,
    [Description]    NVARCHAR (500) NULL,
    [IsActive]       BIT            NULL,
    [ContactNumber]  BIGINT         NULL,
    [EmailID]        NVARCHAR (50)  NULL,
    [IsOrganization] BIT            NULL,
    [IsIndividual]   BIT            NULL,
    [IDCard]         NVARCHAR (30)  NULL,
    [ProfilePicture] NVARCHAR (100) NULL,
    [Attachment]     NVARCHAR (100) NULL,
    [CreatedDate]    DATE           NULL,
    [Extra]          NCHAR (10)     NULL,
    [Extra2]         NCHAR (10)     NULL,
    CONSTRAINT [PK_tbl_F] PRIMARY KEY CLUSTERED ([DonorID] ASC)
);

