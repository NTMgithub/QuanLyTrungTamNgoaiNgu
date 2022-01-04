USE [master]
GO
/****** Object:  Database [TTAN]    Script Date: 1/4/2022 1:00:26 PM ******/
CREATE DATABASE [TTAN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TTAN', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TTAN.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TTAN_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TTAN_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
ALTER DATABASE [TTAN] SET AUTO_CREATE_STATISTICS ON 
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
/****** Object:  Table [dbo].[DSThiSinhTrongPhongThi]    Script Date: 1/4/2022 1:00:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSThiSinhTrongPhongThi](
	[MADK] [int] NOT NULL,
	[MAPHONGTHI] [nvarchar](50) NOT NULL,
	[SBD] [nvarchar](50) NOT NULL,
	[DIEMNGHE] [nvarchar](50) NOT NULL,
	[DIEMNOI] [nvarchar](50) NOT NULL,
	[DIEMVIET] [nvarchar](50) NOT NULL,
	[DIEMDOC] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DSThiSinhTrongPhongThi_1] PRIMARY KEY CLUSTERED 
(
	[MAPHONGTHI] ASC,
	[MADK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 1/4/2022 1:00:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MAGV] [nvarchar](50) NOT NULL,
	[TENGV] [nvarchar](50) NOT NULL,
	[MAPHONGTHI] [nvarchar](50) NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhoaThi]    Script Date: 1/4/2022 1:00:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoaThi](
	[MAKHOATHI] [nvarchar](50) NOT NULL,
	[TENKHOATHI] [nvarchar](50) NULL,
	[NGAYTHI] [datetime] NULL,
 CONSTRAINT [PK_KHOATHI] PRIMARY KEY CLUSTERED 
(
	[MAKHOATHI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongThi]    Script Date: 1/4/2022 1:00:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongThi](
	[MAPHONGTHI] [nvarchar](50) NOT NULL,
	[MAKHOATHI] [nvarchar](50) NULL,
	[TRINHDO] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhongThi] PRIMARY KEY CLUSTERED 
(
	[MAPHONGTHI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThiSinhDK]    Script Date: 1/4/2022 1:00:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThiSinhDK](
	[MADK] [int] NOT NULL,
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
INSERT [dbo].[DSThiSinhTrongPhongThi] ([MADK], [MAPHONGTHI], [SBD], [DIEMNGHE], [DIEMNOI], [DIEMVIET], [DIEMDOC]) VALUES (1, N'A2P01', N'A2001', N'7', N'6', N'6', N'7')
INSERT [dbo].[DSThiSinhTrongPhongThi] ([MADK], [MAPHONGTHI], [SBD], [DIEMNGHE], [DIEMNOI], [DIEMVIET], [DIEMDOC]) VALUES (2, N'A2P01', N'A2002', N'7', N'8', N'9', N'8')
INSERT [dbo].[DSThiSinhTrongPhongThi] ([MADK], [MAPHONGTHI], [SBD], [DIEMNGHE], [DIEMNOI], [DIEMVIET], [DIEMDOC]) VALUES (3, N'B1P01', N'B1001', N'7', N'9', N'8', N'10')
INSERT [dbo].[GiaoVien] ([MAGV], [TENGV], [MAPHONGTHI]) VALUES (N'GV01', N'Phạm Quỳnh Anh', NULL)
INSERT [dbo].[GiaoVien] ([MAGV], [TENGV], [MAPHONGTHI]) VALUES (N'GV02', N'Triệu Lệ Dĩnh', NULL)
INSERT [dbo].[GiaoVien] ([MAGV], [TENGV], [MAPHONGTHI]) VALUES (N'GV03', N'Dương Tử', NULL)
INSERT [dbo].[KhoaThi] ([MAKHOATHI], [TENKHOATHI], [NGAYTHI]) VALUES (N'KT01', N'THI THANG 1', NULL)
INSERT [dbo].[KhoaThi] ([MAKHOATHI], [TENKHOATHI], [NGAYTHI]) VALUES (N'KT02', N'THI THANG 2', NULL)
INSERT [dbo].[KhoaThi] ([MAKHOATHI], [TENKHOATHI], [NGAYTHI]) VALUES (N'KT03', N'THI THANG 3', NULL)
INSERT [dbo].[KhoaThi] ([MAKHOATHI], [TENKHOATHI], [NGAYTHI]) VALUES (N'KT04', N'THI THANG 4', NULL)
INSERT [dbo].[PhongThi] ([MAPHONGTHI], [MAKHOATHI], [TRINHDO]) VALUES (N'A2P01', N'KT01', N'A2')
INSERT [dbo].[PhongThi] ([MAPHONGTHI], [MAKHOATHI], [TRINHDO]) VALUES (N'A2P02', N'KT01', N'A2')
INSERT [dbo].[PhongThi] ([MAPHONGTHI], [MAKHOATHI], [TRINHDO]) VALUES (N'B1P01', N'KT01', N'B1')
INSERT [dbo].[PhongThi] ([MAPHONGTHI], [MAKHOATHI], [TRINHDO]) VALUES (N'B1P02', N'KT01', N'B1')
INSERT [dbo].[ThiSinhDK] ([MADK], [CMND], [NGAYDK], [TRINHDO], [HOTEN], [GIOITINH], [NGAYSINH], [SDT], [EMAIL]) VALUES (0, N'1234567890', CAST(N'2022-01-03 12:00:00.000' AS DateTime), N'', N'phong vui ve', N'', CAST(N'2000-02-01 12:00:00.000' AS DateTime), N'0987654321', N'phong@')
INSERT [dbo].[ThiSinhDK] ([MADK], [CMND], [NGAYDK], [TRINHDO], [HOTEN], [GIOITINH], [NGAYSINH], [SDT], [EMAIL]) VALUES (1, N'272707567', CAST(N'2022-01-02 00:00:00.000' AS DateTime), N'A2', N'PHONG', N'nam', CAST(N'2000-10-10 00:00:00.000' AS DateTime), N'0987654321', N'phong@gmail.com')
INSERT [dbo].[ThiSinhDK] ([MADK], [CMND], [NGAYDK], [TRINHDO], [HOTEN], [GIOITINH], [NGAYSINH], [SDT], [EMAIL]) VALUES (2, N'232345456', CAST(N'2022-02-01 00:00:00.000' AS DateTime), N'B1', N'MEN', NULL, NULL, NULL, NULL)
INSERT [dbo].[ThiSinhDK] ([MADK], [CMND], [NGAYDK], [TRINHDO], [HOTEN], [GIOITINH], [NGAYSINH], [SDT], [EMAIL]) VALUES (3, N'232345456', CAST(N'2022-02-01 00:00:00.000' AS DateTime), N'B1', N'NHU', NULL, NULL, NULL, NULL)
INSERT [dbo].[ThiSinhDK] ([MADK], [CMND], [NGAYDK], [TRINHDO], [HOTEN], [GIOITINH], [NGAYSINH], [SDT], [EMAIL]) VALUES (4, N'232323456', CAST(N'2022-01-02 00:00:00.000' AS DateTime), N'B1', N'NINH', NULL, NULL, NULL, NULL)
ALTER TABLE [dbo].[DSThiSinhTrongPhongThi]  WITH CHECK ADD  CONSTRAINT [FK_DSThiSinhTrongPhongThi_PhongThi] FOREIGN KEY([MAPHONGTHI])
REFERENCES [dbo].[PhongThi] ([MAPHONGTHI])
GO
ALTER TABLE [dbo].[DSThiSinhTrongPhongThi] CHECK CONSTRAINT [FK_DSThiSinhTrongPhongThi_PhongThi]
GO
ALTER TABLE [dbo].[DSThiSinhTrongPhongThi]  WITH CHECK ADD  CONSTRAINT [FK_DSThiSinhTrongPhongThi_ThiSinhDK] FOREIGN KEY([MADK])
REFERENCES [dbo].[ThiSinhDK] ([MADK])
GO
ALTER TABLE [dbo].[DSThiSinhTrongPhongThi] CHECK CONSTRAINT [FK_DSThiSinhTrongPhongThi_ThiSinhDK]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_PhongThi] FOREIGN KEY([MAPHONGTHI])
REFERENCES [dbo].[PhongThi] ([MAPHONGTHI])
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
