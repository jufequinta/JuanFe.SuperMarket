CREATE TABLE [dbo].[Product_Provider](
	[Id_Product] [bigint] NOT NULL,
	[Id_Provider] [int] NOT NULL,
	[Id_Product_Provider] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Product_Provider] PRIMARY KEY CLUSTERED 
(
	[Id_Product_Provider] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Product_Provider]  WITH CHECK ADD  CONSTRAINT [FK_Product_Provider_Product] FOREIGN KEY([Id_Product])
REFERENCES [dbo].[Product] ([Id])
GO

ALTER TABLE [dbo].[Product_Provider] CHECK CONSTRAINT [FK_Product_Provider_Product]
GO

ALTER TABLE [dbo].[Product_Provider]  WITH CHECK ADD  CONSTRAINT [FK_Product_Provider_Provider] FOREIGN KEY([Id_Provider])
REFERENCES [dbo].[Provider] ([Id])
GO

ALTER TABLE [dbo].[Product_Provider] CHECK CONSTRAINT [FK_Product_Provider_Provider]
GO


