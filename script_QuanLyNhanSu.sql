USE [master]
GO
/****** Object:  Database [quanlynhansu]    Script Date: 12/05/2021 19:33:04 ******/
CREATE DATABASE [quanlynhansu] ON  PRIMARY 
( NAME = N'quanlynhansu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\quanlynhansu.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'quanlynhansu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\quanlynhansu_log.LDF' , SIZE = 504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [quanlynhansu] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quanlynhansu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quanlynhansu] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [quanlynhansu] SET ANSI_NULLS OFF
GO
ALTER DATABASE [quanlynhansu] SET ANSI_PADDING OFF
GO
ALTER DATABASE [quanlynhansu] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [quanlynhansu] SET ARITHABORT OFF
GO
ALTER DATABASE [quanlynhansu] SET AUTO_CLOSE ON
GO
ALTER DATABASE [quanlynhansu] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [quanlynhansu] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [quanlynhansu] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [quanlynhansu] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [quanlynhansu] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [quanlynhansu] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [quanlynhansu] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [quanlynhansu] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [quanlynhansu] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [quanlynhansu] SET  ENABLE_BROKER
GO
ALTER DATABASE [quanlynhansu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [quanlynhansu] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [quanlynhansu] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [quanlynhansu] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [quanlynhansu] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [quanlynhansu] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [quanlynhansu] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [quanlynhansu] SET  READ_WRITE
GO
ALTER DATABASE [quanlynhansu] SET RECOVERY SIMPLE
GO
ALTER DATABASE [quanlynhansu] SET  MULTI_USER
GO
ALTER DATABASE [quanlynhansu] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [quanlynhansu] SET DB_CHAINING OFF
GO
USE [quanlynhansu]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 12/05/2021 19:33:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[d_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[d_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Department] ON
INSERT [dbo].[Department] ([d_id], [name]) VALUES (1, N'Kỹ Thuật')
INSERT [dbo].[Department] ([d_id], [name]) VALUES (2, N'Nhân Sự')
SET IDENTITY_INSERT [dbo].[Department] OFF
/****** Object:  Table [dbo].[Account]    Script Date: 12/05/2021 19:33:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[a_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](255) NOT NULL,
	[pass] [nvarchar](255) NOT NULL,
	[fullname] [nvarchar](255) NOT NULL,
	[a_role] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[a_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON
INSERT [dbo].[Account] ([a_id], [username], [pass], [fullname], [a_role]) VALUES (1, N'admin', N'admin', N'Nguyễn Admin', N'admin')
INSERT [dbo].[Account] ([a_id], [username], [pass], [fullname], [a_role]) VALUES (2, N'user', N'user', N'Trần User', N'user')
SET IDENTITY_INSERT [dbo].[Account] OFF
/****** Object:  Table [dbo].[Job]    Script Date: 12/05/2021 19:33:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[j_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[base_salary] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[j_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Job] ON
INSERT [dbo].[Job] ([j_id], [name], [base_salary]) VALUES (1, N'Nhân Viên IT', 1500)
INSERT [dbo].[Job] ([j_id], [name], [base_salary]) VALUES (2, N'Kế Toán', 1000)
SET IDENTITY_INSERT [dbo].[Job] OFF
/****** Object:  Table [dbo].[Employee]    Script Date: 12/05/2021 19:33:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[e_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[dob] [date] NOT NULL,
	[sex] [nvarchar](20) NOT NULL,
	[e_address] [nvarchar](255) NOT NULL,
	[idcard] [nvarchar](12) NOT NULL,
	[phone] [nvarchar](12) NOT NULL,
	[depID] [int] NULL,
	[jobID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[e_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[phone] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[idcard] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON
INSERT [dbo].[Employee] ([e_id], [name], [dob], [sex], [e_address], [idcard], [phone], [depID], [jobID]) VALUES (1, N'Nguyễn A', CAST(0x07240B00 AS Date), N'Nam', N'An Giang', N'08912300', N'123456789', 1, 1)
INSERT [dbo].[Employee] ([e_id], [name], [dob], [sex], [e_address], [idcard], [phone], [depID], [jobID]) VALUES (2, N'Lê B', CAST(0x27240B00 AS Date), N'Nữ', N'Cần Thơ', N'08912301', N'987654321', 2, 2)
SET IDENTITY_INSERT [dbo].[Employee] OFF
/****** Object:  ForeignKey [FK__Employee__depID__15502E78]    Script Date: 12/05/2021 19:33:05 ******/
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([depID])
REFERENCES [dbo].[Job] ([j_id])
GO
/****** Object:  ForeignKey [FK__Employee__jobID__164452B1]    Script Date: 12/05/2021 19:33:05 ******/
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([jobID])
REFERENCES [dbo].[Department] ([d_id])
GO
