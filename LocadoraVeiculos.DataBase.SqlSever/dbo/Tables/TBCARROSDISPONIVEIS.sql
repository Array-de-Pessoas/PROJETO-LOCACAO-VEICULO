CREATE TABLE [dbo].[TBCARROSDISPONIVEIS] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Marca]           VARCHAR (100) NOT NULL,
    [IdGrupoVeiculos] VARCHAR (100) NOT NULL,
    [Placa]           VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


