CREATE TABLE [dbo].[TBLOCACOESPENDENTES]
(
	[Id]          INT           IDENTITY (1, 1) NOT NULL, 
    [NomeCliente] VARCHAR(100) NOT NULL,
    [IdVeiculo] VARCHAR (100) NOT NULL,
    [DataLocacao] DATETIME NOT NULL, 
    [DataDevolucao] DATETIME NOT NULL
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
