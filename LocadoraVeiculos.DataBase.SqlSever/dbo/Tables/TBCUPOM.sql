CREATE TABLE [dbo].[TBCUPOM]
(
	[Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Codigo] NVARCHAR(100) NOT NULL, 
    [Tipo] NVARCHAR(100) NOT NULL, 
    [Valor] DECIMAL(18, 2) NOT NULL, 
    [ValorMinimo] DECIMAL(18, 2) NOT NULL, 
    [Parceiro] NVARCHAR(100) NOT NULL, 
    [DiaVencimento] DATETIME NOT NULL, 
    [Quantidade] INT NOT NULL
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
