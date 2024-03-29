USE [colegio]
GO
/****** Object:  Table [dbo].[curso]    Script Date: 25/07/2019 12:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[curso](
	[id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](max) NULL,
	[descripcion] [nvarchar](max) NULL,
	[fecha_inicio_clases] [nvarchar](max) NULL,
	[fecha_fin_clases] [nvarchar](max) NULL,
	[valor_mensualidad] [numeric](18, 0) NULL,
	[cedula_profesor] [nvarchar](50) NULL,
 CONSTRAINT [PK_plan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inscripcion]    Script Date: 25/07/2019 12:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inscripcion](
	[id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[id_niño] [nvarchar](20) NULL,
	[id_curso] [nvarchar](20) NULL,
	[fecha] [datetime] NULL,
 CONSTRAINT [PK_inscripcion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mensualidad]    Script Date: 25/07/2019 12:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mensualidad](
	[id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[id_inscripcion] [numeric](18, 0) NULL,
	[estado] [nvarchar](50) NULL,
	[valor_pagado] [numeric](18, 0) NULL,
	[deuda] [numeric](18, 0) NULL,
	[fecha] [datetime] NULL,
 CONSTRAINT [PK_mensualidad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[niño]    Script Date: 25/07/2019 12:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[niño](
	[id] [nvarchar](20) NULL,
	[nombre] [nvarchar](max) NULL,
	[edad] [nvarchar](max) NULL,
	[sexo] [nvarchar](max) NULL,
	[id_acudiente] [nvarchar](max) NULL,
	[nombre_acudiente] [nvarchar](max) NULL,
	[telefono_acudiente] [nvarchar](max) NULL,
	[direccion_acudiente] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[profesor]    Script Date: 25/07/2019 12:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profesor](
	[cedula] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](max) NULL,
	[telefono] [nvarchar](max) NULL,
	[direccion] [nvarchar](max) NULL,
 CONSTRAINT [PK_profesor] PRIMARY KEY CLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salidas_entradas]    Script Date: 25/07/2019 12:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salidas_entradas](
	[id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[tipo] [nvarchar](50) NULL,
	[fecha] [datetime] NULL,
	[id_niño] [nvarchar](20) NULL,
 CONSTRAINT [PK_salidas_entradas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[curso] ON 

INSERT [dbo].[curso] ([id], [nombre], [descripcion], [fecha_inicio_clases], [fecha_fin_clases], [valor_mensualidad], [cedula_profesor]) VALUES (CAST(16 AS Numeric(18, 0)), N'kinder', N'de 2 a 4 años', N'01/10/2019 0:00:00', N'25/07/2019 0:00:00', CAST(170000 AS Numeric(18, 0)), N'123')
INSERT [dbo].[curso] ([id], [nombre], [descripcion], [fecha_inicio_clases], [fecha_fin_clases], [valor_mensualidad], [cedula_profesor]) VALUES (CAST(17 AS Numeric(18, 0)), N'preescolar', N'de 5 a 6 años', N'01/10/2019 0:00:00', N'25/07/2019 0:00:00', CAST(180000 AS Numeric(18, 0)), N'123')
INSERT [dbo].[curso] ([id], [nombre], [descripcion], [fecha_inicio_clases], [fecha_fin_clases], [valor_mensualidad], [cedula_profesor]) VALUES (CAST(18 AS Numeric(18, 0)), N'primero', N'de 7 a 8 años', N'25/07/2019 0:00:00', N'01/10/2019 0:00:00', CAST(190000 AS Numeric(18, 0)), N'456')
SET IDENTITY_INSERT [dbo].[curso] OFF
SET IDENTITY_INSERT [dbo].[inscripcion] ON 

INSERT [dbo].[inscripcion] ([id], [id_niño], [id_curso], [fecha]) VALUES (CAST(1 AS Numeric(18, 0)), N'111', N'16', CAST(N'2019-07-25T05:34:49.703' AS DateTime))
INSERT [dbo].[inscripcion] ([id], [id_niño], [id_curso], [fecha]) VALUES (CAST(3 AS Numeric(18, 0)), N'222', N'17', CAST(N'2019-07-25T05:36:04.267' AS DateTime))
SET IDENTITY_INSERT [dbo].[inscripcion] OFF
SET IDENTITY_INSERT [dbo].[mensualidad] ON 

INSERT [dbo].[mensualidad] ([id], [id_inscripcion], [estado], [valor_pagado], [deuda], [fecha]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'Pago completo', CAST(170000 AS Numeric(18, 0)), CAST(0 AS Numeric(18, 0)), CAST(N'2019-07-25T09:10:51.160' AS DateTime))
INSERT [dbo].[mensualidad] ([id], [id_inscripcion], [estado], [valor_pagado], [deuda], [fecha]) VALUES (CAST(4 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'Pago completo', CAST(180000 AS Numeric(18, 0)), CAST(0 AS Numeric(18, 0)), CAST(N'2019-07-25T09:21:29.113' AS DateTime))
SET IDENTITY_INSERT [dbo].[mensualidad] OFF
INSERT [dbo].[niño] ([id], [nombre], [edad], [sexo], [id_acudiente], [nombre_acudiente], [telefono_acudiente], [direccion_acudiente]) VALUES (N'111', N'orlandito liñan', N'3', N'Masculino', N'1065000000', N'juan alberto perez', N'310478990', N'cra 15 # 30-20 La esperanza')
INSERT [dbo].[niño] ([id], [nombre], [edad], [sexo], [id_acudiente], [nombre_acudiente], [telefono_acudiente], [direccion_acudiente]) VALUES (N'222', N'juan ramirez lago', N'2', N'Masculino', N'1065000001', N'lucho ramirez', N'3123456789', N'cll 6 N23-15')
INSERT [dbo].[profesor] ([cedula], [nombre], [telefono], [direccion]) VALUES (N'123', N'Juan Alberto Rolls', N'cra 20 # 7 30', N'3298765554')
INSERT [dbo].[profesor] ([cedula], [nombre], [telefono], [direccion]) VALUES (N'456', N'Alma Josefa Diaz', N'cra 23 N 7bbis 18', N'5701567')
SET IDENTITY_INSERT [dbo].[salidas_entradas] ON 

INSERT [dbo].[salidas_entradas] ([id], [tipo], [fecha], [id_niño]) VALUES (CAST(1 AS Numeric(18, 0)), N'Entrada', CAST(N'2019-07-25T09:49:11.370' AS DateTime), N'111')
INSERT [dbo].[salidas_entradas] ([id], [tipo], [fecha], [id_niño]) VALUES (CAST(2 AS Numeric(18, 0)), N'Salida', CAST(N'2019-07-25T10:08:36.023' AS DateTime), N'111')
INSERT [dbo].[salidas_entradas] ([id], [tipo], [fecha], [id_niño]) VALUES (CAST(3 AS Numeric(18, 0)), N'Entrada', CAST(N'2019-07-25T10:08:43.623' AS DateTime), N'111')
INSERT [dbo].[salidas_entradas] ([id], [tipo], [fecha], [id_niño]) VALUES (CAST(4 AS Numeric(18, 0)), N'Salida', CAST(N'2019-07-25T10:08:52.300' AS DateTime), N'111')
INSERT [dbo].[salidas_entradas] ([id], [tipo], [fecha], [id_niño]) VALUES (CAST(5 AS Numeric(18, 0)), N'Entrada', CAST(N'2019-07-25T10:09:02.313' AS DateTime), N'222')
INSERT [dbo].[salidas_entradas] ([id], [tipo], [fecha], [id_niño]) VALUES (CAST(6 AS Numeric(18, 0)), N'Salida', CAST(N'2019-07-25T10:09:10.167' AS DateTime), N'222')
SET IDENTITY_INSERT [dbo].[salidas_entradas] OFF
ALTER TABLE [dbo].[inscripcion] ADD  CONSTRAINT [DF_inscripcion_fecha]  DEFAULT (getdate()) FOR [fecha]
GO
ALTER TABLE [dbo].[mensualidad] ADD  CONSTRAINT [DF_mensualidad_deuda]  DEFAULT ((0)) FOR [deuda]
GO
ALTER TABLE [dbo].[mensualidad] ADD  CONSTRAINT [DF_mensualidad_fecha]  DEFAULT (getdate()) FOR [fecha]
GO
ALTER TABLE [dbo].[salidas_entradas] ADD  CONSTRAINT [DF_salidas_entradas_fecha]  DEFAULT (getdate()) FOR [fecha]
GO
