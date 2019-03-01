USE [master]
GO
/****** Object:  Database [Tp_Courses]    Script Date: 28/02/2019 15:40:39 ******/
CREATE DATABASE [Tp_Courses]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Tp_Courses', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Tp_Courses.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Tp_Courses_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Tp_Courses_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Tp_Courses] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tp_Courses].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tp_Courses] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tp_Courses] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tp_Courses] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tp_Courses] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tp_Courses] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tp_Courses] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Tp_Courses] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tp_Courses] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tp_Courses] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tp_Courses] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tp_Courses] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tp_Courses] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tp_Courses] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tp_Courses] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tp_Courses] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Tp_Courses] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tp_Courses] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tp_Courses] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tp_Courses] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tp_Courses] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tp_Courses] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tp_Courses] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tp_Courses] SET RECOVERY FULL 
GO
ALTER DATABASE [Tp_Courses] SET  MULTI_USER 
GO
ALTER DATABASE [Tp_Courses] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tp_Courses] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tp_Courses] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tp_Courses] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Tp_Courses] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Tp_Courses', N'ON'
GO
USE [Tp_Courses]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 28/02/2019 15:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Course](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](255) NULL,
	[Date] [datetime] NULL,
	[VilleID] [int] NULL,
	[Organisateur] [int] NULL,
	[SportID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inscription]    Script Date: 28/02/2019 15:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscription](
	[UtilisateurID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UtilisateurID] ASC,
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[POI]    Script Date: 28/02/2019 15:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[POI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](255) NULL,
	[PositionID] [int] NOT NULL,
	[CourseID] [int] NULL,
	[Latitude] [float] NULL,
	[Longitude] [float] NULL,
 CONSTRAINT [PK_POI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Position]    Script Date: 28/02/2019 15:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Longitude] [decimal](18, 0) NULL,
	[Latitude] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sport]    Script Date: 28/02/2019 15:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sport](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Utilisateur]    Script Date: 28/02/2019 15:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Utilisateur](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](255) NULL,
	[Prenom] [varchar](255) NULL,
	[Login] [varchar](255) NULL,
	[Password] [varchar](255) NULL,
	[Role] [int] NULL,
	[VilleID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ville]    Script Date: 28/02/2019 15:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ville](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](255) NULL,
	[CodePostal] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([ID], [Nom], [Date], [VilleID], [Organisateur], [SportID]) VALUES (1, N'10km CMB', CAST(N'2010-10-10 00:00:00.000' AS DateTime), 2, 2, 1)
INSERT [dbo].[Course] ([ID], [Nom], [Date], [VilleID], [Organisateur], [SportID]) VALUES (3, N'Course 2', CAST(N'2019-02-27 00:00:00.000' AS DateTime), 1, 1, 1)
INSERT [dbo].[Course] ([ID], [Nom], [Date], [VilleID], [Organisateur], [SportID]) VALUES (4, N'Course 3', CAST(N'2019-02-27 00:00:00.000' AS DateTime), 2, 3, 2)
INSERT [dbo].[Course] ([ID], [Nom], [Date], [VilleID], [Organisateur], [SportID]) VALUES (5, N'Course 4', CAST(N'2019-02-27 00:00:00.000' AS DateTime), 2, 3, 3)
SET IDENTITY_INSERT [dbo].[Course] OFF
INSERT [dbo].[Inscription] ([UtilisateurID], [CourseID]) VALUES (1, 1)
SET IDENTITY_INSERT [dbo].[POI] ON 

INSERT [dbo].[POI] ([ID], [Libelle], [PositionID], [CourseID], [Latitude], [Longitude]) VALUES (2, N'Arrivée', 1, 1, 43, -2)
INSERT [dbo].[POI] ([ID], [Libelle], [PositionID], [CourseID], [Latitude], [Longitude]) VALUES (3, N'Départ', 2, 1, 40, -2)
SET IDENTITY_INSERT [dbo].[POI] OFF
SET IDENTITY_INSERT [dbo].[Position] ON 

