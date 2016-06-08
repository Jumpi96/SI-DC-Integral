CREATE TABLE [dbo].[TiposCliente] (
    [Numero]      INT           IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (40) NOT NULL,
    PRIMARY KEY CLUSTERED ([Numero] ASC)
);

