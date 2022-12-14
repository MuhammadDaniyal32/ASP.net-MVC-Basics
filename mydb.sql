USE [Asp_Daniyal]
GO
/****** Object:  Table [dbo].[city]    Script Date: 20/01/2020 1:06:40 PM ******/
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
/****** Object:  Table [dbo].[contact_tbl]    Script Date: 20/01/2020 1:06:40 PM ******/
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
/****** Object:  Table [dbo].[Country]    Script Date: 20/01/2020 1:06:40 PM ******/
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
/****** Object:  Table [dbo].[Customer_tbl]    Script Date: 20/01/2020 1:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_tbl](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
 CONSTRAINT [PK_Customer_tbl] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dep_tbl]    Script Date: 20/01/2020 1:06:40 PM ******/
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
/****** Object:  Table [dbo].[emp_tbl]    Script Date: 20/01/2020 1:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emp_tbl](
	[Emp_id] [int] IDENTITY(1,1) NOT NULL,
	[Emp_name] [varchar](10) NULL,
	[Dep_id] [int] NULL,
	[Address] [varchar](15) NULL,
	[IsDeleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee_tbl]    Script Date: 20/01/2020 1:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_tbl](
	[Emp_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](10) NULL,
	[Address] [varchar](20) NULL,
	[Age] [int] NULL,
	[Salary] [decimal](18, 0) NULL,
	[Worktype] [varchar](20) NULL,
 CONSTRAINT [PK_Employee_tbl] PRIMARY KEY CLUSTERED 
(
	[Emp_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[site_tbl]    Script Date: 20/01/2020 1:06:40 PM ******/
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
/****** Object:  Table [dbo].[state]    Script Date: 20/01/2020 1:06:40 PM ******/
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

INSERT [dbo].[Dep_tbl] ([Dep_id], [Dep_name]) VALUES (1, N'First dep')
INSERT [dbo].[Dep_tbl] ([Dep_id], [Dep_name]) VALUES (2, N'Second dep')
INSERT [dbo].[Dep_tbl] ([Dep_id], [Dep_name]) VALUES (3, N'Third dep')
SET IDENTITY_INSERT [dbo].[Dep_tbl] OFF
SET IDENTITY_INSERT [dbo].[emp_tbl] ON 

INSERT [dbo].[emp_tbl] ([Emp_id], [Emp_name], [Dep_id], [Address], [IsDeleted]) VALUES (1, N'daniyal', 1, N'abc', NULL)
INSERT [dbo].[emp_tbl] ([Emp_id], [Emp_name], [Dep_id], [Address], [IsDeleted]) VALUES (1002, N'h', 2, N'h', NULL)
INSERT [dbo].[emp_tbl] ([Emp_id], [Emp_name], [Dep_id], [Address], [IsDeleted]) VALUES (1003, N'da', 1, N'as', NULL)
INSERT [dbo].[emp_tbl] ([Emp_id], [Emp_name], [Dep_id], [Address], [IsDeleted]) VALUES (1004, N'1', 3, N'1', NULL)
INSERT [dbo].[emp_tbl] ([Emp_id], [Emp_name], [Dep_id], [Address], [IsDeleted]) VALUES (1005, N'Fahad', 1, N'Gulshan', NULL)
INSERT [dbo].[emp_tbl] ([Emp_id], [Emp_name], [Dep_id], [Address], [IsDeleted]) VALUES (1006, N'Bilal', 2, N'Karachi', NULL)
INSERT [dbo].[emp_tbl] ([Emp_id], [Emp_name], [Dep_id], [Address], [IsDeleted]) VALUES (1007, N'Junaid', 1, N'Lahore', NULL)
INSERT [dbo].[emp_tbl] ([Emp_id], [Emp_name], [Dep_id], [Address], [IsDeleted]) VALUES (1008, N'Abdullah', 1, N'Karachi', NULL)
INSERT [dbo].[emp_tbl] ([Emp_id], [Emp_name], [Dep_id], [Address], [IsDeleted]) VALUES (1009, N'Ahsan', 1, N'Karachi', NULL)
INSERT [dbo].[emp_tbl] ([Emp_id], [Emp_name], [Dep_id], [Address], [IsDeleted]) VALUES (1010, N'er', 1, N'g', NULL)
SET IDENTITY_INSERT [dbo].[emp_tbl] OFF
SET IDENTITY_INSERT [dbo].[Employee_tbl] ON 

INSERT [dbo].[Employee_tbl] ([Emp_ID], [Name], [Address], [Age], [Salary], [Worktype]) VALUES (1, N'daniyal', N'abc', 21, CAST(0 AS Decimal(18, 0)), N'none')
SET IDENTITY_INSERT [dbo].[Employee_tbl] OFF
SET IDENTITY_INSERT [dbo].[site_tbl] ON 

INSERT [dbo].[site_tbl] ([site_id], [Emp_id], [site_name]) VALUES (1, 1, N'dfd')
INSERT [dbo].[site_tbl] ([site_id], [Emp_id], [site_name]) VALUES (2, 2, N'fghj')
INSERT [dbo].[site_tbl] ([site_id], [Emp_id], [site_name]) VALUES (3, 3, N'hfg')
INSERT [dbo].[site_tbl] ([site_id], [Emp_id], [site_name]) VALUES (1002, 1002, N'f')
INSERT [dbo].[site_tbl] ([site_id], [Emp_id], [site_name]) VALUES (1003, 1003, N'aa')
INSERT [dbo].[site_tbl] ([site_id], [Emp_id], [site_name]) VALUES (1004, 1004, N'1')
INSERT [dbo].[site_tbl] ([site_id], [Emp_id], [site_name]) VALUES (1005, 1005, N'abc')
INSERT [dbo].[site_tbl] ([site_id], [Emp_id], [site_name]) VALUES (1006, 1006, N'asdf')
INSERT [dbo].[site_tbl] ([site_id], [Emp_id], [site_name]) VALUES (1007, 1007, N'asdf')
INSERT [dbo].[site_tbl] ([site_id], [Emp_id], [site_name]) VALUES (1008, 1008, N'asdf')
INSERT [dbo].[site_tbl] ([site_id], [Emp_id], [site_name]) VALUES (1009, 1009, N'asdf')
INSERT [dbo].[site_tbl] ([site_id], [Emp_id], [site_name]) VALUES (1010, 1010, N'g')
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
