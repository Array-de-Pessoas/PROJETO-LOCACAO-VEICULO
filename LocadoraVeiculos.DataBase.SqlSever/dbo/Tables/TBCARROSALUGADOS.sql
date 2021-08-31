CREATE TABLE [dbo].[TBCARROSALUGADOS] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [id_cliente]  INT NOT NULL,
    [id_veiculo] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

