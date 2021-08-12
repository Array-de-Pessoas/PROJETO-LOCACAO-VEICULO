CREATE TABLE [dbo].[TBCLIENTE] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Nome]            VARCHAR (200) NOT NULL,
    [Endereco]        VARCHAR (100) NOT NULL,
    [Telefone]        VARCHAR (50)  NOT NULL,
    [CPF/CNPJ]        VARCHAR (50)  NOT NULL,
    [NomeCondutor]    VARCHAR (200) NULL,
    [CNH]             VARCHAR (50)  NOT NULL,
    [CPFCondutor]     VARCHAR (50)  NULL,
    [RG]              VARCHAR (50)  NOT NULL,
    [DataValidadeCNH] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

