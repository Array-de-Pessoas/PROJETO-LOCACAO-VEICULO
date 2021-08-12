CREATE TABLE [dbo].[TBFUNCIONARIO] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Nome]        VARCHAR (250)   NOT NULL,
    [Usuario]     VARCHAR (200)   NOT NULL,
    [Senha]       VARCHAR (50)    NOT NULL,
    [DataEntrada] DATETIME        NULL,
    [Salario]     DECIMAL (18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

