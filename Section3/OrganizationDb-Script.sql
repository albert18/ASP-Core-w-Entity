USE [OrganizationDB]
GO
/****** Object:  Table [dbo].[tbl_Dept]    Script Date: 23-11-2015 19:49:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Dept](
	[Did] [int] IDENTITY(100,1) NOT NULL,
	[DName] [varchar](50) NOT NULL,
	[HOD] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Dept] PRIMARY KEY CLUSTERED 
(
	[Did] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Emp]    Script Date: 23-11-2015 19:49:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Emp](
	[Eid] [int] IDENTITY(1,1) NOT NULL,
	[Ename] [varchar](50) NOT NULL,
	[Salary] [float] NOT NULL,
	[Dob] [datetime] NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Deptid] [int] NULL,
 CONSTRAINT [PK_tbl_Emp] PRIMARY KEY CLUSTERED 
(
	[Eid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 23-11-2015 19:49:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Role] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tbl_Emp]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Emp_tbl_Dept] FOREIGN KEY([Deptid])
REFERENCES [dbo].[tbl_Dept] ([Did])
GO
ALTER TABLE [dbo].[tbl_Emp] CHECK CONSTRAINT [FK_tbl_Emp_tbl_Dept]
GO
