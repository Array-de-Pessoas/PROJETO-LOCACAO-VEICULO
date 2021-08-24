CREATE TABLE [dbo].[TBGRUPOVEICULOS] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [Grupo] VARCHAR (50) NOT NULL,
    [ValorDiariaPlanoDiario] DECIMAL(18, 2) NOT NULL, 
    [ValorDiariaPlanoControlado] DECIMAL(18, 2) NOT NULL, 
    [ValorDiariaPlanoLivre] DECIMAL(18, 2) NOT NULL, 
    [ValorDoKMPlanoDiario] DECIMAL(18, 2) NOT NULL, 
    [LimiteKMPlanoControlado] DECIMAL(18, 2) NOT NULL, 
    [ValorKmExcedentePlanoControlado] DECIMAL(18, 2) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

