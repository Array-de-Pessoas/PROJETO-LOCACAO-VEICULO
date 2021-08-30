CREATE TABLE [dbo].[TBCARROSALUGADOS] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [NomeCliente]  VARCHAR (100) NOT NULL,
    [IdVeiculo] VARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

