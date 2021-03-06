USE [Employee]
GO
/****** Object:  Table [dbo].[departments]    Script Date: 8/31/2018 11:59:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[departments](
	[dept_no] [nvarchar](50) NOT NULL,
	[dept_name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[dept_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employees]    Script Date: 8/31/2018 11:59:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employees](
	[emp_no] [int] NOT NULL,
	[title_name] [varchar](50) NULL,
	[first_name] [varchar](50) NULL,
	[last_name] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[department] [varchar](50) NULL,
	[salary] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[genders]    Script Date: 8/31/2018 11:59:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[genders](
	[gender_id] [int] NOT NULL,
	[gender_name] [nvarchar](50) NULL,
	[gender_description] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[gender_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[titles]    Script Date: 8/31/2018 11:59:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[titles](
	[title] [int] NOT NULL,
	[title_name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[departments] ([dept_no], [dept_name]) VALUES (N'1', N'Programmer')
INSERT [dbo].[departments] ([dept_no], [dept_name]) VALUES (N'2', N'Support')
INSERT [dbo].[departments] ([dept_no], [dept_name]) VALUES (N'3', N'Tester')
INSERT [dbo].[employees] ([emp_no], [title_name], [first_name], [last_name], [gender], [department], [salary]) VALUES (2, N'Mr.', N'sdfgwertwere', N'eerr', N'1', N'Programmer', CAST(101010 AS Decimal(18, 0)))
INSERT [dbo].[employees] ([emp_no], [title_name], [first_name], [last_name], [gender], [department], [salary]) VALUES (4, N'Ms.', N'aaa', N'SSSS', N'2', N'Programmer', CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[employees] ([emp_no], [title_name], [first_name], [last_name], [gender], [department], [salary]) VALUES (5, N'Ms.', N'3R3EW', N'WE', N'2', N'Tester', CAST(2000 AS Decimal(18, 0)))
INSERT [dbo].[genders] ([gender_id], [gender_name], [gender_description]) VALUES (1, N'M', N'Male')
INSERT [dbo].[genders] ([gender_id], [gender_name], [gender_description]) VALUES (2, N'F', N'Female')
INSERT [dbo].[titles] ([title], [title_name]) VALUES (1, N'Mr.')
INSERT [dbo].[titles] ([title], [title_name]) VALUES (2, N'Ms.')
