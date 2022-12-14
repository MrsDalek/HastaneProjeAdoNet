USE [master]
GO
/****** Object:  Database [HastaneDLL]    Script Date: 10.05.2022 14:48:53 ******/
CREATE DATABASE [HastaneDLL]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HastaneDLL', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\HastaneDLL.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HastaneDLL_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\HastaneDLL_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HastaneDLL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HastaneDLL] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HastaneDLL] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HastaneDLL] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HastaneDLL] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HastaneDLL] SET ARITHABORT OFF 
GO
ALTER DATABASE [HastaneDLL] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HastaneDLL] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HastaneDLL] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HastaneDLL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HastaneDLL] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HastaneDLL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HastaneDLL] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HastaneDLL] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HastaneDLL] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HastaneDLL] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HastaneDLL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HastaneDLL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HastaneDLL] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HastaneDLL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HastaneDLL] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HastaneDLL] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HastaneDLL] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HastaneDLL] SET RECOVERY FULL 
GO
ALTER DATABASE [HastaneDLL] SET  MULTI_USER 
GO
ALTER DATABASE [HastaneDLL] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HastaneDLL] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HastaneDLL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HastaneDLL] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HastaneDLL] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HastaneDLL', N'ON'
GO
USE [HastaneDLL]
GO
/****** Object:  Table [dbo].[AltBolge]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AltBolge](
	[AltBolgeID] [int] NOT NULL,
	[AltBolgeAdi] [nvarchar](50) NULL,
	[BolgeID] [int] NULL,
 CONSTRAINT [PK_AltBolge] PRIMARY KEY CLUSTERED 
(
	[AltBolgeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bolge]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolge](
	[BolgeID] [int] NOT NULL,
	[BolgeAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Bolge] PRIMARY KEY CLUSTERED 
(
	[BolgeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doktorlar]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doktorlar](
	[DoktorID] [int] NOT NULL,
	[TBID] [int] NULL,
	[PersonelID] [int] NULL,
 CONSTRAINT [PK_Doktorlar] PRIMARY KEY CLUSTERED 
(
	[DoktorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hasta]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hasta](
	[HastaID] [int] IDENTITY(1,1) NOT NULL,
	[HastaAdi] [nvarchar](50) NULL,
	[HastaSoyAdi] [nvarchar](50) NULL,
	[Tc_Passaport] [nchar](10) NULL,
	[durum] [bit] NULL,
 CONSTRAINT [PK__Hasta__114C5CAB61D9F8E2] PRIMARY KEY CLUSTERED 
(
	[HastaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HastaDetay]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HastaDetay](
	[HDID] [int] IDENTITY(1,1) NOT NULL,
	[HastaKanGrubu] [nvarchar](50) NULL,
	[HastaBoy] [nvarchar](50) NULL,
	[HastaKilo] [nvarchar](50) NULL,
	[HastaAdres] [nvarchar](50) NULL,
	[HastaTel] [nvarchar](50) NULL,
	[HastaYas] [int] NULL,
	[durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[HDID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hastaneler]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hastaneler](
	[HastaneID] [int] IDENTITY(1,1) NOT NULL,
	[HastaneAdi] [nvarchar](50) NULL,
	[AltBolgeID] [int] NULL,
	[HastaneTel] [nvarchar](50) NULL,
	[HastaneAdres] [nvarchar](255) NULL,
	[HastaneMail] [nvarchar](50) NULL,
	[durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[HastaneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HastaTahlil]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HastaTahlil](
	[TahlilID] [int] NOT NULL,
	[HastaID] [int] NOT NULL,
	[TahlilTarih] [date] NULL,
	[SonucTarih] [date] NULL,
	[TahlilSonuc] [nvarchar](250) NULL,
 CONSTRAINT [PK_HastaTahlil_1] PRIMARY KEY CLUSTERED 
(
	[TahlilID] ASC,
	[HastaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Muayene]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Muayene](
	[MID] [int] NOT NULL,
	[DoktorID] [int] NULL,
	[HastaID] [int] NULL,
	[MTURID] [int] NULL,
	[MGiris] [date] NULL,
	[MCikis] [date] NULL,
 CONSTRAINT [PK_Muayene] PRIMARY KEY CLUSTERED 
(
	[MID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MuayeneTedavi]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuayeneTedavi](
	[MID] [int] NOT NULL,
	[TedaviID] [int] NOT NULL,
	[ReceteAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_MuayeneTedavi] PRIMARY KEY CLUSTERED 
(
	[MID] ASC,
	[TedaviID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MuayeneTur]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuayeneTur](
	[MTURID] [int] NOT NULL,
	[MuayeneTuru] [nvarchar](50) NULL,
 CONSTRAINT [PK_MuayeneTur] PRIMARY KEY CLUSTERED 
(
	[MTURID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonelDetay]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelDetay](
	[PDID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelYas] [int] NULL,
	[PersonelCinsiyet] [bit] NULL,
	[PersonelTel] [nvarchar](50) NULL,
	[PersonelMail] [nvarchar](50) NULL,
	[PersonelAdres] [nvarchar](50) NULL,
	[PersonelTc] [nvarchar](50) NULL,
	[durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[PDID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personeller]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeller](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAdi] [nvarchar](50) NULL,
	[PersonelSoyad] [nvarchar](50) NULL,
	[HastaneID] [int] NULL,
	[UnvanID] [int] NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tahliller]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tahliller](
	[TahlilID] [int] NOT NULL,
	[TahlilTur] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tahliller] PRIMARY KEY CLUSTERED 
(
	[TahlilID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tedavi]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tedavi](
	[TedaviID] [int] NOT NULL,
	[TedaviTanim] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tedavi] PRIMARY KEY CLUSTERED 
(
	[TedaviID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TibbiBirimler]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TibbiBirimler](
	[TBID] [int] NOT NULL,
	[TibbiAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TibbiBirimler] PRIMARY KEY CLUSTERED 
(
	[TBID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unvan]    Script Date: 10.05.2022 14:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unvan](
	[UnvanID] [int] NOT NULL,
	[UnvanAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Unvan] PRIMARY KEY CLUSTERED 
(
	[UnvanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AltBolge] ([AltBolgeID], [AltBolgeAdi], [BolgeID]) VALUES (6, N'Ankara', 4)
INSERT [dbo].[AltBolge] ([AltBolgeID], [AltBolgeAdi], [BolgeID]) VALUES (10, N'Balıkesir', 1)
INSERT [dbo].[AltBolge] ([AltBolgeID], [AltBolgeAdi], [BolgeID]) VALUES (34, N'İstanbul', 1)
INSERT [dbo].[AltBolge] ([AltBolgeID], [AltBolgeAdi], [BolgeID]) VALUES (35, N'İzmir', 2)
INSERT [dbo].[AltBolge] ([AltBolgeID], [AltBolgeAdi], [BolgeID]) VALUES (48, N'Muğla', 2)
INSERT [dbo].[AltBolge] ([AltBolgeID], [AltBolgeAdi], [BolgeID]) VALUES (53, N'Rize', 3)
INSERT [dbo].[AltBolge] ([AltBolgeID], [AltBolgeAdi], [BolgeID]) VALUES (55, N'Samsun', 3)
INSERT [dbo].[AltBolge] ([AltBolgeID], [AltBolgeAdi], [BolgeID]) VALUES (58, N'Sivas', 4)
INSERT [dbo].[AltBolge] ([AltBolgeID], [AltBolgeAdi], [BolgeID]) VALUES (61, N'Trabzon', 3)
GO
INSERT [dbo].[Bolge] ([BolgeID], [BolgeAdi]) VALUES (1, N'Marmara')
INSERT [dbo].[Bolge] ([BolgeID], [BolgeAdi]) VALUES (2, N'Ege')
INSERT [dbo].[Bolge] ([BolgeID], [BolgeAdi]) VALUES (3, N'Karadeniz')
INSERT [dbo].[Bolge] ([BolgeID], [BolgeAdi]) VALUES (4, N'İç Anadolu')
GO
INSERT [dbo].[Doktorlar] ([DoktorID], [TBID], [PersonelID]) VALUES (1, 4, 9)
INSERT [dbo].[Doktorlar] ([DoktorID], [TBID], [PersonelID]) VALUES (2, 2, 2)
INSERT [dbo].[Doktorlar] ([DoktorID], [TBID], [PersonelID]) VALUES (3, 3, 1)
INSERT [dbo].[Doktorlar] ([DoktorID], [TBID], [PersonelID]) VALUES (4, 1, 10)
GO
SET IDENTITY_INSERT [dbo].[Hasta] ON 

INSERT [dbo].[Hasta] ([HastaID], [HastaAdi], [HastaSoyAdi], [Tc_Passaport], [durum]) VALUES (1, N'Furkan', N'Varaşgan', N'2231231231', 1)
INSERT [dbo].[Hasta] ([HastaID], [HastaAdi], [HastaSoyAdi], [Tc_Passaport], [durum]) VALUES (2, N'Şeyma', N'Çakıroğlu', N'2331231123', 1)
INSERT [dbo].[Hasta] ([HastaID], [HastaAdi], [HastaSoyAdi], [Tc_Passaport], [durum]) VALUES (3, N'Emine', N'Bilgi', N'1231312312', 1)
INSERT [dbo].[Hasta] ([HastaID], [HastaAdi], [HastaSoyAdi], [Tc_Passaport], [durum]) VALUES (4, N'Şafak', N'Saydır', N'8974587245', 1)
INSERT [dbo].[Hasta] ([HastaID], [HastaAdi], [HastaSoyAdi], [Tc_Passaport], [durum]) VALUES (5, N'Atakan', N'Başgjgk', N'9871235489', 1)
INSERT [dbo].[Hasta] ([HastaID], [HastaAdi], [HastaSoyAdi], [Tc_Passaport], [durum]) VALUES (6, N'elifoski', N'akoski', N'123455355 ', 1)
SET IDENTITY_INSERT [dbo].[Hasta] OFF
GO
SET IDENTITY_INSERT [dbo].[HastaDetay] ON 

INSERT [dbo].[HastaDetay] ([HDID], [HastaKanGrubu], [HastaBoy], [HastaKilo], [HastaAdres], [HastaTel], [HastaYas], [durum]) VALUES (1, N'AB+', N'163', N'55', N'İstanbul Merkez', N'012356486', 28, 1)
INSERT [dbo].[HastaDetay] ([HDID], [HastaKanGrubu], [HastaBoy], [HastaKilo], [HastaAdres], [HastaTel], [HastaYas], [durum]) VALUES (2, N'BRH+', N'190', N'85', N'Konya Merkez', N'012345890', 17, 1)
INSERT [dbo].[HastaDetay] ([HDID], [HastaKanGrubu], [HastaBoy], [HastaKilo], [HastaAdres], [HastaTel], [HastaYas], [durum]) VALUES (3, N'ARH-', N'175', N'90', N'İzmir Merkez', N'012312312', 33, 1)
INSERT [dbo].[HastaDetay] ([HDID], [HastaKanGrubu], [HastaBoy], [HastaKilo], [HastaAdres], [HastaTel], [HastaYas], [durum]) VALUES (4, N'AB-', N'155', N'70', N'Mardin Merkez', N'012345678', 25, 1)
INSERT [dbo].[HastaDetay] ([HDID], [HastaKanGrubu], [HastaBoy], [HastaKilo], [HastaAdres], [HastaTel], [HastaYas], [durum]) VALUES (5, N'0RH+', N'170', N'110', N'Diyarbakır Merkez', N'012354865', 54, 1)
INSERT [dbo].[HastaDetay] ([HDID], [HastaKanGrubu], [HastaBoy], [HastaKilo], [HastaAdres], [HastaTel], [HastaYas], [durum]) VALUES (6, N'abrh+', N'65', N'25', N'pendik', N'125446546', 25, 1)
SET IDENTITY_INSERT [dbo].[HastaDetay] OFF
GO
SET IDENTITY_INSERT [dbo].[Hastaneler] ON 

INSERT [dbo].[Hastaneler] ([HastaneID], [HastaneAdi], [AltBolgeID], [HastaneTel], [HastaneAdres], [HastaneMail], [durum]) VALUES (1, N'Wikido', 34, N'3761096941', N'169 Sundown Alley', N'johrtmann0@1688.com', 1)
INSERT [dbo].[Hastaneler] ([HastaneID], [HastaneAdi], [AltBolgeID], [HastaneTel], [HastaneAdres], [HastaneMail], [durum]) VALUES (2, N'Shufflebeat', 58, N'9263092958', N'2853 Thierer Trail', N'csempill1@guardian.co.uk', 1)
INSERT [dbo].[Hastaneler] ([HastaneID], [HastaneAdi], [AltBolgeID], [HastaneTel], [HastaneAdres], [HastaneMail], [durum]) VALUES (3, N'Wordify', 55, N'7101798357', N'903 Dovetail Way', N'olanders2@state.tx.us', 1)
INSERT [dbo].[Hastaneler] ([HastaneID], [HastaneAdi], [AltBolgeID], [HastaneTel], [HastaneAdres], [HastaneMail], [durum]) VALUES (4, N'Gevee', 61, N'8297004325', N'0 Express Drive', N'mbourget3@arizona.edu', 1)
INSERT [dbo].[Hastaneler] ([HastaneID], [HastaneAdi], [AltBolgeID], [HastaneTel], [HastaneAdres], [HastaneMail], [durum]) VALUES (5, N'Tekfly', 53, N'6590356920', N'7 Fordem Drive', N'llongforth4@bbb.org', 1)
INSERT [dbo].[Hastaneler] ([HastaneID], [HastaneAdi], [AltBolgeID], [HastaneTel], [HastaneAdres], [HastaneMail], [durum]) VALUES (6, N'Feedbug', 35, N'2337311074', N'7944 Gateway Court', N'ghellyer5@wunderground.com', 1)
INSERT [dbo].[Hastaneler] ([HastaneID], [HastaneAdi], [AltBolgeID], [HastaneTel], [HastaneAdres], [HastaneMail], [durum]) VALUES (7, N'Avavee', 48, N'0622245163', N'6673 Arapahoe Street', N'scosley6@histats.com', 1)
INSERT [dbo].[Hastaneler] ([HastaneID], [HastaneAdi], [AltBolgeID], [HastaneTel], [HastaneAdres], [HastaneMail], [durum]) VALUES (8, N'Quamba', 6, N'6414892742', N'0328 Esker Crossing', N'nsowter7@bluehost.com', 1)
INSERT [dbo].[Hastaneler] ([HastaneID], [HastaneAdi], [AltBolgeID], [HastaneTel], [HastaneAdres], [HastaneMail], [durum]) VALUES (9, N'Voomm', 10, N'8811900654', N'1201 Spohn Lane', N'mmacgillivray8@oaic.gov.au', 1)
SET IDENTITY_INSERT [dbo].[Hastaneler] OFF
GO
INSERT [dbo].[HastaTahlil] ([TahlilID], [HastaID], [TahlilTarih], [SonucTarih], [TahlilSonuc]) VALUES (1, 2, CAST(N'2022-02-18' AS Date), CAST(N'2022-02-20' AS Date), N'Negatif')
INSERT [dbo].[HastaTahlil] ([TahlilID], [HastaID], [TahlilTarih], [SonucTarih], [TahlilSonuc]) VALUES (1, 3, CAST(N'2022-02-15' AS Date), CAST(N'2022-02-15' AS Date), N'Negatif')
INSERT [dbo].[HastaTahlil] ([TahlilID], [HastaID], [TahlilTarih], [SonucTarih], [TahlilSonuc]) VALUES (2, 1, CAST(N'2022-02-21' AS Date), CAST(N'2022-02-21' AS Date), N'Negatif')
GO
INSERT [dbo].[Muayene] ([MID], [DoktorID], [HastaID], [MTURID], [MGiris], [MCikis]) VALUES (1, 4, 2, 1, CAST(N'2022-02-20' AS Date), CAST(N'2022-02-20' AS Date))
INSERT [dbo].[Muayene] ([MID], [DoktorID], [HastaID], [MTURID], [MGiris], [MCikis]) VALUES (2, 3, 4, 2, CAST(N'2022-02-19' AS Date), CAST(N'2022-03-19' AS Date))
INSERT [dbo].[Muayene] ([MID], [DoktorID], [HastaID], [MTURID], [MGiris], [MCikis]) VALUES (3, 3, 1, 1, CAST(N'2022-02-21' AS Date), CAST(N'2022-02-21' AS Date))
INSERT [dbo].[Muayene] ([MID], [DoktorID], [HastaID], [MTURID], [MGiris], [MCikis]) VALUES (4, 2, 3, 2, CAST(N'2021-12-15' AS Date), CAST(N'2022-01-24' AS Date))
INSERT [dbo].[Muayene] ([MID], [DoktorID], [HastaID], [MTURID], [MGiris], [MCikis]) VALUES (5, 1, 5, 2, CAST(N'2022-02-21' AS Date), NULL)
GO
INSERT [dbo].[MuayeneTedavi] ([MID], [TedaviID], [ReceteAdi]) VALUES (1, 2, N'A0564XC')
INSERT [dbo].[MuayeneTedavi] ([MID], [TedaviID], [ReceteAdi]) VALUES (2, 1, N'X2312DS')
INSERT [dbo].[MuayeneTedavi] ([MID], [TedaviID], [ReceteAdi]) VALUES (3, 4, N'G124XGF')
INSERT [dbo].[MuayeneTedavi] ([MID], [TedaviID], [ReceteAdi]) VALUES (4, 3, N'RFGGWE')
INSERT [dbo].[MuayeneTedavi] ([MID], [TedaviID], [ReceteAdi]) VALUES (5, 4, N'')
GO
INSERT [dbo].[MuayeneTur] ([MTURID], [MuayeneTuru]) VALUES (1, N'Ayakta')
INSERT [dbo].[MuayeneTur] ([MTURID], [MuayeneTuru]) VALUES (2, N'Yatakta')
GO
SET IDENTITY_INSERT [dbo].[PersonelDetay] ON 

INSERT [dbo].[PersonelDetay] ([PDID], [PersonelYas], [PersonelCinsiyet], [PersonelTel], [PersonelMail], [PersonelAdres], [PersonelTc], [durum]) VALUES (1, 35, 1, N'0124864789', N'Rory@gmail.com', N'İstanbul Üsküdar', N'5223456789', 1)
INSERT [dbo].[PersonelDetay] ([PDID], [PersonelYas], [PersonelCinsiyet], [PersonelTel], [PersonelMail], [PersonelAdres], [PersonelTc], [durum]) VALUES (2, 36, 0, N'0213456782', N'karla@gmail.com', N'Bursa ', N'1234567489', 1)
INSERT [dbo].[PersonelDetay] ([PDID], [PersonelYas], [PersonelCinsiyet], [PersonelTel], [PersonelMail], [PersonelAdres], [PersonelTc], [durum]) VALUES (3, 26, 1, N'0123456788', N'Rudolfo@gmail.com', N'Afyon', N'0123456789', 1)
INSERT [dbo].[PersonelDetay] ([PDID], [PersonelYas], [PersonelCinsiyet], [PersonelTel], [PersonelMail], [PersonelAdres], [PersonelTc], [durum]) VALUES (4, 40, 0, N'0123456789', N'katalim@gmail.com', N'Ankara', N'1015468987', 1)
INSERT [dbo].[PersonelDetay] ([PDID], [PersonelYas], [PersonelCinsiyet], [PersonelTel], [PersonelMail], [PersonelAdres], [PersonelTc], [durum]) VALUES (5, 25, 1, N'0234186798', N'raynerattack@gmail.com', N'İzmir', N'5645645652', 1)
INSERT [dbo].[PersonelDetay] ([PDID], [PersonelYas], [PersonelCinsiyet], [PersonelTel], [PersonelMail], [PersonelAdres], [PersonelTc], [durum]) VALUES (6, 54, 0, N'0234988989', N'melisande@gmail.com', N'Edirne', N'1234988945', 1)
INSERT [dbo].[PersonelDetay] ([PDID], [PersonelYas], [PersonelCinsiyet], [PersonelTel], [PersonelMail], [PersonelAdres], [PersonelTc], [durum]) VALUES (7, 25, 1, N'0524689897', N'Archaimbaud@gmail.com', N'Antalya', N'5464564564', 1)
INSERT [dbo].[PersonelDetay] ([PDID], [PersonelYas], [PersonelCinsiyet], [PersonelTel], [PersonelMail], [PersonelAdres], [PersonelTc], [durum]) VALUES (8, 52, 0, N'0564867486', N'Janine@gmail.com', N'İstanbul Kadıköy', N'5674899987', 1)
INSERT [dbo].[PersonelDetay] ([PDID], [PersonelYas], [PersonelCinsiyet], [PersonelTel], [PersonelMail], [PersonelAdres], [PersonelTc], [durum]) VALUES (9, 28, 0, N'0567489778', N'winnah@gmail.com', N'Ankara Keçiören', N'8946965456', 1)
INSERT [dbo].[PersonelDetay] ([PDID], [PersonelYas], [PersonelCinsiyet], [PersonelTel], [PersonelMail], [PersonelAdres], [PersonelTc], [durum]) VALUES (10, 23, 0, N'0564648989', N'elizabet@gmail.com', N'Trabzon', N'5646981112', 1)
SET IDENTITY_INSERT [dbo].[PersonelDetay] OFF
GO
SET IDENTITY_INSERT [dbo].[Personeller] ON 

INSERT [dbo].[Personeller] ([PersonelID], [PersonelAdi], [PersonelSoyad], [HastaneID], [UnvanID], [Durum]) VALUES (1, N'Rory', N'Kindley', 8, 1, 1)
INSERT [dbo].[Personeller] ([PersonelID], [PersonelAdi], [PersonelSoyad], [HastaneID], [UnvanID], [Durum]) VALUES (2, N'Karla', N'Lazenbury', 4, 1, 1)
INSERT [dbo].[Personeller] ([PersonelID], [PersonelAdi], [PersonelSoyad], [HastaneID], [UnvanID], [Durum]) VALUES (3, N'Rudolfo', N'Durrington', 3, 4, 1)
INSERT [dbo].[Personeller] ([PersonelID], [PersonelAdi], [PersonelSoyad], [HastaneID], [UnvanID], [Durum]) VALUES (4, N'Katalin', N'Edwards', 2, 2, 1)
INSERT [dbo].[Personeller] ([PersonelID], [PersonelAdi], [PersonelSoyad], [HastaneID], [UnvanID], [Durum]) VALUES (5, N'Rayner', N'Marley', 1, 3, 1)
INSERT [dbo].[Personeller] ([PersonelID], [PersonelAdi], [PersonelSoyad], [HastaneID], [UnvanID], [Durum]) VALUES (6, N'Melisande', N'MacNeill', 3, 3, 0)
INSERT [dbo].[Personeller] ([PersonelID], [PersonelAdi], [PersonelSoyad], [HastaneID], [UnvanID], [Durum]) VALUES (7, N'Archaimbaud', N'Revan', 1, 2, 1)
INSERT [dbo].[Personeller] ([PersonelID], [PersonelAdi], [PersonelSoyad], [HastaneID], [UnvanID], [Durum]) VALUES (8, N'Janine', N'Goodanew', 6, 2, 1)
INSERT [dbo].[Personeller] ([PersonelID], [PersonelAdi], [PersonelSoyad], [HastaneID], [UnvanID], [Durum]) VALUES (9, N'Winnah', N'Collocott', 5, 1, 0)
INSERT [dbo].[Personeller] ([PersonelID], [PersonelAdi], [PersonelSoyad], [HastaneID], [UnvanID], [Durum]) VALUES (10, N'Elizabet', N'Grigorini', 7, 1, 1)
INSERT [dbo].[Personeller] ([PersonelID], [PersonelAdi], [PersonelSoyad], [HastaneID], [UnvanID], [Durum]) VALUES (11, N'Elizabet', N'John', 1, 1, 1)
INSERT [dbo].[Personeller] ([PersonelID], [PersonelAdi], [PersonelSoyad], [HastaneID], [UnvanID], [Durum]) VALUES (12, N'Archa', N'Dea', 1, 1, 0)
SET IDENTITY_INSERT [dbo].[Personeller] OFF
GO
INSERT [dbo].[Tahliller] ([TahlilID], [TahlilTur]) VALUES (1, N'Kan')
INSERT [dbo].[Tahliller] ([TahlilID], [TahlilTur]) VALUES (2, N'Gaita')
INSERT [dbo].[Tahliller] ([TahlilID], [TahlilTur]) VALUES (3, N'Röntgen')
INSERT [dbo].[Tahliller] ([TahlilID], [TahlilTur]) VALUES (4, N'Tomografi')
INSERT [dbo].[Tahliller] ([TahlilID], [TahlilTur]) VALUES (5, N'Ultrason')
GO
INSERT [dbo].[Tedavi] ([TedaviID], [TedaviTanim]) VALUES (1, N'İlaç Tedavisi')
INSERT [dbo].[Tedavi] ([TedaviID], [TedaviTanim]) VALUES (2, N'Kemoterapi')
INSERT [dbo].[Tedavi] ([TedaviID], [TedaviTanim]) VALUES (3, N'Diyaliz')
INSERT [dbo].[Tedavi] ([TedaviID], [TedaviTanim]) VALUES (4, N'Fizik Tedavi')
GO
INSERT [dbo].[TibbiBirimler] ([TBID], [TibbiAdi]) VALUES (1, N'Beyin Cerrahisi')
INSERT [dbo].[TibbiBirimler] ([TBID], [TibbiAdi]) VALUES (2, N'İç Hastalıkları')
INSERT [dbo].[TibbiBirimler] ([TBID], [TibbiAdi]) VALUES (3, N'KBB')
INSERT [dbo].[TibbiBirimler] ([TBID], [TibbiAdi]) VALUES (4, N'Cildiye')
INSERT [dbo].[TibbiBirimler] ([TBID], [TibbiAdi]) VALUES (5, N'Gastroenteroloji')
GO
INSERT [dbo].[Unvan] ([UnvanID], [UnvanAdi]) VALUES (1, N'Doktor')
INSERT [dbo].[Unvan] ([UnvanID], [UnvanAdi]) VALUES (2, N'Hemşire')
INSERT [dbo].[Unvan] ([UnvanID], [UnvanAdi]) VALUES (3, N'Sekreter')
INSERT [dbo].[Unvan] ([UnvanID], [UnvanAdi]) VALUES (4, N'Temizlik Görevlisi')
INSERT [dbo].[Unvan] ([UnvanID], [UnvanAdi]) VALUES (5, N'Ynt.Doktor')
INSERT [dbo].[Unvan] ([UnvanID], [UnvanAdi]) VALUES (6, N'Blm.bsk.Doktor')
GO
ALTER TABLE [dbo].[Hasta] ADD  CONSTRAINT [DF__Hasta__durum__5AEE82B9]  DEFAULT ((1)) FOR [durum]
GO
ALTER TABLE [dbo].[HastaDetay] ADD  DEFAULT ((1)) FOR [durum]
GO
ALTER TABLE [dbo].[Hastaneler] ADD  DEFAULT ((1)) FOR [durum]
GO
ALTER TABLE [dbo].[PersonelDetay] ADD  DEFAULT ((1)) FOR [durum]
GO
ALTER TABLE [dbo].[Personeller] ADD  DEFAULT ((1)) FOR [Durum]
GO
ALTER TABLE [dbo].[AltBolge]  WITH CHECK ADD  CONSTRAINT [FK_AltBolge_Bolge] FOREIGN KEY([BolgeID])
REFERENCES [dbo].[Bolge] ([BolgeID])
GO
ALTER TABLE [dbo].[AltBolge] CHECK CONSTRAINT [FK_AltBolge_Bolge]
GO
ALTER TABLE [dbo].[Doktorlar]  WITH CHECK ADD  CONSTRAINT [FK_Doktorlar_TibbiBirimler] FOREIGN KEY([TBID])
REFERENCES [dbo].[TibbiBirimler] ([TBID])
GO
ALTER TABLE [dbo].[Doktorlar] CHECK CONSTRAINT [FK_Doktorlar_TibbiBirimler]
GO
ALTER TABLE [dbo].[HastaDetay]  WITH CHECK ADD  CONSTRAINT [FK_HastaDetay_Hasta] FOREIGN KEY([HDID])
REFERENCES [dbo].[Hasta] ([HastaID])
GO
ALTER TABLE [dbo].[HastaDetay] CHECK CONSTRAINT [FK_HastaDetay_Hasta]
GO
ALTER TABLE [dbo].[Hastaneler]  WITH CHECK ADD  CONSTRAINT [FK_Hastaneler_AltBolge] FOREIGN KEY([AltBolgeID])
REFERENCES [dbo].[AltBolge] ([AltBolgeID])
GO
ALTER TABLE [dbo].[Hastaneler] CHECK CONSTRAINT [FK_Hastaneler_AltBolge]
GO
ALTER TABLE [dbo].[HastaTahlil]  WITH CHECK ADD  CONSTRAINT [FK_HastaTahlil_Hasta] FOREIGN KEY([HastaID])
REFERENCES [dbo].[Hasta] ([HastaID])
GO
ALTER TABLE [dbo].[HastaTahlil] CHECK CONSTRAINT [FK_HastaTahlil_Hasta]
GO
ALTER TABLE [dbo].[HastaTahlil]  WITH CHECK ADD  CONSTRAINT [FK_HastaTahlil_Tahliller] FOREIGN KEY([TahlilID])
REFERENCES [dbo].[Tahliller] ([TahlilID])
GO
ALTER TABLE [dbo].[HastaTahlil] CHECK CONSTRAINT [FK_HastaTahlil_Tahliller]
GO
ALTER TABLE [dbo].[Muayene]  WITH CHECK ADD  CONSTRAINT [FK_Muayene_Doktorlar1] FOREIGN KEY([DoktorID])
REFERENCES [dbo].[Doktorlar] ([DoktorID])
GO
ALTER TABLE [dbo].[Muayene] CHECK CONSTRAINT [FK_Muayene_Doktorlar1]
GO
ALTER TABLE [dbo].[Muayene]  WITH CHECK ADD  CONSTRAINT [FK_Muayene_Hasta] FOREIGN KEY([HastaID])
REFERENCES [dbo].[Hasta] ([HastaID])
GO
ALTER TABLE [dbo].[Muayene] CHECK CONSTRAINT [FK_Muayene_Hasta]
GO
ALTER TABLE [dbo].[Muayene]  WITH CHECK ADD  CONSTRAINT [FK_Muayene_MuayeneTur] FOREIGN KEY([MTURID])
REFERENCES [dbo].[MuayeneTur] ([MTURID])
GO
ALTER TABLE [dbo].[Muayene] CHECK CONSTRAINT [FK_Muayene_MuayeneTur]
GO
ALTER TABLE [dbo].[MuayeneTedavi]  WITH CHECK ADD  CONSTRAINT [FK_MuayeneTedavi_Muayene] FOREIGN KEY([MID])
REFERENCES [dbo].[Muayene] ([MID])
GO
ALTER TABLE [dbo].[MuayeneTedavi] CHECK CONSTRAINT [FK_MuayeneTedavi_Muayene]
GO
ALTER TABLE [dbo].[MuayeneTedavi]  WITH CHECK ADD  CONSTRAINT [FK_MuayeneTedavi_Tedavi] FOREIGN KEY([TedaviID])
REFERENCES [dbo].[Tedavi] ([TedaviID])
GO
ALTER TABLE [dbo].[MuayeneTedavi] CHECK CONSTRAINT [FK_MuayeneTedavi_Tedavi]
GO
USE [master]
GO
ALTER DATABASE [HastaneDLL] SET  READ_WRITE 
GO
