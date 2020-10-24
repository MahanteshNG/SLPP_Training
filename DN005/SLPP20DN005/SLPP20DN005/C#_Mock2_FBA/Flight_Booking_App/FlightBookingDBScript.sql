USE master
GO

CREATE DATABASE [FlightBookingDB]
GO

USE [FlightBookingDB]
GO

CREATE TABLE [dbo].[BookingDetails](
	[BookingId] [int] IDENTITY(1,1) NOT NULL,
	[PassengerID] [nvarchar](10) NULL,
	[PassengerName] [nvarchar](50) NOT NULL,
	[JourneyDate] [datetime] NOT NULL,
	[NoOfTickets] [int] NOT NULL,
	[FlightID] [int] NOT NULL,
	[TotalCost] [int] NOT NULL
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[FlightDetails](
	[FlightID] [int] IDENTITY(1,1) NOT NULL,
	[Source] [nvarchar](50) NOT NULL,
	[Destination] [nvarchar](50) NOT NULL,
	[AvailableTickets] [int] NOT NULL,
	[CostperTicket] [int] NOT NULL,
	PRIMARY KEY CLUSTERED 
	(
		[FlightID] ASC
	)
)  

GO
SET IDENTITY_INSERT [dbo].[FlightDetails] ON 

GO
INSERT [dbo].[FlightDetails] ([FlightID], [Source], [Destination], [AvailableTickets], [CostperTicket]) VALUES (1, N'Singapore', N'India', 100, 4000)
GO
INSERT [dbo].[FlightDetails] ([FlightID], [Source], [Destination], [AvailableTickets], [CostperTicket]) VALUES (2, N'Malaysia', N'India', 200, 6000)
GO
SET IDENTITY_INSERT [dbo].[FlightDetails] OFF
GO
ALTER TABLE [dbo].[BookingDetails]  WITH CHECK ADD FOREIGN KEY([FlightID])
REFERENCES [dbo].[FlightDetails] ([FlightID])
GO
