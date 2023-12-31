USE [master]
GO
/****** Object:  Database [ApilPortfolio]    Script Date: 11/8/2023 12:23:17 PM ******/
CREATE DATABASE [ApilPortfolio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ApilPortfolio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ApilPortfolio.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ApilPortfolio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ApilPortfolio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ApilPortfolio] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ApilPortfolio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ApilPortfolio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ApilPortfolio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ApilPortfolio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ApilPortfolio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ApilPortfolio] SET ARITHABORT OFF 
GO
ALTER DATABASE [ApilPortfolio] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ApilPortfolio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ApilPortfolio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ApilPortfolio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ApilPortfolio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ApilPortfolio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ApilPortfolio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ApilPortfolio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ApilPortfolio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ApilPortfolio] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ApilPortfolio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ApilPortfolio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ApilPortfolio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ApilPortfolio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ApilPortfolio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ApilPortfolio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ApilPortfolio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ApilPortfolio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ApilPortfolio] SET  MULTI_USER 
GO
ALTER DATABASE [ApilPortfolio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ApilPortfolio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ApilPortfolio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ApilPortfolio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ApilPortfolio] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ApilPortfolio] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ApilPortfolio] SET QUERY_STORE = OFF
GO
USE [ApilPortfolio]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/8/2023 12:23:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 11/8/2023 12:23:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Massages] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginModel]    Script Date: 11/8/2023 12:23:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginModel](
	[Name] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KeepLoggedIn] [bit] NOT NULL,
 CONSTRAINT [PK_LoginModel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 11/8/2023 12:23:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[Id] [nvarchar](450) NOT NULL,
	[ProjectName] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[LoginModel] ADD  DEFAULT (CONVERT([bit],(0))) FOR [KeepLoggedIn]
GO
USE [master]
GO
ALTER DATABASE [ApilPortfolio] SET  READ_WRITE 
GO
