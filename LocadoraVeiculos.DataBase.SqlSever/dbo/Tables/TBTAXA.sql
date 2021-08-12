CREATE TABLE [dbo].[TBTAXA] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [TipoTaxa] VARCHAR (100)   NOT NULL,
    [Nome]     VARCHAR (200)   NOT NULL,
    [Valor]    DECIMAL (18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

