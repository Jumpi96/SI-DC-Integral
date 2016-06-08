CREATE TABLE [dbo].[Contactos] (
    [Numero]        INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]        NVARCHAR (40) NOT NULL,
    [Descripcion]   NVARCHAR (50) NULL,
    [NumeroCliente] INT           NOT NULL,
    [Telefono]      NVARCHAR (30) NULL,
    [Correo]        NVARCHAR (40) NULL,
    [ModPor]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Numero] ASC),
    CONSTRAINT [FK_Contactos_ToClientes] FOREIGN KEY ([NumeroCliente]) REFERENCES [dbo].[Clientes] ([Numero]),
    CONSTRAINT [FK_Contactos_ToUsuarios] FOREIGN KEY ([ModPor]) REFERENCES [dbo].[Usuarios] ([Numero])
);

