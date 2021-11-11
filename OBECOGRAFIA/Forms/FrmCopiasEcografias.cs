using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OBECOGRAFIA.Class;
using System.IO;
using System.Drawing.Imaging;

namespace OBECOGRAFIA.Forms
{
    public partial class FrmCopiasEcografias : Form
    {
        public FrmCopiasEcografias()
        {
            InitializeComponent();
        }

        private void CargarDatosUser()
        {
            try
            {

                if (Utils.codUsuario == "0000" || Utils.codUsuario == "001")
                {

                    Utils.Titulo01 = "Control de errores de ejecución";
                    Utils.Informa = "Lo siento pero este formulario no se puede" + "\r";
                    Utils.Informa += "abrir en este instante, porque el código del" + "\r";
                    Utils.Informa += "usuario no es válido para realizar operaciones" + "\r";
                    Utils.Informa += "con las historias clinicas de los usuarios." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                else
                {
                    LblCodigoUsaF.Text = Utils.codUsuario;
                    LblNombreUsar.Text = Utils.nomUsuario;
                    LblNivelPermitido.Text = Utils.nivelPermiso;
                    PicLogoEmpresa.SizeMode = PictureBoxSizeMode.Zoom;
                    PicLogoEmpresa.Image = ImageHelper.ByteArrayToImage(Utils.LogoEmpresa);



                }

            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "al cargar la informacion del usario" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //Carga datos de los usuairos.

        public class ImageHelper
        {
            public static Image ByteArrayToImage(byte[] byteArrayIn)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                return Image.FromStream(ms);
            }

            public static byte[] ImageToByteArray(Image imageIn)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CargaDataGridAmbitoHC()
        {
            try
            {
       
                GridAmbitoHC.Rows.Add("3","Ecografia Por Medicos");

            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "al cargar el dataGrid de Ambitos" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int Vigentes = 1;
        private void FrmCopiasEcografias_Load(object sender, EventArgs e)
        {
            try
            {

                CargarDatosUser();
                CargaDataGridAmbitoHC();
            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "al cargar el formulario" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Vigentes = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Vigentes = 2;
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime FecCade01 = DateInicial.Value;
                DateTime FecCade02 = DateFinal.Value;
                int CerraAbierta;
                string Fec1Sql = FecCade01.ToString("yyyy-MM-dd");
                string Fec2Sql = FecCade02.ToString("yyyy-MM-dd");
                string RanFec = "rango de fecha " + Fec1Sql + " al " + Fec2Sql;
                string NomInfo, Para02, Para03, CodMedico = "";

                Utils.Titulo01 = "Control Reportes";

                switch (Vigentes)
                {
                    case 1:
                        CerraAbierta = 0;
                        break;
                    case 2:
                        CerraAbierta = 1;
                        break;
                    default:
                        break;
                }

         


                string AMBITOsel = GridAmbitoHC.SelectedCells[0].Value.ToString();

                switch (AMBITOsel)
                {
                    case "3":

                        Utils.Informa = "¿Ud. desea ver todas las atenciones ";
                        Utils.Informa += "realizadas por el servicio de ";
                        Utils.Informa += "en el " + RanFec;

                        if (CboServiHC5.SelectedIndex == -1)
                        {
                            Utils.Informa = "Usted no ha seleccionado un medico ";
                            Utils.Informa += "para realizar el reporte de atenciones";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        CodMedico = CboServiHC5.SelectedValue.ToString();
                        Utils.infNombreInforme = "Informe de atenciones realizadas";

                        break;
                    default:
                        break;
                }

                var res = MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(res == DialogResult.Yes)
                {

                    Utils.FecIncial = Fec1Sql;
                    Utils.FecFinal = Fec2Sql;
                    Utils.CodMedicoReport = CodMedico;
                    Utils.ArchiEcoReport = Vigentes;

                    Report.FrmReporteEcografias frm = new Report.FrmReporteEcografias();
                    frm.ShowDialog();


                }


                //Proceda a grabar los rangos de fechas seleccionados en la tabla temporal


            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "al dar click en mostrar" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridAmbitoHC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string SqlDatos;
                string AMBITOsel = GridAmbitoHC.SelectedCells[0].Value.ToString();
                switch (AMBITOsel)
                {
                    case "3":

                        SqlDatos = "SELECT [Datos de los medicos].CodiMedico, ";
                        SqlDatos = SqlDatos + "Trim([Datos de los medicos].Apellido1Medico + ' ' + [Datos de los medicos].Apellido2Medico + ' ' + [Datos de los medicos].NomMedico) AS NombreMED ";
                        SqlDatos = SqlDatos + "FROM [GEOGRAXPSQL].[dbo].[Datos de los medicos] ";
                        SqlDatos = SqlDatos + "ORDER BY Trim([Datos de los medicos].Apellido1Medico + ' ' + [Datos de los medicos].Apellido2Medico + ' ' + [Datos de los medicos].NomMedico);";

                        DataSet dataSet = Conexion.SQLDataSet(SqlDatos);

                        if (dataSet != null && dataSet.Tables.Count > 0)
                        {
                            LblServicio.Text = "Médico o Profesional";
                            this.CboServiHC5.DataSource = dataSet.Tables[0];
                            this.CboServiHC5.ValueMember = "CodiMedico";
                            this.CboServiHC5.DisplayMember = "NombreMED";
                        }
                    break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "al dar click en la celda" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
