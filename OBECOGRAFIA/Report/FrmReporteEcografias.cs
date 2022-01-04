using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using OBECOGRAFIA.Class;
using System.Data.SqlClient;

namespace OBECOGRAFIA.Report
{
    public partial class FrmReporteEcografias : Form
    {
        public FrmReporteEcografias()
        {
            InitializeComponent();
        }

        private void FrmReporteEcografias_Load(object sender, EventArgs e)
        {

            string OcuBusML = "", FunEd = "", BarDp = "", CityDp = "", CodEntidadML = "", CodMedBusML = "", HistoBusML = "";
            DateTime FecEco = DateTime.Now;
            DateTime FecNam;

            ReportDataSource dsResidencia = new ReportDataSource();
            ReportDataSource dsMedico = new ReportDataSource();

            string InfoEmpresaData = "SELECT * FROM [BDADMINSIG].[dbo].[Datos informacion de la empresa] WHERE [CodUnico] = '" + Utils.codUnicoEmpresa + "'";

            System.Data.DataSet InfoEmpresa = Conexion.SQLDataSet(InfoEmpresaData);

            ReportDataSource dsEmpresa = new ReportDataSource("dsEmpresa", InfoEmpresa.Tables[0]);

           
            //Procedemos a mostrar los datos del informe, saiendo que este informe se invoca estando abbierta 


            string SqlRegEco = "SELECT [Datos registros de ecografias].NumEcogra, [Datos registros de ecografias].TipoEco, [Datos registros de ecografias].NumAten, [Datos registros de ecografias].NumFactu, [Datos registros de ecografias].NumHisEco,  " +
            " [Datos registros de ecografias].FecRealECO, [Datos registros de ecografias].TransFrec, [Datos registros de ecografias].FUMEco, [Datos registros de ecografias].EdadGesFum, [Datos registros de ecografias].FPPFUM,  " +
            " [Datos registros de ecografias].FecAnulEco, [Datos registros de ecografias].CodRegis, [Datos registros de ecografias].FecRegis, [Datos registros de ecografias].CodModi, [Datos registros de ecografias].FecModi,  " +
            " [Datos tipos de transductores ecografos].NomTraducEco, [Datos tipos de ecografias].NomEcogra, [Datos registros de ecografias].SeConoFUM, [Datos registros de ecografias].NumFetos, [Datos registros de ecografias].Utero,  " +
            " [Datos registros de ecografias].Placenta, [Datos registros de ecografias].GraMaPla, [Datos registros de ecografias].EspePlace, [Datos registros de ecografias].NumSemEco, [Datos registros de ecografias].NumDiasEco,  " +
            " [Datos registros de ecografias].FPPEco, [Datos registros de ecografias].CodAuxECO, [Datos registros de ecografias].ConclusECO, [Datos registros de ecografias].CodMedECO, [Datos registros de ecografias].ArchivEco,  " +
            " [Datos registros de ecografias].CodArchi, [Datos registros de ecografias].FecArchi, [Datos registros de ecografias].AnulEco, [Datos registros de ecografias].RazAnulEco, [Datos registros de ecografias].CodAnulEco,  " +
            " [Datos registros de ecografias].CervixEsta, [Datos registros de ecografias].DiamLongi, [Datos registros de ecografias].DiamAntePos, [Datos registros de ecografias].DiamTras, [Datos registros de ecografias].Endometrio,  " +
            " [Datos registros de ecografias].EspesorCer, [Datos registros de ecografias].DesCervix, [Datos registros de ecografias].DesEndometrio, [Datos registros de ecografias].OvarioDere, [Datos registros de ecografias].PorOvarioDere,  " +
            " [Datos registros de ecografias].OvarioIzquie, [Datos registros de ecografias].PorOvarioIzqui, [Datos registros de ecografias].Comenta, [Datos registros de ecografias].HigaAbdEco, [Datos registros de ecografias].VesicuAbdEco,  " +
            " [Datos registros de ecografias].PancreAbdEco, [Datos registros de ecografias].BazoAdbEco, [Datos registros de ecografias].RinonAbdEco, [Datos registros de ecografias].FormaRiDere,  " +
            " [Datos registros de ecografias].DiamRinDer, [Datos registros de ecografias].DiamAntRinDer, [Datos registros de ecografias].DiamTraRinDer, [Datos registros de ecografias].ObserRinDere,  " +
            " [Datos registros de ecografias].DiamEpRinDer, [Datos registros de ecografias].FormaRinIzq, [Datos registros de ecografias].DiamRinIzq, [Datos registros de ecografias].DiamAntRinIzq,  " +
            " [Datos registros de ecografias].DiamTraRinIzq, [Datos registros de ecografias].DiamEpRinIzq, [Datos registros de ecografias].ObserRinIzquie, [Datos registros de ecografias].AspecVeji,  " +
            " [Datos registros de ecografias].VoluPromVeji, [Datos registros de ecografias].ResiPostVeji, [Datos registros de ecografias].ProstataEco, [Datos registros de ecografias].VesicuSemiEco,  " +
            " [Datos registros de ecografias].RegisEcoGral " +
            " FROM [DACONEXTSQL].[dbo].[Datos tipos de ecografias] INNER JOIN " +
            " [DACONEXTSQL].[dbo].[Datos registros de ecografias] INNER JOIN " +
            " [DACONEXTSQL].[dbo].[Datos tipos de transductores ecografos] ON[Datos registros de ecografias].TransFrec = [Datos tipos de transductores ecografos].CodTraducEco ON " +
            " [Datos tipos de ecografias].CodEcoIps = [Datos registros de ecografias].TipoEco " +
            "WHERE  [Datos registros de ecografias].NumEcogra = '" + Utils.NumECCo + "' ";

            System.Data.DataSet InfoEcografia = Conexion.SQLDataSet(SqlRegEco);

            ReportDataSource dsEcografia = new ReportDataSource("dsEcografia", InfoEcografia.Tables[0]);

            SqlDataReader TabRegEco = Conexion.SQLDataReader(SqlRegEco);

            if (TabRegEco.HasRows)
            {
                TabRegEco.Read();

                FecEco = Convert.ToDateTime(TabRegEco["FecRealECO"].ToString());
                CodMedBusML = TabRegEco["CodMedECO"].ToString();
                HistoBusML = TabRegEco["NumHisEco"].ToString();

                string SqlMedicos = "SELECT [Datos de los medicos].CodiMedico, [Datos de los medicos].CodEspecial, [Datos de los medicos].TipoDocum, " +
                "[Datos de los medicos].NumDocum, [Datos de los medicos].NomMedico, [Datos de los medicos].Nom2Medico, " +
                "[Datos de los medicos].Apellido1Medico, [Datos de los medicos].Apellido2Medico, [Datos de los medicos].CargoMedico, " +
                "[Datos de los medicos].RegisProfes, [Datos de las especialidades].NomEspecial, [Datos de los medicos].FirmaD " +
                "FROM [GEOGRAXPSQL].[dbo].[Datos de los medicos] INNER JOIN [GEOGRAXPSQL].[dbo].[Datos de las especialidades] ON [Datos de los medicos].CodEspecial = " +
                "[GEOGRAXPSQL].[dbo].[Datos de las especialidades].CodiEspecial " +
                "WHERE ([Datos de los medicos].CodiMedico = N'" + CodMedBusML + "')";

                System.Data.DataSet InfoMedico = Conexion.SQLDataSet(SqlMedicos);

                dsMedico = new ReportDataSource("dsMedico", InfoMedico.Tables[0]);

            }

            string InfoPacienteData = "SELECT HistorPaci, TipoIden, NumIden, Nombre1, Nombre2, Apellido1, Apellido2, FechaNaci, EstadoCivil, CodDpto, " +
            "CodMuni, DirecResi, BarrioVive, TelResi, ZonaResiden, Ocupacion, CodiAdmin, [Datos estado civil].NomEstado " +
            "FROM [ACDATOXPSQL].[dbo].[Datos del Paciente] INNER JOIN [ACDATOXPSQL].[dbo].[Datos estado civil] ON " +
            "[Datos del Paciente].EstadoCivil = [Datos estado civil].CodEstado " +
            "WHERE (HistorPaci = N'" + HistoBusML + "')";

            System.Data.DataSet InfoPaciente = Conexion.SQLDataSet(InfoPacienteData);

            ReportDataSource dsPaciente = new ReportDataSource("dsPaciente", InfoPaciente.Tables[0]);

            SqlDataReader TabPacientes = Conexion.SQLDataReader(InfoPacienteData);


            if (TabPacientes.HasRows)
            {
                TabPacientes.Read();
                OcuBusML = TabPacientes["Ocupacion"].ToString();

                CodEntidadML = TabPacientes["CodiAdmin"].ToString();

             
                FecNam = Convert.ToDateTime(TabPacientes["FechaNaci"].ToString());
                FunEd = Utils.EdadAtencion(FecEco, FecNam); //Esto lo pasamo por parametro al reporte

                //Buscamos el barrio, la ciudad y Dpto de residencia del usuario

                BarDp = TabPacientes["BarrioVive"].ToString();
                CityDp = TabPacientes["CodMuni"].ToString();

                string SqlCiudades = "SELECT [Datos localidades de las ciudades].CodBarrio, [Datos localidades de las ciudades].CodCiudad, [Datos localidades de las ciudades].NomBarrio, " +
                "[Datos ciudades del dpto].NombreCiudad , [Datos de los Dpto o Estados].NombreDpto " +
                "FROM [GEOGRAXPSQL].[dbo].[Datos ciudades del dpto] INNER JOIN [GEOGRAXPSQL].[dbo].[Datos de los Dpto o Estados] ON [Datos ciudades del dpto].CodigoDpto = [Datos de los Dpto o Estados].CodigoDpto INNER JOIN " +
                "[GEOGRAXPSQL].[dbo].[Datos localidades de las ciudades] ON [Datos ciudades del dpto].CodDptoCity = [Datos localidades de las ciudades].CodCiudad " +
                "WHERE ([Datos localidades de las ciudades].CodBarrio = N'" + BarDp + "') AND ([Datos localidades de las ciudades].CodCiudad = N'" + CityDp + "') ";


                System.Data.DataSet InfoResidencia = Conexion.SQLDataSet(SqlCiudades);

                dsResidencia = new ReportDataSource("dsResidencia", InfoResidencia.Tables[0]);

            }

            string SqlBiome = "SELECT NumEcoFeto, FetoNum, Presentacion, Situacion, Posicion, MovCardiacos, MovRespiratorios, MovFetales, TonoFetal, ILAFeto, CordonUmbi, SexFeto," +
            " DBPFeto, HCFeto, ACFeto, LFFeto, PesoFeto, FCFFeto, SacoGesta, " +
            " VesiVitelina, BotonEmbriona, LCN, TotaPunt, PuntajeILA, PuntajeMovFet, PuntajeMovRes, PuntajeTonMusc " +
            " FROM DACONEXTSQL.dbo.[Datos biometria de los fetos] WHERE NumEcoFeto  = '"+ Utils.NumECCo + "' " +
            " ORDER BY NumEcoFeto, FetoNum";

            System.Data.DataSet InfoBiome = Conexion.SQLDataSet(SqlBiome);
            ReportDataSource dsBiome = new ReportDataSource("dsBiome", InfoBiome.Tables[0]);



            string SqlOcupa = "SELECT CodGru04, NomGru04 ";
            SqlOcupa = SqlOcupa + "FROM [GEOGRAXPSQL].[dbo].[Datos CIUO cuarta categoria] ";
            SqlOcupa = SqlOcupa + "WHERE (CodGru04 = N'" + OcuBusML + "')";

            System.Data.DataSet InfoOcupacion = Conexion.SQLDataSet(SqlOcupa);
             
            ReportDataSource dsOcupacion = new ReportDataSource("dsOcupacion", InfoOcupacion.Tables[0]);

            string SqlEmpTer = "SELECT CarAdmin, NomAdmin " +
            "FROM [ACDATOXPSQL].[dbo].[Datos empresas y terceros] " +
            "WHERE (CarAdmin = N'" + CodEntidadML + "')";

            System.Data.DataSet InfoTercero = Conexion.SQLDataSet(SqlEmpTer);

            ReportDataSource dsTercero = new ReportDataSource("dsTercero", InfoTercero.Tables[0]);

            //*************************************************************************** Esta es para un deporte de anteciones ************************************************

            Utils.SqlDatos = "SELECT [Datos registros de ecografias].NumEcogra, [Datos del Paciente].HistorPaci, [Datos del Paciente].TipoIden, [Datos del Paciente].NumIden, " +
            " [Datos registros de ecografias].FecRealECO, RTrim([Apellido1] + ' ' + [Apellido2] + ' ' + [Nombre1] + ' ' + [Nombre2]) AS NombreCompleto, " +
            " RTrim([Apellido1Medico] +' ' + [Apellido2Medico] + ' ' + [NomMedico]) AS MediC, [Datos registros de ecografias].ArchivEco, [Datos registros de ecografias].CodMedECO " +
            " FROM ([DACONEXTSQL].[dbo].[Datos registros de ecografias] INNER JOIN[ACDATOXPSQL].[dbo].[Datos del Paciente] ON[Datos registros de ecografias].NumHisEco = [Datos del Paciente].HistorPaci) " +
            " INNER JOIN [GEOGRAXPSQL].[dbo].[Datos de los medicos] ON [Datos registros de ecografias].CodMedECO = [Datos de los medicos].CodiMedico " +
            "  WHERE [Datos registros de ecografias].FecRealECO >= CONVERT(DATETIME, '"+ Utils.FecIncial +"', 102) " +
            " And [Datos registros de ecografias].FecRealECO <= CONVERT(DATETIME, '" + Utils.FecFinal + "', 102) AND " +
            "  [Datos registros de ecografias].CodMedECO = '" + Utils.CodMedicoReport + "' And [Datos registros de ecografias].ArchivEco = "+ Utils.ArchiEcoReport +" " +
            " ORDER BY [Datos registros de ecografias].NumEcogra, RTrim([Apellido1] + ' ' + [Apellido2] + ' ' + [Nombre1] + ' ' + [Nombre2]);";


            System.Data.DataSet InfoAten = Conexion.SQLDataSet(Utils.SqlDatos);

            ReportDataSource dsAtenciones = new ReportDataSource("dsAtenciones", InfoAten.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            this.reportViewer1.LocalReport.EnableExternalImages = true;

            // ReportParameter edad = new ReportParameter("edad", FunEd);
                
            //Array que contendrá los parámetros
            ReportParameter[] parameters = new ReportParameter[1];

            parameters[0] = new ReportParameter("edadCalculada", FunEd);

            this.reportViewer1.LocalReport.DataSources.Add(dsAtenciones);

            this.reportViewer1.LocalReport.DataSources.Add(dsBiome);

            this.reportViewer1.LocalReport.DataSources.Add(dsEmpresa);

            this.reportViewer1.LocalReport.DataSources.Add(dsEcografia);

            this.reportViewer1.LocalReport.DataSources.Add(dsMedico);

            this.reportViewer1.LocalReport.DataSources.Add(dsPaciente);

            this.reportViewer1.LocalReport.DataSources.Add(dsResidencia);

            this.reportViewer1.LocalReport.DataSources.Add(dsTercero);

            this.reportViewer1.LocalReport.DataSources.Add(dsOcupacion);

            string reporte = "OBECOGRAFIA.Report.Rdlc." + Utils.infNombreInforme + ".rdlc";

            this.reportViewer1.LocalReport.ReportEmbeddedResource = reporte;

            this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            this.reportViewer1.ZoomMode = ZoomMode.Percent;

            this.reportViewer1.ZoomPercent = 100;

            this.reportViewer1.RefreshReport();
        }
    }
}
