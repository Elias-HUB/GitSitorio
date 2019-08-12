USE [master]
GO
/****** Object:  Database [FRGP_LABO]    Script Date: 11/08/2019 23:12:58 ******/
CREATE DATABASE [FRGP_LABO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FRGP_LABO', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.FRGP_LABO\MSSQL\DATA\FRGP_LABO.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FRGP_LABO_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.FRGP_LABO\MSSQL\DATA\FRGP_LABO_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FRGP_LABO] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FRGP_LABO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FRGP_LABO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FRGP_LABO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FRGP_LABO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FRGP_LABO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FRGP_LABO] SET ARITHABORT OFF 
GO
ALTER DATABASE [FRGP_LABO] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [FRGP_LABO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FRGP_LABO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FRGP_LABO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FRGP_LABO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FRGP_LABO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FRGP_LABO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FRGP_LABO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FRGP_LABO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FRGP_LABO] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FRGP_LABO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FRGP_LABO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FRGP_LABO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FRGP_LABO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FRGP_LABO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FRGP_LABO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FRGP_LABO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FRGP_LABO] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FRGP_LABO] SET  MULTI_USER 
GO
ALTER DATABASE [FRGP_LABO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FRGP_LABO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FRGP_LABO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FRGP_LABO] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [FRGP_LABO] SET DELAYED_DURABILITY = DISABLED 
GO
USE [FRGP_LABO]
GO
/****** Object:  Table [dbo].[Actividades]    Script Date: 11/08/2019 23:12:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Actividades](
	[Actividades_PK] [tinyint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[BoolAptoMed] [varchar](2) NOT NULL,
	[Costo] [money] NOT NULL,
	[IDSede] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Actividades_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ActSedeXSocio]    Script Date: 11/08/2019 23:12:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActSedeXSocio](
	[ID_Legajo] [int] NOT NULL,
	[ID_Actividades_PK] [tinyint] NULL,
	[Beca] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 11/08/2019 23:12:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Localidad](
	[CodPos_PK] [int] NOT NULL,
	[NombreLoc] [varchar](50) NOT NULL,
	[IDCodProv] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodPos_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 11/08/2019 23:12:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provincia](
	[CodProv_PK] [tinyint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodProv_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sede]    Script Date: 11/08/2019 23:12:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sede](
	[Sede_PK] [tinyint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Mail] [varchar](40) NULL,
	[Telefono] [int] NULL,
	[IDCodPos] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Sede_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Socios]    Script Date: 11/08/2019 23:12:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Socios](
	[Legajo] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[FechaNac] [date] NOT NULL,
	[Genero] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Actividades]  WITH CHECK ADD FOREIGN KEY([IDSede])
REFERENCES [dbo].[Sede] ([Sede_PK])
GO
ALTER TABLE [dbo].[ActSedeXSocio]  WITH CHECK ADD FOREIGN KEY([ID_Actividades_PK])
REFERENCES [dbo].[Actividades] ([Actividades_PK])
GO
ALTER TABLE [dbo].[ActSedeXSocio]  WITH CHECK ADD FOREIGN KEY([ID_Legajo])
REFERENCES [dbo].[Socios] ([Legajo])
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD FOREIGN KEY([IDCodProv])
REFERENCES [dbo].[Provincia] ([CodProv_PK])
GO
ALTER TABLE [dbo].[Sede]  WITH CHECK ADD FOREIGN KEY([IDCodPos])
REFERENCES [dbo].[Localidad] ([CodPos_PK])
GO
ALTER TABLE [dbo].[Actividades]  WITH CHECK ADD CHECK  (([BoolAptoMed]='si' OR [BoolAptoMed]='no' OR [BoolAptoMed]='No' OR [BoolAptoMed]='Si'))
GO
ALTER TABLE [dbo].[Actividades]  WITH CHECK ADD CHECK  (([costo]>(0)))
GO
ALTER TABLE [dbo].[Socios]  WITH CHECK ADD CHECK  (([FechaNac]<'2010-01-01'))
GO
ALTER TABLE [dbo].[Socios]  WITH CHECK ADD CHECK  (([Genero]='f' OR [Genero]='F' OR [Genero]='m' OR [Genero]='M'))
GO
USE [master]
GO
ALTER DATABASE [FRGP_LABO] SET  READ_WRITE 
GO
