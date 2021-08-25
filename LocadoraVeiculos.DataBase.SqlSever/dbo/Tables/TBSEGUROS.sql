CREATE TABLE [dbo].[TBSEGUROS]
(
	[Id]       INT             IDENTITY (1, 1) NOT NULL,
    [TipoSeguro] VARCHAR(100) NOT NULL, 
    [Valor] DECIMAL(18, 2) NOT NULL
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
