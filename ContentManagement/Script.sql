USE [CMS]
GO
/****** Object:  Table [dbo].[Photos]    Script Date: 26-Jun-15 10:53:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Photos](
	[PhotoId] [uniqueidentifier] NOT NULL,
	[Title] [varchar](150) NULL,
	[SmallDescription] [nchar](250) NULL,
	[AlternativeText] [nchar](100) NULL,
	[ParentId] [uniqueidentifier] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
