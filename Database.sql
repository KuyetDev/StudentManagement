USE [master]
GO
/****** Object:  Database [Student_Management]    Script Date: 8/23/2022 12:55:20 AM ******/
CREATE DATABASE [Student_Management]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Student_Management', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Student_Management.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Student_Management_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Student_Management_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Student_Management] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Student_Management].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Student_Management] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Student_Management] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Student_Management] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Student_Management] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Student_Management] SET ARITHABORT OFF 
GO
ALTER DATABASE [Student_Management] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Student_Management] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Student_Management] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Student_Management] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Student_Management] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Student_Management] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Student_Management] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Student_Management] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Student_Management] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Student_Management] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Student_Management] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Student_Management] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Student_Management] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Student_Management] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Student_Management] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Student_Management] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Student_Management] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Student_Management] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Student_Management] SET  MULTI_USER 
GO
ALTER DATABASE [Student_Management] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Student_Management] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Student_Management] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Student_Management] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Student_Management] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Student_Management] SET QUERY_STORE = OFF
GO
USE [Student_Management]
GO
/****** Object:  Table [dbo].[Major]    Script Date: 8/23/2022 12:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Major](
	[MajorCode] [nchar](6) NOT NULL,
	[MajorName] [nchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MajorCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Result]    Script Date: 8/23/2022 12:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[StudentCode] [int] NOT NULL,
	[SubjectCode] [nchar](6) NOT NULL,
	[Mark] [int] NOT NULL,
 CONSTRAINT [PK_Result] PRIMARY KEY CLUSTERED 
(
	[StudentCode] ASC,
	[SubjectCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 8/23/2022 12:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentCode] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[DOB] [datetime] NOT NULL,
	[Gender] [bit] NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[PhoneNum] [int] NOT NULL,
	[MajorCode] [nchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 8/23/2022 12:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[SubjectCode] [nchar](6) NOT NULL,
	[SubjectName] [nchar](50) NOT NULL,
	[NumberOfSlot] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SubjectCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Major] ([MajorCode], [MajorName]) VALUES (N'MA1   ', N'CNTT                          ')
INSERT [dbo].[Major] ([MajorCode], [MajorName]) VALUES (N'MA2   ', N'KDQT                          ')
INSERT [dbo].[Major] ([MajorCode], [MajorName]) VALUES (N'MA3   ', N'NNA                           ')
GO
INSERT [dbo].[Result] ([StudentCode], [SubjectCode], [Mark]) VALUES (1, N'PRN211', 10)
INSERT [dbo].[Result] ([StudentCode], [SubjectCode], [Mark]) VALUES (1, N'PRN221', 9)
INSERT [dbo].[Result] ([StudentCode], [SubjectCode], [Mark]) VALUES (1, N'PRN231', 8)
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentCode], [StudentName], [DOB], [Gender], [Address], [PhoneNum], [MajorCode]) VALUES (1, N'Nguyen Trung Kien', CAST(N'2001-11-02T00:00:00.000' AS DateTime), 1, N'Ha Noi', 999999999, N'MA1   ')
INSERT [dbo].[Student] ([StudentCode], [StudentName], [DOB], [Gender], [Address], [PhoneNum], [MajorCode]) VALUES (2, N'Nguyen Huu Quyet', CAST(N'2001-08-17T00:00:00.000' AS DateTime), 1, N'Hai Phong', 1243454235, N'MA2   ')
INSERT [dbo].[Student] ([StudentCode], [StudentName], [DOB], [Gender], [Address], [PhoneNum], [MajorCode]) VALUES (3, N'Phan Luong Nam', CAST(N'2001-07-09T00:00:00.000' AS DateTime), 1, N'Thanh Hoa', 997978897, N'MA3   ')
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
INSERT [dbo].[Subject] ([SubjectCode], [SubjectName], [NumberOfSlot]) VALUES (N'PRN211', N'.Net fundamental                                  ', 33)
INSERT [dbo].[Subject] ([SubjectCode], [SubjectName], [NumberOfSlot]) VALUES (N'PRN221', N'.Net advanced                                     ', 33)
INSERT [dbo].[Subject] ([SubjectCode], [SubjectName], [NumberOfSlot]) VALUES (N'PRN231', N'.Net pro                                          ', 33)
GO
ALTER TABLE [dbo].[Result]  WITH CHECK ADD FOREIGN KEY([StudentCode])
REFERENCES [dbo].[Student] ([StudentCode])
GO
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Result_Subject] FOREIGN KEY([SubjectCode])
REFERENCES [dbo].[Subject] ([SubjectCode])
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Result_Subject]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([MajorCode])
REFERENCES [dbo].[Major] ([MajorCode])
GO
USE [master]
GO
ALTER DATABASE [Student_Management] SET  READ_WRITE 
GO
