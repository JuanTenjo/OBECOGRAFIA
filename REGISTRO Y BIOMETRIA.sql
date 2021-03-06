USE [DACONEXTSQL]
GO
/****** Object:  Table [dbo].[Datos biometria de los fetos]    Script Date: 22/12/2021 4:33:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Datos biometria de los fetos](
	[NumEcoFeto] [nvarchar](10) NOT NULL,
	[FetoNum] [smallint] NOT NULL,
	[Presentacion] [nvarchar](20) NOT NULL,
	[Situacion] [nvarchar](30) NOT NULL,
	[Posicion] [nvarchar](50) NOT NULL,
	[MovCardiacos] [nvarchar](50) NULL,
	[MovRespiratorios] [nvarchar](50) NULL,
	[MovFetales] [nvarchar](50) NULL,
	[TonoFetal] [nvarchar](150) NULL,
	[ILAFeto] [nvarchar](50) NULL,
	[CordonUmbi] [nvarchar](100) NULL,
	[SexFeto] [nvarchar](1) NULL,
	[DBPFeto] [smallint] NOT NULL,
	[HCFeto] [smallint] NOT NULL,
	[ACFeto] [smallint] NOT NULL,
	[LFFeto] [smallint] NOT NULL,
	[PesoFeto] [smallint] NOT NULL,
	[FCFFeto] [smallint] NOT NULL,
	[SacoGesta] [smallint] NOT NULL,
	[VesiVitelina] [smallint] NOT NULL,
	[BotonEmbriona] [smallint] NOT NULL,
	[LCN] [smallint] NOT NULL,
	[TotaPunt] [nvarchar](150) NULL,
	[PuntajeILA] [nvarchar](8) NULL,
	[PuntajeMovFet] [nvarchar](8) NULL,
	[PuntajeMovRes] [nvarchar](8) NULL,
	[PuntajeTonMusc] [nvarchar](8) NULL,
 CONSTRAINT [PK_Datos biometria de los fetos] PRIMARY KEY CLUSTERED 
(
	[NumEcoFeto] ASC,
	[FetoNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Datos registros de ecografias]    Script Date: 22/12/2021 4:33:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Datos registros de ecografias](
	[NumEcogra] [nvarchar](10) NOT NULL,
	[TipoEco] [nvarchar](2) NOT NULL,
	[NumAten] [nvarchar](10) NOT NULL,
	[NumFactu] [nvarchar](10) NULL,
	[NumHisEco] [nvarchar](15) NOT NULL,
	[FecRealECO] [date] NOT NULL,
	[TransFrec] [nvarchar](10) NULL,
	[SeConoFUM] [bit] NULL,
	[FUMEco] [date] NULL,
	[EdadGesFum] [nvarchar](50) NULL,
	[FPPFUM] [date] NULL,
	[NumFetos] [smallint] NOT NULL,
	[Utero] [nvarchar](max) NULL,
	[Placenta] [nvarchar](50) NULL,
	[GraMaPla] [nvarchar](3) NULL,
	[EspePlace] [smallint] NOT NULL,
	[NumSemEco] [smallint] NOT NULL,
	[NumDiasEco] [smallint] NOT NULL,
	[FPPEco] [date] NULL,
	[ConclusECO] [nvarchar](max) NOT NULL,
	[CodMedECO] [nvarchar](3) NULL,
	[CodAuxECO] [nvarchar](3) NULL,
	[ArchivEco] [bit] NOT NULL,
	[CodArchi] [nvarchar](3) NOT NULL,
	[FecArchi] [date] NOT NULL,
	[AnulEco] [bit] NOT NULL,
	[RazAnulEco] [nvarchar](255) NOT NULL,
	[CodAnulEco] [nvarchar](3) NOT NULL,
	[FecAnulEco] [date] NOT NULL,
	[CodRegis] [nvarchar](3) NOT NULL,
	[FecRegis] [date] NOT NULL,
	[CodModi] [nvarchar](3) NOT NULL,
	[FecModi] [date] NOT NULL,
	[CervixEsta] [nvarchar](50) NULL,
	[DiamLongi] [smallint] NOT NULL,
	[DiamAntePos] [smallint] NOT NULL,
	[DiamTras] [smallint] NOT NULL,
	[Endometrio] [smallint] NOT NULL,
	[EspesorCer] [smallint] NOT NULL,
	[DesCervix] [nvarchar](max) NULL,
	[DesEndometrio] [nvarchar](max) NULL,
	[OvarioDere] [smallint] NOT NULL,
	[PorOvarioDere] [smallint] NOT NULL,
	[OvarioIzquie] [smallint] NOT NULL,
	[PorOvarioIzqui] [smallint] NOT NULL,
	[Comenta] [nvarchar](max) NULL,
	[HigaAbdEco] [nvarchar](max) NULL,
	[VesicuAbdEco] [nvarchar](max) NULL,
	[PancreAbdEco] [nvarchar](max) NULL,
	[BazoAdbEco] [nvarchar](max) NULL,
	[RinonAbdEco] [nvarchar](max) NULL,
	[FormaRiDere] [nvarchar](max) NULL,
	[DiamRinDer] [smallint] NOT NULL,
	[DiamAntRinDer] [smallint] NOT NULL,
	[DiamTraRinDer] [smallint] NOT NULL,
	[DiamEpRinDer] [smallint] NOT NULL,
	[ObserRinDere] [nvarchar](max) NULL,
	[FormaRinIzq] [nvarchar](max) NULL,
	[DiamRinIzq] [smallint] NOT NULL,
	[DiamAntRinIzq] [smallint] NOT NULL,
	[DiamTraRinIzq] [smallint] NOT NULL,
	[DiamEpRinIzq] [smallint] NOT NULL,
	[ObserRinIzquie] [nvarchar](max) NULL,
	[AspecVeji] [nvarchar](max) NULL,
	[VoluPromVeji] [smallint] NOT NULL,
	[ResiPostVeji] [smallint] NOT NULL,
	[ProstataEco] [nvarchar](max) NULL,
	[VesicuSemiEco] [nvarchar](max) NULL,
	[RegisEcoGral] [ntext] NULL,
 CONSTRAINT [PK_Datos registros de ecografias] PRIMARY KEY CLUSTERED 
(
	[NumEcogra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] ADD  CONSTRAINT [DF_Datos biometria de los fetos_FetoNum]  DEFAULT ((1)) FOR [FetoNum]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] ADD  CONSTRAINT [DF_Datos biometria de los fetos_Presentacion]  DEFAULT (N'Cefálica') FOR [Presentacion]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] ADD  CONSTRAINT [DF_Datos biometria de los fetos_Situacion]  DEFAULT (N'Longitudinal') FOR [Situacion]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] ADD  CONSTRAINT [DF_Datos biometria de los fetos_Posicion]  DEFAULT (N'Dorso Izquierdo') FOR [Posicion]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] ADD  CONSTRAINT [DF_Datos biometria de los fetos_SexFeto]  DEFAULT ('I') FOR [SexFeto]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] ADD  CONSTRAINT [DF_Datos biometria de los fetos_DBPFeto]  DEFAULT ((0)) FOR [DBPFeto]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] ADD  CONSTRAINT [DF_Datos biometria de los fetos_HCFeto]  DEFAULT ((0)) FOR [HCFeto]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] ADD  CONSTRAINT [DF_Datos biometria de los fetos_ACFeto]  DEFAULT ((0)) FOR [ACFeto]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] ADD  CONSTRAINT [DF_Datos biometria de los fetos_LFFeto]  DEFAULT ((0)) FOR [LFFeto]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] ADD  CONSTRAINT [DF_Datos biometria de los fetos_PesoFeto]  DEFAULT ((0)) FOR [PesoFeto]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] ADD  CONSTRAINT [DF_Datos biometria de los fetos_FCFFeto]  DEFAULT ((0)) FOR [FCFFeto]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] ADD  CONSTRAINT [DF_Datos biometria de los fetos_SacoGesta]  DEFAULT ((0)) FOR [SacoGesta]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] ADD  CONSTRAINT [DF_Datos biometria de los fetos_VesiVitelina]  DEFAULT ((0)) FOR [VesiVitelina]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] ADD  CONSTRAINT [DF_Datos biometria de los fetos_BotonEmbriona]  DEFAULT ((0)) FOR [BotonEmbriona]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] ADD  CONSTRAINT [DF_Datos biometria de los fetos_LCN]  DEFAULT ((0)) FOR [LCN]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_TipoEco]  DEFAULT ('00') FOR [TipoEco]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_NumAten]  DEFAULT ('0') FOR [NumAten]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_NumFactu]  DEFAULT ('0') FOR [NumFactu]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_NumHisEco]  DEFAULT ('0') FOR [NumHisEco]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_FecRealECO]  DEFAULT (getdate()) FOR [FecRealECO]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografiasOLD_SeConoFUM]  DEFAULT ((0)) FOR [SeConoFUM]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_FUMEco]  DEFAULT ('1900-01-01') FOR [FUMEco]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_FPPFUM]  DEFAULT ('1900-01-01') FOR [FPPFUM]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_NumFetos]  DEFAULT ((0)) FOR [NumFetos]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_EspePlace]  DEFAULT ((0)) FOR [EspePlace]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_NumSemEco]  DEFAULT ((0)) FOR [NumSemEco]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_NumDiasEco]  DEFAULT ((0)) FOR [NumDiasEco]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_ArchivEco]  DEFAULT ('False') FOR [ArchivEco]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_CodArchi]  DEFAULT ('001') FOR [CodArchi]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_FecArchi]  DEFAULT ('1900-01-01') FOR [FecArchi]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_AnulEco]  DEFAULT ('False') FOR [AnulEco]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_RazAnulEco]  DEFAULT ('NUNCA HA SIDO ANULADA') FOR [RazAnulEco]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_CodAnulEco]  DEFAULT ('001') FOR [CodAnulEco]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_FecAnulEco]  DEFAULT ('1900-01-01') FOR [FecAnulEco]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_CodRegis]  DEFAULT ('001') FOR [CodRegis]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_FecRegis]  DEFAULT (getdate()) FOR [FecRegis]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_CodModi]  DEFAULT (N'001') FOR [CodModi]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_FecModi]  DEFAULT ('1800-01-01') FOR [FecModi]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_CervixEsta]  DEFAULT ('CERRADA') FOR [CervixEsta]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_SacoGesta]  DEFAULT ((0)) FOR [DiamLongi]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_DiamLongi1]  DEFAULT ((0)) FOR [DiamAntePos]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_DiamAntePos1]  DEFAULT ((0)) FOR [DiamTras]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_DiamTras1]  DEFAULT ((0)) FOR [Endometrio]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_Endometrio1_1]  DEFAULT ((0)) FOR [EspesorCer]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_Endometrio1]  DEFAULT ((0)) FOR [OvarioDere]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_OvarioDere1]  DEFAULT ((0)) FOR [PorOvarioDere]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_PorOvarioDere1]  DEFAULT ((0)) FOR [OvarioIzquie]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_OvarioIzquie1]  DEFAULT ((0)) FOR [PorOvarioIzqui]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_DiamRinIzq1]  DEFAULT ((0)) FOR [DiamRinDer]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_DiamAntRinIzq1_1]  DEFAULT ((0)) FOR [DiamAntRinDer]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_DiamTraRinIzq1_1]  DEFAULT ((0)) FOR [DiamTraRinDer]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_DiamEpRinIzq1]  DEFAULT ((0)) FOR [DiamEpRinDer]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_DiamTras1_1]  DEFAULT ((0)) FOR [DiamRinIzq]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_DiamRinonDere1]  DEFAULT ((0)) FOR [DiamAntRinIzq]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_DiamAntRinIzq1]  DEFAULT ((0)) FOR [DiamTraRinIzq]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_DiamTraRinIzq1]  DEFAULT ((0)) FOR [DiamEpRinIzq]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_DiamEpRinIzq1_1]  DEFAULT ((0)) FOR [VoluPromVeji]
GO
ALTER TABLE [dbo].[Datos registros de ecografias] ADD  CONSTRAINT [DF_Datos registros de ecografias_VoluPromVeji1]  DEFAULT ((0)) FOR [ResiPostVeji]
GO
ALTER TABLE [dbo].[Datos biometria de los fetos]  WITH CHECK ADD  CONSTRAINT [FK_Datos biometria de los fetos_Datos registros de ecografias] FOREIGN KEY([NumEcoFeto])
REFERENCES [dbo].[Datos registros de ecografias] ([NumEcogra])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Datos biometria de los fetos] CHECK CONSTRAINT [FK_Datos biometria de los fetos_Datos registros de ecografias]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Número del feto correspondiente a la ecografía' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'FetoNum'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'"Cefálica";"Pelviana";"Transversal"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'Presentacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'"Longitudinal"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'Situacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'"Dorso Derecho";"Dorso Izquierdo"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'Posicion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'"Presentes y ritmicos"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'MovCardiacos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'"Normales"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'MovRespiratorios'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'"Expontaneos"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'MovFetales'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'"Adecuado, con movimientos de extensión, flexión y rotación."' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'TonoFetal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'"De aspecto y cantidad normal."' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'ILAFeto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Diametro biparietal en mm' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'DBPFeto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Circunferencia fetalica en mm' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'HCFeto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Circunferencia abdominal en mm' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'ACFeto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Longitud del femur en mm' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'LFFeto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Peso aproximado del feto en gramos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'PesoFeto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Frecuencia cardiaca del feto. Latidos por minutos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'FCFFeto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Saco gestacional en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'SacoGesta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Vesicula vitelina en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'VesiVitelina'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Botón embrionario en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'BotonEmbriona'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Longitud cefalo-caudal en m.m' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos biometria de los fetos', @level2type=N'COLUMN',@level2name=N'LCN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Código o número de la ecografía' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'NumEcogra'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de ecografía' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'TipoEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Número de la atención medica que genera la ecografía' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'NumAten'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Número de la factura con la cual se factura la ecogrfía' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'NumFactu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Número de historia clinica del usuario que se le tomó la ecografía' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'NumHisEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha en la cual se realiza la toma de la Ecografía' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'FecRealECO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Frecuencia del transductor utilizado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'TransFrec'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Define si se conoce o no la FUM de la mujer' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'SeConoFUM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'FUM de la mujer que se le hace la toma de la ECO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'FUMEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Edad gestcaional de acuerdo a la FUM' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'EdadGesFum'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha probable de parto según FUM' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'FPPFUM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Número de fetos localizados' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'NumFetos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Describa las observaciones del utero' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'Utero'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'"Anterior";"Posterior";"Previa"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'Placenta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Grado de madurez de la placenta. I. II, III' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'GraMaPla'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Espesor de la placenta en mm' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'EspePlace'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Numero de semanas de gestción por ECO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'NumSemEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Residuo en días de las semanas de embarazo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'NumDiasEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha probable de partoo según eco' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'FPPEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Opinión o conclusiones de la ECO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'ConclusECO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Código del médico que realiza la toma de la ECO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'CodMedECO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Código del médico que realiza la toma de la ECO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'CodAuxECO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Define si la eco ya fue archivada o no' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'ArchivEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Código del usuario que archiva la Ecografía' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'CodArchi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha en la cual se archiva' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'FecArchi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Define si la ecografía fué anulada' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'AnulEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Código de quien anula la ecografía' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'CodAnulEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha en la cual se anula la ecografía' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'FecAnulEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Código del usaurio que hace el registro en el sistema' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'CodRegis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de regsitro en el sistema' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'FecRegis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Código del usaurio que hace un cambio a los datos en el sistema' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'CodModi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de la última modificacion realizada al registro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'FecModi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Saco gestacional en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'DiamLongi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Saco gestacional en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'DiamAntePos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Saco gestacional en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'DiamTras'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Saco gestacional en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'Endometrio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Saco gestacional en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'EspesorCer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Saco gestacional en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'OvarioDere'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Saco gestacional en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'PorOvarioDere'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Saco gestacional en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'OvarioIzquie'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Saco gestacional en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'PorOvarioIzqui'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripcion higado ecografia abdominal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'HigaAbdEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripcion vesicula ecografia abdominal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'VesicuAbdEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripcion pancreas ecografia abdominal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'PancreAbdEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripcion bazo ecografia abdominal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'BazoAdbEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripcion Riñon ecografia abdominal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'RinonAbdEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Forma Riñon Derecho' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'FormaRiDere'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Diametro longitudinal riñon derecho en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'DiamRinDer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Diametro antero- posterior riñon derecho en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'DiamAntRinDer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Diametro trasverso riñon derecho en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'DiamTraRinDer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Diametro EP riñon derecho en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'DiamEpRinDer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Observacion Riñon Derecho' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'ObserRinDere'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Forma Riñon Izquierdo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'FormaRinIzq'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Diametro longitudinal riñon izquierdo en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'DiamRinIzq'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Diametro antero- posterior riñon izquierdo en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'DiamAntRinIzq'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Diametro trasverso riñon izquierdo en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'DiamTraRinIzq'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Diametro EP riñon izquierdo en m.m.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'DiamEpRinIzq'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Observacion Riñon Izquierdo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'ObserRinIzquie'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Aspecto de la vejiga' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'AspecVeji'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Volumen promedio de la vejiga' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'VoluPromVeji'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'ResiPostVeji'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Prostata Ecografia transrectal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'ProstataEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Vesicula seminal Ecografia transrectal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'VesicuSemiEco'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Notas profesional' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Datos registros de ecografias', @level2type=N'COLUMN',@level2name=N'RegisEcoGral'
GO
