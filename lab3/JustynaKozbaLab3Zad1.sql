USE [master]
GO
/****** Object:  Database [JustynaKozbaLab3Zad1]    Script Date: 26.04.2018 16:41:25 ******/
CREATE DATABASE [JustynaKozbaLab3Zad1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Library.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Library_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JustynaKozbaLab3Zad1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET ARITHABORT OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET RECOVERY FULL 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET  MULTI_USER 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'JustynaKozbaLab3Zad1', N'ON'
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET QUERY_STORE = OFF
GO
USE [JustynaKozbaLab3Zad1]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [JustynaKozbaLab3Zad1]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 26.04.2018 16:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[AuthorName] [nvarchar](50) NULL,
	[AuthorLastName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 26.04.2018 16:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[InternationalStandardBookNumber] [nvarchar](13) NULL,
	[IdCategory] [int] NULL,
	[IdAuthor] [int] NULL,
	[IdPublishingHouse] [int] NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 26.04.2018 16:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TypeOfBook] [nvarchar](20) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 26.04.2018 16:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateOfOrder] [date] NULL,
	[DateOfReceipt] [date] NULL,
	[DateOfReturn] [date] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PublishingHouse]    Script Date: 26.04.2018 16:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PublishingHouse](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[Address] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_PublishingHouse] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Readers]    Script Date: 26.04.2018 16:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Readers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[PESEL] [nvarchar](11) NULL,
	[CardNumber] [nvarchar](10) NULL,
 CONSTRAINT [PK_Readers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([id], [AuthorName], [AuthorLastName]) VALUES (1, N'Don', N'Brown')
INSERT [dbo].[Authors] ([id], [AuthorName], [AuthorLastName]) VALUES (2, N'Rick', N'Riordan')
INSERT [dbo].[Authors] ([id], [AuthorName], [AuthorLastName]) VALUES (3, N'Georde', N'Martin')
INSERT [dbo].[Authors] ([id], [AuthorName], [AuthorLastName]) VALUES (4, N'Paula', N'Hawkins')
INSERT [dbo].[Authors] ([id], [AuthorName], [AuthorLastName]) VALUES (5, N'John', N'Green')
INSERT [dbo].[Authors] ([id], [AuthorName], [AuthorLastName]) VALUES (6, N'Veronica', N'Roth')
INSERT [dbo].[Authors] ([id], [AuthorName], [AuthorLastName]) VALUES (7, N'Nora', N'Roberts')
INSERT [dbo].[Authors] ([id], [AuthorName], [AuthorLastName]) VALUES (8, N'Danielle', N'Steel')
INSERT [dbo].[Authors] ([id], [AuthorName], [AuthorLastName]) VALUES (9, N'Stephen', N'King')
INSERT [dbo].[Authors] ([id], [AuthorName], [AuthorLastName]) VALUES (10, N'John', N'Grisham')
INSERT [dbo].[Authors] ([id], [AuthorName], [AuthorLastName]) VALUES (11, N'J.K.', N'Rowling')
INSERT [dbo].[Authors] ([id], [AuthorName], [AuthorLastName]) VALUES (12, N'Jeff', N'Kinney')
INSERT [dbo].[Authors] ([id], [AuthorName], [AuthorLastName]) VALUES (13, N'James', N'Patterson')
SET IDENTITY_INSERT [dbo].[Authors] OFF
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (25, N'Kod Leonarda da Vinci', N'9658471236', NULL, 1, 1)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (26, N'Magnus Chase i Bogowie Asgaru', N'9658741529', NULL, 2, 2)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (27, N'Gra o Tron', N'2145874963', NULL, 3, 3)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (28, N'Dziewczyna z Pociągu', N'85475214569', NULL, 4, 4)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (29, N'Papierowe Miasta', N'11125448965', NULL, 5, 5)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (30, N'Trylogia Niezgodna', N'52455896547', NULL, 6, 6)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (31, N'Zaklęte Uczucia', N'88594478552', NULL, 7, 7)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (32, N'Siostry', N'54269742512', NULL, 8, 8)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (33, N'Znalezione Nie Kradzione', N'44598745612', NULL, 9, 9)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (34, N'Samotny Wilk', N'85469587421', NULL, 10, 10)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (35, N'Harry Potter', N'55965587441', NULL, 11, 6)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (36, N'Dzienik Cwaniaczka', N'56998745214', NULL, 12, 8)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (37, N'W Sieci Pająka', N'99854476324', NULL, 13, 2)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (38, N'Zielona Mila', N'98745632145', NULL, 9, 1)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (39, N'Dolores Claiborne', N'98546954721', NULL, 9, 3)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (40, N'Doktor Sen', N'21569847512', NULL, 9, 5)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (41, N'Zawod Programista ', N'12598745698', NULL, NULL, NULL)
INSERT [dbo].[Books] ([id], [Title], [InternationalStandardBookNumber], [IdCategory], [IdAuthor], [IdPublishingHouse]) VALUES (42, N'Piata Góra', N'26598745961', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Books] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([id], [TypeOfBook]) VALUES (1, N'Thriller')
INSERT [dbo].[Category] ([id], [TypeOfBook]) VALUES (2, N'Fantasy')
INSERT [dbo].[Category] ([id], [TypeOfBook]) VALUES (3, N'Fantasy')
INSERT [dbo].[Category] ([id], [TypeOfBook]) VALUES (4, N'Thriller')
INSERT [dbo].[Category] ([id], [TypeOfBook]) VALUES (5, N'Novel')
INSERT [dbo].[Category] ([id], [TypeOfBook]) VALUES (6, N'ScienceFiction')
INSERT [dbo].[Category] ([id], [TypeOfBook]) VALUES (7, N'Novel')
INSERT [dbo].[Category] ([id], [TypeOfBook]) VALUES (8, N'Novel')
INSERT [dbo].[Category] ([id], [TypeOfBook]) VALUES (9, N'Thriller')
INSERT [dbo].[Category] ([id], [TypeOfBook]) VALUES (10, N'Thriller')
INSERT [dbo].[Category] ([id], [TypeOfBook]) VALUES (11, N'Fantasy')
INSERT [dbo].[Category] ([id], [TypeOfBook]) VALUES (12, N'Tale')
INSERT [dbo].[Category] ([id], [TypeOfBook]) VALUES (13, N'Thriller')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([id], [DateOfOrder], [DateOfReceipt], [DateOfReturn]) VALUES (1, CAST(N'2018-04-22' AS Date), CAST(N'2018-04-26' AS Date), CAST(N'2018-06-01' AS Date))
INSERT [dbo].[Orders] ([id], [DateOfOrder], [DateOfReceipt], [DateOfReturn]) VALUES (2, CAST(N'2018-04-12' AS Date), CAST(N'2018-04-20' AS Date), CAST(N'2018-05-30' AS Date))
INSERT [dbo].[Orders] ([id], [DateOfOrder], [DateOfReceipt], [DateOfReturn]) VALUES (3, CAST(N'2018-03-23' AS Date), CAST(N'2018-04-01' AS Date), CAST(N'2018-06-01' AS Date))
INSERT [dbo].[Orders] ([id], [DateOfOrder], [DateOfReceipt], [DateOfReturn]) VALUES (4, CAST(N'2018-03-14' AS Date), CAST(N'2008-03-15' AS Date), CAST(N'2018-04-29' AS Date))
INSERT [dbo].[Orders] ([id], [DateOfOrder], [DateOfReceipt], [DateOfReturn]) VALUES (5, CAST(N'2018-04-01' AS Date), CAST(N'2017-04-20' AS Date), CAST(N'2018-05-01' AS Date))
INSERT [dbo].[Orders] ([id], [DateOfOrder], [DateOfReceipt], [DateOfReturn]) VALUES (6, CAST(N'2018-02-01' AS Date), CAST(N'2018-02-02' AS Date), CAST(N'2018-03-01' AS Date))
INSERT [dbo].[Orders] ([id], [DateOfOrder], [DateOfReceipt], [DateOfReturn]) VALUES (7, CAST(N'2018-01-29' AS Date), CAST(N'2018-02-01' AS Date), CAST(N'2018-03-06' AS Date))
INSERT [dbo].[Orders] ([id], [DateOfOrder], [DateOfReceipt], [DateOfReturn]) VALUES (8, CAST(N'2018-01-19' AS Date), CAST(N'2018-01-22' AS Date), CAST(N'2018-02-13' AS Date))
INSERT [dbo].[Orders] ([id], [DateOfOrder], [DateOfReceipt], [DateOfReturn]) VALUES (9, CAST(N'2018-01-10' AS Date), CAST(N'2018-01-11' AS Date), CAST(N'2018-02-22' AS Date))
INSERT [dbo].[Orders] ([id], [DateOfOrder], [DateOfReceipt], [DateOfReturn]) VALUES (10, CAST(N'2018-01-02' AS Date), CAST(N'2018-01-07' AS Date), CAST(N'2018-02-12' AS Date))
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[PublishingHouse] ON 

INSERT [dbo].[PublishingHouse] ([id], [Name], [Address], [Email]) VALUES (1, N'Znak', N'Wielka Brytania', N'znak@pub.com')
INSERT [dbo].[PublishingHouse] ([id], [Name], [Address], [Email]) VALUES (2, N'Reed Elsevier', N'Wielka Brytania', N'reedelsevier@p.com')
INSERT [dbo].[PublishingHouse] ([id], [Name], [Address], [Email]) VALUES (3, N'Thomas Reuters', N'USA', N'thomas@t.com')
INSERT [dbo].[PublishingHouse] ([id], [Name], [Address], [Email]) VALUES (4, N'Wolters Kluwer', N'Holandia', N'kluwer@el.pl')
INSERT [dbo].[PublishingHouse] ([id], [Name], [Address], [Email]) VALUES (5, N'Random House', N'Niemcy', N'random@house.com')
INSERT [dbo].[PublishingHouse] ([id], [Name], [Address], [Email]) VALUES (6, N'Hachette Livre', N'Francja', N'hachette@livre.com')
INSERT [dbo].[PublishingHouse] ([id], [Name], [Address], [Email]) VALUES (7, N'Grupo Planeta', N'Hiszpania', N'grupo@planeta.com')
INSERT [dbo].[PublishingHouse] ([id], [Name], [Address], [Email]) VALUES (8, N'Cengage', N'USA', N'cengage@pub.com')
INSERT [dbo].[PublishingHouse] ([id], [Name], [Address], [Email]) VALUES (9, N'Scholastic', N'USA', N'scholasticpub@lishing.com')
INSERT [dbo].[PublishingHouse] ([id], [Name], [Address], [Email]) VALUES (10, N'Znak', N'USA', N'wiley@house.com')
SET IDENTITY_INSERT [dbo].[PublishingHouse] OFF
SET IDENTITY_INSERT [dbo].[Readers] ON 

INSERT [dbo].[Readers] ([id], [Name], [LastName], [PESEL], [CardNumber]) VALUES (1, N'Julia', N'Kowalska', N'69031256987', N'1115552489')
INSERT [dbo].[Readers] ([id], [Name], [LastName], [PESEL], [CardNumber]) VALUES (2, N'Jan', N'Kowalski', N'85122496325', N'2583697412')
INSERT [dbo].[Readers] ([id], [Name], [LastName], [PESEL], [CardNumber]) VALUES (3, N'Julia', N'Sroka', N'94021466603', N'7891234564')
INSERT [dbo].[Readers] ([id], [Name], [LastName], [PESEL], [CardNumber]) VALUES (4, N'Adam', N'Piatek', N'69090314795', N'9874123654')
INSERT [dbo].[Readers] ([id], [Name], [LastName], [PESEL], [CardNumber]) VALUES (5, N'Piotr', N'Kamel', N'92110632597', N'8521649124')
INSERT [dbo].[Readers] ([id], [Name], [LastName], [PESEL], [CardNumber]) VALUES (6, N'Anna', N'Zdun', N'74020415201', N'1452998863')
INSERT [dbo].[Readers] ([id], [Name], [LastName], [PESEL], [CardNumber]) VALUES (7, N'Katrzyna', N'Chmiel', N'60010198745', N'9996582247')
INSERT [dbo].[Readers] ([id], [Name], [LastName], [PESEL], [CardNumber]) VALUES (8, N'Maria', N'Anton', N'98032652145', N'1145539978')
INSERT [dbo].[Readers] ([id], [Name], [LastName], [PESEL], [CardNumber]) VALUES (9, N'Klara', N'Choda', N'56122369587', N'2256322574')
INSERT [dbo].[Readers] ([id], [Name], [LastName], [PESEL], [CardNumber]) VALUES (10, N'Zbigniew', N'Lato', N'65032569841', N'0124035997')
INSERT [dbo].[Readers] ([id], [Name], [LastName], [PESEL], [CardNumber]) VALUES (19, N'Adam', N'Abacki', N'90030657890', N'3907857468')
SET IDENTITY_INSERT [dbo].[Readers] OFF
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Authors] FOREIGN KEY([IdAuthor])
REFERENCES [dbo].[Authors] ([id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Authors]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Books] FOREIGN KEY([id])
REFERENCES [dbo].[Books] ([id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Books]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Category] FOREIGN KEY([IdCategory])
REFERENCES [dbo].[Category] ([id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Category]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_PublishingHouse] FOREIGN KEY([IdPublishingHouse])
REFERENCES [dbo].[PublishingHouse] ([id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_PublishingHouse]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Orders1] FOREIGN KEY([id])
REFERENCES [dbo].[Orders] ([id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Orders1]
GO
ALTER TABLE [dbo].[Readers]  WITH CHECK ADD  CONSTRAINT [FK_Readers_Readers] FOREIGN KEY([id])
REFERENCES [dbo].[Readers] ([id])
GO
ALTER TABLE [dbo].[Readers] CHECK CONSTRAINT [FK_Readers_Readers]
GO
USE [master]
GO
ALTER DATABASE [JustynaKozbaLab3Zad1] SET  READ_WRITE 
GO
