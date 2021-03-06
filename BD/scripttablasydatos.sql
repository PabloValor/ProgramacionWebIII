CREATE DATABASE [TP_20162C]
GO
USE [TP_20162C]

/****** Object:  Table [dbo].[Cocheras]    Script Date: 10/23/2016 9:37:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cocheras](
	[IdCochera] [int] IDENTITY(1,1) NOT NULL,
	[IdPropietario] [int] NOT NULL,
	[Ubicacion] [nvarchar](200) NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[FechaFin] [datetime] NOT NULL,
	[HoraInicio] [nvarchar](20) NOT NULL,
	[HoraFin] [nvarchar](20) NOT NULL,
	[Descripcion] [nvarchar](500) NOT NULL,
	[Latitud] [decimal](12, 9) NOT NULL,
	[Longitud] [decimal](12, 9) NOT NULL,
	[MetrosCuadrados] [int] NOT NULL,
	[TipoVehiculo] [smallint] NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[Imagen] [nvarchar](400) NOT NULL,
 CONSTRAINT [PK_Cocheras] PRIMARY KEY CLUSTERED 
(
	[IdCochera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reservas]    Script Date: 10/23/2016 9:37:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservas](
	[IdReserva] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdCochera] [int] NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[FechaFin] [datetime] NOT NULL,
	[HoraInicio] [nvarchar](20) NOT NULL,
	[HoraFin] [nvarchar](20) NOT NULL,
	[CantidadHoras] [decimal](18, 2) NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[FechaCarga] [datetime] NOT NULL,
	[Puntuacion] [smallint] NOT NULL,
 CONSTRAINT [PK_Reservas] PRIMARY KEY CLUSTERED 
(
	[IdReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 10/23/2016 9:37:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](200) NOT NULL,
	[Contrasenia] [nvarchar](20) NOT NULL,
	[Perfil] [smallint] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Cocheras] ON 

GO
INSERT [dbo].[Cocheras] ([IdCochera], [IdPropietario], [Ubicacion], [FechaInicio], [FechaFin], [HoraInicio], [HoraFin], [Descripcion], [Latitud], [Longitud], [MetrosCuadrados], [TipoVehiculo], [Precio], [Imagen]) VALUES (1, 1, N'Rivadavia 16299, Haedo, Buenos Aires', CAST(N'2016-11-23 00:00:00.000' AS DateTime), CAST(N'2016-12-23 00:00:00.000' AS DateTime), N'09:00', N'10:00', N'Cochera p/Moto consultar disponibilidad!', CAST(-34.645891900 AS Decimal(12, 9)), CAST(-58.595289700 AS Decimal(12, 9)), 8, 4, CAST(10.00 AS Decimal(18, 2)), N'/imagenes/cochera4.png')
GO
INSERT [dbo].[Cocheras] ([IdCochera], [IdPropietario], [Ubicacion], [FechaInicio], [FechaFin], [HoraInicio], [HoraFin], [Descripcion], [Latitud], [Longitud], [MetrosCuadrados], [TipoVehiculo], [Precio], [Imagen]) VALUES (2, 1, N'Florencio Varela 1903, San Justo, Buenos Aires', CAST(N'2016-10-23 00:00:00.000' AS DateTime), CAST(N'2016-11-23 00:00:00.000' AS DateTime), N'08:00', N'18:00', N'Cochera p/Auto de Lujo consultar disponibilidad!', CAST(-34.667276800 AS Decimal(12, 9)), CAST(-58.567109200 AS Decimal(12, 9)), 20, 1, CAST(200.00 AS Decimal(18, 2)), N'/imagenes/cochera1.png')
GO
INSERT [dbo].[Cocheras] ([IdCochera], [IdPropietario], [Ubicacion], [FechaInicio], [FechaFin], [HoraInicio], [HoraFin], [Descripcion], [Latitud], [Longitud], [MetrosCuadrados], [TipoVehiculo], [Precio], [Imagen]) VALUES (3, 1, N'Rivadavia 16299, Haedo, Buenos Aires', CAST(N'2016-08-23 00:00:00.000' AS DateTime), CAST(N'2016-09-23 00:00:00.000' AS DateTime), N'08:00', N'18:00', N'Cochera p/Pickup consultar disponibilidad! (Publicacion Vencida)', CAST(-34.645891900 AS Decimal(12, 9)), CAST(-58.595289700 AS Decimal(12, 9)), 30, 3, CAST(30.00 AS Decimal(18, 2)), N'/imagenes/cochera3.png')
GO
INSERT [dbo].[Cocheras] ([IdCochera], [IdPropietario], [Ubicacion], [FechaInicio], [FechaFin], [HoraInicio], [HoraFin], [Descripcion], [Latitud], [Longitud], [MetrosCuadrados], [TipoVehiculo], [Precio], [Imagen]) VALUES (4, 1, N'Oncativo 530, Ramos Mejía, Buenos Aires', CAST(N'2016-10-23 00:00:00.000' AS DateTime), CAST(N'2016-11-23 00:00:00.000' AS DateTime), N'08:00', N'18:00', N'Cochera p/Camión inmejorable ubicación!', CAST(35.123456000 AS Decimal(12, 9)), CAST(32.123456000 AS Decimal(12, 9)), 50, 3, CAST(40.00 AS Decimal(18, 2)), N'/imagenes/cochera2.png')
GO
SET IDENTITY_INSERT [dbo].[Cocheras] OFF
GO
SET IDENTITY_INSERT [dbo].[Reservas] ON 

GO
INSERT [dbo].[Reservas] ([IdReserva], [IdCliente], [IdCochera], [FechaInicio], [FechaFin], [HoraInicio], [HoraFin], [CantidadHoras], [Precio], [FechaCarga], [Puntuacion]) VALUES (1, 2, 1, CAST(N'2016-11-10 00:00:00.000' AS DateTime), CAST(N'2016-11-25 00:00:00.000' AS DateTime), N'08:00', N'10:00', CAST(32.00 AS Decimal(18, 2)), CAST(3200.00 AS Decimal(18, 2)), CAST(N'2016-10-23 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[Reservas] ([IdReserva], [IdCliente], [IdCochera], [FechaInicio], [FechaFin], [HoraInicio], [HoraFin], [CantidadHoras], [Precio], [FechaCarga], [Puntuacion]) VALUES (2, 2, 1, CAST(N'2016-10-26 00:00:00.000' AS DateTime), CAST(N'2016-10-26 00:00:00.000' AS DateTime), N'08:00', N'10:00', CAST(2.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(N'2016-10-23 00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[Reservas] ([IdReserva], [IdCliente], [IdCochera], [FechaInicio], [FechaFin], [HoraInicio], [HoraFin], [CantidadHoras], [Precio], [FechaCarga], [Puntuacion]) VALUES (3, 3, 2, CAST(N'2016-10-23 00:00:00.000' AS DateTime), CAST(N'2016-10-25 00:00:00.000' AS DateTime), N'08:00', N'10:00', CAST(6.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)), CAST(N'2016-10-23 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[Reservas] ([IdReserva], [IdCliente], [IdCochera], [FechaInicio], [FechaFin], [HoraInicio], [HoraFin], [CantidadHoras], [Precio], [FechaCarga], [Puntuacion]) VALUES (4, 4, 2, CAST(N'2016-10-23 00:00:00.000' AS DateTime), CAST(N'2016-10-26 00:00:00.000' AS DateTime), N'12:00', N'18:00', CAST(16.00 AS Decimal(18, 2)), CAST(3200.00 AS Decimal(18, 2)), CAST(N'2016-10-23 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[Reservas] ([IdReserva], [IdCliente], [IdCochera], [FechaInicio], [FechaFin], [HoraInicio], [HoraFin], [CantidadHoras], [Precio], [FechaCarga], [Puntuacion]) VALUES (5, 5, 2, CAST(N'2016-10-23 00:00:00.000' AS DateTime), CAST(N'2016-10-27 00:00:00.000' AS DateTime), N'21:00', N'23:00', CAST(10.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(N'2016-10-23 00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[Reservas] ([IdReserva], [IdCliente], [IdCochera], [FechaInicio], [FechaFin], [HoraInicio], [HoraFin], [CantidadHoras], [Precio], [FechaCarga], [Puntuacion]) VALUES (6, 6, 3, CAST(N'2016-12-24 00:00:00.000' AS DateTime), CAST(N'2016-12-25 00:00:00.000' AS DateTime), N'04:00', N'07:00', CAST(6.00 AS Decimal(18, 2)), CAST(180.00 AS Decimal(18, 2)), CAST(N'2016-10-23 00:00:00.000' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[Reservas] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

GO
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Email], [Contrasenia], [Perfil]) VALUES (1, N'Ejemplo', N'Propietario', N'propietario@gmail.com', N'Password01', 2)
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Email], [Contrasenia], [Perfil]) VALUES (2, N'Ejemplo', N'Cliente', N'cliente@gmail.com', N'Password01', 1)
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Email], [Contrasenia], [Perfil]) VALUES (3, N'Cristiano', N'Romualdo', N'cr7@gmail.com', N'Password01', 1)
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Email], [Contrasenia], [Perfil]) VALUES (4, N'Lionel', N'Mussi', N'm10@gmail.com', N'Password01', 1)
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Email], [Contrasenia], [Perfil]) VALUES (5, N'Mauro', N'Icardio', N'nosoymaxi@gmail.com', N'Password01', 1)
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Email], [Contrasenia], [Perfil]) VALUES (6, N'Chano', N'Yosigodelargo', N'chano@gmail.com', N'Password01', 1)
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Cocheras]  WITH CHECK ADD  CONSTRAINT [FK_Cocheras_Usuarios] FOREIGN KEY([IdPropietario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Cocheras] CHECK CONSTRAINT [FK_Cocheras_Usuarios]
GO
ALTER TABLE [dbo].[Reservas]  WITH CHECK ADD  CONSTRAINT [FK_Reservas_Cocheras] FOREIGN KEY([IdCochera])
REFERENCES [dbo].[Cocheras] ([IdCochera])
GO
ALTER TABLE [dbo].[Reservas] CHECK CONSTRAINT [FK_Reservas_Cocheras]
GO
ALTER TABLE [dbo].[Reservas]  WITH CHECK ADD  CONSTRAINT [FK_Reservas_Usuarios] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Reservas] CHECK CONSTRAINT [FK_Reservas_Usuarios]
GO
