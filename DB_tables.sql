USE [master]
GO

CREATE DATABASE [MigrationDb] 
GO
USE [MigrationDb]
GO


ALTER DATABASE [MigrationDb] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MigrationDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [MigrationDb] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [MigrationDb] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [MigrationDb] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [MigrationDb] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [MigrationDb] SET ARITHABORT OFF 
GO

ALTER DATABASE [MigrationDb] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [MigrationDb] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [MigrationDb] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [MigrationDb] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [MigrationDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [MigrationDb] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [MigrationDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [MigrationDb] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [MigrationDb] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [MigrationDb] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [MigrationDb] SET  DISABLE_BROKER 
GO

ALTER DATABASE [MigrationDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [MigrationDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [MigrationDb] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [MigrationDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [MigrationDb] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [MigrationDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [MigrationDb] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [MigrationDb] SET  READ_WRITE 
GO

ALTER DATABASE [MigrationDb] SET RECOVERY FULL 
GO

ALTER DATABASE [MigrationDb] SET  MULTI_USER 
GO

ALTER DATABASE [MigrationDb] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [MigrationDb] SET DB_CHAINING OFF 
GO

USE [MigrationDb]
GO 

/****** Object:  Table [dbo].[Table1]    Script Date: 07/27/2012 16:04:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Table1](
 [col1] [int] IDENTITY(1,1) NOT NULL,
 [col2] [nvarchar](50) NULL,
 [col3] [nvarchar](50) NULL,
 [col4] [nvarchar](50) NULL,
 [col5] [nvarchar](50) NULL,
 [col6] [nvarchar](50) NULL,
 [col7] [nvarchar](50) NULL,
 [col8] [nvarchar](50) NULL,
 [col9] [nvarchar](50) NULL,
 [col10] [nvarchar](50) NULL,
 [col11] [nvarchar](50) NULL,
 [col12] [smalldatetime] NULL,
 CONSTRAINT [PK_Table1] PRIMARY KEY CLUSTERED 
(
 [col1] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [MigrationDb]
GO 

/****** Object:  Table [dbo].[Table2]    Script Date: 07/27/2012 16:05:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Table2](
 [Id] [int] IDENTITY(1,1) NOT NULL,
 [ManagedBy] [int] NOT NULL,
 [Name] [nvarchar](200) NOT NULL,
 [ACN] [nvarchar](50) NOT NULL,
 [Phone] [nvarchar](50) NOT NULL,
 [Website] [nvarchar](100) NOT NULL,
 [AddressLine1] [nvarchar](50) NULL,
 [AddressLine2] [nvarchar](50) NOT NULL,
 [Postcode] [int] NOT NULL,
 [City] [nvarchar](50) NOT NULL,
 [State] [nvarchar](50) NOT NULL,
 [Type] [nvarchar](1) NOT NULL,
 [Reserves] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Business] PRIMARY KEY CLUSTERED 
(
 [Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [MigrationDb]
GO 

/****** Object:  Table [dbo].[Table3]    Script Date: 07/27/2012 16:05:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Table3](
 [Id] [int] IDENTITY(1,1) NOT NULL,
 [Desc] [nvarchar](50) NOT NULL,
 [Col1] [int] NOT NULL,
 [Col2] [int] NOT NULL,
 [Col3] [int] NOT NULL,
 [Col4] [int] NOT NULL,
 [Col5] [int] NOT NULL,
 [Col6] [int] NOT NULL,
 [Col7] [int] NOT NULL,
 [Col8] [int] NOT NULL,
 [Col9] [int] NOT NULL,
 [Col10] [int] NOT NULL,
 [Col11] [int] NOT NULL,
 [Col12] [int] NOT NULL,
 [Col13] [int] NOT NULL,
 [Col14] [int] NOT NULL,
 [Col15] [date] NOT NULL,
 CONSTRAINT [PK_Table3] PRIMARY KEY CLUSTERED 
(
 [Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

