USE [Asp_Daniyal]
GO
/****** Object:  Table [dbo].[city]    Script Date: 23/12/2019 12:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[city](
	[city_Id] [int] IDENTITY(1,1) NOT NULL,
	[city_name] [varchar](50) NULL,
 CONSTRAINT [PK_city] PRIMARY KEY CLUSTERED 
(
	[city_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[contact_tbl]    Script Date: 23/12/2019 12:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contact_tbl](
	[cont_ID] [int] IDENTITY(1,2) NOT NULL,
	[Name] [varchar](50) NULL,
	[Mobile] [varchar](15) NULL,
	[Address] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cont_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Country]    Script Date: 23/12/2019 12:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[Country_id] [int] IDENTITY(1,2) NOT NULL,
	[Country_name] [varchar](50) NULL,
	[city_Id] [varchar](50) NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Country_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dep_tbl]    Script Date: 23/12/2019 12:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dep_tbl](
	[Dep_id] [int] IDENTITY(1,1) NOT NULL,
	[Dep_name] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Dep_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[emp_tbl]    Script Date: 23/12/2019 12:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emp_tbl](
	[Emp_id] [int] IDENTITY(1,1) NOT NULL,
	[Emp_name] [varchar](10) NULL,
	[Dep_id] [int] NULL,
	[Address] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[Emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[site_tbl]    Script Date: 23/12/2019 12:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[site_tbl](
	[site_id] [int] IDENTITY(1,1) NOT NULL,
	[Emp_id] [int] NULL,
	[site_name] [varchar](20) NULL,
 CONSTRAINT [PK__site_tbl__B22FDBCAC94BD1B3] PRIMARY KEY CLUSTERED 
(
	[site_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[state]    Script Date: 23/12/2019 12:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[state](
	[State_id] [int] IDENTITY(1,3) NOT NULL,
	[State_name] [varchar](50) NULL,
	[Country_id] [int] NULL,
 CONSTRAINT [PK_state] PRIMARY KEY CLUSTERED 
(
	[State_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[city] ON 

INSERT [dbo].[city] ([city_Id], [city_name]) VALUES (1, N'Karachi')
INSERT [dbo].[city] ([city_Id], [city_name]) VALUES (2, N'Lahore')
INSERT [dbo].[city] ([city_Id], [city_name]) VALUES (3, N'Multan')
INSERT [dbo].[city] ([city_Id], [city_name]) VALUES (4, N'Las vagas')
INSERT [dbo].[city] ([city_Id], [city_name]) VALUES (5, N'Califorina')
INSERT [dbo].[city] ([city_Id], [city_name]) VALUES (6, N'shanghie')
SET IDENTITY_INSERT [dbo].[city] OFF
SET IDENTITY_INSERT [dbo].[contact_tbl] ON 

INSERT [dbo].[contact_tbl] ([cont_ID], [Name], [Mobile], [Address]) VALUES (1, N'daniyal', N'013343', N'asdfvfdv')
SET IDENTITY_INSERT [dbo].[contact_tbl] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([Country_id], [Country_name], [city_Id]) VALUES (1, N'Pakistan', N'1')
INSERT [dbo].[Country] ([Country_id], [Country_name], [city_Id]) VALUES (3, N'India', NULL)
INSERT [dbo].[Country] ([Country_id], [Country_name], [city_Id]) VALUES (5, N'China', N'6')
INSERT [dbo].[Country] ([Country_id], [Country_name], [city_Id]) VALUES (7, N'USA', N'4')
INSERT [dbo].[Country] ([Country_id], [Country_name], [city_Id]) VALUES (9, N'Iran', NULL)
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Dep_tbl] ON 

INSERT [dbo].[Dep_tbl] ([Dep_id], [Dep_name]) VALUES (1, N'sasd')
INSERT [dbo].[Dep_tbl] ([Dep_id], [Dep_name]) VALUES (2, N'dff')
INSERT [dbo].[Dep_tbl] ([Dep_id], [Dep_name]) VALUES (3, N'sfdsdf')
SET IDENTITY_INSERT [dbo].[Dep_tbl] OFF
SET IDENTITY_INSERT [dbo].[emp_tbl] ON 

INSERT [dbo].[emp_tbl] ([Emp_id], [Emp_name], [Dep_id], [Address]) VALUES (1, N'daniyal', 1, N'abc')
INSERT [dbo].[emp_tbl] ([Emp_id], [Emp_name], [Dep_id], [Address]) VALUES (2, N'ali', 2, N'cdfd')
INSERT [dbo].[emp_tbl] ([Emp_id], [Emp_name], [Dep_id], [Address]) VALUES (4, N'ahsan', 3, N'sdfsdf')
SET IDENTITY_INSERT [dbo].[emp_tbl] OFF
SET IDENTITY_INSERT [dbo].[site_tbl] ON 

INSERT [dbo].[site_tbl] ([site_id], [Emp_id], [site_name]) VALUES (1, 1, N'dfd')
INSERT [dbo].[site_tbl] ([site_id], [Emp_id], [site_name]) VALUES (2, 2, N'fghj')
INSERT [dbo].[site_tbl] ([site_id], [Emp_id], [site_name]) VALUES (3, 3, N'hfg')
SET IDENTITY_INSERT [dbo].[site_tbl] OFF
SET IDENTITY_INSERT [dbo].[state] ON 

INSERT [dbo].[state] ([State_id], [State_name], [Country_id]) VALUES (1, N'Asia', 3)
INSERT [dbo].[state] ([State_id], [State_name], [Country_id]) VALUES (4, N'East Asia', 1)
INSERT [dbo].[state] ([State_id], [State_name], [Country_id]) VALUES (7, N'West Asia', 5)
INSERT [dbo].[state] ([State_id], [State_name], [Country_id]) VALUES (10, N'Europe', 7)
INSERT [dbo].[state] ([State_id], [State_name], [Country_id]) VALUES (13, N'Midde East', 9)
SET IDENTITY_INSERT [dbo].[state] OFF
ALTER TABLE [dbo].[emp_tbl]  WITH CHECK ADD FOREIGN KEY([Dep_id])
REFERENCES [dbo].[Dep_tbl] ([Dep_id])
GO
