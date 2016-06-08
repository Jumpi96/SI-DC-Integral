﻿CREATE TABLE [dbo].[Clientes] (
    [Numero]    INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]    NVARCHAR (40) NOT NULL,
    [Domicilio] NVARCHAR (60) NULL,
    [TelFijo]   NVARCHAR (20) NULL,
    [TelCel]    NVARCHAR (20) NULL,
    [Correo]    NVARCHAR (40) NULL,
    [Tipo]      INT           NOT NULL,
    [ModPor]    INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Numero] ASC),
    CONSTRAINT [FK_Clientes_ToTiposCliente] FOREIGN KEY ([Tipo]) REFERENCES [dbo].[TiposCliente] ([Numero]),
    CONSTRAINT [FK_Clientes_ToUsuarios] FOREIGN KEY ([ModPor]) REFERENCES [dbo].[Usuarios] ([Numero])
);

