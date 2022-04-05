CREATE TABLE [dbo].[Invoice_Detail](
	[Id_Invoice_Detail] [bigint] IDENTITY(1,1) NOT NULL,
	[Id_Invoice] [bigint] NOT NULL,
	[Id_Product] [bigint] NOT NULL,
 CONSTRAINT [PK_Invoice_Detail] PRIMARY KEY CLUSTERED 
(
	[Id_Invoice_Detail] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Invoice_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Detail_Invoice] FOREIGN KEY([Id_Invoice])
REFERENCES [dbo].[Invoice] ([Id])
GO

ALTER TABLE [dbo].[Invoice_Detail] CHECK CONSTRAINT [FK_Invoice_Detail_Invoice]
GO

ALTER TABLE [dbo].[Invoice_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Detail_Product] FOREIGN KEY([Id_Product])
REFERENCES [dbo].[Product] ([Id])
GO

ALTER TABLE [dbo].[Invoice_Detail] CHECK CONSTRAINT [FK_Invoice_Detail_Product]
GO


