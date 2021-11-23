USE [quanlynhansu]
GO
/****** Object:  ForeignKey [FK__Employee__depID__0F975522]    Script Date: 11/22/2021 13:57:16 ******/
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK__Employee__depID__0F975522]
GO
/****** Object:  ForeignKey [FK__Employee__jobID__108B795B]    Script Date: 11/22/2021 13:57:16 ******/
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK__Employee__jobID__108B795B]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11/22/2021 13:57:16 ******/
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK__Employee__depID__0F975522]
GO
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK__Employee__jobID__108B795B]
GO
DROP TABLE [dbo].[Employee]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 11/22/2021 13:57:16 ******/
DROP TABLE [dbo].[Job]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/22/2021 13:57:16 ******/
DROP TABLE [dbo].[Account]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 11/22/2021 13:57:16 ******/
DROP TABLE [dbo].[Department]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 11/22/2021 13:57:16 ******/
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
INSERT [dbo].[Department] ([d_id], [name]) VALUES (1, N'Nhân Sự')
INSERT [dbo].[Department] ([d_id], [name]) VALUES (2, N'Kỹ Thuật')
SET IDENTITY_INSERT [dbo].[Department] OFF
/****** Object:  Table [dbo].[Account]    Script Date: 11/22/2021 13:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[username] [nvarchar](255) NOT NULL,
	[pass] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([username], [pass]) VALUES (N'admin', N'admin')
INSERT [dbo].[Account] ([username], [pass]) VALUES (N'user', N'user')
/****** Object:  Table [dbo].[Job]    Script Date: 11/22/2021 13:57:16 ******/
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
/****** Object:  Table [dbo].[Employee]    Script Date: 11/22/2021 13:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[e_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[dob] [date] NOT NULL,
	[e_address] [nvarchar](255) NOT NULL,
	[phone] [char](12) NOT NULL,
	[depID] [int] NULL,
	[jobID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[e_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[phone] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON
INSERT [dbo].[Employee] ([e_id], [name], [dob], [e_address], [phone], [depID], [jobID]) VALUES (1, N'Nguyễn Văn A', CAST(0x07240B00 AS Date), N'Cần Thơ', N'123456789   ', 1, 1)
INSERT [dbo].[Employee] ([e_id], [name], [dob], [e_address], [phone], [depID], [jobID]) VALUES (2, N'Trần Văn B', CAST(0x27240B00 AS Date), N'An Giang', N'987654321   ', 2, 2)
SET IDENTITY_INSERT [dbo].[Employee] OFF
/****** Object:  ForeignKey [FK__Employee__depID__0F975522]    Script Date: 11/22/2021 13:57:16 ******/
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([depID])
REFERENCES [dbo].[Job] ([j_id])
GO
/****** Object:  ForeignKey [FK__Employee__jobID__108B795B]    Script Date: 11/22/2021 13:57:16 ******/
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([jobID])
REFERENCES [dbo].[Department] ([d_id])
GO
