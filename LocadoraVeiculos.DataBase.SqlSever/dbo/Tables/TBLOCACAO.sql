CREATE TABLE [dbo].[TBLOCACAO]
(
	[Id] INT IDENTITY (1, 1) NOT NULL,
    [id_cliente] INT NOT NULL, 
    [id_veiculo] INT NOT NULL, 
    [id_taxa] INT NOT NULL, 
    [id_seguro] INT NOT NULL,
    [dataLocacao] DATE NOT NULL, 
    [dataDevolucao] DATE NOT NULL, 
    [preco] DECIMAL(18, 2) NULL,
    [plano] NVARCHAR(50) NOT NULL, 
    [locacaoAtiva] BIT NULL, 
    [dataDevolucaoRealizada] DATE NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBLOCACAO_TBCLIENTE] FOREIGN KEY ([id_cliente]) REFERENCES [dbo].[TBCLIENTE] ([Id]),
    CONSTRAINT [FK_TBLOCACAO_TBVEICULO] FOREIGN KEY ([id_veiculo]) REFERENCES [dbo].[TBVEICULO] ([Id]),
    CONSTRAINT [FK_TBLOCACAO_TBTAXA] FOREIGN KEY ([id_taxa]) REFERENCES [dbo].[TBTAXA] ([Id]),
    CONSTRAINT [FK_TBLOCACAO_TBSEGUROS] FOREIGN KEY ([id_seguro]) REFERENCES [dbo].[TBSEGUROS] ([Id])

)
