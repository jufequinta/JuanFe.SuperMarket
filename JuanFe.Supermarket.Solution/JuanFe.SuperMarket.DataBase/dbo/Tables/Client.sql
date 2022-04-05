CREATE TABLE [dbo].[Client](
	[Id_Client] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Last_Name] [varchar](50) NOT NULL,
	[Birthday] [datetime] NOT NULL,
	[Id] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Cellphone] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id_Client] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO