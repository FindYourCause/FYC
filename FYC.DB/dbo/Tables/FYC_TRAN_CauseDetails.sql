CREATE TABLE [dbo].[FYC_TRAN_CauseDetails] (
    [ID]                BIGINT         NOT NULL,
    [CauseID]           BIGINT         NULL,
    [Address1]          NVARCHAR (500) NULL,
    [Address2]          NVARCHAR (500) NULL,
    [Address3]          NVARCHAR (500) NULL,
    [PANCardNumber]     NVARCHAR (50)  NULL,
    [BankName]          NVARCHAR (150) NULL,
    [BranchName]        NVARCHAR (150) NULL,
    [BankIFSCCode]      NVARCHAR (150) NULL,
    [BankAccountNumber] NVARCHAR (150) NULL,
    [BankAccountHolder] NVARCHAR (150) NULL,
    [AadhaarNumber]     NVARCHAR (50)  NULL,
    [VoterID]           NVARCHAR (150) NULL,
    [CreatedBy]         BIGINT         NULL,
    [CreatedDate]       DATETIME       NULL,
    [ModifiedBy]        BIGINT         NULL,
    [ModifiedDate]      DATETIME       NULL,
    CONSTRAINT [PK_FYC_TRAN_CauseDetails] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_FYC_TRAN_CauseDetails_FYC_TRAN_Cause] FOREIGN KEY ([CauseID]) REFERENCES [dbo].[FYC_TRAN_Cause] ([ID])
);

