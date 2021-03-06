USE [DACONEXTSQL]
GO
/****** Object:  Table [dbo].[Datos listas formularios ecografias]    Script Date: 22/12/2021 4:44:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Datos listas formularios ecografias](
	[CodLista] [nvarchar](2) NOT NULL,
	[ConseLista] [smallint] NOT NULL,
	[NomLista] [nvarchar](100) NOT NULL,
	[CodRegis] [nvarchar](3) NOT NULL,
	[FecRegis] [date] NOT NULL,
	[CodModi] [nvarchar](3) NOT NULL,
	[FecModi] [date] NOT NULL,
 CONSTRAINT [PK_Datos listas formularios ecografias] PRIMARY KEY CLUSTERED 
(
	[CodLista] ASC,
	[ConseLista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Datos listas formularios ecografias] ADD  CONSTRAINT [DF_Datos listas formularios ecografias_ConseLista]  DEFAULT ((0)) FOR [ConseLista]
GO
ALTER TABLE [dbo].[Datos listas formularios ecografias] ADD  CONSTRAINT [DF_Datos listas formularios ecografias_CodRegis]  DEFAULT ('001') FOR [CodRegis]
GO
ALTER TABLE [dbo].[Datos listas formularios ecografias] ADD  CONSTRAINT [DF_Datos listas formularios ecografias_FecRegis]  DEFAULT (getdate()) FOR [FecRegis]
GO
ALTER TABLE [dbo].[Datos listas formularios ecografias] ADD  CONSTRAINT [DF_Datos listas formularios ecografias_CodModi]  DEFAULT (N'001') FOR [CodModi]
GO
ALTER TABLE [dbo].[Datos listas formularios ecografias] ADD  CONSTRAINT [DF_Datos listas formularios ecografias_FecModi]  DEFAULT (getdate()) FOR [FecModi]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Código de la lista de datos en los formularios de ecografías' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos listas formularios ecografias', @level2type=N'COLUMN',@level2name=N'CodLista'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Consecutivo de la lista' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos listas formularios ecografias', @level2type=N'COLUMN',@level2name=N'ConseLista'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Código del usuario que regsitró el producto en la base de datos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos listas formularios ecografias', @level2type=N'COLUMN',@level2name=N'CodRegis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de registro en el sistema' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos listas formularios ecografias', @level2type=N'COLUMN',@level2name=N'FecRegis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Código del usuario que modificó el producto en la base de datos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos listas formularios ecografias', @level2type=N'COLUMN',@level2name=N'CodModi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de la última modificación' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos listas formularios ecografias', @level2type=N'COLUMN',@level2name=N'FecModi'
GO
