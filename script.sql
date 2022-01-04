USE [master]
GO
/****** Object:  Database [TTAN]    Script Date: 04/01/2022 9:02:10 PM ******/
CREATE DATABASE [TTAN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TTAN', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TTAN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TTAN_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TTAN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TTAN] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TTAN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TTAN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TTAN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TTAN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TTAN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TTAN] SET ARITHABORT OFF 
GO
ALTER DATABASE [TTAN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TTAN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TTAN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TTAN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TTAN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TTAN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TTAN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TTAN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TTAN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TTAN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TTAN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TTAN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TTAN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TTAN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TTAN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TTAN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TTAN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TTAN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TTAN] SET  MULTI_USER 
GO
ALTER DATABASE [TTAN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TTAN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TTAN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TTAN] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TTAN]
GO
/****** Object:  Table [dbo].[DSThiSinhTrongPhongThi]    Script Date: 04/01/2022 9:02:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSThiSinhTrongPhongThi](
	[MADK] [int] IDENTITY(1,1) NOT NULL,
	[MAPHONGTHI] [nvarchar](50) NOT NULL,
	[MAKHOATHI] [int] NOT NULL,
	[SBD] [nvarchar](50) NOT NULL,
	[DIEMNGHE] [nvarchar](50) NOT NULL,
	[DIEMNOI] [nvarchar](50) NOT NULL,
	[DIEMVIET] [nvarchar](50) NOT NULL,
	[DIEMDOC] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DSThiSinhTrongPhongThi] PRIMARY KEY CLUSTERED 
(
	[MADK] ASC,
	[MAPHONGTHI] ASC,
	[MAKHOATHI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 04/01/2022 9:02:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TENGV] [nvarchar](50) NOT NULL,
	[MAPHONGTHI] [nvarchar](50) NOT NULL,
	[MAKHOATHI] [int] NOT NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[MAPHONGTHI] ASC,
	[MAKHOATHI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoaThi]    Script Date: 04/01/2022 9:02:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoaThi](
	[MAKHOATHI] [int] IDENTITY(1,1) NOT NULL,
	[TENKHOATHI] [nvarchar](50) NULL,
	[NGAYTHI] [datetime] NULL,
 CONSTRAINT [PK_KHOATHI] PRIMARY KEY CLUSTERED 
(
	[MAKHOATHI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongThi]    Script Date: 04/01/2022 9:02:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongThi](
	[MAPHONGTHI] [nvarchar](50) NOT NULL,
	[MAKHOATHI] [int] NOT NULL,
	[TRINHDO] [nvarchar](50) NULL,
 CONSTRAINT [PK__PhongThi__3E119885863A2E57] PRIMARY KEY CLUSTERED 
(
	[MAPHONGTHI] ASC,
	[MAKHOATHI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThiSinhDK]    Script Date: 04/01/2022 9:02:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThiSinhDK](
	[MADK] [int] IDENTITY(1,1) NOT NULL,
	[CMND] [nvarchar](50) NOT NULL,
	[NGAYDK] [datetime] NOT NULL,
	[TRINHDO] [nvarchar](50) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[GIOITINH] [nvarchar](50) NULL,
	[NGAYSINH] [datetime] NULL,
	[SDT] [nvarchar](50) NULL,
	[EMAIL] [nvarchar](50) NULL,
 CONSTRAINT [PK_ThiSinh_1] PRIMARY KEY CLUSTERED 
(
	[MADK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ThiSinhDK] ON 

INSERT [dbo].[ThiSinhDK] ([MADK], [CMND], [NGAYDK], [TRINHDO], [HOTEN], [GIOITINH], [NGAYSINH], [SDT], [EMAIL]) VALUES (9, N'2312312312', CAST(N'2022-01-04T12:00:00.000' AS DateTime), N'A2', N'Nguyễn Văn Ba', N'Nam', CAST(N'2000-01-04T12:00:00.000' AS DateTime), N'0563423423', N'aaaaa@gmail.com')
INSERT [dbo].[ThiSinhDK] ([MADK], [CMND], [NGAYDK], [TRINHDO], [HOTEN], [GIOITINH], [NGAYSINH], [SDT], [EMAIL]) VALUES (10, N'2123123112', CAST(N'2022-01-04T12:00:00.000' AS DateTime), N'B1', N'Nguyễn Ngọc Quỳnh Như', N'Nữ', CAST(N'2000-01-12T12:00:00.000' AS DateTime), N'0562342342', N'2adasdasd@yopmail.com')
SET IDENTITY_INSERT [dbo].[ThiSinhDK] OFF
GO
ALTER TABLE [dbo].[DSThiSinhTrongPhongThi]  WITH CHECK ADD  CONSTRAINT [FK_DSThiSinhTrongPhongThi_PhongThi] FOREIGN KEY([MAPHONGTHI], [MAKHOATHI])
REFERENCES [dbo].[PhongThi] ([MAPHONGTHI], [MAKHOATHI])
GO
ALTER TABLE [dbo].[DSThiSinhTrongPhongThi] CHECK CONSTRAINT [FK_DSThiSinhTrongPhongThi_PhongThi]
GO
ALTER TABLE [dbo].[DSThiSinhTrongPhongThi]  WITH CHECK ADD  CONSTRAINT [FK_DSThiSinhTrongPhongThi_ThiSinhDK] FOREIGN KEY([MADK])
REFERENCES [dbo].[ThiSinhDK] ([MADK])
GO
ALTER TABLE [dbo].[DSThiSinhTrongPhongThi] CHECK CONSTRAINT [FK_DSThiSinhTrongPhongThi_ThiSinhDK]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_PhongThi] FOREIGN KEY([MAPHONGTHI], [MAKHOATHI])
REFERENCES [dbo].[PhongThi] ([MAPHONGTHI], [MAKHOATHI])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_PhongThi]
GO
ALTER TABLE [dbo].[PhongThi]  WITH CHECK ADD  CONSTRAINT [FK_PhongThi_KhoaThi] FOREIGN KEY([MAKHOATHI])
REFERENCES [dbo].[KhoaThi] ([MAKHOATHI])
GO
ALTER TABLE [dbo].[PhongThi] CHECK CONSTRAINT [FK_PhongThi_KhoaThi]
GO
USE [master]
GO
ALTER DATABASE [TTAN] SET  READ_WRITE 
GO
