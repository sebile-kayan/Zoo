USE [master]
GO
/****** Object:  Database [Denemezoo2]    Script Date: 12.05.2024 22:48:31 ******/
CREATE DATABASE [Denemezoo2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Denemezoo2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Denemezoo2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Denemezoo2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Denemezoo2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Denemezoo2] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Denemezoo2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Denemezoo2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Denemezoo2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Denemezoo2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Denemezoo2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Denemezoo2] SET ARITHABORT OFF 
GO
ALTER DATABASE [Denemezoo2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Denemezoo2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Denemezoo2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Denemezoo2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Denemezoo2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Denemezoo2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Denemezoo2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Denemezoo2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Denemezoo2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Denemezoo2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Denemezoo2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Denemezoo2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Denemezoo2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Denemezoo2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Denemezoo2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Denemezoo2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Denemezoo2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Denemezoo2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Denemezoo2] SET  MULTI_USER 
GO
ALTER DATABASE [Denemezoo2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Denemezoo2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Denemezoo2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Denemezoo2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Denemezoo2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Denemezoo2] SET QUERY_STORE = OFF
GO
USE [Denemezoo2]
GO
/****** Object:  Table [dbo].[Gosteri]    Script Date: 12.05.2024 22:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gosteri](
	[gosterino] [int] NOT NULL,
	[gosteriadi] [varchar](25) NULL,
	[gosterisaati] [varchar](25) NULL,
	[gosteritarihi] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[gosterino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bilet]    Script Date: 12.05.2024 22:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bilet](
	[biletno] [int] NOT NULL,
	[fiyat] [int] NULL,
	[gosterinum] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[biletno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DenemeGosterisiBiletleri]    Script Date: 12.05.2024 22:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DenemeGosterisiBiletleri] AS
SELECT fiyat
FROM Bilet, Gosteri
WHERE Bilet.gosterinum = Gosteri.gosterino
AND Gosteri.gosteriadi = 'Deneme Gösterisi';
GO
/****** Object:  Table [dbo].[AraTablo]    Script Date: 12.05.2024 22:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AraTablo](
	[gosterinum] [int] NOT NULL,
	[hayvanid] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[gosterinum] ASC,
	[hayvanid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Egitmen]    Script Date: 12.05.2024 22:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Egitmen](
	[egitmenno] [int] NOT NULL,
	[egitmenad] [varchar](25) NULL,
	[egitmentel] [char](25) NULL,
	[egitmenyas] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[egitmenno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GosteriYeri]    Script Date: 12.05.2024 22:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GosteriYeri](
	[yernumarasi] [int] NOT NULL,
	[gosteriadres] [varchar](100) NULL,
	[gosteritel] [char](25) NULL,
	[koltukkapasitesi] [int] NULL,
	[gosterinum] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[yernumarasi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hayvan]    Script Date: 12.05.2024 22:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hayvan](
	[hayvankodu] [int] NOT NULL,
	[hayvanadi] [varchar](25) NULL,
	[cinsiyet] [char](1) NULL,
	[hayvanyas] [int] NULL,
	[cinsi] [varchar](25) NULL,
	[egitmennum] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[hayvankodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Bilet] ([biletno], [fiyat], [gosterinum]) VALUES (1, 50, 1)
INSERT [dbo].[Bilet] ([biletno], [fiyat], [gosterinum]) VALUES (2, 75, 2)
INSERT [dbo].[Bilet] ([biletno], [fiyat], [gosterinum]) VALUES (3, 60, 3)
INSERT [dbo].[Bilet] ([biletno], [fiyat], [gosterinum]) VALUES (4, 80, 4)
INSERT [dbo].[Bilet] ([biletno], [fiyat], [gosterinum]) VALUES (5, 70, 5)
INSERT [dbo].[Bilet] ([biletno], [fiyat], [gosterinum]) VALUES (6, 70, 5)
GO
INSERT [dbo].[Egitmen] ([egitmenno], [egitmenad], [egitmentel], [egitmenyas]) VALUES (1, N'Sebile', N'5564131011               ', 48)
INSERT [dbo].[Egitmen] ([egitmenno], [egitmenad], [egitmentel], [egitmenyas]) VALUES (2, N'Hamiyet', N'5553334455               ', 36)
INSERT [dbo].[Egitmen] ([egitmenno], [egitmenad], [egitmentel], [egitmenyas]) VALUES (3, N'Yağmur', N'5551112233               ', 28)
INSERT [dbo].[Egitmen] ([egitmenno], [egitmenad], [egitmentel], [egitmenyas]) VALUES (4, N'Mehmet', N'5551234567               ', 35)
INSERT [dbo].[Egitmen] ([egitmenno], [egitmenad], [egitmentel], [egitmenyas]) VALUES (5, N'fatma', N'555123654                ', 42)
INSERT [dbo].[Egitmen] ([egitmenno], [egitmenad], [egitmentel], [egitmenyas]) VALUES (6, N'Murat', N'5434258963               ', 25)
INSERT [dbo].[Egitmen] ([egitmenno], [egitmenad], [egitmentel], [egitmenyas]) VALUES (7, N'İbrahim', N'5445685612               ', 38)
INSERT [dbo].[Egitmen] ([egitmenno], [egitmenad], [egitmentel], [egitmenyas]) VALUES (8, N'Nurefşan', N'5443585612               ', 21)
GO
INSERT [dbo].[Gosteri] ([gosterino], [gosteriadi], [gosterisaati], [gosteritarihi]) VALUES (1, N'Deneme Gösterisi', N'14:00', CAST(N'2024-05-10' AS Date))
INSERT [dbo].[Gosteri] ([gosterino], [gosteriadi], [gosterisaati], [gosteritarihi]) VALUES (2, N'Akşam Gösterisi', N'19:30', CAST(N'2024-05-15' AS Date))
INSERT [dbo].[Gosteri] ([gosterino], [gosteriadi], [gosterisaati], [gosteritarihi]) VALUES (3, N'Çocuk Gösterisi', N'11:00', CAST(N'2024-05-20' AS Date))
INSERT [dbo].[Gosteri] ([gosterino], [gosteriadi], [gosterisaati], [gosteritarihi]) VALUES (4, N'Yetişkin Gösterisi', N'21:00', CAST(N'2024-05-25' AS Date))
INSERT [dbo].[Gosteri] ([gosterino], [gosteriadi], [gosterisaati], [gosteritarihi]) VALUES (5, N'Aile gosteri', N'21.15', CAST(N'2014-03-16' AS Date))
INSERT [dbo].[Gosteri] ([gosterino], [gosteriadi], [gosterisaati], [gosteritarihi]) VALUES (6, N'Aile gosteri 2', N'21.15', CAST(N'2014-03-18' AS Date))
INSERT [dbo].[Gosteri] ([gosterino], [gosteriadi], [gosterisaati], [gosteritarihi]) VALUES (7, N'İp Cambazı', N'22.35', CAST(N'2021-05-13' AS Date))
GO
INSERT [dbo].[GosteriYeri] ([yernumarasi], [gosteriadres], [gosteritel], [koltukkapasitesi], [gosterinum]) VALUES (1, N'Ankara Cad. No: 123', N'0312-123456              ', 100, 1)
INSERT [dbo].[GosteriYeri] ([yernumarasi], [gosteriadres], [gosteritel], [koltukkapasitesi], [gosterinum]) VALUES (2, N'İstanbul Cad. No: 456', N'0212-654321              ', 150, 2)
INSERT [dbo].[GosteriYeri] ([yernumarasi], [gosteriadres], [gosteritel], [koltukkapasitesi], [gosterinum]) VALUES (3, N'İzmir Cad. No: 789', N'0232-987654              ', 200, 3)
INSERT [dbo].[GosteriYeri] ([yernumarasi], [gosteriadres], [gosteritel], [koltukkapasitesi], [gosterinum]) VALUES (4, N'Bursa Cad. No: 012', N'0224-321654              ', 120, 4)
INSERT [dbo].[GosteriYeri] ([yernumarasi], [gosteriadres], [gosteritel], [koltukkapasitesi], [gosterinum]) VALUES (5, N'Ankara', N'05526353215              ', 205, 3)
INSERT [dbo].[GosteriYeri] ([yernumarasi], [gosteriadres], [gosteritel], [koltukkapasitesi], [gosterinum]) VALUES (6, N'Kars cad. No:215', N'5364952336               ', 500, 3)
GO
INSERT [dbo].[Hayvan] ([hayvankodu], [hayvanadi], [cinsiyet], [hayvanyas], [cinsi], [egitmennum]) VALUES (12, N'kırkır', N'x', 6, N'Kaplumbağa', 1)
INSERT [dbo].[Hayvan] ([hayvankodu], [hayvanadi], [cinsiyet], [hayvanyas], [cinsi], [egitmennum]) VALUES (22, N'Necati', N'y', 3, N'fil', 2)
INSERT [dbo].[Hayvan] ([hayvankodu], [hayvanadi], [cinsiyet], [hayvanyas], [cinsi], [egitmennum]) VALUES (33, N'Luna', N'x', 5, N'kedi', 3)
INSERT [dbo].[Hayvan] ([hayvankodu], [hayvanadi], [cinsiyet], [hayvanyas], [cinsi], [egitmennum]) VALUES (36, N'kala', N'x', 3, N'maymun', 3)
INSERT [dbo].[Hayvan] ([hayvankodu], [hayvanadi], [cinsiyet], [hayvanyas], [cinsi], [egitmennum]) VALUES (44, N'Simba', N'y', 6, N'aslan', 4)
INSERT [dbo].[Hayvan] ([hayvankodu], [hayvanadi], [cinsiyet], [hayvanyas], [cinsi], [egitmennum]) VALUES (55, N'uzun', N'y', 7, N'zürafa', 5)
INSERT [dbo].[Hayvan] ([hayvankodu], [hayvanadi], [cinsiyet], [hayvanyas], [cinsi], [egitmennum]) VALUES (66, N'bobo', N'x', 3, N'kedi', 3)
INSERT [dbo].[Hayvan] ([hayvankodu], [hayvanadi], [cinsiyet], [hayvanyas], [cinsi], [egitmennum]) VALUES (77, N'lila', N'x', 4, N'kedi', 2)
INSERT [dbo].[Hayvan] ([hayvankodu], [hayvanadi], [cinsiyet], [hayvanyas], [cinsi], [egitmennum]) VALUES (88, N'Şila', N'x', 5, N'Kaplumbağa', 3)
INSERT [dbo].[Hayvan] ([hayvankodu], [hayvanadi], [cinsiyet], [hayvanyas], [cinsi], [egitmennum]) VALUES (99, N'lala', N'y', 3, N'at', 2)
INSERT [dbo].[Hayvan] ([hayvankodu], [hayvanadi], [cinsiyet], [hayvanyas], [cinsi], [egitmennum]) VALUES (111, N'poco', N'x', 5, N'Kaplumbağa', 3)
GO
ALTER TABLE [dbo].[AraTablo]  WITH CHECK ADD  CONSTRAINT [FK__AraTablo__goster__440B1D61] FOREIGN KEY([gosterinum])
REFERENCES [dbo].[Gosteri] ([gosterino])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AraTablo] CHECK CONSTRAINT [FK__AraTablo__goster__440B1D61]
GO
ALTER TABLE [dbo].[AraTablo]  WITH CHECK ADD  CONSTRAINT [FK__AraTablo__hayvan__44FF419A] FOREIGN KEY([hayvanid])
REFERENCES [dbo].[Hayvan] ([hayvankodu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AraTablo] CHECK CONSTRAINT [FK__AraTablo__hayvan__44FF419A]
GO
ALTER TABLE [dbo].[Bilet]  WITH CHECK ADD  CONSTRAINT [FK__Bilet__gosterinu__412EB0B6] FOREIGN KEY([gosterinum])
REFERENCES [dbo].[Gosteri] ([gosterino])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bilet] CHECK CONSTRAINT [FK__Bilet__gosterinu__412EB0B6]
GO
ALTER TABLE [dbo].[GosteriYeri]  WITH CHECK ADD  CONSTRAINT [FK__GosteriYe__goste__3E52440B] FOREIGN KEY([gosterinum])
REFERENCES [dbo].[Gosteri] ([gosterino])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GosteriYeri] CHECK CONSTRAINT [FK__GosteriYe__goste__3E52440B]
GO
ALTER TABLE [dbo].[Hayvan]  WITH CHECK ADD  CONSTRAINT [FK__Hayvan__egitmenn__398D8EEE] FOREIGN KEY([egitmennum])
REFERENCES [dbo].[Egitmen] ([egitmenno])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Hayvan] CHECK CONSTRAINT [FK__Hayvan__egitmenn__398D8EEE]
GO
USE [master]
GO
ALTER DATABASE [Denemezoo2] SET  READ_WRITE 
GO