INSERT [dbo].[Position] ([ID], [Longitude], [Latitude]) VALUES (1, CAST(43 AS Decimal(18, 0)), CAST(-43 AS Decimal(18, 0)))
INSERT [dbo].[Position] ([ID], [Longitude], [Latitude]) VALUES (2, CAST(20 AS Decimal(18, 0)), CAST(-20 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Position] OFF
SET IDENTITY_INSERT [dbo].[Sport] ON 

INSERT [dbo].[Sport] ([ID], [Libelle]) VALUES (1, N'Running')
INSERT [dbo].[Sport] ([ID], [Libelle]) VALUES (2, N'Velo')
INSERT [dbo].[Sport] ([ID], [Libelle]) VALUES (3, N'Automobile')
SET IDENTITY_INSERT [dbo].[Sport] OFF
SET IDENTITY_INSERT [dbo].[Utilisateur] ON 

INSERT [dbo].[Utilisateur] ([ID], [Nom], [Prenom], [Login], [Password], [Role], [VilleID]) VALUES (1, N'TEUSE', N'Bob', N'b@teuse.fr', N'bob', 0, 1)
INSERT [dbo].[Utilisateur] ([ID], [Nom], [Prenom], [Login], [Password], [Role], [VilleID]) VALUES (2, N'ADMIN', N'admin', N'admin@admin.fr', N'admin', 1, 2)
INSERT [dbo].[Utilisateur] ([ID], [Nom], [Prenom], [Login], [Password], [Role], [VilleID]) VALUES (3, N'TEST', N'test', N'test@test.fr', N'test', 0, 3)
SET IDENTITY_INSERT [dbo].[Utilisateur] OFF
SET IDENTITY_INSERT [dbo].[Ville] ON 

INSERT [dbo].[Ville] ([ID], [Nom], [CodePostal]) VALUES (1, N'La Fleche', 72200)
INSERT [dbo].[Ville] ([ID], [Nom], [CodePostal]) VALUES (2, N'Nantes', 44000)
INSERT [dbo].[Ville] ([ID], [Nom], [CodePostal]) VALUES (3, N'Angers', 49000)
INSERT [dbo].[Ville] ([ID], [Nom], [CodePostal]) VALUES (4, N'Rennes', 35000)
INSERT [dbo].[Ville] ([ID], [Nom], [CodePostal]) VALUES (5, N'Fougères', 35133)
INSERT [dbo].[Ville] ([ID], [Nom], [CodePostal]) VALUES (6, N'Parigné', 35133)
INSERT [dbo].[Ville] ([ID], [Nom], [CodePostal]) VALUES (7, N'Saint-Malo', 35000)
INSERT [dbo].[Ville] ([ID], [Nom], [CodePostal]) VALUES (8, N'Cean', 14000)
INSERT [dbo].[Ville] ([ID], [Nom], [CodePostal]) VALUES (9, N'Vannes', 56000)
INSERT [dbo].[Ville] ([ID], [Nom], [CodePostal]) VALUES (10, N'Lorient', 56000)
SET IDENTITY_INSERT [dbo].[Ville] OFF
ALTER TABLE [dbo].[Course]  WITH CHECK ADD FOREIGN KEY([Organisateur])
REFERENCES [dbo].[Utilisateur] ([ID])
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD FOREIGN KEY([Organisateur])
REFERENCES [dbo].[Utilisateur] ([ID])
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD FOREIGN KEY([SportID])
REFERENCES [dbo].[Sport] ([ID])
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD FOREIGN KEY([VilleID])
REFERENCES [dbo].[Ville] ([ID])
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD FOREIGN KEY([VilleID])
REFERENCES [dbo].[Ville] ([ID])
GO
ALTER TABLE [dbo].[Inscription]  WITH CHECK ADD FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([ID])
GO
ALTER TABLE [dbo].[Inscription]  WITH CHECK ADD FOREIGN KEY([UtilisateurID])
REFERENCES [dbo].[Utilisateur] ([ID])
GO
ALTER TABLE [dbo].[POI]  WITH CHECK ADD FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([ID])
GO
ALTER TABLE [dbo].[POI]  WITH CHECK ADD FOREIGN KEY([PositionID])
REFERENCES [dbo].[Position] ([ID])
GO
ALTER TABLE [dbo].[Utilisateur]  WITH CHECK ADD FOREIGN KEY([VilleID])
REFERENCES [dbo].[Ville] ([ID])
GO
ALTER TABLE [dbo].[Utilisateur]  WITH CHECK ADD FOREIGN KEY([VilleID])
REFERENCES [dbo].[Ville] ([ID])
GO
USE [master]
GO
ALTER DATABASE [Tp_Courses] SET  READ_WRITE 
GO
