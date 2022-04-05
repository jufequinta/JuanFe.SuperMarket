
CREATE TABLE [dbo].[User](
	[Id] [bigint] NOT NULL,
	[Id_User] [uniqueidentifier] NOT NULL,
	[User_Name] [varchar](50) NOT NULL,
	[Password] [varchar](1000) NOT NULL,
	[User_Type] [smallint] NOT NULL,
	[Id_Client] [bigint] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_User_Type] FOREIGN KEY([User_Type])
REFERENCES [dbo].[User_Type] ([Id])
GO

ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_User_Type]
GO