﻿CREATE TABLE [dbo].[Obras] (
    [Numero]        INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]        NVARCHAR (40) NOT NULL,
    [NumeroCliente] INT           NOT NULL,
    [Tipo]          INT           NOT NULL,
    [ModPor]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Numero] ASC),
    CONSTRAINT [FK_Obras_ToClientes] FOREIGN KEY ([NumeroCliente]) REFERENCES [dbo].[Clientes] ([Numero]),
    CONSTRAINT [FK_Obras_ToTiposObra] FOREIGN KEY ([Tipo]) REFERENCES [dbo].[TiposObra] ([Numero]),
    CONSTRAINT [FK_Obras_ToUsuarios] FOREIGN KEY ([ModPor]) REFERENCES [dbo].[Usuarios] ([Numero])
);

