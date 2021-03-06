/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [BloodBank]
GO
/****** Object:  Table [dbo].[BloodGroup]    Script Date: 11-Oct-17 8:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BloodGroup](
	[bgId] [int] NOT NULL,
	[bgName] [varchar](5) NOT NULL,
 CONSTRAINT [PK_BLOODGROUP] PRIMARY KEY CLUSTERED 
(
	[bgId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donation]    Script Date: 11-Oct-17 8:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donation](
	[donationId] [int] IDENTITY(1,1) NOT NULL,
	[DonorId] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_DONATION] PRIMARY KEY CLUSTERED 
(
	[donationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donor]    Script Date: 11-Oct-17 8:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donor](
	[DonorId] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](60) NOT NULL,
	[dob] [date] NULL,
	[bloodGroup] [int] NOT NULL,
	[weight] [int] NULL,
	[mobileNo] [varchar](15) NOT NULL,
	[address] [varchar](150) NOT NULL,
	[lastDonationDate] [date] NULL,
	[lastrecipientDate] [date] NULL,
 CONSTRAINT [PK_Donor] PRIMARY KEY CLUSTERED 
(
	[DonorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reciption]    Script Date: 11-Oct-17 8:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reciption](
	[receptionId] [int] IDENTITY(1,1) NOT NULL,
	[DonorId] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_RECIPTION] PRIMARY KEY CLUSTERED 
(
	[receptionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Storage]    Script Date: 11-Oct-17 8:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Storage](
	[storageId] [int] NOT NULL,
	[bgId] [int] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_STORAGE] PRIMARY KEY CLUSTERED 
(
	[storageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Donation]  WITH CHECK ADD  CONSTRAINT [Donation_fk0] FOREIGN KEY([DonorId])
REFERENCES [dbo].[Donor] ([DonorId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Donation] CHECK CONSTRAINT [Donation_fk0]
GO
ALTER TABLE [dbo].[Donor]  WITH CHECK ADD  CONSTRAINT [Donor_fk0] FOREIGN KEY([bloodGroup])
REFERENCES [dbo].[BloodGroup] ([bgId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Donor] CHECK CONSTRAINT [Donor_fk0]
GO
ALTER TABLE [dbo].[Reciption]  WITH CHECK ADD  CONSTRAINT [Reciption_fk0] FOREIGN KEY([DonorId])
REFERENCES [dbo].[Donor] ([DonorId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Reciption] CHECK CONSTRAINT [Reciption_fk0]
GO
ALTER TABLE [dbo].[Storage]  WITH CHECK ADD  CONSTRAINT [Storage_fk0] FOREIGN KEY([bgId])
REFERENCES [dbo].[BloodGroup] ([bgId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Storage] CHECK CONSTRAINT [Storage_fk0]
GO
