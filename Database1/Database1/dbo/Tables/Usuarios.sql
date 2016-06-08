﻿CREATE TABLE [dbo].[Usuarios] (
    [Numero]      INT           IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (30) NOT NULL,
    [Admin]       BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Numero] ASC)
);

