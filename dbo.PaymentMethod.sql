CREATE TABLE [dbo].[PaymentMethod] (
    [PaymentId]           INT        NOT NULL,
    [PaymentType]         VARCHAR(50) NULL,
    [CCNumber]            INT NULL,
    [BillingZipCode]      INT NULL,
    [BillingAddress]      VARBINARY(100) NULL,
    [CCExpDate]           NCHAR (10) NULL,
    [AuthorizationNumber] NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([PaymentId] ASC)
);

