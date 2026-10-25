CREATE TABLE [dbo].[Cart] (
    [CartId]     INT        NOT NULL,
    [CustomerId] INT NOT NULL,
    [ProductId]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([CartId] ASC) 
);

