CREATE TABLE [dbo].[InventoryInfo] (
    [ProductId]    INT        NOT NULL,
    [Price]        MONEY NULL,
    [CurrentStock] INT NULL,
    PRIMARY KEY CLUSTERED ([ProductId] ASC)
);

