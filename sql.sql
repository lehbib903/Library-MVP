USE [master]
GO
/****** Object:  Database [Library]    Script Date: 7/21/2024 7:02:40 AM ******/
CREATE DATABASE [Library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Library.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Library_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Library] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Library] SET ARITHABORT OFF 
GO
ALTER DATABASE [Library] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Library] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Library] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Library] SET  MULTI_USER 
GO
ALTER DATABASE [Library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Library] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Library] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Library] SET QUERY_STORE = ON
GO
ALTER DATABASE [Library] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Library]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 7/21/2024 7:02:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](250) NULL,
	[Date] [nvarchar](50) NULL,
	[Country] [int] NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books_Borrow]    Script Date: 7/21/2024 7:02:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books_Borrow](
	[ID] [int] NOT NULL,
	[Borrower_ID] [int] NULL,
	[Book_ID] [int] NULL,
	[Start_Date] [nvarchar](50) NULL,
	[End_Date] [nvarchar](50) NULL,
	[Notes] [nvarchar](250) NULL,
 CONSTRAINT [PK_Books_Borrow] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books_Data]    Script Date: 7/21/2024 7:02:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books_Data](
	[ID] [int] NOT NULL,
	[Book_Name] [nvarchar](250) NULL,
	[Cat_ID] [int] NULL,
	[Author_ID] [int] NULL,
	[Country_ID] [int] NULL,
	[Dar_ID] [int] NULL,
	[SubCat] [nvarchar](250) NULL,
	[Date] [nvarchar](50) NULL,
	[PagesNumber] [int] NULL,
	[Place_ID] [int] NULL,
	[Book_Statu] [nvarchar](250) NULL,
	[Book_Price] [real] NULL,
 CONSTRAINT [PK_Books_Data] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borrowers]    Script Date: 7/21/2024 7:02:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrowers](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](250) NULL,
	[Date] [nvarchar](50) NULL,
	[Phone] [nvarchar](250) NULL,
 CONSTRAINT [PK_Borrowers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/21/2024 7:02:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 7/21/2024 7:02:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dar_Nacher]    Script Date: 7/21/2024 7:02:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dar_Nacher](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](250) NULL,
	[Country] [int] NULL,
 CONSTRAINT [PK_Dar_Nacher] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Places]    Script Date: 7/21/2024 7:02:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Places](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Places] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Books_Borrow]  WITH CHECK ADD  CONSTRAINT [FK_Books_Borrow_Books_Data] FOREIGN KEY([Book_ID])
REFERENCES [dbo].[Books_Data] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books_Borrow] CHECK CONSTRAINT [FK_Books_Borrow_Books_Data]
GO
ALTER TABLE [dbo].[Books_Borrow]  WITH CHECK ADD  CONSTRAINT [FK_Books_Borrow_Borrowers] FOREIGN KEY([Borrower_ID])
REFERENCES [dbo].[Borrowers] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books_Borrow] CHECK CONSTRAINT [FK_Books_Borrow_Borrowers]
GO
ALTER TABLE [dbo].[Books_Data]  WITH CHECK ADD  CONSTRAINT [FK_Books_Data_Author] FOREIGN KEY([Author_ID])
REFERENCES [dbo].[Author] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books_Data] CHECK CONSTRAINT [FK_Books_Data_Author]
GO
ALTER TABLE [dbo].[Books_Data]  WITH CHECK ADD  CONSTRAINT [FK_Books_Data_Category] FOREIGN KEY([Cat_ID])
REFERENCES [dbo].[Category] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books_Data] CHECK CONSTRAINT [FK_Books_Data_Category]
GO
ALTER TABLE [dbo].[Books_Data]  WITH CHECK ADD  CONSTRAINT [FK_Books_Data_Country] FOREIGN KEY([Country_ID])
REFERENCES [dbo].[Country] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books_Data] CHECK CONSTRAINT [FK_Books_Data_Country]
GO
ALTER TABLE [dbo].[Books_Data]  WITH CHECK ADD  CONSTRAINT [FK_Books_Data_Dar_Nacher] FOREIGN KEY([Dar_ID])
REFERENCES [dbo].[Dar_Nacher] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books_Data] CHECK CONSTRAINT [FK_Books_Data_Dar_Nacher]
GO
ALTER TABLE [dbo].[Books_Data]  WITH CHECK ADD  CONSTRAINT [FK_Books_Data_Places] FOREIGN KEY([Place_ID])
REFERENCES [dbo].[Places] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books_Data] CHECK CONSTRAINT [FK_Books_Data_Places]
GO
/****** Object:  StoredProcedure [dbo].[categoryDelete]    Script Date: 7/21/2024 7:02:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[categoryDelete]
@Id int

AS
delete from Category where ID=@Id
GO
/****** Object:  StoredProcedure [dbo].[categoryDeleteAll]    Script Date: 7/21/2024 7:02:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[categoryDeleteAll]


AS
delete from Category 
GO
/****** Object:  StoredProcedure [dbo].[categoryGetAll]    Script Date: 7/21/2024 7:02:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[categoryGetAll]


AS
select ID as 'رقم التصنيف' , Name as 'اسم التصنيف' from Category
GO
/****** Object:  StoredProcedure [dbo].[categoryInsert]    Script Date: 7/21/2024 7:02:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[categoryInsert]
@Id int,
@Name nvarchar(250)
AS
insert into Category values(@id,@Name)
GO
/****** Object:  StoredProcedure [dbo].[categoryUpdate]    Script Date: 7/21/2024 7:02:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[categoryUpdate]
@Id int,
@Name nvarchar(250)
AS
update Category set Name=@Name where ID=@Id
GO
/****** Object:  StoredProcedure [dbo].[countryDelete]    Script Date: 7/21/2024 7:02:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 create PROCEDURE [dbo].[countryDelete]
@Id int

AS
delete from Country where Id = @Id
GO
/****** Object:  StoredProcedure [dbo].[countryDeleteAll]    Script Date: 7/21/2024 7:02:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 CREATE PROCEDURE [dbo].[countryDeleteAll]


AS
delete from Country 
GO
/****** Object:  StoredProcedure [dbo].[countryGetAll]    Script Date: 7/21/2024 7:02:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[countryGetAll]
AS
BEGIN

select ID as 'رقم الدولة' , Name as 'اسم الدولة' from Country
END;

GO
/****** Object:  StoredProcedure [dbo].[countryGetLastRow]    Script Date: 7/21/2024 7:02:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[countryGetLastRow]

AS
BEGIN

select count(ID) from Country

END;
GO
/****** Object:  StoredProcedure [dbo].[countryInsert]    Script Date: 7/21/2024 7:02:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[countryInsert]
@Id int,
@Name nvarchar(250)
AS
insert into Country values(@id,@Name)
GO
/****** Object:  StoredProcedure [dbo].[countryUpdate]    Script Date: 7/21/2024 7:02:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[countryUpdate]
@Id int,
@Name nvarchar(250)
AS
update Country set Name=@Name where ID=@Id
GO
USE [master]
GO
ALTER DATABASE [Library] SET  READ_WRITE 
GO
