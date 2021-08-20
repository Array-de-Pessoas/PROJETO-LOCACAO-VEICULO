CREATE TABLE [dbo].[TBVEICULO] (
    [Id]                INT             IDENTITY (1, 1) NOT NULL,
    [Placa]             VARCHAR (50)    NOT NULL,
    [Cor]               VARCHAR (50)    NOT NULL,
    [Marca]             VARCHAR (50)    NOT NULL,
    [Ano]               INT             NOT NULL,
    [TipoCombustivel]   VARCHAR (50)    NOT NULL,
    [QuantidadeLitros]  DECIMAL (18, 2) NOT NULL,
    [NumeroPortas]      INT             NOT NULL,
    [CapacidadePessoas] INT             NOT NULL,
    [TamanhoPortaMalas] VARCHAR (50)    NOT NULL,
    [Foto]              IMAGE           NULL,
    [Kilometragem]      INT             NOT NULL,
    [IdGrupoVeiculos]   INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBVEICULO_TBGRUPOVEICULOS] FOREIGN KEY ([IdGrupoVeiculos]) REFERENCES [dbo].[TBGRUPOVEICULOS] ([Id])
);





