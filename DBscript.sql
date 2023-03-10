USE [master]
GO
/****** Object:  Database [SpeedrunCommunity]    Script Date: 26.1.2023. 06:17:05 ******/
CREATE DATABASE [SpeedrunCommunity]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SpeedrunCommunity', FILENAME = N'C:\Users\Urio\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\SpeedrunCommunity.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SpeedrunCommunity_log', FILENAME = N'C:\Users\Urio\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\SpeedrunCommunity.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SpeedrunCommunity] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SpeedrunCommunity].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SpeedrunCommunity] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [SpeedrunCommunity] SET ANSI_NULLS ON 
GO
ALTER DATABASE [SpeedrunCommunity] SET ANSI_PADDING ON 
GO
ALTER DATABASE [SpeedrunCommunity] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [SpeedrunCommunity] SET ARITHABORT ON 
GO
ALTER DATABASE [SpeedrunCommunity] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SpeedrunCommunity] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SpeedrunCommunity] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SpeedrunCommunity] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SpeedrunCommunity] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [SpeedrunCommunity] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [SpeedrunCommunity] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SpeedrunCommunity] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [SpeedrunCommunity] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SpeedrunCommunity] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SpeedrunCommunity] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SpeedrunCommunity] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SpeedrunCommunity] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SpeedrunCommunity] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SpeedrunCommunity] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SpeedrunCommunity] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SpeedrunCommunity] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SpeedrunCommunity] SET RECOVERY FULL 
GO
ALTER DATABASE [SpeedrunCommunity] SET  MULTI_USER 
GO
ALTER DATABASE [SpeedrunCommunity] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SpeedrunCommunity] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SpeedrunCommunity] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SpeedrunCommunity] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SpeedrunCommunity] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SpeedrunCommunity] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SpeedrunCommunity] SET QUERY_STORE = OFF
GO
USE [SpeedrunCommunity]
GO
/****** Object:  Table [dbo].[Igrac]    Script Date: 26.1.2023. 06:17:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Igrac](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nadimak] [varchar](50) NOT NULL,
	[Starost] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kategorija]    Script Date: 26.1.2023. 06:17:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategorija](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
	[Opis] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KategorijaIgre]    Script Date: 26.1.2023. 06:17:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KategorijaIgre](
	[VideoIgraID] [int] NOT NULL,
	[KategorijaID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[VideoIgraID] ASC,
	[KategorijaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Platforma]    Script Date: 26.1.2023. 06:17:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Platforma](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezultat]    Script Date: 26.1.2023. 06:17:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezultat](
	[IgracID] [int] NOT NULL,
	[VideoIgraID] [int] NOT NULL,
	[KategorijaID] [int] NOT NULL,
	[Vreme] [int] NOT NULL,
	[Datum] [datetime2](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IgracID] ASC,
	[VideoIgraID] ASC,
	[KategorijaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VideoIgra]    Script Date: 26.1.2023. 06:17:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VideoIgra](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
	[Izdavac] [varchar](50) NOT NULL,
	[GodinaIzdanja] [int] NOT NULL,
	[PlatformaID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Igrac] ON 

INSERT [dbo].[Igrac] ([ID], [Nadimak], [Starost]) VALUES (1, N'Mario', 27)
INSERT [dbo].[Igrac] ([ID], [Nadimak], [Starost]) VALUES (2, N'Mica', 25)
INSERT [dbo].[Igrac] ([ID], [Nadimak], [Starost]) VALUES (3, N'Novke', 27)
INSERT [dbo].[Igrac] ([ID], [Nadimak], [Starost]) VALUES (4, N'Velja', 26)
INSERT [dbo].[Igrac] ([ID], [Nadimak], [Starost]) VALUES (5, N'Džeja', 15)
INSERT [dbo].[Igrac] ([ID], [Nadimak], [Starost]) VALUES (6004, N'Bleki', 30)
SET IDENTITY_INSERT [dbo].[Igrac] OFF
GO
SET IDENTITY_INSERT [dbo].[Kategorija] ON 

INSERT [dbo].[Kategorija] ([ID], [Naziv], [Opis]) VALUES (2, N'Any%', N'Bez ikakvih dodatnih zahteva')
INSERT [dbo].[Kategorija] ([ID], [Naziv], [Opis]) VALUES (3, N'100%', N'Zahteva 100% prelazak video igre')
INSERT [dbo].[Kategorija] ([ID], [Naziv], [Opis]) VALUES (4, N'Glitchless', N'Bez korišcenja bagova')
SET IDENTITY_INSERT [dbo].[Kategorija] OFF
GO
INSERT [dbo].[KategorijaIgre] ([VideoIgraID], [KategorijaID]) VALUES (1, 2)
INSERT [dbo].[KategorijaIgre] ([VideoIgraID], [KategorijaID]) VALUES (1, 3)
INSERT [dbo].[KategorijaIgre] ([VideoIgraID], [KategorijaID]) VALUES (1, 4)
INSERT [dbo].[KategorijaIgre] ([VideoIgraID], [KategorijaID]) VALUES (2, 3)
INSERT [dbo].[KategorijaIgre] ([VideoIgraID], [KategorijaID]) VALUES (3, 2)
INSERT [dbo].[KategorijaIgre] ([VideoIgraID], [KategorijaID]) VALUES (3, 3)
INSERT [dbo].[KategorijaIgre] ([VideoIgraID], [KategorijaID]) VALUES (6, 2)
INSERT [dbo].[KategorijaIgre] ([VideoIgraID], [KategorijaID]) VALUES (6, 3)
INSERT [dbo].[KategorijaIgre] ([VideoIgraID], [KategorijaID]) VALUES (7, 3)
INSERT [dbo].[KategorijaIgre] ([VideoIgraID], [KategorijaID]) VALUES (8, 2)
INSERT [dbo].[KategorijaIgre] ([VideoIgraID], [KategorijaID]) VALUES (8, 3)
GO
SET IDENTITY_INSERT [dbo].[Platforma] ON 

INSERT [dbo].[Platforma] ([ID], [Naziv]) VALUES (1, N'PC')
INSERT [dbo].[Platforma] ([ID], [Naziv]) VALUES (2, N'Xbox')
INSERT [dbo].[Platforma] ([ID], [Naziv]) VALUES (3, N'PlayStation')
SET IDENTITY_INSERT [dbo].[Platforma] OFF
GO
INSERT [dbo].[Rezultat] ([IgracID], [VideoIgraID], [KategorijaID], [Vreme], [Datum]) VALUES (1, 1, 2, 150, CAST(N'2000-01-01T04:20:00.0000000' AS DateTime2))
INSERT [dbo].[Rezultat] ([IgracID], [VideoIgraID], [KategorijaID], [Vreme], [Datum]) VALUES (3, 2, 3, 450, CAST(N'2012-11-06T03:00:00.0000000' AS DateTime2))
INSERT [dbo].[Rezultat] ([IgracID], [VideoIgraID], [KategorijaID], [Vreme], [Datum]) VALUES (4, 1, 2, 70, CAST(N'2023-01-26T05:48:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[VideoIgra] ON 

INSERT [dbo].[VideoIgra] ([ID], [Naziv], [Izdavac], [GodinaIzdanja], [PlatformaID]) VALUES (1, N'Mirror''s Edge (PC)', N'EA', 2008, 1)
INSERT [dbo].[VideoIgra] ([ID], [Naziv], [Izdavac], [GodinaIzdanja], [PlatformaID]) VALUES (2, N'Portal', N'Valve', 2007, 1)
INSERT [dbo].[VideoIgra] ([ID], [Naziv], [Izdavac], [GodinaIzdanja], [PlatformaID]) VALUES (3, N'Stray (PC)', N'Blue Twelve Studios', 2022, 1)
INSERT [dbo].[VideoIgra] ([ID], [Naziv], [Izdavac], [GodinaIzdanja], [PlatformaID]) VALUES (6, N'Stray (PS)', N'Blue Twelve Studios', 2022, 3)
INSERT [dbo].[VideoIgra] ([ID], [Naziv], [Izdavac], [GodinaIzdanja], [PlatformaID]) VALUES (7, N'Mirror''s Edge (Xbox)', N'EA', 2008, 2)
INSERT [dbo].[VideoIgra] ([ID], [Naziv], [Izdavac], [GodinaIzdanja], [PlatformaID]) VALUES (8, N'Mirror''s Edge (PS)', N'EA', 2008, 3)
INSERT [dbo].[VideoIgra] ([ID], [Naziv], [Izdavac], [GodinaIzdanja], [PlatformaID]) VALUES (6003, N'test', N'ea', 2000, 1)
SET IDENTITY_INSERT [dbo].[VideoIgra] OFF
GO
ALTER TABLE [dbo].[KategorijaIgre]  WITH CHECK ADD  CONSTRAINT [FK_KategorijaIgre_To_Kategorija] FOREIGN KEY([KategorijaID])
REFERENCES [dbo].[Kategorija] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KategorijaIgre] CHECK CONSTRAINT [FK_KategorijaIgre_To_Kategorija]
GO
ALTER TABLE [dbo].[KategorijaIgre]  WITH CHECK ADD  CONSTRAINT [FK_KategorijaIgre_To_VideoIgra] FOREIGN KEY([VideoIgraID])
REFERENCES [dbo].[VideoIgra] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KategorijaIgre] CHECK CONSTRAINT [FK_KategorijaIgre_To_VideoIgra]
GO
ALTER TABLE [dbo].[Rezultat]  WITH CHECK ADD  CONSTRAINT [FK_Rezultat_To_Igrac] FOREIGN KEY([IgracID])
REFERENCES [dbo].[Igrac] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezultat] CHECK CONSTRAINT [FK_Rezultat_To_Igrac]
GO
ALTER TABLE [dbo].[Rezultat]  WITH CHECK ADD  CONSTRAINT [FK_Rezultat_To_KategorijaIgre] FOREIGN KEY([VideoIgraID], [KategorijaID])
REFERENCES [dbo].[KategorijaIgre] ([VideoIgraID], [KategorijaID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezultat] CHECK CONSTRAINT [FK_Rezultat_To_KategorijaIgre]
GO
ALTER TABLE [dbo].[VideoIgra]  WITH CHECK ADD  CONSTRAINT [FK_VideoIgra_To_Platforma] FOREIGN KEY([PlatformaID])
REFERENCES [dbo].[Platforma] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[VideoIgra] CHECK CONSTRAINT [FK_VideoIgra_To_Platforma]
GO
ALTER TABLE [dbo].[Igrac]  WITH CHECK ADD  CONSTRAINT [CK_Igrac_Starost] CHECK  (([Starost]>(13)))
GO
ALTER TABLE [dbo].[Igrac] CHECK CONSTRAINT [CK_Igrac_Starost]
GO
USE [master]
GO
ALTER DATABASE [SpeedrunCommunity] SET  READ_WRITE 
GO
