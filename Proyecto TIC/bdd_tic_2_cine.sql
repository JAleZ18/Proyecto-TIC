USE [master]
GO
/****** Object:  Database [Cine]    Script Date: 21/11/2022 02:37:44 p. m. ******/
CREATE DATABASE [Cine]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cine', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Cine.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cine_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Cine_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Cine] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cine].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cine] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Cine] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Cine] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Cine] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Cine] SET ARITHABORT OFF 
GO
ALTER DATABASE [Cine] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Cine] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Cine] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Cine] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Cine] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Cine] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Cine] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Cine] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Cine] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Cine] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Cine] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Cine] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Cine] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Cine] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Cine] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Cine] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Cine] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Cine] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Cine] SET  MULTI_USER 
GO
ALTER DATABASE [Cine] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Cine] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Cine] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Cine] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Cine] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Cine] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Cine] SET QUERY_STORE = OFF
GO
USE [Cine]
GO
/****** Object:  Table [dbo].[cartelera]    Script Date: 21/11/2022 02:37:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cartelera](
	[id_cartelera] [int] IDENTITY(1,1) NOT NULL,
	[id_sala] [int] NULL,
	[id_horarios] [int] NULL,
	[id_peliculas] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[horarios]    Script Date: 21/11/2022 02:37:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[horarios](
	[id_horarios] [int] IDENTITY(1,1) NOT NULL,
	[hora] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_horarios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[peliculas]    Script Date: 21/11/2022 02:37:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[peliculas](
	[id_peliculas] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](50) NULL,
	[duracion] [varchar](5) NULL,
	[genero] [varchar](25) NULL,
	[clasificacion] [varchar](10) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_peliculas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sala]    Script Date: 21/11/2022 02:37:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sala](
	[id_sala] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_sala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[cartelera] ON 
GO
INSERT [dbo].[cartelera] ([id_cartelera], [id_sala], [id_horarios], [id_peliculas]) VALUES (1, 2, 3, 1)
GO
INSERT [dbo].[cartelera] ([id_cartelera], [id_sala], [id_horarios], [id_peliculas]) VALUES (2, 1, 4, 3)
GO
SET IDENTITY_INSERT [dbo].[cartelera] OFF
GO
SET IDENTITY_INSERT [dbo].[horarios] ON 
GO
INSERT [dbo].[horarios] ([id_horarios], [hora]) VALUES (1, CAST(N'12:20:00' AS Time))
GO
INSERT [dbo].[horarios] ([id_horarios], [hora]) VALUES (2, CAST(N'14:20:00' AS Time))
GO
INSERT [dbo].[horarios] ([id_horarios], [hora]) VALUES (3, CAST(N'16:20:00' AS Time))
GO
INSERT [dbo].[horarios] ([id_horarios], [hora]) VALUES (4, CAST(N'18:20:00' AS Time))
GO
INSERT [dbo].[horarios] ([id_horarios], [hora]) VALUES (5, CAST(N'20:20:00' AS Time))
GO
SET IDENTITY_INSERT [dbo].[horarios] OFF
GO
SET IDENTITY_INSERT [dbo].[peliculas] ON 
GO
INSERT [dbo].[peliculas] ([id_peliculas], [titulo], [duracion], [genero], [clasificacion], [estado]) VALUES (1, N'Megalodon', N'2:00', N'Terror', N'+18', 1)
GO
INSERT [dbo].[peliculas] ([id_peliculas], [titulo], [duracion], [genero], [clasificacion], [estado]) VALUES (2, N'Crepusculo', N'2:10', N'Fantasia', N'+13', 0)
GO
INSERT [dbo].[peliculas] ([id_peliculas], [titulo], [duracion], [genero], [clasificacion], [estado]) VALUES (3, N'Vivo', N'1:30', N'Terror', N'+18', 1)
GO
INSERT [dbo].[peliculas] ([id_peliculas], [titulo], [duracion], [genero], [clasificacion], [estado]) VALUES (4, N'Prey', N'1:52', N'Terror', N'+18', 1)
GO
SET IDENTITY_INSERT [dbo].[peliculas] OFF
GO
SET IDENTITY_INSERT [dbo].[sala] ON 
GO
INSERT [dbo].[sala] ([id_sala], [nombre], [descripcion]) VALUES (1, N'Sala 1', N'Normal')
GO
INSERT [dbo].[sala] ([id_sala], [nombre], [descripcion]) VALUES (2, N'Sala 2', N'Normal')
GO
INSERT [dbo].[sala] ([id_sala], [nombre], [descripcion]) VALUES (3, N'Sala 3', N'VIP')
GO
INSERT [dbo].[sala] ([id_sala], [nombre], [descripcion]) VALUES (4, N'Sala 4', N'Normal')
GO
SET IDENTITY_INSERT [dbo].[sala] OFF
GO
ALTER TABLE [dbo].[peliculas] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[cartelera]  WITH CHECK ADD FOREIGN KEY([id_horarios])
REFERENCES [dbo].[horarios] ([id_horarios])
GO
ALTER TABLE [dbo].[cartelera]  WITH CHECK ADD FOREIGN KEY([id_peliculas])
REFERENCES [dbo].[peliculas] ([id_peliculas])
GO
ALTER TABLE [dbo].[cartelera]  WITH CHECK ADD FOREIGN KEY([id_sala])
REFERENCES [dbo].[sala] ([id_sala])
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_horarios]    Script Date: 21/11/2022 02:37:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_actualizar_horarios]
(
@pid_horarios int,
@phora time
)
as 
if exists (Select * from horarios where (id_horarios = @pid_horarios))
Update horarios
Set hora = @phora
where id_horarios = @pid_horarios
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_peliculas]    Script Date: 21/11/2022 02:37:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_actualizar_peliculas]
(
@pid_peliculas int,
@ptitulo varchar(50),
@pduracion varchar(5),
@pgenero varchar(25),
@pclasificacion varchar(10)

)
as 
if exists (Select * from peliculas where (id_peliculas = @pid_peliculas))
Update peliculas
Set titulo = @ptitulo,
duracion = @pduracion,
genero = @pgenero,
clasificacion = @pclasificacion
where id_peliculas = @pid_peliculas
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_sala]    Script Date: 21/11/2022 02:37:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_actualizar_sala]
(
@pid_sala int,
@pnombre varchar(50),
@pdescripcion varchar(50)
)
as 
if exists (Select * from sala where (id_sala = @pid_sala))
Update sala
Set nombre = @pnombre,
descripcion = @pdescripcion
where id_sala = @pid_sala
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_pelicula]    Script Date: 21/11/2022 02:37:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_eliminar_pelicula]
(
@pid_peliculas int
)
as 
if EXISTS (SELECT id_peliculas FROM peliculas WHERE (id_peliculas = @pid_peliculas))
Update peliculas
Set estado = 0
where id_peliculas = @pid_peliculas
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_cartelera]    Script Date: 21/11/2022 02:37:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_insertar_cartelera]
(
@pid_sala int,
@pid_horarios int,
@pid_peiculas int
)
as
insert into cartelera
(
id_sala,
id_horarios,
id_peliculas
)

values
(
@pid_sala,
@pid_horarios,
@pid_peiculas
)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_horarios]    Script Date: 21/11/2022 02:37:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_insertar_horarios]
(
@phora time
)
as
insert into horarios
(
hora
)

values
(
@phora
)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_pelicula]    Script Date: 21/11/2022 02:37:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_insertar_pelicula]
(
@ptitulo varchar(50),
@pduracion varchar(5),
@pgenero varchar(25),
@pclasificacion varchar(10)
)
as
insert into peliculas
(
titulo,
duracion,
genero,
clasificacion
)

values
(
@ptitulo,
@pduracion,
@pgenero,
@pclasificacion
)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_sala]    Script Date: 21/11/2022 02:37:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_insertar_sala]
(
@pnombre varchar(50), 
@pdescripcion varchar(50)
)
as
insert into sala
(
nombre,
descripcion
)

values
(
@pnombre,
@pdescripcion
)
GO
/****** Object:  StoredProcedure [dbo].[sp_select_cartelera]    Script Date: 21/11/2022 02:37:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_select_cartelera]
as
begin
select * from cartelera
end 
GO
/****** Object:  StoredProcedure [dbo].[sp_select_horarios]    Script Date: 21/11/2022 02:37:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_select_horarios]
as
begin
select * from horarios
end 
GO
/****** Object:  StoredProcedure [dbo].[sp_select_peliculas]    Script Date: 21/11/2022 02:37:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_select_peliculas]
as
begin
select * from peliculas
end 
GO
/****** Object:  StoredProcedure [dbo].[sp_select_salas]    Script Date: 21/11/2022 02:37:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_select_salas]
as
begin
select * from sala
end 
GO
USE [master]
GO
ALTER DATABASE [Cine] SET  READ_WRITE 
GO
