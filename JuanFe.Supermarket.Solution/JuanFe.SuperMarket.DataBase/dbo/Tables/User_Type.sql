CREATE TABLE [dbo].[User_Type](
	[Id] [smallint] NOT NULL,
	[User_Type] [varchar](50) NOT NULL,
	[User_Type_Description] [varchar](150) NOT NULL,
 CONSTRAINT [PK_User_Type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO