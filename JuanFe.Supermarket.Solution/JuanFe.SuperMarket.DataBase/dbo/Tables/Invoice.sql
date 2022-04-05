CREATE TABLE [dbo].[Invoice](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Id_Invoce] [uniqueidentifier] NOT NULL,
	[Id_Client] [bigint] NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Invoice] ADD  CONSTRAINT [DF_Invoice_Date]  DEFAULT (getdate()) FOR [Date]
GO

ALTER TABLE [dbo].[Invoice] ADD  CONSTRAINT [DF_Invoice_IdInvoce]  DEFAULT (newid()) FOR [Id_Invoce]
GO

ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Client] FOREIGN KEY([Id_Client])
REFERENCES [dbo].[Client] ([Id_Client])
GO

ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Client]
GO
