using OBECOGRAFIA.Class;
using System;
using System.Data;
using System.Windows.Forms;


namespace OBECOGRAFIA.Forms
{
    public partial class FrmReporteEcografias : Form
    {
        public FrmReporteEcografias()
        {
            InitializeComponent();
        }

        private void CargarRangoFechas()
        {
            try
            {
                DateTime FechaActual = DateTime.Now;

                DateTime FechaUnMesAntes = DateTime.Now.AddMonths(-1);

                DateInicial.Value = FechaUnMesAntes;

                DateFinal.Value = FechaActual;
            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "al abrir funcion CargarRangoFechas" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //Carga las fechas desde la fecha actual y un mes antes. Para los filtros

        int MarValidez = 1;
        int MarEstaTria = 2;
        int MarProveddor = 1;


        private void FrmReporteEcografias_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "al abrir el formulario reporte de ecografias" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            try
            {

    
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                if (fichero.ShowDialog() == DialogResult.OK) //Abre cuadro de dialogo para ver donde guarda el archivo
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    //hoja_trabajo.Cells[1, 0] = "Num Ecografia";
                    for (int i = 0; i < grd.Rows.Count; i++)
                    {
                        for (int j = 0; j < grd.Columns.Count - 1; j++)
                        {
                            hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "en la funcion ExportarDataGridViewExcel" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.Titulo01 = "Control para mostrar ecografías";
                string EstaVali = "", DefWhere = "", EstaTri = "", SqlConsultas = "", Fec1Sql, Fec2Sql;
                DateTime FecCade01, FecCade02;

                //Revisamos por cual estado de validez desea mostrar

                switch (MarValidez)
                {
                    case 1: //Validos

                        EstaVali = "Validos";
                        DefWhere = "1";

                        break;
                    case 2: //Anulados

                        EstaVali = "Anulados";
                        DefWhere = "2";

                        break;
                    case 3: //todos

                        EstaVali = "Todos";
                        DefWhere = "3";

                        break;
                    default:
                        break;
                }

                //Revisamos el estado de la ecografía


                switch (MarEstaTria)
                {
                    case 1: //Abiertos

                        EstaTri = "Abiertos";
                        DefWhere += "1";

                        break;
                    case 2: //Cerrados

                        EstaTri = "Cerrados";
                        DefWhere += "2";

                        break;
                    case 3: //Todos

                        EstaTri = "Todos";
                        DefWhere += "3";

                        break;
                    default:
                        break;
                }

                FecCade01 = DateInicial.Value;
                FecCade02 = DateFinal.Value;

                Fec1Sql = FecCade01.ToString("yyyy-MM-dd");
                Fec2Sql = FecCade02.ToString("yyyy-MM-dd");

                Utils.Informa = "¿Usted desea MOSTRAR todas las ecografías" + "\r";
                Utils.Informa += "realizadas entre el " + Fec1Sql + " y el " + Fec2Sql + "\r";
                Utils.Informa += "con los siguientes parámetros.?" + "\r";
                Utils.Informa += "ESTADO DE VALIDEZ: " + EstaVali + "\r";
                Utils.Informa += "ESTADO DE LA ECOGRAFIA: " + EstaTri + "\r";
                var res = MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if(res == DialogResult.Yes)
                {
                    SqlConsultas = "SELECT [Datos registros de ecografias].NumEcogra, [Datos registros de ecografias].TipoEco, ACDATOXPSQL.dbo.[Datos del Paciente].HistorPaci, ";
                    SqlConsultas += "RTRIM(ACDATOXPSQL.dbo.[Datos del Paciente].Nombre1 + ' ' + ISNULL(ACDATOXPSQL.dbo.[Datos del Paciente].Nombre2, N'')) + ' ' + RTRIM(ACDATOXPSQL.dbo.[Datos del Paciente].Apellido1 + ' ' + ISNULL(ACDATOXPSQL.dbo.[Datos del Paciente].Apellido2, N'')) AS NombreDelUsario, ";
                    SqlConsultas += "ACDATOXPSQL.dbo.[Datos del Paciente].TipoIden, ACDATOXPSQL.dbo.[Datos del Paciente].NumIden, [Datos registros de ecografias].FecRealECO, [Datos registros de ecografias].NumFactu, ACDATOXPSQL.dbo.[Datos del Paciente].Sexo, ACDATOXPSQL.dbo.[Datos del Paciente].FechaNaci,";
                    SqlConsultas += "ACDATOXPSQL.dbo.[Datos del Paciente].TelResi, RTRIM(GEOGRAXPSQL.dbo.[Datos de los medicos].NomMedico + ' ' + GEOGRAXPSQL.dbo.[Datos de los medicos].Apellido1Medico) + ' ' + ISNULL(GEOGRAXPSQL.dbo.[Datos de los medicos].Apellido2Medico, N'') AS NomMed, ";
                    SqlConsultas += "ACDATOXPSQL.dbo.[Datos del Paciente].DirecResi + ' ' + '(' + GEOGRAXPSQL.dbo.[Datos de los barrios o veredas].NomBarrio + ') - ' + GEOGRAXPSQL.dbo.[Datos de las ciudades].NombreCiudad + '( ' + GEOGRAXPSQL.dbo.[Datos de los Dpto o Estados].NombreDpto + ' ) ' AS Procedencia, ";
                    SqlConsultas += "[Datos registros de ecografias].ArchivEco, [Datos registros de ecografias].AnulEco ";
                    SqlConsultas += "FROM  GEOGRAXPSQL.dbo.[Datos de los barrios o veredas] RIGHT OUTER JOIN GEOGRAXPSQL.dbo.[Datos de los medicos] INNER JOIN [DACONEXTSQL].[dbo].[Datos registros de ecografias] ON GEOGRAXPSQL.dbo.[Datos de los medicos].CodiMedico = [Datos registros de ecografias].CodMedECO INNER JOIN ";
                    SqlConsultas += "GEOGRAXPSQL.dbo.[Datos de los Dpto o Estados] INNER JOIN ACDATOXPSQL.dbo.[Datos del Paciente] ON GEOGRAXPSQL.dbo.[Datos de los Dpto o Estados].CodigoDpto = ACDATOXPSQL.dbo.[Datos del Paciente].CodDpto ON [Datos registros de ecografias].NumHisEco = ACDATOXPSQL.dbo.[Datos del Paciente].HistorPaci ON ";
                    SqlConsultas += "GEOGRAXPSQL.dbo.[Datos de los barrios o veredas].CodBarrio = ACDATOXPSQL.dbo.[Datos del Paciente].BarrioVive LEFT OUTER JOIN GEOGRAXPSQL.dbo.[Datos de las ciudades] ON ACDATOXPSQL.dbo.[Datos del Paciente].CodDpto = GEOGRAXPSQL.dbo.[Datos de las ciudades].CodigoDpto AND ";
                    SqlConsultas += "ACDATOXPSQL.dbo.[Datos del Paciente].CodMuni = GEOGRAXPSQL.dbo.[Datos de las ciudades].CodigoCiudad ";
                    SqlConsultas += "WHERE [Datos registros de ecografias].FecRealECO >= Convert(Datetime, '" + Fec1Sql + "', 102) And ";
                    SqlConsultas += "[Datos registros de ecografias].FecRealECO <= Convert(Datetime, '" + Fec2Sql + "', 102) ";


                    switch (DefWhere)
                    {
                        case "11": //Validos, abierto
                            SqlConsultas += "and ([Datos registros de ecografias].AnulEco = 'False') ";
                            SqlConsultas += "and ([Datos registros de ecografias].ArchivEco = 'False')) ";
                            break;
                        case "12": //Validos y cerrados
                            SqlConsultas += "and ([Datos registros de ecografias].AnulEco = 'False') ";
                            SqlConsultas += "and ([Datos registros de ecografias].ArchivEco = 'True')) ";
                            break;
                        case "13": //Validos y todos

                            SqlConsultas += "and ([Datos registros de ecografias].AnulEco = 'False') ";
                       
                            break;
                        case "21": //Anulados y abiertos
                            SqlConsultas += "and ([Datos registros de ecografias].AnulEco = 'True') ";
                            SqlConsultas += "and ([Datos registros de ecografias].ArchivEco = 'False') ";
                            break;

                        case "22": //Anulados y cerrados
                            SqlConsultas += "and ([Datos registros de ecografias].AnulEco = 'True') ";
                            SqlConsultas += "and ([Datos registros de ecografias].ArchivEco = 'True') ";
                            break;
                        case "23": //Anulados y todos
                            SqlConsultas += "and ([Datos registros de ecografias].AnulEco = 'True') ";
                           
                            break;
                        case "31": //Todos y abiertos          
                            SqlConsultas += "and ([Datos registros de ecografias].ArchivEco = 'False') ";
                            break;
                        case "32": //Todos y cerrados       
                            SqlConsultas += "and ([Datos registros de ecografias].ArchivEco = 'True') ";
                            break;
                        case "33": //Todos y Todos          
                           
                            break;
                        default:
                            Utils.Informa = "Lo siento pero la combinación de parámetros" + "\r";
                            Utils.Informa += "seleccionada por usted, no está contemplada en" + "\r";
                            Utils.Informa += "este momento, favor tomar notar e informarle" + "\r";
                            Utils.Informa += "al administrador del sistema para que sea" + "\r";
                            Utils.Informa += "implementada dicha opción" + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                            break;
                    }

                    SqlConsultas += "ORDER BY ([Datos registros de ecografias].[NumEcogra]);";

                    DataSet TabConsultas = Conexion.SQLDataSet(SqlConsultas);

                    LblTolTriage.Text = "";

                    if (TabConsultas.Tables.Count > 0)
                    {
                        GridTriageSelecionados.DataSource = null;
                        GridTriageSelecionados.DataSource = TabConsultas.Tables[0];
                        LblTolTriage.Text = TabConsultas.Tables[0].Rows.Count.ToString();
                    }


                }

            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "en el botons mostrar" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCopias_Click(object sender, EventArgs e)
        {
            try
            {

                string NomInfor, TipEco = "", TriaSel = "", NomUsSel = "";
                if (GridTriageSelecionados.SelectedRows.Count < 0)
                {
                    Utils.Informa = "Lo siento pero usted aún no ha seleccionado ninguna" + "\r";
                    Utils.Informa += "ecografía para poder generar una copia por este sistema." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                     TriaSel   = GridTriageSelecionados.SelectedCells[0].Value.ToString();
                     TipEco = GridTriageSelecionados.SelectedCells[1].Value.ToString();
                     NomUsSel = GridTriageSelecionados.SelectedCells[3].Value.ToString();
                }

                switch (TipEco)
                {
                    case "01": //Ecografía obstetrica


       
                        Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                        Utils.Informa += "de la ECOGRAFÍA OBSTETRICA No. " + TriaSel + "\r";
                        Utils.Informa += "realizada a la usuaria de nombre" + "\r";
                        Utils.Informa += NomUsSel + ".?" + "\r";

                        NomInfor = "Informe ecografia obstetrica";
                                


                        break;
                    case "02": //ecografia pelvica transvaginal
     
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA PELVICA No. " + TriaSel + "\r";
                            Utils.Informa += "realizada a la usuaria de nombre" + "\r";
                            Utils.Informa += NomUsSel + ".?" + "\r";

                            //Se llama a este informe ya que son lo mismo
                            NomInfor = "Informe ecografia obstetrica transvaginal";

                        break;
                    case "03": //ecografia obstetrica temprana
         
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA OBSTETRICA TEMPRANA No. " + TriaSel + "\r";
                            Utils.Informa += "realizada a la usuaria de nombre" + "\r";
                            Utils.Informa += NomUsSel + ".?" + "\r";

                            //Le paso el informe de obstetrica aborto ya que son el mismo

                            NomInfor = "Informe ecografia obstetrica aborto";
  
                        break;
                    case "04": //Aborto retenido

                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA OBSTETRICA DE ABORTO No. " + TriaSel + "\r";
                            Utils.Informa += "realizada a la usuaria de nombre" + "\r";
                            Utils.Informa += NomUsSel + ".?" + "\r";

                            NomInfor = "Informe ecografia obstetrica aborto";


                        break;
                    case "05": //ecografia abdominal
    
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA ABDOMINAL No. " + TriaSel + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += NomUsSel + ".?" + "\r";

                            NomInfor = "Informe ecografia abdominal";

                        break;
                    case "06": //ecografia renal bilateral
       
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA RENAL BILATERAL No. " + TriaSel + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += NomUsSel + ".?" + "\r";

                            NomInfor = "Informe ecografia renal bilateral";

                        break;
                    case "07": //ecografia hepatobiliar

  
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA HEPATOBILIAR No. " + TriaSel + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += NomUsSel + ".?" + "\r";

                            //NomInfor = "Informe ecografia hepatobiliar"; Se llama al informe  ecografia abdomen superior ya que son el mismo y no veo la necesario

                            NomInfor = "Informe ecografia abdominal";

                        break;
                    case "08": //ecografia renal y vias urinarias

                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA RENAL BILATERAL Y VIAS URINARIAS No. " + TriaSel + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += NomUsSel + ".?" + "\r";

                            NomInfor = "Informe ecografia renal y vias urinarias";


                        break;
                    case "09": //ecografia abdomen superior

                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA ABDOMEN SUPERIOR No. " + TriaSel + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += NomUsSel + ".?" + "\r";

                            NomInfor = "Informe ecografia abdomen superior";

                        break;
                    case "10": //ecografia obstetrica transvaginal

                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA OBSTETRICA TRANSVAGINAL No. " + TriaSel + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += NomUsSel + ".?" + "\r";

                            NomInfor = "Informe ecografia obstetrica transvaginal";

                        break;
                    case "11": //ecografia perfil biofisico

                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA DE PERFIL BIOFISICO  No. " + TriaSel + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += NomUsSel + ".?" + "\r";
                            NomInfor = "Informe ecografia perfil biofisico";


                        break;
                    case "12": //ecografia pelvica transabdominal

                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA PELVICA TRANSABDOMINAL No. " + TriaSel + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += NomUsSel + ".?" + "\r";
                            //Se llama a este informe ya que son lo mismo
                            NomInfor = "Informe ecografia obstetrica transvaginal";
     
                        break;
                    case "13": //ecografia cervicometria

                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA CERVICOMETRIA No. " + TriaSel + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += NomUsSel + ".?" + "\r";

                            NomInfor = "Informe ecografia cervicometria";

                        break;
                    case "14": //ecografia transrectal

                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA TRANSRECTAL No. " + TriaSel + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += NomUsSel + ".?" + "\r";
                            NomInfor = "Informe ecografia transrectal";

                        break;
                    case "15": //ecografia tejidos blandos

                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA DE TEJIDOS BLANDOS No. " + TriaSel + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += NomUsSel + ".?" + "\r";
                            NomInfor = "Informe ecografia general";

                        break;
                    case "16": //cografia ecodoppler testicular
  
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA Y ECODOPPLER TESTICULAR No. " + TriaSel + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += NomUsSel + ".?" + "\r";
                            NomInfor = "Informe ecografia general";

                        break;

                    default:
                        Utils.Informa = "Lo siento pero el tipo de ecografía no" + "\r";
                        Utils.Informa += "se encuentra definido en el código de" + "\r";
                        Utils.Informa += "programación de estes sistema, por lo" + "\r";
                        Utils.Informa += "tanto no se puede realizar el archivo" + "\r";
                        Utils.Informa += "en la basee de datos." + "\r";
                        MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                        break;
                }

                var res = MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    Utils.infNombreInforme = NomInfor;
                    Utils.NumECCo = TriaSel;
                    Report.FrmReporteEcografias frm = new Report.FrmReporteEcografias();
                    frm.ShowDialog();
                }



            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "en el boton copias" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RbValidos_CheckedChanged(object sender, EventArgs e)
        {
            MarValidez = 1;
        }

        private void RbAnulados_CheckedChanged(object sender, EventArgs e)
        {
            MarValidez = 2;
        }

        private void RbTodos_CheckedChanged(object sender, EventArgs e)
        {
            MarValidez = 3;
        }

        private void RbAbierto_CheckedChanged(object sender, EventArgs e)
        {
            MarEstaTria = 1;
        }

        private void s_CheckedChanged(object sender, EventArgs e)
        {
            MarEstaTria = 2;
        }

        private void RbTOdosEC_CheckedChanged(object sender, EventArgs e)
        {
            MarEstaTria = 3;
        }

        private void RbEx2002_CheckedChanged(object sender, EventArgs e)
        {
            MarProveddor = 1;
        }

        private void RbEx2010_CheckedChanged(object sender, EventArgs e)
        {
            MarProveddor = 2;
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            try
            {

                if(GridTriageSelecionados.Rows.Count <= 0)
                {
                    Utils.Informa = "No hay  datos a exportar" + "\r";
                    Utils.Informa += "Carga la grilla con los datos que quieras exportar" + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ExportarDataGridViewExcel(GridTriageSelecionados);
                }

             
            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "al presionar el boton exportar" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
