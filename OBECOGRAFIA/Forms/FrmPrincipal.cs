using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using OBECOGRAFIA.Class;

namespace OBECOGRAFIA.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Utils.BaseDeDatosPrincipal = "ACDATOXPSQL";

                Conexion.conexionACCESS = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SIIGHOSPLUS\LogPlus.LogSip;Jet OLEDB:Database Password=SIIGHOS33";

                Utils.SqlDatos = "SELECT * FROM [Local registro del usuario]";

                OleDbDataReader dr = Conexion.AccessDataReaderOLEDB(Utils.SqlDatos);

                if (dr.HasRows)
                {
                    dr.Read();

                    // Se procede a validar las credenciales de acceso al Servidor SQL Server
                    // Y verificar el tipo de cliente de SQL Server

                    Conexion.servidor = dr["NomServi"].ToString();
                    Conexion.username = dr["NomUsar"].ToString();
                    Conexion.password = dr["PassWusa"].ToString();

                    Conexion.conexionSQL = "Server=" + Conexion.servidor + "; " +
                                           "Initial Catalog=" + Utils.BaseDeDatosPrincipal + ";" +
                                           "User ID=" + Conexion.username + "; " +
                                           "Password=" + Conexion.password;


                    Utils.codUsuario = dr["CodigUsar"].ToString();
                    Utils.nomUsuario = dr["NombreUsar"].ToString();
                 
                    Utils.codUnicoEmpresa = dr["CodRegEn"].ToString(); // CodEnti
                    Utils.CodAplicacion = dr["CodApli"].ToString();



                    this.lblFecha.Text = DateTime.Now.ToString("dddd dd 'de' MMMM 'de' yyyy") + "   -";
                    this.lblCodUsuario.Text = Utils.codUsuario;
                    this.lblNomUsuario.Text = Utils.nomUsuario;



                    Utils.SqlDatos = "SELECT [NivelPermiso], [IdentificUsa]" +
                    "FROM [DATUSIIGXPSQL].[dbo].[Datos usuarios de los aplicativos] " +
                    "WHERE CodigoUsa = '" + Utils.codUsuario + "'";

                    string docuMedi = "";

                    SqlDataReader TabUser = Conexion.SQLDataReader(Utils.SqlDatos);

                    if (TabUser.HasRows)
                    {
                        TabUser.Read();
                        Utils.nivelPermiso = TabUser["NivelPermiso"].ToString();
                        docuMedi = TabUser["IdentificUsa"].ToString();
                    }

                    if (Conexion.sqlConnection.State == ConnectionState.Open) Conexion.sqlConnection.Close();



                    //Buscamos los datoa de los medicos

                    Utils.SqlDatos = "SELECT [CodiMedico], [CodEspecial]" +
                    "FROM [GEOGRAXPSQL].[dbo].[Datos de los medicos] " +
                    "WHERE NumDocum = '" + docuMedi + "'";


                    SqlDataReader TabMedi = Conexion.SQLDataReader(Utils.SqlDatos);

                    if (TabMedi.HasRows)
                    {
                        TabMedi.Read();

                        Utils.CodEspecialidad = TabMedi["CodEspecial"].ToString();
                        Utils.CodigoMedico = TabMedi["CodiMedico"].ToString();

                    }

                    if (Conexion.sqlConnection.State == ConnectionState.Open) Conexion.sqlConnection.Close();




                    Utils.SqlDatos = "SELECT CodiMinSalud, NitCCEmpresa,CatEmpresa, NomEmpresa,LogoEmpresa, TipoDocEmp, TelPrin " +
                                   "FROM [BDADMINSIG].[dbo].[Datos informacion de la empresa] " +
                                   "WHERE CodUnico = @codUnicoEmpresa";

                    List<SqlParameter> parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@codUnicoEmpresa", SqlDbType.VarChar, 2) { Value = Utils.codUnicoEmpresa }
                    };

                    SqlDataReader Sqldr = Conexion.SQLDataReader(Utils.SqlDatos, parameters);

                    if (Sqldr.HasRows)
                    {
                        Sqldr.Read();
                        Utils.codMinSalud = Sqldr["CodiMinSalud"].ToString();
                        Utils.nitEmpresa = Sqldr["NitCCEmpresa"].ToString();
                        Utils.nomEmpresa = Sqldr["NomEmpresa"].ToString();
                        Utils.CateEmpresa = Sqldr["CatEmpresa"].ToString();
                        Utils.tipoDocEmp = Sqldr["TipoDocEmp"].ToString();
                        Utils.TelEmpresa = Sqldr["TelPrin"].ToString();
                        Utils.LogoEmpresa = (byte[])Sqldr["LogoEmpresa"];
                    }



                    Sqldr.Close();
                }
                else
                {
                    this.Close();
                }

                string cadena = Utils.nomEmpresa;

                string[] parte = cadena.Split(' ');

                int cantidad = parte.Length;

                LblNombreEmpresa.Text = "";

                if (cantidad > 4)
                {

                    int parImpar = cantidad % 2;

                    int mitadSalto = parImpar == 0 ? cantidad / 2 : (cantidad + 1) / 2;
                   
                    for (int i = 0; i < parte.Length; i++)
                    {
                        if(i == mitadSalto)
                        {
                            LblNombreEmpresa.Text += "\r";
                        }

                        LblNombreEmpresa.Text = LblNombreEmpresa.Text + parte[i] + " ";

                    }

                    LblNombreEmpresa.Text += "\r" + Utils.CateEmpresa;


                }
                else
                {
                    LblNombreEmpresa.Text = Utils.nomEmpresa + "\r" + Utils.CateEmpresa;
                }

      


                dr.Close();
            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "al abrir el formulario principal" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ecografiasObtetricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtencionEcografiasObstreticas frmAtencionEcografiasObstreticas = new FrmAtencionEcografiasObstreticas();
            frmAtencionEcografiasObstreticas.ShowDialog();
        }

        private void informesEcografiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteEcografias frmReporte = new FrmReporteEcografias();
            frmReporte.ShowDialog();
        }

        private void reporteEcografíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCopiasEcografias frmCopiasEcografias = new FrmCopiasEcografias();
            frmCopiasEcografias.ShowDialog();
        }
    }   
}
