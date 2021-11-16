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



namespace OBECOGRAFIA.Forms
{
    public partial class FrmAtencionEcografiasObstreticas : Form
    {
        public FrmAtencionEcografiasObstreticas()
        {
            InitializeComponent();
        }

        #region ComboBox

        private void CboEspecialidad1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bandera == 1)
            {
                ComboMedicos(CboEspecialidad1.SelectedValue.ToString());
            }
        }

        private void CboTipoEcoReal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (bandera == 1)
                {
                    string T; 

                    if (CboTipoEcoReal.SelectedIndex == -1)
                    {
                        TxtCodCupEco.Clear();
                        TxtNomCupsEco.Clear();
                        T = "00";

                    }
                    else
                    {
                        T = CboTipoEcoReal.SelectedValue.ToString();
                        CargarTipoExo();
                        cargarTabSeleccionado(T);
                    }


                    //Si ya se digitó un numero de historia, validamos si el usuario tiene alguna ecografía abierta, pendiente de cerrar, con el mismo médico

                    if (string.IsNullOrWhiteSpace(TxtNumHistoEco.Text))
                    {
                        //no busca nada
                    }
                    else
                    {
                        //Revisamos si se seleecciono un profesional
                        if(CboCodiMedi.SelectedIndex == -1)
                        {
                            //Noo haga nada
                        }
                        else
                        {
                            string H = TxtNumHistoEco.Text;
                            string M = CboCodiMedi.SelectedValue.ToString();

                            MostraEcografias(T, H, M);

                        }
                    }


                }

            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "en el evento changed de Tipo Ecograficas" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CboConoceFUM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboConoceFUM.SelectedIndex == 0)
            {
                DtFUMEco.Enabled = false;
                TxtEdadFum.Text = null;
                CboTipTranEco.Select();

            }
            else
            {
                DtFUMEco.Enabled = true;
                DtFUMEco.Select();
            }
        }

        private void CboConoceFUM02_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboConoceFUM02.SelectedIndex == 0)
            {
                DtFUMEco02.Enabled = false;
                TxtEdadFum02.Text = null;
                CboTipTranEco02.Select();

            }
            else
            {
                DtFUMEco02.Enabled = true;
                DtFUMEco02.Select();
            }
        }

        private void CboConoceFUM03_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboConoceFUM03.SelectedIndex == 0)
            {
                DtFUMEco03.Enabled = false;
                TxtEdadFum03.Text = null;
                CboTipTranEco03.Select();

            }
            else
            {
                DtFUMEco03.Enabled = true;
                DtFUMEco03.Select();
            }
        }

        private void CboConoceFUM05_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboConoceFUM05.SelectedIndex == 0)
            {
                DtFUMEco05.Enabled = false;
                TxtEdadFum05.Text = null;
                CboTipTranEco05.Select();

            }
            else
            {
                DtFUMEco05.Enabled = true;
                DtFUMEco05.Select();
            }
        }

        private void CboConoceFUM06_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboConoceFUM06.SelectedIndex == 0)
            {
                DtFUMEco06.Enabled = false;
                TxtEdadFum06.Text = null;
                CboTipTranEco06.Select();

            }
            else
            {
                DtFUMEco06.Enabled = true;
                DtFUMEco06.Select();
            }
        }

        private void CboConoceFUM07_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboConoceFUM07.SelectedIndex == 0)
            {
                DtFUMEco07.Enabled = false;
                TxtEdadFum07.Text = null;
                CboTipTranEco07.Select();

            }
            else
            {
                DtFUMEco07.Enabled = true;
                DtFUMEco07.Select();
            }
        }

        private void CboConoceFUM08_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboConoceFUM08.SelectedIndex == 0)
            {
                DtFUMEco08.Enabled = false;
                TxtEdadFum08.Text = null;
                CboTipTranEco08.Select();

            }
            else
            {
                DtFUMEco08.Enabled = true;
                DtFUMEco08.Select();
            }
        }

        private void CboConoceFUM11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboConoceFUM11.SelectedIndex == 0)
            {
                DtFUMEco11.Enabled = false;
                TxtEdadFum11.Text = null;
                CboTipTranEco11.Select();

            }
            else
            {
                DtFUMEco11.Enabled = true;
                DtFUMEco11.Select();
            }
        }

        private void CboConoceFUM13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboConoceFUM13.SelectedIndex == 0)
            {
                DtFUMEco13.Enabled = false;
                TxtEdadFum13.Text = null;
                CboTipTranEco13.Select();

            }
            else
            {
                DtFUMEco13.Enabled = true;
                DtFUMEco13.Select();
            }
        }

        private void CboConoceFUM14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboConoceFUM14.SelectedIndex == 0)
            {
                DtFUMEco14.Enabled = false;
                TxtEdadFum14.Text = null;
                CboTipTranEco14.Select();

            }
            else
            {
                DtFUMEco14.Enabled = true;
                DtFUMEco14.Select();
            }
        }

        #endregion

        #region Texbox



        private void TxtNumHistoEco_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    string HisBus = TxtNumHistoEco.Text;
                    limpiarTextBoxes(this);
                    CargarDatos(HisBus);
                }
            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "después de actualizar el número de historia" + "\r";
                Utils.Informa += "Mensaje del error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Funciones

        private void ModificaEco(string T, string H, string M, string FunConEco)
        {
            try
            {

                string UsaRegis = lblCodigoUser.Text, SqlBioFeto;
                int NFetos = 0, NFtol = 0;
                bool Insert;
                List<SqlParameter> parameters = new List<SqlParameter>();

                switch (T)
                {
                    case string estado when estado == "01" || estado == "12": //Ecografía obstetrica

                        if (TxtEcoNumForm.Text == FunConEco)
                        {

                            Utils.SqlDatos = "UPDATE [DACONEXTSQL].[dbo].[Datos registros de ecografias] SET  " +
                            "Numaten = '" + TxtAtenNumEco.Text + "'," +
                            "NumFactu = '" + TxtFactConsul.Text + "'," +
                            "NumHisEco = '" + TxtNumHistoEco.Text + "'," +
                            $"FecRealECO = {Conexion.ValidarFechaNula(DtFecTomaEco.Value.ToString("yyyy-MM-dd"))} " +
                            "TransFrec = '" + CboTipTranEco.SelectedValue + "'," +
                            "SeConoFUM = '" + CboConoceFUM.SelectedIndex + "'," +
                            $"FUMEco = {Conexion.ValidarFechaNula(DtFUMEco.Value.ToString("yyyy-MM-dd"))} " +
                            "EdadGesFum = '" + TxtEdadFum.Text + "'," +
                            $"FPPFUM = {Conexion.ValidarFechaNula(DtFPPFUM.Value.ToString("yyyy-MM-dd"))} " +
                            "NumFetos = '" + TxtNumFetosECO.Text + "'," +
                            "Utero = '" + TxtDesUteroEco.Text + "'," +
                            "Placenta = '" + CboPlacenECO.SelectedValue + "'," +
                            "GraMaPla = '" + CboGradoMadECO.Text + "'," +
                            "EspePlace = '" + TxtEspePlace.Value + "'," +
                            "NumSemECO = '" + TxtNumSemECO.Text + "'," +
                            "NumDiasECO = '" + TxtNumDiasECO.Text + "'," +
                            $"FPPEco = {Conexion.ValidarFechaNula(DtFFPECO.Value.ToString("yyyy-MM-dd"))} " +
                            "ConclusECO = '" + TxtConcluEcos.Text + "'," +
                            "CodMedECO = '" + CboCodiMedi.SelectedValue + "'," +
                            "CodAuxECO = '" + CboCodiAuxRegis.SelectedValue + "'," +
                            "ArchivEco = 'False'," +
                            $"FecModi = {Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))} " +
                            "CodModi = '" + UsaRegis + "'" +
                            "WHERE (NumEcogra = N'" + FunConEco + "') ";

                            bool ActControl = Conexion.SQLUpdate(Utils.SqlDatos);

                            //Procedemos a agregar la biometria de los fetos

                            NFetos = Convert.ToInt32(TxtNumFetosECO.Text);
                            NFtol = 1;

                            while (NFetos > 0)
                            {

                                SqlBioFeto = "SELECT NumEcoFeto, FetoNum, Presentacion, Situacion, Posicion, MovCardiacos, ";
                                SqlBioFeto = SqlBioFeto + "MovRespiratorios, MovFetales, TonoFetal, ILAFeto, CordonUmbi, SexFeto, ";
                                SqlBioFeto = SqlBioFeto + "DBPFeto, HCFeto, ACFeto, LFFeto, PesoFeto, FCFFeto ";
                                SqlBioFeto = SqlBioFeto + "FROM [DACONEXTSQL].[dbo].[Datos biometria de los fetos] ";
                                SqlBioFeto = SqlBioFeto + "WHERE  NumEcoFeto = '" + FunConEco + "' AND FetoNum = " + NFtol;


                                SqlDataReader TabBioFeto;

                                using (SqlConnection connection = new SqlConnection(Conexion.conexionSQL))
                                {
                                    SqlCommand command = new SqlCommand(SqlBioFeto, connection);
                                    command.Connection.Open();
                                    TabBioFeto = command.ExecuteReader();

                                    if (TabBioFeto.HasRows == false)
                                    {


                                        Utils.SqlDatos = "INSERT INTO [DACONEXTSQL].[dbo].[Datos biometria de los fetos] (NumEcoFeto, FetoNum, Presentacion, Situacion, Posicion, MovCardiacos, MovRespiratorios, MovFetales, TonoFetal, ILAFeto, CordonUmbi, SexFeto, DBPFeto, HCFeto, ACFeto,LFFeto, PesoFeto, FCFFeto) " +
                                        "VALUES (@NumEcoFeto, @FetoNum,@Presentacion,@Situacion,@Posicion,@MovCardiacos,@MovRespiratorios,@MovFetales,@TonoFetal,@ILAFeto,@CordonUmbi,@SexFeto,@DBPFeto,@HCFeto,@ACFeto,@LFFeto,@PesoFeto,@FCFFeto)";


                                        switch (NFtol)
                                        {
                                            case 1: //Agrega el primer feto


                                                parameters = null;
                                                parameters = new List<SqlParameter>
                                                            {
                                                                new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                new SqlParameter("@FetoNum", SqlDbType.Int){ Value = NFtol},
                                                                new SqlParameter("@Presentacion", SqlDbType.VarChar){ Value = CboPresenta01.Text},
                                                                new SqlParameter("@Situacion", SqlDbType.VarChar){ Value = TxtSituacion01.Text},
                                                                new SqlParameter("@Posicion", SqlDbType.VarChar){ Value = CboPosicion01.Text},
                                                                new SqlParameter("@MovCardiacos", SqlDbType.VarChar){ Value = TxtMovCardi01.Text},
                                                                new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovRespi01.Text},
                                                                new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMoviFeta01.Text},
                                                                new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoFetal01.Text},
                                                                new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtLiquiAm01.Text},
                                                                new SqlParameter("@CordonUmbi", SqlDbType.VarChar){ Value = TxtCordon01.Text},
                                                                new SqlParameter("@SexFeto", SqlDbType.VarChar){ Value = CboSexFeto01.Text},
                                                                new SqlParameter("@DBPFeto", SqlDbType.Int){ Value = TxtBDP01.Text},
                                                                new SqlParameter("@HCFeto", SqlDbType.Int){ Value = TxtHC01.Text},
                                                                new SqlParameter("@ACFeto", SqlDbType.Int){ Value = TxtAC01.Text},
                                                                new SqlParameter("@LFFeto", SqlDbType.Int){ Value = TxtLF01.Text},
                                                                new SqlParameter("@PesoFeto", SqlDbType.Int){ Value = TxtPeso01.Text},
                                                                new SqlParameter("@FCFFeto", SqlDbType.Int){ Value = TxtFCFFeto01.Text},
                                                            };

                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);


                                                break;
                                            case 2:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                            {
                                                                new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                new SqlParameter("@Presentacion", SqlDbType.VarChar){ Value = CboPresenta02.Text},
                                                                new SqlParameter("@Situacion", SqlDbType.VarChar){ Value = TxtSituacion02.Text},
                                                                new SqlParameter("@Posicion", SqlDbType.VarChar){ Value = CboPosicion02.Text},
                                                                new SqlParameter("@MovCardiacos", SqlDbType.VarChar){ Value = TxtMovCardi02.Text},
                                                                new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovRespi02.Text},
                                                                new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMoviFeta02.Text},
                                                                new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoFetal02.Text},
                                                                new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtLiquiAm02.Text},
                                                                new SqlParameter("@CordonUmbi", SqlDbType.VarChar){ Value = TxtCordon02.Text},
                                                                new SqlParameter("@SexFeto", SqlDbType.VarChar){ Value = CboSexFeto02.Text},
                                                                new SqlParameter("@DBPFeto", SqlDbType.SmallInt){ Value = TxtBDP02.Text},
                                                                new SqlParameter("@HCFeto", SqlDbType.SmallInt){ Value = TxtHC02.Text},
                                                                new SqlParameter("@ACFeto", SqlDbType.SmallInt){ Value = TxtAC02.Text},
                                                                new SqlParameter("@LFFeto", SqlDbType.SmallInt){ Value = TxtLF02.Text},
                                                                new SqlParameter("@PesoFeto", SqlDbType.VarChar){ Value = TxtPeso02.Text},
                                                                new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCFFeto02.Text},
                                                            };

                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                break;
                                            case 3:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                            {
                                                                new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                new SqlParameter("@Presentacion", SqlDbType.VarChar){ Value = CboPresenta03.Text},
                                                                new SqlParameter("@Situacion", SqlDbType.VarChar){ Value = TxtSituacion03.Text},
                                                                new SqlParameter("@Posicion", SqlDbType.VarChar){ Value = CboPosicion03.Text},
                                                                new SqlParameter("@MovCardiacos", SqlDbType.VarChar){ Value = TxtMovCardi03.Text},
                                                                new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovRespi03.Text},
                                                                new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMoviFeta03.Text},
                                                                new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoFetal03.Text},
                                                                new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtLiquiAm03.Text},
                                                                new SqlParameter("@CordonUmbi", SqlDbType.VarChar){ Value = TxtCordon03.Text},
                                                                new SqlParameter("@SexFeto", SqlDbType.VarChar){ Value = CboSexFeto03.Text},
                                                                new SqlParameter("@DBPFeto", SqlDbType.SmallInt){ Value = TxtBDP03.Text},
                                                                new SqlParameter("@HCFeto", SqlDbType.SmallInt){ Value = TxtHC03.Text},
                                                                new SqlParameter("@ACFeto", SqlDbType.SmallInt){ Value = TxtAC03.Text},
                                                                new SqlParameter("@LFFeto", SqlDbType.SmallInt){ Value = TxtLF03.Text},
                                                                new SqlParameter("@PesoFeto", SqlDbType.VarChar){ Value = TxtPeso03.Text},
                                                                new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCFFeto03.Text},
                                                            };

                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);


                                                break;

                                            case 4:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                            {
                                                                 new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                new SqlParameter("@Presentacion", SqlDbType.VarChar){ Value = CboPresenta04.Text},
                                                                new SqlParameter("@Situacion", SqlDbType.VarChar){ Value = TxtSituacion04.Text},
                                                                new SqlParameter("@Posicion", SqlDbType.VarChar){ Value = CboPosicion04.Text},
                                                                new SqlParameter("@MovCardiacos", SqlDbType.VarChar){ Value = TxtMovCardi04.Text},
                                                                new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovRespi04.Text},
                                                                new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMoviFeta04.Text},
                                                                new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoFetal04.Text},
                                                                new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtLiquiAm04.Text},
                                                                new SqlParameter("@CordonUmbi", SqlDbType.VarChar){ Value = TxtCordon04.Text},
                                                                new SqlParameter("@SexFeto", SqlDbType.VarChar){ Value = CboSexFeto04.Text},
                                                                new SqlParameter("@DBPFeto", SqlDbType.SmallInt){ Value = TxtBDP04.Text},
                                                                new SqlParameter("@HCFeto", SqlDbType.SmallInt){ Value = TxtHC04.Text},
                                                                new SqlParameter("@ACFeto", SqlDbType.SmallInt){ Value = TxtAC04.Text},
                                                                new SqlParameter("@LFFeto", SqlDbType.SmallInt){ Value = TxtLF04.Text},
                                                                new SqlParameter("@PesoFeto", SqlDbType.VarChar){ Value = TxtPeso04.Text},
                                                                new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCFFeto04.Text},
                                                            };

                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);


                                                break;


                                            case 5:



                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                            {
                                                                new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                new SqlParameter("@Presentacion", SqlDbType.VarChar){ Value = CboPresenta05.Text},
                                                                new SqlParameter("@Situacion", SqlDbType.VarChar){ Value = TxtSituacion05.Text},
                                                                new SqlParameter("@Posicion", SqlDbType.VarChar){ Value = CboPosicion05.Text},
                                                                new SqlParameter("@MovCardiacos", SqlDbType.VarChar){ Value = TxtMovCardi05.Text},
                                                                new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovRespi05.Text},
                                                                new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMoviFeta05.Text},
                                                                new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoFetal05.Text},
                                                                new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtLiquiAm05.Text},
                                                                new SqlParameter("@CordonUmbi", SqlDbType.VarChar){ Value = TxtCordon05.Text},
                                                                new SqlParameter("@SexFeto", SqlDbType.VarChar){ Value = CboSexFeto05.Text},
                                                                new SqlParameter("@DBPFeto", SqlDbType.SmallInt){ Value = TxtBDP05.Text},
                                                                new SqlParameter("@HCFeto", SqlDbType.SmallInt){ Value = TxtHC05.Text},
                                                                new SqlParameter("@ACFeto", SqlDbType.SmallInt){ Value = TxtAC05.Text},
                                                                new SqlParameter("@LFFeto", SqlDbType.SmallInt){ Value = TxtLF05.Text},
                                                                new SqlParameter("@PesoFeto", SqlDbType.VarChar){ Value = TxtPeso05.Text},
                                                                new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCFFeto05.Text},
                                                            };

                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                break;

                                            default:
                                                break;
                                        }

                                    }
                                    else
                                    {

                                        //@NumEcoFeto, @FetoNum

                                        Utils.SqlDatos = "UPDATE [DACONEXTSQL].[dbo].[Datos biometria de los fetos]  SET Presentacion = @Presentacion, Situacion = @Situacion, Posicion = @Posicion," +
                                            " MovCardiacos = @MovCardiacos," +
                                            " MovRespiratorios = @MovRespiratorios, MovFetales = @MovFetales, TonoFetal = @TonoFetal, ILAFeto = @ILAFeto," +
                                            " CordonUmbi = @CordonUmbi, SexFeto = @SexFeto, DBPFeto = @DBPFeto, HCFeto = @HCFeto, ACFeto = @ACFeto,LFFeto = @LFFeto, PesoFeto = @PesoFeto, FCFFeto = @FCFFeto " +
                                            " WHERE NumEcoFeto = @NumEcoFeto AND FetoNum = @FetoNum";

                                        switch (NFtol)
                                        {
                                            case 1: //Agrega el primer feto


                                                parameters = null;
                                                parameters = new List<SqlParameter>
                                                            {
                                                                new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                new SqlParameter("@FetoNum", SqlDbType.Int){ Value = NFtol},
                                                                new SqlParameter("@Presentacion", SqlDbType.VarChar){ Value = CboPresenta01.Text},
                                                                new SqlParameter("@Situacion", SqlDbType.VarChar){ Value = TxtSituacion01.Text},
                                                                new SqlParameter("@Posicion", SqlDbType.VarChar){ Value = CboPosicion01.Text},
                                                                new SqlParameter("@MovCardiacos", SqlDbType.VarChar){ Value = TxtMovCardi01.Text},
                                                                new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovRespi01.Text},
                                                                new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMoviFeta01.Text},
                                                                new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoFetal01.Text},
                                                                new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtLiquiAm01.Text},
                                                                new SqlParameter("@CordonUmbi", SqlDbType.VarChar){ Value = TxtCordon01.Text},
                                                                new SqlParameter("@SexFeto", SqlDbType.VarChar){ Value = CboSexFeto01.Text},
                                                                new SqlParameter("@DBPFeto", SqlDbType.Int){ Value = TxtBDP01.Text},
                                                                new SqlParameter("@HCFeto", SqlDbType.Int){ Value = TxtHC01.Text},
                                                                new SqlParameter("@ACFeto", SqlDbType.Int){ Value = TxtAC01.Text},
                                                                new SqlParameter("@LFFeto", SqlDbType.Int){ Value = TxtLF01.Text},
                                                                new SqlParameter("@PesoFeto", SqlDbType.Int){ Value = TxtPeso01.Text},
                                                                new SqlParameter("@FCFFeto", SqlDbType.Int){ Value = TxtFCFFeto01.Text},
                                                            };

                                                Insert = Conexion.SQLUpdate(Utils.SqlDatos, parameters);


                                                break;
                                            case 2:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                            {
                                                                new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                new SqlParameter("@Presentacion", SqlDbType.VarChar){ Value = CboPresenta02.Text},
                                                                new SqlParameter("@Situacion", SqlDbType.VarChar){ Value = TxtSituacion02.Text},
                                                                new SqlParameter("@Posicion", SqlDbType.VarChar){ Value = CboPosicion02.Text},
                                                                new SqlParameter("@MovCardiacos", SqlDbType.VarChar){ Value = TxtMovCardi02.Text},
                                                                new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovRespi02.Text},
                                                                new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMoviFeta02.Text},
                                                                new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoFetal02.Text},
                                                                new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtLiquiAm02.Text},
                                                                new SqlParameter("@CordonUmbi", SqlDbType.VarChar){ Value = TxtCordon02.Text},
                                                                new SqlParameter("@SexFeto", SqlDbType.VarChar){ Value = CboSexFeto02.Text},
                                                                new SqlParameter("@DBPFeto", SqlDbType.SmallInt){ Value = TxtBDP02.Text},
                                                                new SqlParameter("@HCFeto", SqlDbType.SmallInt){ Value = TxtHC02.Text},
                                                                new SqlParameter("@ACFeto", SqlDbType.SmallInt){ Value = TxtAC02.Text},
                                                                new SqlParameter("@LFFeto", SqlDbType.SmallInt){ Value = TxtLF02.Text},
                                                                new SqlParameter("@PesoFeto", SqlDbType.VarChar){ Value = TxtPeso02.Text},
                                                                new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCFFeto02.Text},
                                                            };

                                                Insert = Conexion.SQLUpdate(Utils.SqlDatos, parameters);

                                                break;
                                            case 3:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                            {
                                                                new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                new SqlParameter("@Presentacion", SqlDbType.VarChar){ Value = CboPresenta03.Text},
                                                                new SqlParameter("@Situacion", SqlDbType.VarChar){ Value = TxtSituacion03.Text},
                                                                new SqlParameter("@Posicion", SqlDbType.VarChar){ Value = CboPosicion03.Text},
                                                                new SqlParameter("@MovCardiacos", SqlDbType.VarChar){ Value = TxtMovCardi03.Text},
                                                                new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovRespi03.Text},
                                                                new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMoviFeta03.Text},
                                                                new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoFetal03.Text},
                                                                new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtLiquiAm03.Text},
                                                                new SqlParameter("@CordonUmbi", SqlDbType.VarChar){ Value = TxtCordon03.Text},
                                                                new SqlParameter("@SexFeto", SqlDbType.VarChar){ Value = CboSexFeto03.Text},
                                                                new SqlParameter("@DBPFeto", SqlDbType.SmallInt){ Value = TxtBDP03.Text},
                                                                new SqlParameter("@HCFeto", SqlDbType.SmallInt){ Value = TxtHC03.Text},
                                                                new SqlParameter("@ACFeto", SqlDbType.SmallInt){ Value = TxtAC03.Text},
                                                                new SqlParameter("@LFFeto", SqlDbType.SmallInt){ Value = TxtLF03.Text},
                                                                new SqlParameter("@PesoFeto", SqlDbType.VarChar){ Value = TxtPeso03.Text},
                                                                new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCFFeto03.Text},
                                                            };

                                                Insert = Conexion.SQLUpdate(Utils.SqlDatos, parameters);


                                                break;

                                            case 4:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                            {
                                                                 new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                new SqlParameter("@Presentacion", SqlDbType.VarChar){ Value = CboPresenta04.Text},
                                                                new SqlParameter("@Situacion", SqlDbType.VarChar){ Value = TxtSituacion04.Text},
                                                                new SqlParameter("@Posicion", SqlDbType.VarChar){ Value = CboPosicion04.Text},
                                                                new SqlParameter("@MovCardiacos", SqlDbType.VarChar){ Value = TxtMovCardi04.Text},
                                                                new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovRespi04.Text},
                                                                new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMoviFeta04.Text},
                                                                new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoFetal04.Text},
                                                                new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtLiquiAm04.Text},
                                                                new SqlParameter("@CordonUmbi", SqlDbType.VarChar){ Value = TxtCordon04.Text},
                                                                new SqlParameter("@SexFeto", SqlDbType.VarChar){ Value = CboSexFeto04.Text},
                                                                new SqlParameter("@DBPFeto", SqlDbType.SmallInt){ Value = TxtBDP04.Text},
                                                                new SqlParameter("@HCFeto", SqlDbType.SmallInt){ Value = TxtHC04.Text},
                                                                new SqlParameter("@ACFeto", SqlDbType.SmallInt){ Value = TxtAC04.Text},
                                                                new SqlParameter("@LFFeto", SqlDbType.SmallInt){ Value = TxtLF04.Text},
                                                                new SqlParameter("@PesoFeto", SqlDbType.VarChar){ Value = TxtPeso04.Text},
                                                                new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCFFeto04.Text},
                                                            };

                                                Insert = Conexion.SQLUpdate(Utils.SqlDatos, parameters);


                                                break;


                                            case 5:



                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                            {
                                                                new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                new SqlParameter("@Presentacion", SqlDbType.VarChar){ Value = CboPresenta05.Text},
                                                                new SqlParameter("@Situacion", SqlDbType.VarChar){ Value = TxtSituacion05.Text},
                                                                new SqlParameter("@Posicion", SqlDbType.VarChar){ Value = CboPosicion05.Text},
                                                                new SqlParameter("@MovCardiacos", SqlDbType.VarChar){ Value = TxtMovCardi05.Text},
                                                                new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovRespi05.Text},
                                                                new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMoviFeta05.Text},
                                                                new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoFetal05.Text},
                                                                new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtLiquiAm05.Text},
                                                                new SqlParameter("@CordonUmbi", SqlDbType.VarChar){ Value = TxtCordon05.Text},
                                                                new SqlParameter("@SexFeto", SqlDbType.VarChar){ Value = CboSexFeto05.Text},
                                                                new SqlParameter("@DBPFeto", SqlDbType.SmallInt){ Value = TxtBDP05.Text},
                                                                new SqlParameter("@HCFeto", SqlDbType.SmallInt){ Value = TxtHC05.Text},
                                                                new SqlParameter("@ACFeto", SqlDbType.SmallInt){ Value = TxtAC05.Text},
                                                                new SqlParameter("@LFFeto", SqlDbType.SmallInt){ Value = TxtLF05.Text},
                                                                new SqlParameter("@PesoFeto", SqlDbType.VarChar){ Value = TxtPeso05.Text},
                                                                new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCFFeto05.Text},
                                                            };

                                                Insert = Conexion.SQLUpdate(Utils.SqlDatos, parameters);

                                                break;

                                            default:
                                                break;

                                        }

                                    }

                                }

                                NFtol += 1;
                                NFetos -= 1;

                            }

                            Utils.Informa = "Los datos de la ecografía han sido actualizados satisfactoriamente.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information); ;




                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero el sistema ha encontrado la";
                            Utils.Informa += "ecografia No. " + FunConEco + " la cual el número";
                            Utils.Informa += "es distinto a la que usted esta modificando.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        }

                        break;


                    case string estado when estado == "02" || estado == "10":

                        if (TxtEcoNumForm02.Text == FunConEco)
                        {

                            Utils.SqlDatos = "UPDATE [DACONEXTSQL].[dbo].[Datos registros de ecografias] SET  " +
                            "Numaten = '" + TxtAtenNumEco.Text + "'," +
                            "NumFactu = '" + TxtFactConsul.Text + "'," +
                            "NumHisEco = '" + TxtNumHistoEco.Text + "'," +
                            $"FecRealECO = {Conexion.ValidarFechaNula(DtFecTomaEco02.Value.ToString("yyyy-MM-dd"))} " +
                            "TransFrec = '" + CboTipTranEco02.SelectedValue + "'," +
                            "SeConoFUM = '" + CboConoceFUM02.SelectedIndex + "'," +
                            $"FUMEco = {Conexion.ValidarFechaNula(DtFUMEco02.Value.ToString("yyyy-MM-dd"))} " +
                            "EdadGesFum = '" + TxtEdadFum02.Text + "'," +
                            $"FPPFUM = {Conexion.ValidarFechaNula(DtFPPFUM02.Value.ToString("yyyy-MM-dd"))} " +
                            "Utero = '" + TxtDesUteroEco02.Text + "'," +
                            "DiamLongi = '" + TxtDiameLongi02.Text + "'," +
                            "DiamAntePos = '" + TxtDiameAntePos02.Text + "'," +
                            "DiamTras = '" + TxtDiameTras02.Text + "'," +
                            "Endometrio = '" + TxtEndome02.Text + "'," +
                            "DesEndometrio = '" + TxtDesEndome02.Text + "'," +
                            "OvarioDere = '" + TxtOvariDere02.Text + "'," +
                            "PorOvarioDere = '" + TxtPorOvariDere02.Text + "'," +
                            "OvarioIzquie = '" + TxtOvariIzquie02.Text + "'," +
                            "PorOvarioIzqui = '" + TxtPorOvariIzqui02.Text + "'," +
                            "Comenta = '" + TxtComentario02.Text + "'," +
                            "ConclusECO = '" + TxtConcluEcos02.Text + " '," +
                            "CodMedECO = '" + CboCodiMedi.SelectedValue + "'," +
                            "CodAuxECO = '" + CboCodiAuxRegis.SelectedValue + "'," +
                            "ArchivEco = 'False'," +
                            $"FecModi = {Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))} " +
                            "CodModi = '" + UsaRegis + "'" +
                            "WHERE (NumEcogra = N'" + FunConEco + "') ";

                            bool ActControl = Conexion.SQLUpdate(Utils.SqlDatos);

                            Utils.Informa = "Los datos de la ecografía han sido actualizados satisfactoriamente.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information); ;


                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero el sistema ha encontrado la";
                            Utils.Informa += "ecografia No. " + FunConEco + " la cual el número";
                            Utils.Informa += "es distinto a la que usted esta modificando.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        }


                        break;


                    case string estado when estado == "03" || estado == "04":

                        if (TxtEcoNumForm03.Text == FunConEco)
                        {

                            Utils.SqlDatos = "UPDATE [DACONEXTSQL].[dbo].[Datos registros de ecografias] SET  " +
                            "Numaten = '" + TxtAtenNumEco.Text + "'," +
                            "NumFactu = '" + TxtFactConsul.Text + "'," +
                            "NumHisEco = '" + TxtNumHistoEco.Text + "'," +
                            $"FecRealECO = {Conexion.ValidarFechaNula(DtFecTomaEco03.Value.ToString("yyyy-MM-dd"))} " +
                            "TransFrec = '" + CboTipTranEco03.SelectedValue + "'," +
                            "SeConoFUM = '" + CboConoceFUM03.SelectedIndex + "'," +
                            $"FUMEco = {Conexion.ValidarFechaNula(DtFUMEco03.Value.ToString("yyyy-MM-dd"))} " +
                            "EdadGesFum = '" + TxtEdadFum03.Text + "'," +
                            $"FPPFUM = {Conexion.ValidarFechaNula(DtFPPFUM03.Value.ToString("yyyy-MM-dd"))} " +
                            "NumFetos = '" + TxtNumFetosECO03.Text + "'," +
                            "Utero = '" + TxtDesUteroEco03.Text + "'," +
                            "CervixEsta = '" + TxtCervixCerra.Text + "'," +
                            "NumSemECO = '" + TxtNumSemECO03.Text + "'," +
                            "NumDiasECO = '" + TxtNumDiasECO03.Text + "'," +
                            $"FPPEco = {Conexion.ValidarFechaNula(DtFFPECO03.Value.ToString("yyyy-MM-dd"))} " +
                            "ConclusECO = '" + TxtConcluEcos03.Text + "'," +
                            "CodMedECO = '" + CboCodiMedi.SelectedValue + "'," +
                            "CodAuxECO = '" + CboCodiAuxRegis.SelectedValue + "'," +
                            "ArchivEco = 'False'," +
                            $"FecModi = {Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))} " +
                            "CodModi = '" + UsaRegis + "'" +
                            "WHERE (NumEcogra = N'" + FunConEco + "') ";

                            bool ActControl = Conexion.SQLUpdate(Utils.SqlDatos);

                            //Procedemos a agregar la biometria de los fetos

                            NFetos = Convert.ToInt32(TxtNumFetosECO03.Text);
                            NFtol = 1;

                            while (NFetos > 0)
                            {

                                SqlBioFeto = "SELECT NumEcoFeto, FetoNum, Presentacion, Situacion, Posicion, MovCardiacos, TotaPunt, ";
                                SqlBioFeto = SqlBioFeto + "MovRespiratorios, MovFetales, TonoFetal, ILAFeto, CordonUmbi, SexFeto, SacoGesta, ";
                                SqlBioFeto = SqlBioFeto + "VesiVitelina, BotonEmbriona, DBPFeto, LCN, HCFeto, ACFeto, LFFeto, PesoFeto, FCFFeto ";
                                SqlBioFeto = SqlBioFeto + "FROM [DACONEXTSQL].[dbo].[Datos biometria de los fetos] ";
                                SqlBioFeto = SqlBioFeto + "WHERE  NumEcoFeto = '" + FunConEco + "' AND FetoNum = " + NFtol;

                                SqlDataReader TabBioFeto;

                                using (SqlConnection connection = new SqlConnection(Conexion.conexionSQL))
                                {
                                    SqlCommand command = new SqlCommand(SqlBioFeto, connection);
                                    command.Connection.Open();
                                    TabBioFeto = command.ExecuteReader();

                                    if (TabBioFeto.HasRows == false)
                                    {

                                        Utils.SqlDatos = "INSERT [DACONEXTSQL].[dbo].[Datos biometria de los fetos](NumEcoFeto,FetoNum,FCFFeto,SacoGesta,VesiVitelina,BotonEmbriona,LCN) ";
                                        Utils.SqlDatos += "VALUES (@NumEcoFeto,@FetoNum,@FCFFeto,@SacoGesta,@VesiVitelina,@BotonEmbriona,@LCN)";

                                        switch (NFtol)
                                        {
                                            case 1:

                                                parameters = null;



                                                parameters = new List<SqlParameter>
                                                {

                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCF01.Text},
                                                    new SqlParameter("@SacoGesta", SqlDbType.VarChar){ Value = TxtSacoGes01.Text},
                                                    new SqlParameter("@VesiVitelina", SqlDbType.VarChar){ Value = TxtVesiVitelina01.Text},
                                                    new SqlParameter("@BotonEmbriona", SqlDbType.VarChar){ Value = TxtBotonEmbriona01.Text},
                                                    new SqlParameter("@LCN", SqlDbType.VarChar){ Value = TxtLCN01.Text},

                                                };

                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);


                                                break;

                                            case 2:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                {

                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCF02.Text},
                                                    new SqlParameter("@SacoGesta", SqlDbType.VarChar){ Value = TxtSacoGes02.Text},
                                                    new SqlParameter("@VesiVitelina", SqlDbType.VarChar){ Value = TxtVesiVitelina02.Text},
                                                    new SqlParameter("@BotonEmbriona", SqlDbType.VarChar){ Value = TxtBotonEmbriona02.Text},
                                                    new SqlParameter("@LCN", SqlDbType.VarChar){ Value = TxtLCN02.Text},

                                                };

                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                break;


                                            case 3:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                {

                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCF03.Text},
                                                    new SqlParameter("@SacoGesta", SqlDbType.VarChar){ Value = TxtSacoGes03.Text},
                                                    new SqlParameter("@VesiVitelina", SqlDbType.VarChar){ Value = TxtVesiVitelina03.Text},
                                                    new SqlParameter("@BotonEmbriona", SqlDbType.VarChar){ Value = TxtBotonEmbriona03.Text},
                                                    new SqlParameter("@LCN", SqlDbType.VarChar){ Value = TxtLCN03.Text},

                                                };

                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                break;

                                            case 4:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                {

                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCF04.Text},
                                                    new SqlParameter("@SacoGesta", SqlDbType.VarChar){ Value = TxtSacoGes04.Text},
                                                    new SqlParameter("@VesiVitelina", SqlDbType.VarChar){ Value = TxtVesiVitelina04.Text},
                                                    new SqlParameter("@BotonEmbriona", SqlDbType.VarChar){ Value = TxtBotonEmbriona04.Text},
                                                    new SqlParameter("@LCN", SqlDbType.VarChar){ Value = TxtLCN04.Text},

                                                };

                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                break;

                                            case 5:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                {

                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCF05.Text},
                                                    new SqlParameter("@SacoGesta", SqlDbType.VarChar){ Value = TxtSacoGes05.Text},
                                                    new SqlParameter("@VesiVitelina", SqlDbType.VarChar){ Value = TxtVesiVitelina05.Text},
                                                    new SqlParameter("@BotonEmbriona", SqlDbType.VarChar){ Value = TxtBotonEmbriona05.Text},
                                                    new SqlParameter("@LCN", SqlDbType.VarChar){ Value = TxtLCN05.Text},

                                                };

                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                break;

                                            default:
                                                break;
                                        }// SWICH
                                    }
                                    else
                                    {
                                        //Modifique los datos

                                        Utils.SqlDatos = "UPDATE [DACONEXTSQL].[dbo].[Datos biometria de los fetos] SET FCFFeto = @FCFFeto,SacoGesta = @SacoGesta,VesiVitelina = @VesiVitelina,BotonEmbriona = @BotonEmbriona,LCN = @LCN ";
                                        Utils.SqlDatos += "WHERE (NumEcoFeto = @NumEcoFeto AND FetoNum = @FetoNum)";


                                        switch (NFtol)
                                        {
                                            case 1:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                {
                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCF01.Text},
                                                    new SqlParameter("@SacoGesta", SqlDbType.VarChar){ Value = TxtSacoGes01.Text},
                                                    new SqlParameter("@VesiVitelina", SqlDbType.VarChar){ Value = TxtVesiVitelina01.Text},
                                                    new SqlParameter("@BotonEmbriona", SqlDbType.VarChar){ Value = TxtBotonEmbriona01.Text},
                                                    new SqlParameter("@LCN", SqlDbType.VarChar){ Value = TxtLCN01.Text},

                                                };

                                                Insert = Conexion.SQLUpdate(Utils.SqlDatos, parameters);


                                                break;

                                            case 2:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                {
                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCF02.Text},
                                                    new SqlParameter("@SacoGesta", SqlDbType.VarChar){ Value = TxtSacoGes02.Text},
                                                    new SqlParameter("@VesiVitelina", SqlDbType.VarChar){ Value = TxtVesiVitelina02.Text},
                                                    new SqlParameter("@BotonEmbriona", SqlDbType.VarChar){ Value = TxtBotonEmbriona02.Text},
                                                    new SqlParameter("@LCN", SqlDbType.VarChar){ Value = TxtLCN02.Text},

                                                };

                                                Insert = Conexion.SQLUpdate(Utils.SqlDatos, parameters);

                                                break;


                                            case 3:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                {
                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCF03.Text},
                                                    new SqlParameter("@SacoGesta", SqlDbType.VarChar){ Value = TxtSacoGes03.Text},
                                                    new SqlParameter("@VesiVitelina", SqlDbType.VarChar){ Value = TxtVesiVitelina03.Text},
                                                    new SqlParameter("@BotonEmbriona", SqlDbType.VarChar){ Value = TxtBotonEmbriona03.Text},
                                                    new SqlParameter("@LCN", SqlDbType.VarChar){ Value = TxtLCN03.Text},

                                                };

                                                Insert = Conexion.SQLUpdate(Utils.SqlDatos, parameters);

                                                break;

                                            case 4:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                {
                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCF04.Text},
                                                    new SqlParameter("@SacoGesta", SqlDbType.VarChar){ Value = TxtSacoGes04.Text},
                                                    new SqlParameter("@VesiVitelina", SqlDbType.VarChar){ Value = TxtVesiVitelina04.Text},
                                                    new SqlParameter("@BotonEmbriona", SqlDbType.VarChar){ Value = TxtBotonEmbriona04.Text},
                                                    new SqlParameter("@LCN", SqlDbType.VarChar){ Value = TxtLCN04.Text},

                                                };

                                                Insert = Conexion.SQLUpdate(Utils.SqlDatos, parameters);

                                                break;

                                            case 5:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                {
                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCF05.Text},
                                                    new SqlParameter("@SacoGesta", SqlDbType.VarChar){ Value = TxtSacoGes05.Text},
                                                    new SqlParameter("@VesiVitelina", SqlDbType.VarChar){ Value = TxtVesiVitelina05.Text},
                                                    new SqlParameter("@BotonEmbriona", SqlDbType.VarChar){ Value = TxtBotonEmbriona05.Text},
                                                    new SqlParameter("@LCN", SqlDbType.VarChar){ Value = TxtLCN05.Text},

                                                };

                                                Insert = Conexion.SQLUpdate(Utils.SqlDatos, parameters);

                                                break;

                                            default:
                                                break;
                                        }// SWICH

                                    }
                                }//Usiog

                                TabBioFeto.Close();
                                NFtol += 1;
                                NFetos -= 1;

                            }//While


                            Utils.Informa = "Los datos de la ecografía han sido actualizados satisfactoriamente.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero el sistema ha encontrado la";
                            Utils.Informa += "ecografia No. " + FunConEco + " la cual el número";
                            Utils.Informa += "es distinto a la que usted esta modificando.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        }


                        break;


                    case string estado when estado == "05" || estado == "07":

                        if (TxtEcoNumForm05.Text == FunConEco)
                        {
                            Utils.SqlDatos = "UPDATE [DACONEXTSQL].[dbo].[Datos registros de ecografias] SET  " +
                            "Numaten = '" + TxtAtenNumEco.Text + "'," +
                            "NumFactu = '" + TxtFactConsul.Text + "'," +
                            "NumHisEco = '" + TxtNumHistoEco.Text + "'," +
                            $"FecRealECO = {Conexion.ValidarFechaNula(DtFecTomaEco05.Value.ToString("yyyy-MM-dd"))} " +
                            "TransFrec = '" + CboTipTranEco05.SelectedValue + "'," +
                            "SeConoFUM = '" + CboConoceFUM05.SelectedIndex + "'," +

                            $"HigaAbdEco = '" + TxtHigadoEco05.Text + "'," +
                            "VesicuAbdEco = '" + TxtVesiculaEco05.Text + "'," +
                            "PancreAbdEco = '" + TxtPancreasEco05.Text + "'," +
                            "BazoAdbEco = '" + TxtBazoEco05.Text + "'," +
                            "RinonAbdEco = '" + txtRinonEco05.Text + "'," +
                            "ConclusECO = '" + TxtComentario05.Text + "'," +


                            "CodMedECO = '" + CboCodiMedi.SelectedValue + "'," +
                            "CodAuxECO = '" + CboCodiAuxRegis.SelectedValue + "'," +
                            "ArchivEco = 'False'," +
                            $"FecModi = {Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))} " +
                            "CodModi = '" + UsaRegis + "'" +
                            "WHERE (NumEcogra = N'" + FunConEco + "') ";

                            bool ActControl = Conexion.SQLUpdate(Utils.SqlDatos);

                            if (T == "5")
                            {
                                Utils.Informa = "Los datos de la ecografía abdominal han sido actualizados satisfactoriamente." + "\r";
                                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                Utils.Informa = "Los datos de la ecografía hepatobiliar han sido actualizados satisfactoriamente." + "\r";
                                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero el sistema ha encontrado la";
                            Utils.Informa += "ecografia No. " + FunConEco + " la cual el número";
                            Utils.Informa += "es distinto a la que usted esta modificando.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        }

                        break;


                    case "06":

                        if (TxtEcoNumForm06.Text == FunConEco)
                        {

                            Utils.SqlDatos = "UPDATE [DACONEXTSQL].[dbo].[Datos registros de ecografias] SET  " +
                            "Numaten = '" + TxtAtenNumEco.Text + "'," +
                            "NumFactu = '" + TxtFactConsul.Text + "'," +
                            "NumHisEco = '" + TxtNumHistoEco.Text + "'," +
                            $"FecRealECO = {Conexion.ValidarFechaNula(DtFecTomaEco06.Value.ToString("yyyy-MM-dd"))} " +
                            "TransFrec = '" + CboTipTranEco06.SelectedValue + "'," +
                            "FormaRiDere  = '" + TxtFormaRiDerecho06.Text + "'," +
                            "DiamRinDer  = '" + TxtDiamRinDerecho06.Text + "'," +
                            "DiamAntRinDer  = '" + TxtDiamAntRinDerecho06.Text + "'," +
                            "DiamTraRinDer  = '" + TxtDiamTraRinDerecho06.Text + "'," +
                            "DiamEpRinDer  = '" + TxtDiamEpRinDerecho06.Text + "'," +
                            "ObserRinDere  = '" + TxtObservaRinDerecho06.Text + "'," +
                            "FormaRinIzq  = '" + TxtFormaRinIzquie06.Text + "'," +
                            "DiamRinIzq  = '" + TxtDiamRinIzquie06.Text + "'," +
                            "DiamAntRinIzq  = '" + TxtDiamAntRinIzquie06.Text + "'," +
                            "DiamTraRinIzq  = '" + TxtDiamTraRinIzquie06.Text + "'," +
                            "DiamEpRinIzq  = '" + TxtDiamEpRinIzquie06.Text + "'," +
                            "ObserRinIzquie  = '" + TxtObservaRinIzquie06.Text + "'," +
                            "Comenta  = '" + TxtComentario06.Text + "'," +
                            "ConclusECO  = '" + TxtConcluEcos06.Text + "'," +
                            "CodMedECO = '" + CboCodiMedi.SelectedValue + "'," +
                            "CodAuxECO = '" + CboCodiAuxRegis.SelectedValue + "'," +
                            "ArchivEco = 'False'," +
                            $"FecModi = {Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))} " +
                            "CodModi = '" + UsaRegis + "'" +
                            "WHERE (NumEcogra = N'" + FunConEco + "') ";

                            bool ActControl = Conexion.SQLUpdate(Utils.SqlDatos);

                            Utils.Informa = "Los datos de la ecografía han sido actualizados satisfactoriamente.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information); ;


                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero el sistema ha encontrado la";
                            Utils.Informa += "ecografia No. " + FunConEco + " la cual el número";
                            Utils.Informa += "es distinto a la que usted esta modificando.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        }

                        break;

                    case "09":

                        if (TxtEcoNumForm07.Text == FunConEco)
                        {

                            Utils.SqlDatos = "UPDATE [DACONEXTSQL].[dbo].[Datos registros de ecografias] SET  " +
                            "Numaten = '" + TxtAtenNumEco.Text + "'," +
                            "NumFactu = '" + TxtFactConsul.Text + "'," +
                            "NumHisEco = '" + TxtNumHistoEco.Text + "'," +
                            $"FecRealECO = {Conexion.ValidarFechaNula(DtFecTomaEco07.Value.ToString("yyyy-MM-dd"))} " +
                            "TransFrec = '" + CboTipTranEco07.SelectedValue + "'," +
                            "SeConoFUM  = '" + CboConoceFUM07.SelectedIndex + "'," +
                            "HigaAbdEco  = '" + TxtHigadoEco07.Text + "'," +
                            "VesicuAbdEco  = '" + TxtVesiculaEco07.Text + "'," +
                            "PancreAbdEco  = '" + TxtPancreasEco07.Text + "'," +
                            "ConclusECO  = '" + TxtComentario07.Text + "'," +
                            "CodMedECO = '" + CboCodiMedi.SelectedValue + "'," +
                            "CodAuxECO = '" + CboCodiAuxRegis.SelectedValue + "'," +
                            "ArchivEco = 'False'," +
                            $"FecModi = {Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))} " +
                            "CodModi = '" + UsaRegis + "'" +
                            "WHERE (NumEcogra = N'" + FunConEco + "') ";

                            bool ActControl = Conexion.SQLUpdate(Utils.SqlDatos);

                            Utils.Informa = "Los datos de la ecografía han sido actualizados satisfactoriamente.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information); ;


                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero el sistema ha encontrado la";
                            Utils.Informa += "ecografia No. " + FunConEco + " la cual el número";
                            Utils.Informa += "es distinto a la que usted esta modificando.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        }

                        break;


                    case "08":

                        if (TxtEcoNumForm08.Text == FunConEco)
                        {
                            Utils.SqlDatos = "UPDATE [DACONEXTSQL].[dbo].[Datos registros de ecografias] SET  " +
                            "Numaten = '" + TxtAtenNumEco.Text + "'," +
                            "NumFactu = '" + TxtFactConsul.Text + "'," +
                            "NumHisEco = '" + TxtNumHistoEco.Text + "'," +
                            $"FecRealECO = {Conexion.ValidarFechaNula(DtFecTomaEco08.Value.ToString("yyyy-MM-dd"))} " +
                            "TransFrec = '" + CboTipTranEco08.SelectedValue + "'," +
                            "FormaRiDere  = '" + TxtFormaRiDerecho08.Text + "'," +
                            "DiamRinDer  = '" + TxtDiamRinDerecho08.Text + "'," +
                            "DiamAntRinDer  = '" + TxtDiamAntRinDerecho08.Text + "'," +
                            "DiamTraRinDer  = '" + TxtDiamTraRinDerecho08.Text + "'," +
                            "DiamEpRinDer  = '" + TxtDiamEpRinDerecho08.Text + "'," +
                            "ObserRinDere  = '" + TxtObservaRinDerecho08.Text + "'," +
                            "FormaRinIzq  = '" + TxtFormaRinIzquie08.Text + "'," +
                            "DiamRinIzq  = '" + TxtDiamRinIzquie08.Text + "'," +
                            "DiamAntRinIzq  = '" + TxtDiamAntRinIzquie08.Text + "'," +
                            "DiamTraRinIzq  = '" + TxtDiamTraRinIzquie08.Text + "'," +
                            "DiamEpRinIzq  = '" + TxtDiamEpRinIzquie08.Text + "'," +
                            "ObserRinIzquie  = '" + TxtObservaRinIzquie08.Text + "'," +
                            "AspecVeji  = '" + TxtAspecVejiga08.Text + "'," +
                            "VoluPromVeji  = '" + TxtVoluPromVejiga08.Text + "'," +
                            "ResiPostVeji  = '" + TxtResiPostVejiga08.Text + "'," +
                            "Comenta  = '" + TxtComentario08.Text + "'," +
                            "ConclusECO  = '" + TxtConcluEcos08.Text + "'," +
                            "CodMedECO = '" + CboCodiMedi.SelectedValue + "'," +
                            "CodAuxECO = '" + CboCodiAuxRegis.SelectedValue + "'," +
                            "ArchivEco = 'False'," +
                            $"FecModi = {Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))} " +
                            "CodModi = '" + UsaRegis + "'" +
                            "WHERE (NumEcogra = N'" + FunConEco + "') ";

                            bool ActControl = Conexion.SQLUpdate(Utils.SqlDatos);

                            Utils.Informa = "Los datos de la ecografía han sido actualizados satisfactoriamente.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information); ;


                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero el sistema ha encontrado la";
                            Utils.Informa += "ecografia No. " + FunConEco + " la cual el número";
                            Utils.Informa += "es distinto a la que usted esta modificando.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        }

                        break;

                    case "11":

                        if (TxtEcoNumForm11.Text == FunConEco)
                        {
                            Utils.SqlDatos = "UPDATE [DACONEXTSQL].[dbo].[Datos registros de ecografias] SET  " +
                            "Numaten = '" + TxtAtenNumEco.Text + "'," +
                            "NumFactu = '" + TxtFactConsul.Text + "'," +
                            "NumHisEco = '" + TxtNumHistoEco.Text + "'," +
                            $"FecRealECO = {Conexion.ValidarFechaNula(DtFecTomaEco11.Value.ToString("yyyy-MM-dd"))} " +
                            "TransFrec = '" + CboTipTranEco11.SelectedValue + "'," +
                            "SeConoFUM  = '" + CboConoceFUM11.SelectedIndex + "'," +
                            $"FUMEco = {Conexion.ValidarFechaNula(DtFUMEco11.Value.ToString("yyyy-MM-dd"))} " +
                            "EdadGesFum  = '" + TxtEdadFum11.Text + "'," +
                            $"FPPFUM = {Conexion.ValidarFechaNula(DtFPPFUM11.Value.ToString("yyyy-MM-dd"))} " +
                            "NumFetos  = '" + TxtNumFetosECO11.Text + "'," +
                            "ConclusECO  = '" + TxtConcluEcos11.Text + "'," +
                            "CodMedECO = '" + CboCodiMedi.SelectedValue + "'," +
                            "CodAuxECO = '" + CboCodiAuxRegis.SelectedValue + "'," +
                            "ArchivEco = 'False'," +
                            $"FecModi = {Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))} " +
                            "CodModi = '" + UsaRegis + "'" +
                            "WHERE (NumEcogra = N'" + FunConEco + "') ";

                            bool ActControl = Conexion.SQLUpdate(Utils.SqlDatos);

                            //Procedemos a agregar la biometria de los fetos

                            NFetos = Convert.ToInt32(TxtNumFetosECO11.Text);
                            NFtol = 1;




                            while (NFetos > 0)
                            {

                                SqlBioFeto = "SELECT NumEcoFeto, FetoNum, Presentacion, Situacion, Posicion, MovCardiacos, TotaPunt, ";
                                SqlBioFeto = SqlBioFeto + "MovRespiratorios, MovFetales, TonoFetal, ILAFeto, CordonUmbi, SexFeto, SacoGesta, ";
                                SqlBioFeto = SqlBioFeto + "VesiVitelina, BotonEmbriona, DBPFeto, LCN, HCFeto, ACFeto, LFFeto, PesoFeto, FCFFeto, ";
                                SqlBioFeto = SqlBioFeto + "PuntajeILA, PuntajeMovFet, PuntajeMovRes, PuntajeTonMusc ";
                                SqlBioFeto = SqlBioFeto + "FROM [DACONEXTSQL].[dbo].[Datos biometria de los fetos] ";
                                SqlBioFeto = SqlBioFeto + "WHERE  NumEcoFeto = '" + FunConEco + "' AND FetoNum = " + NFtol;

                                SqlDataReader TabBioFeto;

                                using (SqlConnection connection = new SqlConnection(Conexion.conexionSQL))
                                {
                                    SqlCommand command = new SqlCommand(SqlBioFeto, connection);
                                    command.Connection.Open();
                                    TabBioFeto = command.ExecuteReader();

                                    if (TabBioFeto.HasRows == false)
                                    {

                                        Utils.SqlDatos = "INSERT [DACONEXTSQL].[dbo].[Datos biometria de los fetos] (NumEcoFeto,FetoNum,FCFFeto,ILAFeto,TotaPunt,MovFetales,MovRespiratorios,TonoFetal,PuntajeILA,PuntajeMovFet,PuntajeMovRes,PuntajeTonMusc) ";
                                        Utils.SqlDatos += "VALUES (@NumEcoFeto,@FetoNum,@FCFFeto,@ILAFeto,@TotaPunt,@MovFetales,@MovRespiratorios,@TonoFetal,@PuntajeILA,@PuntajeMovFet,@PuntajeMovRes,@PuntajeTonMusc)";

                                        switch (NFtol)
                                        {

                                            case 1: //Agrega el primer feto

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                                {
                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = FCF01.Text},
                                                                    new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtILA01.Text},
                                                                    new SqlParameter("@TotaPunt", SqlDbType.VarChar){ Value = TxtTotal01.Text},
                                                                    new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMovFeta01.Text},
                                                                    new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovResp01.Text},
                                                                    new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoMusc01.Text},
                                                                    new SqlParameter("@PuntajeILA", SqlDbType.VarChar){ Value = TxtPuntaILA.Text},
                                                                    new SqlParameter("@PuntajeMovFet", SqlDbType.VarChar){ Value = TxtPuntaMovFet.Text},
                                                                    new SqlParameter("@PuntajeMovRes", SqlDbType.VarChar){ Value = TxtPuntaMovRes.Text},
                                                                    new SqlParameter("@PuntajeTonMusc", SqlDbType.VarChar){ Value = TxtPuntaTonMusc.Text},
                                                                };

                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);


                                                break;
                                            case 2:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                                {
                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = FCF02.Text},
                                                                    new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtILA02.Text},
                                                                    new SqlParameter("@TotaPunt", SqlDbType.VarChar){ Value = TxtTotal02.Text},
                                                                    new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMovFeta02.Text},
                                                                    new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovResp02.Text},
                                                                    new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoMusc02.Text},
                                                                    new SqlParameter("@PuntajeILA", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovFet", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovRes", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeTonMusc", SqlDbType.VarChar){ Value = ""},
                                                                };

                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                break;

                                            case 3:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                                {
                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = FCF03.Text},
                                                                    new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtILA03.Text},
                                                                    new SqlParameter("@TotaPunt", SqlDbType.VarChar){ Value = TxtTotal03.Text},
                                                                    new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMovFeta03.Text},
                                                                    new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovResp03.Text},
                                                                    new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoMusc03.Text},
                                                                    new SqlParameter("@PuntajeILA", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovFet", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovRes", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeTonMusc", SqlDbType.VarChar){ Value = ""},
                                                                };

                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                break;
                                            case 4:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                                {
                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = FCF04.Text},
                                                                    new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtILA04.Text},
                                                                    new SqlParameter("@TotaPunt", SqlDbType.VarChar){ Value = TxtTotal04.Text},
                                                                    new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMovFeta04.Text},
                                                                    new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovResp04.Text},
                                                                    new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoMusc04.Text},
                                                                    new SqlParameter("@PuntajeILA", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovFet", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovRes", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeTonMusc", SqlDbType.VarChar){ Value = ""},
                                                                };

                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                break;
                                            case 5:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                                {
                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = FCF05.Text},
                                                                    new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtILA05.Text},
                                                                    new SqlParameter("@TotaPunt", SqlDbType.VarChar){ Value = TxtTotal05.Text},
                                                                    new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMovFeta05.Text},
                                                                    new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovResp05.Text},
                                                                    new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoMusc05.Text},
                                                                    new SqlParameter("@PuntajeILA", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovFet", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovRes", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeTonMusc", SqlDbType.VarChar){ Value = ""},
                                                                };

                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);


                                                break;
                                            default:
                                                break;
                                        }

                                    }
                                    else
                                    {
                                        //modifique los datos

                                        Utils.SqlDatos = "UPDATE [DACONEXTSQL].[dbo].[Datos biometria de los fetos] SET FCFFeto = @FCFFeto, ILAFeto = @ILAFeto,TotaPunt = @TotaPunt,MovFetales = @MovFetales,MovRespiratorios = @MovRespiratorios,TonoFetal = @TonoFetal,PuntajeILA = @PuntajeILA,PuntajeMovFet = @PuntajeMovFet,PuntajeMovRes = @PuntajeMovRes,PuntajeTonMusc = @PuntajeTonMusc ";
                                        Utils.SqlDatos += "WHERE (NumEcoFeto = @NumEcoFeto AND FetoNum = @FetoNum)";

                                        switch (NFtol)
                                        {

                                            case 1: //Agrega el primer feto

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                                {
                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = FCF01.Text},
                                                                    new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtILA01.Text},
                                                                    new SqlParameter("@TotaPunt", SqlDbType.VarChar){ Value = TxtTotal01.Text},
                                                                    new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMovFeta01.Text},
                                                                    new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovResp01.Text},
                                                                    new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoMusc01.Text},
                                                                    new SqlParameter("@PuntajeILA", SqlDbType.VarChar){ Value = TxtPuntaILA.Text},
                                                                    new SqlParameter("@PuntajeMovFet", SqlDbType.VarChar){ Value = TxtPuntaMovFet.Text},
                                                                    new SqlParameter("@PuntajeMovRes", SqlDbType.VarChar){ Value = TxtPuntaMovRes.Text},
                                                                    new SqlParameter("@PuntajeTonMusc", SqlDbType.VarChar){ Value = TxtPuntaTonMusc.Text},
                                                                };

                                                Insert = Conexion.SQLUpdate(Utils.SqlDatos, parameters);


                                                break;
                                            case 2:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                                {
                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = FCF02.Text},
                                                                    new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtILA02.Text},
                                                                    new SqlParameter("@TotaPunt", SqlDbType.VarChar){ Value = TxtTotal02.Text},
                                                                    new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMovFeta02.Text},
                                                                    new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovResp02.Text},
                                                                    new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoMusc02.Text},
                                                                    new SqlParameter("@PuntajeILA", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovFet", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovRes", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeTonMusc", SqlDbType.VarChar){ Value = ""},
                                                                };

                                                Insert = Conexion.SQLUpdate(Utils.SqlDatos, parameters);

                                                break;

                                            case 3:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                                {
                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = FCF03.Text},
                                                                    new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtILA03.Text},
                                                                    new SqlParameter("@TotaPunt", SqlDbType.VarChar){ Value = TxtTotal03.Text},
                                                                    new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMovFeta03.Text},
                                                                    new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovResp03.Text},
                                                                    new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoMusc03.Text},
                                                                    new SqlParameter("@PuntajeILA", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovFet", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovRes", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeTonMusc", SqlDbType.VarChar){ Value = ""},
                                                                };

                                                Insert = Conexion.SQLUpdate(Utils.SqlDatos, parameters);

                                                break;
                                            case 4:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                                {
                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = FCF04.Text},
                                                                    new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtILA04.Text},
                                                                    new SqlParameter("@TotaPunt", SqlDbType.VarChar){ Value = TxtTotal04.Text},
                                                                    new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMovFeta04.Text},
                                                                    new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovResp04.Text},
                                                                    new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoMusc04.Text},
                                                                    new SqlParameter("@PuntajeILA", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovFet", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovRes", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeTonMusc", SqlDbType.VarChar){ Value = ""},


                                                                };

                                                Insert = Conexion.SQLUpdate(Utils.SqlDatos, parameters);

                                                break;
                                            case 5:

                                                parameters = null;

                                                parameters = new List<SqlParameter>
                                                                {
                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = FCF05.Text},
                                                                    new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtILA05.Text},
                                                                    new SqlParameter("@TotaPunt", SqlDbType.VarChar){ Value = TxtTotal05.Text},
                                                                    new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMovFeta05.Text},
                                                                    new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovResp05.Text},
                                                                    new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoMusc05.Text},
                                                                    new SqlParameter("@PuntajeILA", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovFet", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovRes", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeTonMusc", SqlDbType.VarChar){ Value = ""},
                                                                };

                                                Insert = Conexion.SQLUpdate(Utils.SqlDatos, parameters);


                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                }

                                TabBioFeto.Close();

                                NFtol += 1;
                                NFetos -= 1;

                            }//While

                            Utils.Informa = "Los datos de la ecografía han sido actualizados satisfactoriamente.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero el sistema ha encontrado la";
                            Utils.Informa += "ecografia No. " + FunConEco + " la cual el número";
                            Utils.Informa += "es distinto a la que usted esta modificando.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        }

                        break;


                    case "13":

                        if (TxtEcoNumForm13.Text == FunConEco)
                        {
                            Utils.SqlDatos = "UPDATE [DACONEXTSQL].[dbo].[Datos registros de ecografias] SET  " +
                            "Numaten = '" + TxtAtenNumEco.Text + "'," +
                            "NumFactu = '" + TxtFactConsul.Text + "'," +
                            "NumHisEco = '" + TxtNumHistoEco.Text + "'," +
                            $"FecRealECO = {Conexion.ValidarFechaNula(DtFecTomaEco13.Value.ToString("yyyy-MM-dd"))} " +
                            "TransFrec = '" + CboTipTranEco13.SelectedValue + "'," +
                            "SeConoFUM  = '" + CboConoceFUM13.SelectedIndex + "'," +
                            $"FUMEco = {Conexion.ValidarFechaNula(DtFUMEco13.Value.ToString("yyyy-MM-dd"))} " +
                            "EdadGesFum  = '" + TxtEdadFum13.Text + "'," +
                            $"FPPFUM = {Conexion.ValidarFechaNula(DtFPPFUM13.Value.ToString("yyyy-MM-dd"))} " +
                            "Utero  = '" + TxtDesUteroEco13.Text + "'," +
                            "DiamLongi  = '" + TxtDiameLongi13.Text + "'," +
                            "EspesorCer  = '" + TxtEspeCervix13.Text + "'," +
                            "DesCervix  = '" + TxtDesCervixEco13.Text + "'," +
                            "ConclusECO  = '" + TxtConcluEcos13.Text + "'," +
                            "CodMedECO = '" + CboCodiMedi.SelectedValue + "'," +
                            "CodAuxECO = '" + CboCodiAuxRegis.SelectedValue + "'," +
                            "ArchivEco = 'False'," +
                            $"FecModi = {Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))} " +
                            "CodModi = '" + UsaRegis + "'" +
                            "WHERE (NumEcogra = N'" + FunConEco + "') ";

                            bool ActControl = Conexion.SQLUpdate(Utils.SqlDatos);

                            Utils.Informa = "Los datos de la ecografía han sido actualizados satisfactoriamente.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information); ;


                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero el sistema ha encontrado la";
                            Utils.Informa += "ecografia No. " + FunConEco + " la cual el número";
                            Utils.Informa += "es distinto a la que usted esta modificando.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        }


                        break;

                    case "14":


                        if (TxtEcoNumForm14.Text == FunConEco)
                        {

                            Utils.SqlDatos = "UPDATE [DACONEXTSQL].[dbo].[Datos registros de ecografias] SET  " +
                            "Numaten = '" + TxtAtenNumEco.Text + "'," +
                            "NumFactu = '" + TxtFactConsul.Text + "'," +
                            "NumHisEco = '" + TxtNumHistoEco.Text + "'," +
                            $"FecRealECO = {Conexion.ValidarFechaNula(DtFecTomaEco14.Value.ToString("yyyy-MM-dd"))} " +
                            "TransFrec = '" + CboTipTranEco14.SelectedValue + "'," +
                            "SeConoFUM  = '" + CboConoceFUM14.SelectedIndex + "'," +

                            "ProstataEco = '" + TxtProstaEco14.Text + "'," +
                            "VesicuSemiEco  = '" + TxtVesiSeminal14.Text + "'," +
                            "AspecVeji = '" + TxtVejigaEco14.Text + "'," +
                            "ConclusECO  = '" + TxtComentario14.Text + "'," +

                            "CodMedECO = '" + CboCodiMedi.SelectedValue + "'," +
                            "CodAuxECO = '" + CboCodiAuxRegis.SelectedValue + "'," +
                            "ArchivEco = 'False'," +
                            $"FecModi = {Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))} " +
                            "CodModi = '" + UsaRegis + "'" +
                            "WHERE (NumEcogra = N'" + FunConEco + "') ";

                            bool ActControl = Conexion.SQLUpdate(Utils.SqlDatos);

                            Utils.Informa = "Los datos de la ecografía han sido actualizados satisfactoriamente.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information); ;


                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero el sistema ha encontrado la";
                            Utils.Informa += "ecografia No. " + FunConEco + " la cual el número";
                            Utils.Informa += "es distinto a la que usted esta modificando.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        }

                        break;

                    case string estado when estado == "15" || estado == "16":

                        if (TxtEcoNumForm15.Text == FunConEco)
                        {

                            Utils.SqlDatos = "UPDATE [DACONEXTSQL].[dbo].[Datos registros de ecografias] SET  " +
                            "Numaten = '" + TxtAtenNumEco.Text + "'," +
                            "NumFactu = '" + TxtFactConsul.Text + "'," +
                            "NumHisEco = '" + TxtNumHistoEco.Text + "'," +
                            $"FecRealECO = {Conexion.ValidarFechaNula(DtFecTomaEco15.Value.ToString("yyyy-MM-dd"))} " +
                            "TransFrec = '" + CboTipTranEco15.SelectedValue + "'," +
                            "SeConoFUM  = '" + CboConoceFUM15.SelectedIndex + "'," +
                            "RegisEcoGral = '" + TxtEcoGeneral15.Text + "'," +
                            "ConclusECO  = '" + TxtComentario15.Text + "'," +
                            "CodMedECO = '" + CboCodiMedi.SelectedValue + "'," +
                            "CodAuxECO = '" + CboCodiAuxRegis.SelectedValue + "'," +
                            "ArchivEco = 'False'," +
                            $"FecModi = {Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))} " +
                            "CodModi = '" + UsaRegis + "'" +
                            "WHERE (NumEcogra = N'" + FunConEco + "') ";

                            bool ActControl = Conexion.SQLUpdate(Utils.SqlDatos);

                            Utils.Informa = "Los datos de la ecografía han sido actualizados satisfactoriamente.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information); ;


                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero el sistema ha encontrado la";
                            Utils.Informa += "ecografia No. " + FunConEco + " la cual el número";
                            Utils.Informa += "es distinto a la que usted esta modificando.";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
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
                Utils.Informa += "al dar click en el boton guardar" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        private void ActualizarCita(string HisEcoCita, double NumCitaEco, string CodColEco)
        {
            try
            {

                string SqlCitasProgra = "SELECT [Datos de citas programadas].ConsecutivoCita, [Datos de citas programadas].CodiMedico, ";
                SqlCitasProgra += "[Datos de citas programadas].NoFactura, [Datos de citas programadas].HistoriaCita, ";
                SqlCitasProgra += "[Datos de citas programadas].ColorCita, [Datos de citas programadas].Confirmada ";
                SqlCitasProgra += "FROM [DACITASXPSQL].[dbo].[Datos de citas programadas] ";
                SqlCitasProgra += "WHERE ((([Datos de citas programadas].ConsecutivoCita) = " + NumCitaEco + ") And ";
                SqlCitasProgra += "(([Datos de citas programadas].HistoriaCita) = N'" + HisEcoCita + "'))";

                SqlDataReader TabCitasProgra;

                using (SqlConnection connection = new SqlConnection(Conexion.conexionSQL))
                {
                    SqlCommand sqlCommand = new SqlCommand(SqlCitasProgra, connection);
                    sqlCommand.Connection.Open();
                    TabCitasProgra = sqlCommand.ExecuteReader();

                    if (TabCitasProgra.HasRows)
                    {
                        Utils.SqlDatos = "UPDATE [DACITASXPSQL].[dbo].[Datos de citas programadas] SET Confirmada = 'True', ColorCita = '" + CodColEco + "' WHERE [Datos de citas programadas].ConsecutivoCita = " + NumCitaEco + " ";

                        bool act = Conexion.SQLUpdate(Utils.SqlDatos);

                    }

                }

                TabCitasProgra.Close();

            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "en el procedimiento local ActualizarCita." + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ConsecutivoDocumen(string CodDocu, bool ActConse, string CodUsua)
        {
            try
            {
                //Permite buscar el consecutivo del documento deseado

                string SqlConsecu, CodFormado = "", PreDoc, ConTomado;
                DateTime FechaUltima;
                int SigPro = 0, TCG = 0, TCGPf = 0;
                int ConsecActual;
                string Formato;

                SqlConsecu = "SELECT  CodConse, PrefiConse, ConseDocu, UlltiConseDoc, CodUsaConse, ";
                SqlConsecu = SqlConsecu + "ConseCrono, FecConseDoc, CanDigConse, NomDocuConse, CodRegis, FecRegis ";
                SqlConsecu = SqlConsecu + "FROM [BDADMINSIG].[dbo].[Datos consecutivos SIIGHOSPLUS] ";
                SqlConsecu = SqlConsecu + "WHERE CodConse = '" + CodDocu + "' ";


                SqlDataReader TabConsecu;

                using (SqlConnection connection = new SqlConnection(Conexion.conexionSQL))
                {
                    SqlCommand command = new SqlCommand(SqlConsecu, connection);
                    command.Connection.Open();
                    TabConsecu = command.ExecuteReader();

                    if (TabConsecu.HasRows == false)
                    {
                        //NO se encontró el registro de consecutivo para este documento
                        CodFormado = "0";
                    }
                    else
                    {
                        TabConsecu.Read();
                        //Revisamos si el documento es obligatorio que sea cronologíco

                        if (Convert.ToBoolean(TabConsecu["ConseCrono"]) == true)
                        {
                            //Es obligatorio la fecha cronologica
                            FechaUltima = Convert.ToDateTime(TabConsecu["FecConseDoc"]);
                            //Revisemos que esta no sea mayor a la del sistema

                            if (FechaUltima > DateTime.Now.Date)
                            {
                                CodFormado = "-1";
                                SigPro = 0;
                            }
                            else
                            {
                                SigPro = 1;
                            }//Final de FechaUltima > Date
                        }
                        else
                        {
                            SigPro = 1;
                        }//'Final de TabConsecu![ConseCrono] = True
                    }

                    if (SigPro == 1)
                    {
                        //Revisamos si existe un consecutivo por reasignar o perdido

                        if (Convert.ToInt32(TabConsecu["UlltiConseDoc"]) == 0)
                        {
                            //No existen comprobantes perdidos, debe generar el siguiente
                            ConsecActual = Convert.ToInt32(TabConsecu["ConseDocu"]);
                            ConsecActual += 1;
                            //Procedemos a actualizar el consecutivo, si la función viene positiva

                            if (ActConse == true)
                            {
                                string UpdateConce = "UPDATE  [BDADMINSIG].[dbo].[Datos consecutivos SIIGHOSPLUS] SET ConseDocu = '" + ConsecActual + "', CodUsaConse = '" + CodUsua + "', FecConseDoc = CONVERT(DATETIME,'" + DateTime.Now.ToString("yyyy-MM-dd") + "',102) WHERE CodConse = '" + CodDocu + "'";

                                bool update = Conexion.SQLUpdate(UpdateConce);

                                //Procedemos a actualizar el consecutivo, si la función viene positiva

                            } //Final de ActConse = True

                        }
                        else
                        {
                            //Existe un consecutivo perdido

                            ConsecActual = Convert.ToInt32(TabConsecu["UlltiConseDoc"]);

                            if (ActConse)
                            {
                                string UpdateConce = "UPDATE  [BDADMINSIG].[dbo].[Datos consecutivos SIIGHOSPLUS] SET " +
                                "UlltiConseDoc = 0 " +
                                "WHERE CodConse = '" + CodDocu + "'";

                                bool update = Conexion.SQLUpdate(UpdateConce);
                            }
                            //Voy Aqui            
                        }

                        //Tomamos el tamaño del código a generar


                        TCG = Convert.ToInt32(TabConsecu["CanDigConse"]);

                        //Revisamos si el consecutivo lleva prefijo

                        PreDoc = TabConsecu["PrefiConse"].ToString();
                        ConTomado = ConsecActual.ToString();

                        if (PreDoc == "00")
                        {
                            //No lleva prefijo
                            if (TCG < ConTomado.Length)
                            {
                                //'NO se pueden generar más código, porqu llego al limite
                                CodFormado = "-3";
                            }
                            else
                            {

                                Formato = "D" + TCG;

                                CodFormado = ConsecActual.ToString(Formato);


                            }
                        }
                        else
                        {
                            //LLeva prefijo, al tamanó real se le el tamño del prefijo

                            TCGPf = TCG - PreDoc.Length;

                            if (TCGPf < ConTomado.Length)
                            {
                                //NO se pueden generar más código, porqu llego al limite
                                CodFormado = "-3";
                            }
                            else
                            {

                                Formato = "D" + TCG;

                                CodFormado = PreDoc + ConsecActual.ToString(Formato); //Agregue cuantos ceros falten a la izquierda para completar el tamaño

                            }
                        }//Final de PreDoc = "00"
                    }//Fin SigPro = 1
                }

                TabConsecu.Close();

                return CodFormado;


            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "en la función: ConsecutivoDocumen del" + "\r";
                Utils.Informa += "Módulo variables de la aplicación" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "-1";
            }
        }
        private void MosEcosSinArchivar()
        {
            try
            {


                GridLisEcosSinArchivar.Rows.Clear();

                string SqlUsuarios = "SELECT ([Datos registros de ecografias].NumHisEco) as NumHisEco," +
                " RTrim(ACDATOXPSQL.dbo.[Datos del Paciente].[Nombre1] + ' ' + Isnull(ACDATOXPSQL.dbo.[Datos del Paciente].[Nombre2], '')) + ' ' + RTrim(ACDATOXPSQL.dbo.[Datos del Paciente].[Apellido1] + ' ' + IsNull(ACDATOXPSQL.dbo.[Datos del Paciente].[Apellido2], '')) AS Paciente ";
                SqlUsuarios += "FROM [DACONEXTSQL].[dbo].[Datos registros de ecografias] ";
                SqlUsuarios +=   "INNER JOIN ACDATOXPSQL.dbo.[Datos del Paciente] ON [DACONEXTSQL].[dbo].[Datos registros de ecografias].NumHisEco = ACDATOXPSQL.dbo.[Datos del Paciente].HistorPaci ";
                SqlUsuarios += "WHERE  ([Datos registros de ecografias].ArchivEco = 'False') ";
                SqlUsuarios += "ORDER BY ACDATOXPSQL.dbo.[Datos del Paciente].Nombre1, ACDATOXPSQL.dbo.[Datos del Paciente].Nombre2, ACDATOXPSQL.dbo.[Datos del Paciente].Apellido1, ACDATOXPSQL.dbo.[Datos del Paciente].Apellido2";


                //DataSet sqlDataSet = Conexion.SQLDataSet(SqlUsuarios);

                SqlDataReader sqlDataReader = Conexion.SQLDataReader(SqlUsuarios);


                //if (sqlDataSet.Tables.Count > 0)
                //{
                //    GridLisEcosSinArchivar.DataSource = sqlDataSet.Tables[0];
                //}


                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        GridLisEcosSinArchivar.Rows.Add(sqlDataReader["NumHisEco"].ToString(), sqlDataReader["Paciente"].ToString());
                    }
                }

                if (Conexion.sqlConnection.State == ConnectionState.Open) Conexion.sqlConnection.Close();


            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "en la funcion MosEcosSinArchivar" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void CargarTipoExo()
        {
            try
            {

                TxtCodCupEco.Clear();
                TxtNomCupsEco.Clear();
                
                string CPs;

                Utils.SqlDatos = "SELECT CodEcoIps, NomEcogra, CodFacEco, SexApli FROM [DACONEXTSQL].[dbo].[Datos tipos de ecografias] WHERE RealizIPS = 'True' AND  CodEcoIps = '" + CboTipoEcoReal.SelectedValue.ToString() + "'";


                SqlDataReader TipoEcoReal = Conexion.SQLDataReader(Utils.SqlDatos);


                if (TipoEcoReal.HasRows == false)
                {
                    TxtCodCupEco.Clear();
                    TxtNomCupsEco.Clear();
                }
                else
                {
                    TipoEcoReal.Read();

                    TxtCodCupEco.Text = TipoEcoReal["CodFacEco"].ToString();

                    CPs = TipoEcoReal["CodFacEco"].ToString();

                    if (CPs == "0")
                    {
                        TxtNomCupsEco.Clear();
                    }
                    else
                    {
                        //Buscamos el nombre del procedimiento NomEcoCUPS
                        TxtNomCupsEco.Text = NomEcoCUPS(CPs);
                    }

                }

                TipoEcoReal.Close();
                Conexion.sqlConnection.Close();

            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "en la funcion CargarTipoExo" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CargarComboBox()
        {
            try
            {
                //Agregamos primeramente los combos, abriendo las instancias que se pueden cerrar inmediatament


                this.CboTipoDocEco.DataSource = null;
                this.CboEspecialidad1.DataSource = null;
                this.CboTipoEcoReal.DataSource = null;

                string ParEspe = "";

                Utils.SqlDatos = "SELECT CodIdenti, NomIdenti FROM [ACDATOXPSQL].[dbo].[Datos documentos usuarios]";

                DataSet dataSet = Conexion.SQLDataSet(Utils.SqlDatos);

                if (dataSet != null && dataSet.Tables.Count > 0)
                {
                    this.CboTipoDocEco.DataSource = dataSet.Tables[0];
                    this.CboTipoDocEco.ValueMember = "CodIdenti";
                    this.CboTipoDocEco.DisplayMember = "NomIdenti";
                }


                Utils.SqlDatos = "SELECT CodiEspecial, NomEspecial FROM [GEOGRAXPSQL].[dbo].[Datos de las especialidades] WHERE ActivEspe = 1 ORDER BY NomEspecial";

                DataSet dataSet2 = Conexion.SQLDataSet(Utils.SqlDatos);

                if (dataSet2 != null && dataSet2.Tables.Count > 0)
                {
                    this.CboEspecialidad1.DataSource = dataSet2.Tables[0];
                    this.CboEspecialidad1.ValueMember = "CodiEspecial";
                    this.CboEspecialidad1.DisplayMember = "NomEspecial";
                }
                else
                {
                    ParEspe = "0";
                }
                //'Mostrar el combo de los médicos



                if (string.IsNullOrWhiteSpace(ParEspe))
                {
                    ParEspe = "0";
                }
                else
                {
                    ParEspe = CboEspecialidad1.SelectedValue.ToString();
                }

                CargaEcografiaObstetrica();

                ComboMedicos(ParEspe);

                ComboRegis();

                //'Cargamos los tipos de ecografias

                Utils.SqlDatos = "SELECT CodEcoIps, NomEcogra, CodFacEco, SexApli FROM [DACONEXTSQL].[dbo].[Datos tipos de ecografias] WHERE RealizIPS = 1 ORDER BY NomEcogra";

                DataSet dataSet3 = Conexion.SQLDataSet(Utils.SqlDatos);

                if (dataSet3 != null && dataSet3.Tables.Count > 0)
                {
                    this.CboTipoEcoReal.DataSource = dataSet3.Tables[0];
                    this.CboTipoEcoReal.ValueMember = "CodEcoIps";
                    this.CboTipoEcoReal.DisplayMember = "NomEcogra";
                }

                CargarTipoExo();

                MosEcosSinArchivar();

            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "en la funcion que carga los Combobox" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private string NomEcoCUPS(string Cbus)
        {
            try
            {

                string SqlCataServi = "SELECT CodInterno, NomServicio, Finalidad, CenCosto, CodiSOAT, CodiISS, CodiCUPS, ";
                SqlCataServi = SqlCataServi + "ValorCUPS, HabilPro, SexAplica, NivelActi, PrograPyP ";
                SqlCataServi = SqlCataServi + "FROM [ACDATOXPSQL].[dbo].[Datos catalogo de servicios] ";
                SqlCataServi = SqlCataServi + "WHERE (CodiCUPS = N'" + Cbus + "')";

                string result = "";

                SqlDataReader TabCataServi = Conexion.SQLDataReader(SqlCataServi);

                if (TabCataServi.HasRows == false)
                {
                    result = "Código CUPS no catalogado";
                }
                else
                {
                    TabCataServi.Read();
                    result = TabCataServi["NomServicio"].ToString();
                }

                Conexion.sqlConnection.Close();

                return result;

            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "en la función local NomEcoCUPS()" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Código CUPS no catalogado";
            }
        }
        private void ComboMedicos(string ParEspe)
        {
            try
            {


                this.CboCodiMedi.DataSource = null;
                this.CboCodiMedi.DataSource = null;


                Utils.SqlDatos = "SELECT CodiMedico, (Apellido1Medico + ' ' + IsNull(Apellido2Medico, '') + ' ' + NomMedico) AS Medico FROM [GEOGRAXPSQL].[dbo].[Datos de los medicos] ";
                Utils.SqlDatos += "WHERE CodEspecial = '" + ParEspe + "' AND ActiMedico = 1 ORDER BY Apellido1Medico, Apellido2Medico, NomMedico";

                DataSet dataSet = Conexion.SQLDataSet(Utils.SqlDatos);

                if (dataSet != null && dataSet.Tables.Count > 0)
                {
                    this.CboCodiMedi.DataSource = dataSet.Tables[0];
                    this.CboCodiMedi.ValueMember = "CodiMedico";
                    this.CboCodiMedi.DisplayMember = "Medico";
                }

            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "al cargar el combo ComboMedicos" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ComboRegis()
        {
            try
            {

                this.CboCodiAuxRegis.DataSource = null;
                this.CboCodiAuxRegis.DataSource = null;
                //string ParEspe;

                Utils.SqlDatos = "SELECT CodiMedico, (Apellido1Medico + ' ' + IsNull(Apellido2Medico, '') + ' ' + NomMedico) AS Medico FROM [GEOGRAXPSQL].[dbo].[Datos de los medicos] ";
                Utils.SqlDatos += "WHERE ActiMedico = 1 ORDER BY Apellido1Medico, Apellido2Medico, NomMedico";


                DataSet dataSet = Conexion.SQLDataSet(Utils.SqlDatos);

                if (dataSet != null && dataSet.Tables.Count > 0)
                {
                    this.CboCodiAuxRegis.DataSource = dataSet.Tables[0];
                    this.CboCodiAuxRegis.ValueMember = "CodiMedico";
                    this.CboCodiAuxRegis.DisplayMember = "Medico";
                }


            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "al cargar el combo ComboRegis" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    lblCodigoUser.Text = Utils.codUsuario;
                    lblNombreUser.Text = Utils.nomUsuario;
                    lblNivelPermitido.Text = Utils.nivelPermiso;

                    int level = Convert.ToInt32(lblNivelPermitido.Text);

                    switch (level)
                    {
                        case 1: //Administrador
                            Utils.Titulo01 = "Control de permisos";
                            Utils.Informa = "Lo siento pero usted no tiene suficientes privilegios" + "\r";
                            Utils.Informa += "para ingresar al formulario de atención no formal." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                            break;
                        case int levelS when level >= 2 && level <= 4: //Supervisor

                            Utils.Titulo01 = "Control de permisos";
                            Utils.Informa = "Lo siento pero usted no tiene suficientes privilegios" + "\r";
                            Utils.Informa += "para ingresar al formulario de atención de consultas." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                            break;
                        case int levelS when level >= 5 && level <= 6: //Profesional I y profesional II
                            //Aqui deberia validar la especialidad y demás

                            if (Utils.CodEspecialidad == "0" || Utils.CodigoMedico == "0" || Utils.CodEspecialidad == "000" || Utils.CodigoMedico == "000")
                            {
                                Utils.Titulo01 = "Control de permisos";
                                Utils.Informa = "Lo siento pero la especialidad o código del médico" + "\r";
                                Utils.Informa += "no se encuentra definida, por lo tanto no se puede" + "\r";
                                Utils.Informa += "abrir el formulario, por favor comuniquese con el" + "\r";
                                Utils.Informa += "administrador del sistema o ingrese de nuevo." + "\r";
                                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                            else
                            {

                                CboEspecialidad1.SelectedValue = Utils.CodEspecialidad;

                                CboCodiMedi.SelectedValue = Utils.CodigoMedico;

                            }

                            break;

                        case int levelS when level >= 7 && level <= 8: //Tecnico y 'Consultor
                            Utils.Titulo01 = "Control de permisos";
                            Utils.Informa = "Lo siento pero usted no tiene suficientes privilegios" + "\r";
                            Utils.Informa += "para ingresar al formulario de atención de consultas." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                            break;
                        default:
                            Utils.Titulo01 = "Control de permisos";
                            Utils.Informa = "Lo siento pero usted no tiene suficientes privilegios" + "\r";
                            Utils.Informa += "para ingresar al formulario de atención de consultas." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                            break;
                    }
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
        private void CargaCitasProgramadas()
        {
            try
            {

                GridLisEcosSinArchivar.DataSource = null;
                GridCitasProgramadas.DataSource = null;


                string Date = DateTime.Now.ToString("yyyy-MM-dd");



                //string SqlCitas = " SELECT [Datos de los colores en citas].Color, [Datos de citas programadas].ConsecutivoCita, [Datos de citas programadas].HoraAsignacion, [Datos del Paciente].[Nombre1] + ' ' + [Datos del Paciente].[Nombre2] + ' ' + [Datos del Paciente].[Apellido1] + ' ' + [Datos del Paciente].[Apellido2] AS Nombre," +
                //                    " [Datos de citas programadas].CodiMedico, [Datos de citas programadas].NoFactura, [Datos de los programas citas].DescripcionProg, [Datos de citas programadas].HistoriaCita" +
                //                    " FROM ([DACITASXPSQL].[dbo].[Datos de los colores en citas] INNER JOIN([DACITASXPSQL].[dbo].[Datos de citas programadas] LEFT JOIN [ACDATOXPSQL].[dbo].[Datos del Paciente] ON[Datos de citas programadas].HistoriaCita = [Datos del Paciente].HistorPaci)" +
                //                    " ON [Datos de los colores en citas].CodColor = [Datos de citas programadas].ColorCita) LEFT JOIN[DACITASXPSQL].[dbo].[Datos de los programas citas] ON [Datos de citas programadas].Programa = [Datos de los programas citas].CodigoProg";
                //SqlCitas += " WHERE [Datos de citas programadas].FechaCita = CONVERT(DATETIME, '" + Convert.ToDateTime(Date).ToString("yyyy-MM-dd") + "', 102) ORDER BY [Datos de citas programadas].ConsecutivoCita";


                string SqlCitas = " SELECT TOP(200) [Datos de citas programadas].ColorCita, [Datos de los colores en citas].CodigoVBcolor, [Datos de los colores en citas].Color, " +
                "[Datos de los colores en citas].NombreColor," +
                "[Datos de citas programadas].ConsecutivoCita, [Datos de citas programadas].HoraAsignacion, " +
                "[Datos del Paciente].[Nombre1] + ' ' + [Datos del Paciente].[Nombre2] + ' ' + [Datos del Paciente].[Apellido1] + ' ' + [Datos del Paciente].[Apellido2] AS Nombre," +
                " [Datos de citas programadas].CodiMedico, [Datos de citas programadas].NoFactura, [Datos de los programas citas].DescripcionProg,  [Datos de citas programadas].HistoriaCita" +
                " FROM ([DACITASXPSQL].[dbo].[Datos de los colores en citas] INNER JOIN ([DACITASXPSQL].[dbo].[Datos de citas programadas] LEFT JOIN [ACDATOXPSQL].[dbo].[Datos del Paciente] " +
                " ON [Datos de citas programadas].HistoriaCita = [Datos del Paciente].HistorPaci) ON [Datos de los colores en citas].CodColor = [Datos de citas programadas].ColorCita) " +
                " LEFT JOIN [DACITASXPSQL].[dbo].[Datos de los programas citas] ON[Datos de citas programadas].Programa = [Datos de los programas citas].CodigoProg " +
                " WHERE [Datos de citas programadas].FechaCita = CONVERT(DATETIME, '" + Convert.ToDateTime(Date).ToString("yyyy-MM-dd") + "', 102) " +
                //" WHERE [Datos de citas programadas].FechaCita > '2020-08-01'" +
                "ORDER BY [Datos de citas programadas].ConsecutivoCita";


                SqlDataReader sqlDataReader = Conexion.SQLDataReader(SqlCitas);



                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {

                        string strMensaje = "" + sqlDataReader["Nombre"].ToString() + " \n" + sqlDataReader["DescripcionProg"].ToString();

                        GridCitasProgramadas.Rows.Add(sqlDataReader["HoraAsignacion"], strMensaje, sqlDataReader["HistoriaCita"].ToString(), 
                        sqlDataReader["NoFactura"].ToString(), sqlDataReader["ConsecutivoCita"].ToString(), sqlDataReader["DescripcionProg"].ToString(),
                        sqlDataReader["ColorCita"].ToString(), sqlDataReader["NombreColor"].ToString());

                    }
                }

                sqlDataReader.Close();
                sqlDataReader = null;

                if (Conexion.sqlConnection.State == ConnectionState.Open) Conexion.sqlConnection.Close();


                foreach (DataGridViewRow row in GridCitasProgramadas.Rows)
                {

                    string EstadoCita = row.Cells["colorCita"].Value.ToString();

                    string ColorBase = row.Cells["NombreColor"].Value.ToString();

                    row.DefaultCellStyle.BackColor = Color.FromName(ColorBase);

                    switch (EstadoCita)
                    {
                        case "007":

                            row.DefaultCellStyle.ForeColor = Color.Black;

                            break;
                        case "006":

                            row.DefaultCellStyle.ForeColor = Color.Black;

                            break;

                        case "005":

                            row.DefaultCellStyle.ForeColor = Color.Black;

                            break;
                        case "004":

                            row.DefaultCellStyle.ForeColor = Color.White;

                            break;
                        case "003":

                            row.DefaultCellStyle.ForeColor = Color.Black;

                            break;
                        case "002":

                            row.DefaultCellStyle.ForeColor = Color.White;

                            break;
                        case "001":

                            row.DefaultCellStyle.ForeColor = Color.White;

                            break;

                        default:

                            break;
                    }

                }


            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "en la funcion CargaCitasProgramadas" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarDatos(string HisBus)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(HisBus) == false)
                {

                    string T = "", M = "";
                    DateTime FecNaceUs;


                    Utils.Titulo01 = "Control busqueda de usuarios";



                    string US = lblCodigoUser.Text;

                    CboTipoDocEco.SelectedIndex = 0;
                    TxtNumDocSinAten.Clear();
                    TxtEdadActualSinAten.Clear();
                    FtFecNacidoSinAten.Value = DateTime.Now;
                    TxtSexoSinAten.Clear();
                    TxtNomUsaSin.Clear();

                    TabControlEcograficas.SelectedIndex = 0;

                    TxtNumHistoEco.Text = HisBus;



                    if (CboTipoEcoReal.SelectedIndex == -1 || string.IsNullOrWhiteSpace(CboTipoEcoReal.Text))
                    {
                        TxtCodCupEco.Clear();
                        TxtNomCupsEco.Clear();
                        T = "00";
                    }
                    else
                    {
                        T = CboTipoEcoReal.SelectedValue.ToString();

                        CargarTipoExo();

                    }

                    cargarTabSeleccionado(T);//Cargar Pestaña seleccionada

                    //Proceda a buscar el paciente en la base de datos

                    string ConsulPaci = "SELECT * FROM [ACDATOXPSQL].[dbo].[Datos del Paciente] WHERE HistorPaci= '" + HisBus + "'";
                    ConsulPaci = ConsulPaci + " ORDER BY [Datos del Paciente].HistorPaci;";

                    SqlDataReader TabPaci = Conexion.SQLDataReader(ConsulPaci);

                    if (TabPaci.HasRows == false)
                    {
                        Utils.Informa = "Lo siento pero el número de historia digitado no se" + "\r";
                        Utils.Informa += "encuentra registrado en este sistema, por lo tanto no" + "\r";
                        Utils.Informa += "se puede registrar los datos de la ecografía." + "\r";
                        MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        TabPaci.Read();

                        //Muestre los datos del usuario
                        CboTipoDocEco.SelectedValue = Convert.ToString(TabPaci["TipoIden"]);
                        TxtNumDocSinAten.Text = TabPaci["NumIden"].ToString();
                        FtFecNacidoSinAten.Value = Convert.ToDateTime(TabPaci["FechaNaci"].ToString());
                        FecNaceUs = Convert.ToDateTime(TabPaci["FechaNaci"].ToString());

                        DateTime date = DateTime.Now;

                        TxtEdadActualSinAten.Text = Utils.EdadAtencion(date, FecNaceUs);
                        TxtSexoSinAten.Text = TabPaci["Sexo"].ToString();
                        TxtNomUsaSin.Text = TabPaci["Nombre1"].ToString() + " " + TabPaci["Nombre2"].ToString() + " " + TabPaci["Apellido1"].ToString() + " " + TabPaci["Apellido2"].ToString();

                        //Como encontró al paciente

                        //Revisamos si seleccionó un profesional

                        if (CboCodiMedi.SelectedIndex == -1)
                        {
                            return;
                        }
                        else
                        {
                            //Buscamos en la base de datos
                            M = CboCodiMedi.SelectedValue.ToString();
                        }


                        MostraEcografias(T, HisBus, M);

                    }

                    if (Conexion.sqlConnection.State == ConnectionState.Open) Conexion.sqlConnection.Close();


                }
            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "en la funcion CargarDatos" + "\r";
                Utils.Informa += "Mensaje del error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostraEcografias(string T, string H, string M)
        {
            try
            {

                string UsaRegis, FunConEco, CodConseD;
                int NFetos = 0, NFtol;
                DateTime dateNUll = new DateTime(1900, 1, 1); 

                Utils.Titulo01 = "Control para mostrar datos";


                //Si se tiene definido un tipo ecografias seleccionado, proceda a cargar el respectivo formulario, para dejar en blanco
                //'Revisamos si el usuario tiene abierta una ecografía o no


                string SqlRegEco = "SELECT * ";
                SqlRegEco = SqlRegEco + "FROM [DACONEXTSQL].[dbo].[Datos registros de ecografias] ";
                //SqlRegEco = SqlRegEco & "Where TipoEco = '" & T & "' and NumHisEco = '" & H & "' and "
                SqlRegEco = SqlRegEco + "Where NumHisEco = '" + H + "' and ";
                SqlRegEco = SqlRegEco + "CodMedECO = '" + M + "' and ArchivEco = 'False' and AnulEco = 'False'";

                SqlDataReader TabRegEco;

                using (SqlConnection connection = new SqlConnection(Conexion.conexionSQL))
                {
                    SqlCommand command = new SqlCommand(SqlRegEco, connection);
                    command.Connection.Open();
                    TabRegEco = command.ExecuteReader();

                    if (TabRegEco.HasRows == false)
                    {
                        //No tiene ecografias abiertas para el medico actual
                    }
                    else
                    {
                        TabRegEco.Read();

                        FunConEco = TabRegEco["NumEcogra"].ToString();
                  
                        T = TabRegEco["TipoEco"].ToString();


                        // 'Muestre los datos, de a cuerdo al tipo de ecografia

                        CboTipoEcoReal.SelectedValue = T; //Cargar Pestaña seleccionada

                        switch (T)
                        {
                            case "01": //Ecografía obstetrica TabCentral.SelectedIndex = 0;



                                //Muestre los datos del usuario

                                TxtAtenNumEco.Text = TabRegEco["Numaten"].ToString();
                                TxtFactConsul.Text = TabRegEco["NumFactu"].ToString();
                                TxtNumHistoEco.Text = TabRegEco["NumHisEco"].ToString();
                                TxtEcoNumForm.Text = FunConEco;

                                DtFecTomaEco.Value = Convert.ToDateTime(TabRegEco["FecRealECO"]);

                                CboTipTranEco.SelectedValue = TabRegEco["TransFrec"].ToString();


                                TxtEdadFum.Text = TabRegEco["EdadGesFum"].ToString();

                                CboConoceFUM.SelectedIndex = Convert.ToInt32(TabRegEco["SeConoFUM"]);


                                dateNUll = new DateTime(1900, 1, 1);

                                if (Convert.ToDateTime(TabRegEco["FUMEco"]) == dateNUll)
                                {
                                    DtFUMEco.Value = dateNUll;
                                }
                                else
                                {
                                    DtFUMEco.Value = Convert.ToDateTime(TabRegEco["FUMEco"]);
                                }

                                if (Convert.ToDateTime(TabRegEco["FPPFUM"]) == dateNUll)
                                {
                                    DtFPPFUM.Value = dateNUll;
                                }
                                else
                                {
                                    DtFPPFUM.Value = Convert.ToDateTime(TabRegEco["FPPFUM"]);
                                }

                                CalcularEdadFum(CboConoceFUM, DtFecTomaEco, DtFUMEco, DtFPPFUM, TxtEdadFum);

                                TxtNumFetosECO.Text = TabRegEco["NumFetos"].ToString();
                                TxtDesUteroEco.Text = TabRegEco["Utero"].ToString();
                                CboPlacenECO.SelectedValue = TabRegEco["Placenta"].ToString();

                                CboGradoMadECO.Text = TabRegEco["GraMaPla"].ToString();

                                TxtEspePlace.Text = TabRegEco["EspePlace"].ToString();
                                TxtNumSemECO.Text = TabRegEco["NumSemECO"].ToString();
                                TxtNumDiasECO.Text = TabRegEco["NumDiasECO"].ToString();
                                DtFFPECO.Value = Convert.ToDateTime(TabRegEco["FPPEco"]);
  
                                TxtConcluEcos.Text = TabRegEco["ConclusECO"].ToString();
                                NFetos = Convert.ToInt32(TabRegEco["NumFetos"]); //Optiene el numero de fetos



                                //Procedemos a agregar la biometria de los fetos

                                NFtol = 1;

                                while (NFetos > 0)
                                {

                                    string SqlBioFeto = "SELECT NumEcoFeto, FetoNum, Presentacion, Situacion, Posicion, MovCardiacos, ";
                                    SqlBioFeto = SqlBioFeto + "MovRespiratorios, MovFetales, TonoFetal, ILAFeto, CordonUmbi, SexFeto, ";
                                    SqlBioFeto = SqlBioFeto + "DBPFeto, HCFeto, ACFeto, LFFeto, PesoFeto, FCFFeto ";
                                    SqlBioFeto = SqlBioFeto + "FROM [DACONEXTSQL].[dbo].[Datos biometria de los fetos] ";
                                    SqlBioFeto = SqlBioFeto + "WHERE  NumEcoFeto = '" + FunConEco + "' AND FetoNum = " + NFtol;


                                    SqlDataReader TabBioFeto;

                                    using (SqlConnection connection3 = new SqlConnection(Conexion.conexionSQL))
                                    {
                                        SqlCommand command3 = new SqlCommand(SqlBioFeto, connection3);
                                        command3.Connection.Open();
                                        TabBioFeto = command3.ExecuteReader();

                                        if (TabBioFeto.HasRows == false)
                                        {
                                            //Aún no tiene registrado los datos del feto
                                        }
                                        else
                                        {

                                            TabBioFeto.Read();

                                            switch (NFtol)
                                            {
                                                case 1: //Agrega el primer feto
                                                    CboPresenta01.Text = TabBioFeto["Presentacion"].ToString();
                                                    TxtSituacion01.Text = TabBioFeto["Situacion"].ToString();
                                                    CboPosicion01.Text = TabBioFeto["Posicion"].ToString();
                                                    TxtMovCardi01.Text = TabBioFeto["MovCardiacos"].ToString();
                                                    TxtMovRespi01.Text = TabBioFeto["MovRespiratorios"].ToString();
                                                    TxtMoviFeta01.Text = TabBioFeto["MovFetales"].ToString();
                                                    TxtTonoFetal01.Text = TabBioFeto["TonoFetal"].ToString();
                                                    TxtLiquiAm01.Text = TabBioFeto["ILAFeto"].ToString();
                                                    TxtCordon01.Text = TabBioFeto["CordonUmbi"].ToString();
                                                    CboSexFeto01.Text = TabBioFeto["SexFeto"].ToString();
                                                    TxtBDP01.Text = TabBioFeto["DBPFeto"].ToString();
                                                    TxtHC01.Text = TabBioFeto["HCFeto"].ToString();
                                                    TxtAC01.Text = TabBioFeto["ACFeto"].ToString();
                                                    TxtLF01.Text = TabBioFeto["LFFeto"].ToString();
                                                    TxtPeso01.Text = TabBioFeto["PesoFeto"].ToString();
                                                    TxtFCFFeto01.Text = TabBioFeto["FCFFeto"].ToString();
                                                    break;
                                                case 2:
                                                    CboPresenta02.Text = TabBioFeto["Presentacion"].ToString();
                                                    TxtSituacion02.Text = TabBioFeto["Situacion"].ToString();
                                                    CboPosicion02.Text = TabBioFeto["Posicion"].ToString();
                                                    TxtMovCardi02.Text = TabBioFeto["MovCardiacos"].ToString();
                                                    TxtMovRespi02.Text = TabBioFeto["MovRespiratorios"].ToString();
                                                    TxtMoviFeta02.Text = TabBioFeto["MovFetales"].ToString();
                                                    TxtTonoFetal02.Text = TabBioFeto["TonoFetal"].ToString();
                                                    TxtLiquiAm02.Text = TabBioFeto["ILAFeto"].ToString();
                                                    TxtCordon02.Text = TabBioFeto["CordonUmbi"].ToString();
                                                    CboSexFeto02.Text = TabBioFeto["SexFeto"].ToString();
                                                    TxtBDP02.Text = TabBioFeto["DBPFeto"].ToString();
                                                    TxtHC02.Text = TabBioFeto["HCFeto"].ToString();
                                                    TxtAC02.Text = TabBioFeto["ACFeto"].ToString();
                                                    TxtLF02.Text = TabBioFeto["LFFeto"].ToString();
                                                    TxtPeso02.Text = TabBioFeto["PesoFeto"].ToString();
                                                    TxtFCFFeto02.Text = TabBioFeto["FCFFeto"].ToString();
                                                    break;
                                                case 3:
                                                    CboPresenta03.Text = TabBioFeto["Presentacion"].ToString();
                                                    TxtSituacion03.Text = TabBioFeto["Situacion"].ToString();
                                                    CboPosicion03.Text = TabBioFeto["Posicion"].ToString();
                                                    TxtMovCardi03.Text = TabBioFeto["MovCardiacos"].ToString();
                                                    TxtMovRespi03.Text = TabBioFeto["MovRespiratorios"].ToString();
                                                    TxtMoviFeta03.Text = TabBioFeto["MovFetales"].ToString();
                                                    TxtTonoFetal03.Text = TabBioFeto["TonoFetal"].ToString();
                                                    TxtLiquiAm03.Text = TabBioFeto["ILAFeto"].ToString();
                                                    TxtCordon03.Text = TabBioFeto["CordonUmbi"].ToString();
                                                    CboSexFeto03.Text = TabBioFeto["SexFeto"].ToString();
                                                    TxtBDP03.Text = TabBioFeto["DBPFeto"].ToString();
                                                    TxtHC03.Text = TabBioFeto["HCFeto"].ToString();
                                                    TxtAC03.Text = TabBioFeto["ACFeto"].ToString();
                                                    TxtLF03.Text = TabBioFeto["LFFeto"].ToString();
                                                    TxtPeso03.Text = TabBioFeto["PesoFeto"].ToString();
                                                    TxtFCFFeto03.Text = TabBioFeto["FCFFeto"].ToString();
                                                    break;
                                                case 4:
                                                    CboPresenta04.Text = TabBioFeto["Presentacion"].ToString();
                                                    TxtSituacion04.Text = TabBioFeto["Situacion"].ToString();
                                                    CboPosicion04.Text = TabBioFeto["Posicion"].ToString();
                                                    TxtMovCardi04.Text = TabBioFeto["MovCardiacos"].ToString();
                                                    TxtMovRespi04.Text = TabBioFeto["MovRespiratorios"].ToString();
                                                    TxtMoviFeta04.Text = TabBioFeto["MovFetales"].ToString();
                                                    TxtTonoFetal04.Text = TabBioFeto["TonoFetal"].ToString();
                                                    TxtLiquiAm04.Text = TabBioFeto["ILAFeto"].ToString();
                                                    TxtCordon04.Text = TabBioFeto["CordonUmbi"].ToString();
                                                    CboSexFeto04.Text = TabBioFeto["SexFeto"].ToString();
                                                    TxtBDP04.Text = TabBioFeto["DBPFeto"].ToString();
                                                    TxtHC04.Text = TabBioFeto["HCFeto"].ToString();
                                                    TxtAC04.Text = TabBioFeto["ACFeto"].ToString();
                                                    TxtLF04.Text = TabBioFeto["LFFeto"].ToString();
                                                    TxtPeso04.Text = TabBioFeto["PesoFeto"].ToString();
                                                    TxtFCFFeto04.Text = TabBioFeto["FCFFeto"].ToString();
                                                    break;
                                                case 5:
                                                    CboPresenta05.Text = TabBioFeto["Presentacion"].ToString();
                                                    TxtSituacion05.Text = TabBioFeto["Situacion"].ToString();
                                                    CboPosicion05.Text = TabBioFeto["Posicion"].ToString();
                                                    TxtMovCardi05.Text = TabBioFeto["MovCardiacos"].ToString();
                                                    TxtMovRespi05.Text = TabBioFeto["MovRespiratorios"].ToString();
                                                    TxtMoviFeta05.Text = TabBioFeto["MovFetales"].ToString();
                                                    TxtTonoFetal05.Text = TabBioFeto["TonoFetal"].ToString();
                                                    TxtLiquiAm05.Text = TabBioFeto["ILAFeto"].ToString();
                                                    TxtCordon05.Text = TabBioFeto["CordonUmbi"].ToString();
                                                    CboSexFeto05.Text = TabBioFeto["SexFeto"].ToString();
                                                    TxtBDP05.Text = TabBioFeto["DBPFeto"].ToString();
                                                    TxtHC05.Text = TabBioFeto["HCFeto"].ToString();
                                                    TxtAC05.Text = TabBioFeto["ACFeto"].ToString();
                                                    TxtLF05.Text = TabBioFeto["LFFeto"].ToString();
                                                    TxtPeso05.Text = TabBioFeto["PesoFeto"].ToString();
                                                    TxtFCFFeto05.Text = TabBioFeto["FCFFeto"].ToString();
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }// if (TabBioFeto.HasRows == false)
                                    }

                                    TabBioFeto.Close();
                                    NFtol += 1;
                                    NFetos -= 1;

                                }

                                break;

                            case string tipo when T == "02" || T == "10" || T == "12":


                                TxtAtenNumEco.Text = TabRegEco["Numaten"].ToString();
                                TxtFactConsul.Text = TabRegEco["NumFactu"].ToString();
                                TxtNumHistoEco.Text = TabRegEco["NumHisEco"].ToString();

                                TxtEcoNumForm02.Text = FunConEco;
                                DtFecTomaEco02.Value = Convert.ToDateTime(TabRegEco["FecRealECO"]);
                                CboTipTranEco02.SelectedValue = TabRegEco["TransFrec"].ToString();
                                
                                TxtDesUteroEco02.Text = TabRegEco["Utero"].ToString();
                                TxtEdadFum02.Text = TabRegEco["EdadGesFum"].ToString();
                                CboConoceFUM02.SelectedIndex = Convert.ToInt32(TabRegEco["SeConoFUM"]);

                   

                                if (Convert.ToString(TabRegEco["FPPFUM"]) == "1900-01-01")
                                {
                                    DtFPPFUM02.Enabled = false;
                                }
                                else
                                {
                                    DtFPPFUM02.Enabled = true;
                                    DtFPPFUM02.Value = Convert.ToDateTime(TabRegEco["FPPFUM"]);
                                }

                                if (Convert.ToDateTime(TabRegEco["FUMEco"]) == dateNUll)
                                {
                                    DtFUMEco02.Value = dateNUll;
                                }
                                else
                                {
                                    DtFUMEco02.Value = Convert.ToDateTime(TabRegEco["FUMEco"]);
                                }

                                CalcularEdadFum(CboConoceFUM02, DtFecTomaEco02, DtFUMEco02, DtFPPFUM02, TxtEdadFum02);

                                TxtDiameLongi02.Text = TabRegEco["DiamLongi"].ToString();
                                TxtDiameAntePos02.Text = TabRegEco["DiamAntePos"].ToString();
                                TxtDiameTras02.Text = TabRegEco["DiamTras"].ToString();
                                TxtEndome02.Text = TabRegEco["Endometrio"].ToString();
                                TxtDesEndome02.Text = TabRegEco["DesEndometrio"].ToString();
                                TxtOvariDere02.Text = TabRegEco["OvarioDere"].ToString();
                                TxtPorOvariDere02.Text = TabRegEco["PorOvarioDere"].ToString();
                                TxtOvariIzquie02.Text = TabRegEco["OvarioIzquie"].ToString();
                                TxtPorOvariIzqui02.Text = TabRegEco["PorOvarioIzqui"].ToString();
                                TxtComentario02.Text = TabRegEco["Comenta"].ToString();
                                TxtConcluEcos02.Text = TabRegEco["ConclusECO"].ToString();
                             
                                break;

                            case string tipo when T == "03" || T == "04":

                                //Ecografia obstetrica temprana

                                NFetos = 0;


                                if (T == "4")
                                {
                                    DtFFPECO03.Enabled = false;
                                }
                                else
                                {
                                    DtFFPECO03.Enabled = true;
                                }


                                TxtAtenNumEco.Text = TabRegEco["Numaten"].ToString();
                                TxtFactConsul.Text = TabRegEco["NumFactu"].ToString();
                                TxtNumHistoEco.Text = TabRegEco["NumHisEco"].ToString();

                                TxtEcoNumForm03.Text = FunConEco;
                                DtFecTomaEco03.Value = Convert.ToDateTime(TabRegEco["FecRealECO"]);
                                CboTipTranEco03.SelectedValue = TabRegEco["TransFrec"].ToString();

                                TxtEdadFum03.Text = TabRegEco["EdadGesFum"].ToString();
                                CboConoceFUM03.SelectedIndex = Convert.ToInt32(TabRegEco["SeConoFUM"]);

                              

                                if (Convert.ToDateTime(TabRegEco["FPPFUM"]) == dateNUll)
                                {
                                    DtFPPFUM03.Enabled = false;
                                }
                                else
                                {
                                    DtFPPFUM03.Enabled = true;
                                    DtFPPFUM03.Value = Convert.ToDateTime(TabRegEco["FPPFUM"]);
                                }

                                if (Convert.ToDateTime(TabRegEco["FUMEco"]) == dateNUll)
                                {
                                    DtFUMEco03.Value = dateNUll;
                                }
                                else
                                {
                                    DtFUMEco03.Value = Convert.ToDateTime(TabRegEco["FUMEco"]);
                                }

                                CalcularEdadFum(CboConoceFUM03, DtFecTomaEco03, DtFUMEco03, DtFPPFUM03, TxtEdadFum03);

                                TxtNumFetosECO03.Text = TabRegEco["NumFetos"].ToString();
                                TxtDesUteroEco03.Text = TabRegEco["Utero"].ToString();
                                TxtCervixCerra.Text = TabRegEco["CervixEsta"].ToString();
                                TxtNumSemECO03.Text = TabRegEco["NumSemECO"].ToString();
                                TxtNumDiasECO03.Text = TabRegEco["NumDiasECO"].ToString();
                                DtFFPECO03.Value = Convert.ToDateTime(TabRegEco["FPPEco"]);
                                TxtConcluEcos03.Text = TabRegEco["ConclusECO"].ToString();

                                NFetos = Convert.ToInt32(TabRegEco["NumFetos"]);
                                NFtol = 1;

                                while (NFetos > 0)
                                {
                                    string SqlBioFeto = "SELECT NumEcoFeto, FetoNum, FCFFeto, SacoGesta, VesiVitelina, BotonEmbriona, LCN ";
                                    SqlBioFeto = SqlBioFeto + "FROM [DACONEXTSQL].[dbo].[Datos biometria de los fetos] ";
                                    SqlBioFeto = SqlBioFeto + "WHERE  NumEcoFeto = '" + FunConEco + "' AND FetoNum = " + NFtol;


                                    SqlDataReader TabBioFeto;

                                    using (SqlConnection connection3 = new SqlConnection(Conexion.conexionSQL))
                                    {
                                        SqlCommand command3 = new SqlCommand(SqlBioFeto, connection3);
                                        command3.Connection.Open();
                                        TabBioFeto = command3.ExecuteReader();

                                        if (TabBioFeto.HasRows == false)
                                        {
                                            //Aún no tiene registrado los datos del feto
                                        }
                                        else
                                        {
                                            TabBioFeto.Read();
                                            //Muestre de acuerdo al número

                                            switch (NFtol)
                                            {
                                                case 1: //Agrega el primer feto
                                                    TxtFCF01.Text = TabBioFeto["FCFFeto"].ToString();
                                                    TxtSacoGes01.Text = TabBioFeto["SacoGesta"].ToString();
                                                    TxtVesiVitelina01.Text = TabBioFeto["VesiVitelina"].ToString();
                                                    TxtBotonEmbriona01.Text = TabBioFeto["BotonEmbriona"].ToString();
                                                    TxtLCN01.Text = TabBioFeto["LCN"].ToString();
                                                    break;
                                                case 2:
                                                    TxtFCF02.Text = TabBioFeto["FCFFeto"].ToString();
                                                    TxtSacoGes02.Text = TabBioFeto["SacoGesta"].ToString();
                                                    TxtVesiVitelina02.Text = TabBioFeto["VesiVitelina"].ToString();
                                                    TxtBotonEmbriona02.Text = TabBioFeto["BotonEmbriona"].ToString();
                                                    TxtLCN02.Text = TabBioFeto["LCN"].ToString();
                                                    break;
                                                case 3:
                                                    TxtFCF03.Text = TabBioFeto["FCFFeto"].ToString();
                                                    TxtSacoGes03.Text = TabBioFeto["SacoGesta"].ToString();
                                                    TxtVesiVitelina03.Text = TabBioFeto["VesiVitelina"].ToString();
                                                    TxtBotonEmbriona03.Text = TabBioFeto["BotonEmbriona"].ToString();
                                                    TxtLCN03.Text = TabBioFeto["LCN"].ToString();
                                                    break;
                                                case 4:
                                                    TxtFCF04.Text = TabBioFeto["FCFFeto"].ToString();
                                                    TxtSacoGes04.Text = TabBioFeto["SacoGesta"].ToString();
                                                    TxtVesiVitelina04.Text = TabBioFeto["VesiVitelina"].ToString();
                                                    TxtBotonEmbriona04.Text = TabBioFeto["BotonEmbriona"].ToString();
                                                    TxtLCN04.Text = TabBioFeto["LCN"].ToString();
                                                    break;
                                                case 5:
                                                    TxtFCF05.Text = TabBioFeto["FCFFeto"].ToString();
                                                    TxtSacoGes05.Text = TabBioFeto["SacoGesta"].ToString();
                                                    TxtVesiVitelina05.Text = TabBioFeto["VesiVitelina"].ToString();
                                                    TxtBotonEmbriona05.Text = TabBioFeto["BotonEmbriona"].ToString();
                                                    TxtLCN05.Text = TabBioFeto["LCN"].ToString();
                                                    break;

                                                default:
                                                    break;
                                            }
                                        }//final de TabBioFeto
                                    }

                                    TabBioFeto.Close();
                                    NFtol += 1;
                                    NFetos -= 1;
                                }

                                break;

                            case string tipo when T == "05" || T == "07":

                                //Ecografia Abdominal
                                //Ecografia Hepa...


                                TxtAtenNumEco.Text = TabRegEco["Numaten"].ToString();
                                TxtFactConsul.Text = TabRegEco["NumFactu"].ToString();
                                TxtNumHistoEco.Text = TabRegEco["NumHisEco"].ToString();

                                TxtEcoNumForm05.Text = FunConEco;
                                DtFecTomaEco05.Value = Convert.ToDateTime(TabRegEco["FecRealECO"]);
                                CboTipTranEco05.SelectedValue = TabRegEco["TransFrec"].ToString();


                                TxtEdadFum05.Text = TabRegEco["EdadGesFum"].ToString();
                                CboConoceFUM05.SelectedIndex = Convert.ToInt32(TabRegEco["SeConoFUM"]);

                                if (Convert.ToDateTime(TabRegEco["FPPFUM"]) == dateNUll)
                                {
                                    DtFPPFUM05.Enabled = false;
                                }
                                else
                                {
                                    DtFPPFUM05.Enabled = true;
                                    DtFPPFUM05.Value = Convert.ToDateTime(TabRegEco["FPPFUM"]);
                                }


                                if (Convert.ToDateTime(TabRegEco["FUMEco"]) == dateNUll)
                                {
                                    DtFUMEco05.Value = dateNUll;
                                }
                                else
                                {
                                    DtFUMEco05.Value = Convert.ToDateTime(TabRegEco["FUMEco"]);
                                }


                                TxtHigadoEco05.Text = TabRegEco["HigaAbdEco"].ToString();
                                TxtVesiculaEco05.Text = TabRegEco["VesicuAbdEco"].ToString();
                                TxtPancreasEco05.Text = TabRegEco["PancreAbdEco"].ToString();
                                TxtBazoEco05.Text = TabRegEco["BazoAdbEco"].ToString();
                                txtRinonEco05.Text = TabRegEco["RinonAbdEco"].ToString();
                                TxtComentario05.Text = TabRegEco["ConclusECO"].ToString();

                                break;

                            case "06":

                                TxtAtenNumEco.Text = TabRegEco["Numaten"].ToString();
                                TxtFactConsul.Text = TabRegEco["NumFactu"].ToString();
                                TxtNumHistoEco.Text = TabRegEco["NumHisEco"].ToString();

                                TxtEcoNumForm06.Text = FunConEco;
                                DtFecTomaEco06.Value = Convert.ToDateTime(TabRegEco["FecRealECO"]);
                                CboTipTranEco06.SelectedValue = TabRegEco["TransFrec"].ToString();

                                CboConoceFUM06.SelectedIndex = Convert.ToInt32(TabRegEco["SeConoFUM"]);
                                TxtEdadFum06.Text = TabRegEco["EdadGesFum"].ToString();

                                if (Convert.ToDateTime(TabRegEco["FPPFUM"]) == dateNUll)
                                {
                                    DtFPPFUM06.Enabled = false;
                                    DtFPPFUM06.Value = dateNUll;
                                }
                                else
                                {
                                    DtFPPFUM06.Enabled = true;
                                    DtFPPFUM06.Value = Convert.ToDateTime(TabRegEco["FPPFUM"]);
                                }


                                if (Convert.ToDateTime(TabRegEco["FUMEco"]) == dateNUll)
                                {
                                    DtFUMEco06.Value = dateNUll;
                                }
                                else
                                {
                                    DtFUMEco06.Value = Convert.ToDateTime(TabRegEco["FUMEco"]);
                                }

                                CalcularEdadFum(CboConoceFUM06, DtFecTomaEco06, DtFUMEco06, DtFPPFUM06, TxtEdadFum06);

                                TxtFormaRiDerecho06.Text = TabRegEco["FormaRiDere"].ToString();
                                TxtDiamRinDerecho06.Text = TabRegEco["DiamRinDer"].ToString();
                                TxtDiamAntRinDerecho06.Text = TabRegEco["DiamAntRinDer"].ToString();
                                TxtDiamTraRinDerecho06.Text = TabRegEco["DiamTraRinDer"].ToString();
                                TxtDiamEpRinDerecho06.Text = TabRegEco["DiamEpRinDer"].ToString();
                                TxtObservaRinDerecho06.Text = TabRegEco["ObserRinDere"].ToString();
                                TxtFormaRinIzquie06.Text = TabRegEco["FormaRinIzq"].ToString();
                                TxtDiamRinIzquie06.Text = TabRegEco["DiamRinIzq"].ToString();
                                TxtDiamAntRinIzquie06.Text = TabRegEco["DiamAntRinIzq"].ToString();
                                TxtDiamTraRinIzquie06.Text = TabRegEco["DiamTraRinIzq"].ToString();
                                TxtDiamEpRinIzquie06.Text = TabRegEco["DiamEpRinIzq"].ToString();
                                TxtObservaRinIzquie06.Text = TabRegEco["ObserRinIzquie"].ToString();
                                TxtComentario06.Text = TabRegEco["Comenta"].ToString();
                                TxtConcluEcos06.Text = TabRegEco["ConclusECO"].ToString();

                                break;

                            case "09":

                                TxtAtenNumEco.Text = TabRegEco["Numaten"].ToString();
                                TxtFactConsul.Text = TabRegEco["NumFactu"].ToString();
                                TxtNumHistoEco.Text = TabRegEco["NumHisEco"].ToString();

                                TxtEcoNumForm07.Text = FunConEco;
                                DtFecTomaEco07.Value = Convert.ToDateTime(TabRegEco["FecRealECO"]);

                                CboTipTranEco07.SelectedValue = TabRegEco["TransFrec"].ToString();


                                CboConoceFUM07.SelectedIndex = Convert.ToInt32(TabRegEco["SeConoFUM"]);

                                TxtEdadFum07.Text = TabRegEco["EdadGesFum"].ToString();

                                if (Convert.ToDateTime(TabRegEco["FPPFUM"]) == dateNUll)
                                {
                                    DtFPPFUM07.Enabled = false;
                                    DtFPPFUM07.Value = dateNUll;
                                }
                                else
                                {
                                    DtFPPFUM07.Enabled = true;
                                    DtFPPFUM07.Value = Convert.ToDateTime(TabRegEco["FPPFUM"]);
                                }

                                

                                if (Convert.ToDateTime(TabRegEco["FUMEco"]) == dateNUll)
                                {
                                    DtFUMEco07.Value = dateNUll;
                                }
                                else
                                {
                                    DtFUMEco07.Value = Convert.ToDateTime(TabRegEco["FUMEco"]);
                                }

                                CalcularEdadFum(CboConoceFUM07, DtFecTomaEco07, DtFUMEco07, DtFPPFUM07, TxtEdadFum07);

                                TxtHigadoEco07.Text = TabRegEco["HigaAbdEco"].ToString();
                                TxtVesiculaEco07.Text = TabRegEco["VesicuAbdEco"].ToString();
                                TxtPancreasEco07.Text = TabRegEco["PancreAbdEco"].ToString();
                                TxtComentario07.Text = TabRegEco["ConclusECO"].ToString();

                                break;

                            case "08":

                                TxtAtenNumEco.Text = TabRegEco["Numaten"].ToString();
                                TxtFactConsul.Text = TabRegEco["NumFactu"].ToString();
                                TxtNumHistoEco.Text = TabRegEco["NumHisEco"].ToString();

                                TxtEcoNumForm08.Text = FunConEco;
                                DtFecTomaEco08.Value = Convert.ToDateTime(TabRegEco["FecRealECO"]);
                                CboTipTranEco08.SelectedValue = TabRegEco["TransFrec"].ToString();


                                CboConoceFUM08.SelectedIndex = Convert.ToInt32(TabRegEco["SeConoFUM"]);


                                if (Convert.ToDateTime(TabRegEco["FPPFUM"]) == dateNUll)
                                {
                                    DtFPPFUM08.Enabled = false;
                                    DtFPPFUM08.Value = dateNUll;
                                }
                                else
                                {
                                    DtFPPFUM08.Enabled = true;
                                    DtFPPFUM08.Value = Convert.ToDateTime(TabRegEco["FPPFUM"]);
                                }



                                if (Convert.ToDateTime(TabRegEco["FUMEco"]) == dateNUll)
                                {
                                    DtFUMEco08.Value = dateNUll;
                                }
                                else
                                {
                                    DtFUMEco08.Value = Convert.ToDateTime(TabRegEco["FUMEco"]);
                                }

                                CalcularEdadFum(CboConoceFUM08, DtFecTomaEco08, DtFUMEco08, DtFPPFUM08, TxtEdadFum08);

                                TxtEdadFum08.Text = TabRegEco["EdadGesFum"].ToString();
                                TxtFormaRiDerecho08.Text = TabRegEco["FormaRiDere"].ToString();
                                TxtDiamRinDerecho08.Text = TabRegEco["DiamRinDer"].ToString();
                                TxtDiamAntRinDerecho08.Text = TabRegEco["DiamAntRinDer"].ToString();
                                TxtDiamTraRinDerecho08.Text = TabRegEco["DiamTraRinDer"].ToString();
                                TxtDiamEpRinDerecho08.Text = TabRegEco["DiamEpRinDer"].ToString();
                                TxtObservaRinDerecho08.Text = TabRegEco["ObserRinDere"].ToString();
                                TxtFormaRinIzquie08.Text = TabRegEco["FormaRinIzq"].ToString();
                                TxtDiamRinIzquie08.Text = TabRegEco["DiamRinIzq"].ToString();
                                TxtDiamAntRinIzquie08.Text = TabRegEco["DiamAntRinIzq"].ToString();
                                TxtDiamTraRinIzquie08.Text = TabRegEco["DiamTraRinIzq"].ToString();
                                TxtDiamEpRinIzquie08.Text = TabRegEco["DiamEpRinIzq"].ToString();
                                TxtObservaRinIzquie08.Text = TabRegEco["ObserRinIzquie"].ToString();
                                TxtComentario08.Text = TabRegEco["Comenta"].ToString();
                                TxtConcluEcos08.Text = TabRegEco["ConclusECO"].ToString();
                                TxtAspecVejiga08.Text = TabRegEco["AspecVeji"].ToString();
                                TxtVoluPromVejiga08.Text = TabRegEco["VoluPromVeji"].ToString();
                                TxtResiPostVejiga08.Text = TabRegEco["ResiPostVeji"].ToString();


                                break;

                            case "11": //Ecografía perfil biofisico

                                TxtAtenNumEco.Text = TabRegEco["Numaten"].ToString();
                                TxtFactConsul.Text = TabRegEco["NumFactu"].ToString();
                                TxtNumHistoEco.Text = TabRegEco["NumHisEco"].ToString();

                                TxtEcoNumForm11.Text = FunConEco;
                                DtFecTomaEco11.Value = Convert.ToDateTime(TabRegEco["FecRealECO"]);


                                CboTipTranEco11.SelectedValue = TabRegEco["TransFrec"].ToString();

                                CboConoceFUM11.SelectedIndex = Convert.ToInt32(TabRegEco["SeConoFUM"]);
                                TxtEdadFum11.Text = TabRegEco["EdadGesFum"].ToString();


                                if (Convert.ToDateTime(TabRegEco["FPPFUM"]) == dateNUll)
                                {
                                    DtFPPFUM11.Enabled = false;
                                    DtFPPFUM11.Value = dateNUll;
                                }
                                else
                                {
                                    DtFPPFUM11.Enabled = true;
                                    DtFPPFUM11.Value = Convert.ToDateTime(TabRegEco["FPPFUM"]);
                                }


                                if (Convert.ToDateTime(TabRegEco["FUMEco"]) == dateNUll)
                                {
                                    DtFUMEco11.Value = dateNUll;
                                }
                                else
                                {
                                    DtFUMEco11.Value = Convert.ToDateTime(TabRegEco["FUMEco"]);
                                }

                                CalcularEdadFum(CboConoceFUM11, DtFecTomaEco11, DtFUMEco11, DtFPPFUM11, TxtEdadFum11);



                                TxtNumFetosECO11.Text = TabRegEco["NumFetos"].ToString();
                                TxtConcluEcos11.Text = TabRegEco["ConclusECO"].ToString();


                                //Procedemos a agregar la biometria de los fetos

                                NFetos = Convert.ToInt32(TabRegEco["NumFetos"]);
                                NFtol = 1;


                                while (NFetos > 0)
                                {
                                    string SqlBioFeto = "SELECT NumEcoFeto, FetoNum, FCFFeto, ILAFeto, TotaPunt, MovFetales, TonoFetal, MovRespiratorios, ";
                                    SqlBioFeto = SqlBioFeto + "PuntajeILA, PuntajeMovFet, PuntajeMovRes, PuntajeTonMusc ";
                                    SqlBioFeto = SqlBioFeto + "FROM [DACONEXTSQL].[dbo].[Datos biometria de los fetos] ";
                                    SqlBioFeto = SqlBioFeto + "WHERE  NumEcoFeto = '" + FunConEco + "' AND FetoNum = " + NFtol;


                                    SqlDataReader TabBioFeto;

                                    using (SqlConnection connection3 = new SqlConnection(Conexion.conexionSQL))
                                    {
                                        SqlCommand command3 = new SqlCommand(SqlBioFeto, connection3);
                                        command3.Connection.Open();
                                        TabBioFeto = command3.ExecuteReader();

                                        if (TabBioFeto.HasRows == false)
                                        {
                                            //Aún no tiene registrado los datos del feto
                                        }
                                        else
                                        {
                                            TabBioFeto.Read();
                                            switch (NFtol)
                                            {
                                                case 1:
                                                    //'Habilitammos la respectiva ficha

                                                    FCF01.Text = TabBioFeto["FCFFeto"].ToString();
                                                    TxtILA01.Text = TabBioFeto["ILAFeto"].ToString();
                                                    TxtTotal01.Text = TabBioFeto["TotaPunt"].ToString();
                                                    TxtMovFeta01.Text = TabBioFeto["MovFetales"].ToString();
                                                    TxtMovResp01.Text = TabBioFeto["MovRespiratorios"].ToString();
                                                    TxtTonoMusc01.Text = TabBioFeto["TonoFetal"].ToString();
                                                    TxtPuntaILA.Text = TabBioFeto["PuntajeILA"].ToString();
                                                    TxtPuntaMovFet.Text = TabBioFeto["PuntajeMovFet"].ToString();
                                                    TxtPuntaMovRes.Text = TabBioFeto["PuntajeMovRes"].ToString();
                                                    TxtPuntaTonMusc.Text = TabBioFeto["PuntajeTonMusc"].ToString();
                                                    break;

                                                case 2:

                                                    FCF02.Text = TabBioFeto["FCFFeto"].ToString();
                                                    TxtILA02.Text = TabBioFeto["ILAFeto"].ToString();
                                                    TxtTotal02.Text = TabBioFeto["TotaPunt"].ToString();
                                                    TxtMovFeta02.Text = TabBioFeto["MovFetales"].ToString();
                                                    TxtMovResp02.Text = TabBioFeto["MovRespiratorios"].ToString();
                                                    TxtTonoMusc02.Text = TabBioFeto["TonoFetal"].ToString();

                                                    break;
                                                case 3:

                                                    FCF03.Text = TabBioFeto["FCFFeto"].ToString();
                                                    TxtILA03.Text = TabBioFeto["ILAFeto"].ToString();
                                                    TxtTotal03.Text = TabBioFeto["TotaPunt"].ToString();
                                                    TxtMovFeta03.Text = TabBioFeto["MovFetales"].ToString();
                                                    TxtMovResp03.Text = TabBioFeto["MovRespiratorios"].ToString();
                                                    TxtTonoMusc03.Text = TabBioFeto["TonoFetal"].ToString();

                                                    break;
                                                case 4:

                                                    FCF04.Text = TabBioFeto["FCFFeto"].ToString();
                                                    TxtILA04.Text = TabBioFeto["ILAFeto"].ToString();
                                                    TxtTotal04.Text = TabBioFeto["TotaPunt"].ToString();
                                                    TxtMovFeta04.Text = TabBioFeto["MovFetales"].ToString();
                                                    TxtMovResp04.Text = TabBioFeto["MovRespiratorios"].ToString();
                                                    TxtTonoMusc04.Text = TabBioFeto["TonoFetal"].ToString();

                                                    break;
                                                case 5:

                                                    FCF05.Text = TabBioFeto["FCFFeto"].ToString();
                                                    TxtILA05.Text = TabBioFeto["ILAFeto"].ToString();
                                                    TxtTotal05.Text = TabBioFeto["TotaPunt"].ToString();
                                                    TxtMovFeta05.Text = TabBioFeto["MovFetales"].ToString();
                                                    TxtMovResp05.Text = TabBioFeto["MovRespiratorios"].ToString();
                                                    TxtTonoMusc05.Text = TabBioFeto["TonoFetal"].ToString();

                                                    break;
                                                default:
                                                    break;
                                            }
                                        }//'final de TabBioFeto.BOF
                                    }

                                    TabBioFeto.Close();
                                    NFtol += 1;
                                    NFetos -= 1;

                                }

                                break;


                            case "13":


                                TxtAtenNumEco.Text = TabRegEco["Numaten"].ToString();
                                TxtFactConsul.Text = TabRegEco["NumFactu"].ToString();
                                TxtNumHistoEco.Text = TabRegEco["NumHisEco"].ToString();

                                TxtEcoNumForm13.Text = FunConEco;
                                DtFecTomaEco13.Value = Convert.ToDateTime(TabRegEco["FecRealECO"]);


                                CboTipTranEco13.SelectedValue = TabRegEco["TransFrec"].ToString();


                                CboConoceFUM13.SelectedIndex = Convert.ToInt32(TabRegEco["SeConoFUM"]);

                                if (Convert.ToDateTime(TabRegEco["FPPFUM"]) == dateNUll)
                                {
                                    DtFPPFUM13.Enabled = false;
                                    DtFPPFUM13.Value = dateNUll;
                                }
                                else
                                {
                                    DtFPPFUM13.Enabled = true;
                                    DtFPPFUM13.Value = Convert.ToDateTime(TabRegEco["FPPFUM"]);
                                }

                                if (Convert.ToDateTime(TabRegEco["FUMEco"]) == dateNUll)
                                {
                                    DtFUMEco13.Value = dateNUll;
                                }
                                else
                                {
                                    DtFUMEco13.Value = Convert.ToDateTime(TabRegEco["FUMEco"]);
                                }


                                CalcularEdadFum(CboConoceFUM13, DtFecTomaEco13, DtFUMEco13, DtFPPFUM13, TxtEdadFum13);


                                TxtEdadFum13.Text = TabRegEco["EdadGesFum"].ToString();

                                TxtDiameLongi13.Text = TabRegEco["DiamLongi"].ToString();
                                TxtEspeCervix13.Text = TabRegEco["EspesorCer"].ToString();
                                TxtDesCervixEco13.Text = TabRegEco["DesCervix"].ToString();
                                TxtConcluEcos13.Text = TabRegEco["ConclusECO"].ToString();

                                TxtDesUteroEco13.Text = TabRegEco["Utero"].ToString();



                                break;

                            case "14":


                                TxtAtenNumEco.Text = TabRegEco["Numaten"].ToString();
                                TxtFactConsul.Text = TabRegEco["NumFactu"].ToString();
                                TxtNumHistoEco.Text = TabRegEco["NumHisEco"].ToString();


                                TxtEcoNumForm14.Text = FunConEco;
                                DtFecTomaEco14.Value = Convert.ToDateTime(TabRegEco["FecRealECO"]);


                                CboTipTranEco14.SelectedValue = TabRegEco["TransFrec"].ToString();

                                CboConoceFUM14.SelectedIndex = Convert.ToInt32(TabRegEco["SeConoFUM"]);
                                TxtEdadFum14.Text = TabRegEco["EdadGesFum"].ToString();


                                if (Convert.ToDateTime(TabRegEco["FPPFUM"]) == dateNUll)
                                {
                                    DtFPPFUM14.Enabled = false;
                                    DtFPPFUM14.Value = dateNUll;
                                }
                                else
                                {
                                    DtFPPFUM14.Enabled = true;
                                    DtFPPFUM14.Value = Convert.ToDateTime(TabRegEco["FPPFUM"]);
                                }



                                if (Convert.ToDateTime(TabRegEco["FUMEco"]) == dateNUll)
                                {
                                    DtFUMEco14.Value = dateNUll;
                                }
                                else
                                {
                                    DtFUMEco14.Value = Convert.ToDateTime(TabRegEco["FUMEco"]);
                                }


                                CalcularEdadFum(CboConoceFUM14, DtFecTomaEco14, DtFUMEco14, DtFPPFUM14, TxtEdadFum14);

                                TxtProstaEco14.Text = TabRegEco["ProstataEco"].ToString();
                                TxtVesiSeminal14.Text = TabRegEco["VesicuSemiEco"].ToString();
                                TxtVejigaEco14.Text = TabRegEco["AspecVeji"].ToString();
                                TxtComentario14.Text = TabRegEco["ConclusECO"].ToString();


                                break;

                            case string tipo when T == "15" || T == "16":

                                TxtAtenNumEco.Text = TabRegEco["Numaten"].ToString();
                                TxtFactConsul.Text = TabRegEco["NumFactu"].ToString();
                                TxtNumHistoEco.Text = TabRegEco["NumHisEco"].ToString();


                                TxtEcoNumForm15.Text = FunConEco;
                                DtFecTomaEco15.Value = Convert.ToDateTime(TabRegEco["FecRealECO"]);

                                CboTipTranEco15.SelectedValue = TabRegEco["TransFrec"].ToString();

                                CboConoceFUM15.SelectedIndex = Convert.ToInt32(TabRegEco["SeConoFUM"]);
                                TxtEcoGeneral15.Text = TabRegEco["RegisEcoGral"].ToString();

                                TxtComentario15.Text = TabRegEco["ConclusECO"].ToString();

                                if (Convert.ToDateTime(TabRegEco["FUMEco"]) == dateNUll)
                                {
                                    DtFUMEco15.Value = dateNUll;

                                }
                                else
                                {
                                    DtFUMEco15.Value = Convert.ToDateTime(TabRegEco["FUMEco"]);
                                }


                                CalcularEdadFum(CboConoceFUM15, DtFecTomaEco15, DtFUMEco15, DtFPPFUM15, TxtEdadFum15);


                                break;

                            default:

                                Utils.Titulo01 = "Control de ejecución";
                                Utils.Informa = "Lo siento pero el tipo de ecografía no se encuentra definido" + "\r";
                                Utils.Informa += "en el código de programación de estes sistema," + "\r";
                                Utils.Informa += "por lo tanto no se puede realizar el registro" + "\r";
                                Utils.Informa += "en la basee de datos." + "\r";
                                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                        }
                    }
                }

                TabRegEco.Close();

            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "en la funcion CargarDatos" + "\r";
                Utils.Informa += "Mensaje del error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargaEcografiaObstetrica()
        {
            try
            {

                //Este lo utilizan varios por lo cual se le colocan varios combobox

                string SqlTipTrans = "SELECT CodTraducEco, NomTraducEco ";
                SqlTipTrans = SqlTipTrans + "FROM [DACONEXTSQL].[dbo].[Datos tipos de transductores ecografos]";
                SqlTipTrans = SqlTipTrans + "WHERE (habilTran = 'True') ";
                SqlTipTrans = SqlTipTrans + "ORDER BY NomTraducEco";

                CboTipTranEco.DataSource = null;
                CboTipTranEco02.DataSource = null;

                DataSet dataSet = Conexion.SQLDataSet(SqlTipTrans);

                if (dataSet != null && dataSet.Tables.Count > 0)
                {
                    this.CboTipTranEco.DataSource = dataSet.Tables[0];
                    this.CboTipTranEco.ValueMember = "CodTraducEco";
                    this.CboTipTranEco.DisplayMember = "NomTraducEco";

                    this.CboTipTranEco02.DataSource = dataSet.Tables[0];
                    this.CboTipTranEco02.ValueMember = "CodTraducEco";
                    this.CboTipTranEco02.DisplayMember = "NomTraducEco";


                    this.CboTipTranEco03.DataSource = dataSet.Tables[0];
                    this.CboTipTranEco03.ValueMember = "CodTraducEco";
                    this.CboTipTranEco03.DisplayMember = "NomTraducEco";

                    this.CboTipTranEco05.DataSource = dataSet.Tables[0];
                    this.CboTipTranEco05.ValueMember = "CodTraducEco";
                    this.CboTipTranEco05.DisplayMember = "NomTraducEco";


                    this.CboTipTranEco06.DataSource = dataSet.Tables[0];
                    this.CboTipTranEco06.ValueMember = "CodTraducEco";
                    this.CboTipTranEco06.DisplayMember = "NomTraducEco";

                    this.CboTipTranEco07.DataSource = dataSet.Tables[0];
                    this.CboTipTranEco07.ValueMember = "CodTraducEco";
                    this.CboTipTranEco07.DisplayMember = "NomTraducEco";

                    this.CboTipTranEco08.DataSource = dataSet.Tables[0];
                    this.CboTipTranEco08.ValueMember = "CodTraducEco";
                    this.CboTipTranEco08.DisplayMember = "NomTraducEco";

                    this.CboTipTranEco11.DataSource = dataSet.Tables[0];
                    this.CboTipTranEco11.ValueMember = "CodTraducEco";
                    this.CboTipTranEco11.DisplayMember = "NomTraducEco";

                    this.CboTipTranEco13.DataSource = dataSet.Tables[0];
                    this.CboTipTranEco13.ValueMember = "CodTraducEco";
                    this.CboTipTranEco13.DisplayMember = "NomTraducEco";

                    this.CboTipTranEco14.DataSource = dataSet.Tables[0];
                    this.CboTipTranEco14.ValueMember = "CodTraducEco";
                    this.CboTipTranEco14.DisplayMember = "NomTraducEco";

                    this.CboTipTranEco15.DataSource = dataSet.Tables[0];
                    this.CboTipTranEco15.ValueMember = "CodTraducEco";
                    this.CboTipTranEco15.DisplayMember = "NomTraducEco";


                }

                //Cargamos el combo de la placenta de inserción

                string SqlLisFormu = "SELECT NomLista ";
                SqlLisFormu = SqlLisFormu + "FROM [DACONEXTSQL].[dbo].[Datos listas formularios ecografias]";
                SqlLisFormu = SqlLisFormu + "WHERE (CodLista = '05')";
                SqlLisFormu = SqlLisFormu + "ORDER BY NomLista";

                CboPlacenECO.DataSource = null;

                DataSet dataSet2 = Conexion.SQLDataSet(SqlLisFormu);

                if (dataSet2 != null && dataSet2.Tables.Count > 0)
                {
                    this.CboPlacenECO.DataSource = dataSet2.Tables[0];
                    this.CboPlacenECO.ValueMember = "NomLista";
                    this.CboPlacenECO.DisplayMember = "NomLista";
                }


            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "en la funcion CargaEcografiaObstetrica" + "\r";
                Utils.Informa += "Mensaje del error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarTabSeleccionado(string T)
        {
            try
            {
                switch (T)
                {
                    case "01": //Ecografía obstetrica

                        TabControlEcograficas.SelectedIndex = 0;

                        break;
                    case "02": //Ecografía pelvica

                        groupEcoCombina01.Text = "Ecografia pelvica transvaginal";
                        TabControlEcograficas.SelectedIndex = 1;

                        break;


                    case "03": //Ecografía obstetrica temprana

                        GroupTemAbor.Text = "Ecografia obstetrica temprana";

                        TabControlEcograficas.SelectedIndex = 2;

                        break;


                    case "04": //Ecografia obstetrica aborto

                        GroupTemAbor.Text = "Ecografia obstetrica aborto";

                        TabControlEcograficas.SelectedIndex = 2;

                        break;


                    case "05": //Ecografía Abdominal

                        groupAbdoHepa.Text = "Ecografía Abdominal";

                        TabControlEcograficas.SelectedIndex = 3;

                        break;


                    case "06": //Ecografía renal bilateral

                        TabControlEcograficas.SelectedIndex = 4;

                        break;


                    case "07": //Ecografía renal hepatobiliar

                        groupAbdoHepa.Text = "Ecografía renal hepatobiliar";

                        TabControlEcograficas.SelectedIndex = 3;

                        break;


                    case "08": //Ecografía renal vias urinarias

                        TabControlEcograficas.SelectedIndex = 6;

                        break;


                    case "09": //Ecografía abdomen superior

                        GroupHepaAbor.Text = "Ecografía Abdominal superior";

                        TabControlEcograficas.SelectedIndex = 5;

                        break;


                    case "10": //Ecografía obstetrica transvaginal

                        groupEcoCombina01.Text = "Ecografía obstetrica transvaginal";

                        TabControlEcograficas.SelectedIndex = 1;

                        break;

                    case "11": //Ecografía perfil biofisico

                        TabControlEcograficas.SelectedIndex = 7;

                        break;


                    case "12": //Ecografía pelvica transabdominal


                        groupEcoCombina01.Text = "Ecografia pelvica transabdominal";

                        TabControlEcograficas.SelectedIndex = 1;

                        break;


                    case "13": //Ecografía cervicometria

                        TabControlEcograficas.SelectedIndex = 8;

                        break;


                    case "14": //Ecografía cervicometria

                        TabControlEcograficas.SelectedIndex = 9;

                        break;

                    case "15": //Ecografía tejidos blandos

                        groupBoxEcografiaGeneral.Text = "Ecografía tejidos blandos";

                        TabControlEcograficas.SelectedIndex = 10;

                        break;

                    case "16": //Ecografía y ecodoppler testicular estudio de varicocele

                        groupBoxEcografiaGeneral.Text = "Ecografía y ecodoppler testicular estudio de varicocele";

                        TabControlEcograficas.SelectedIndex = 10;

                        break;


                    default:

                        TabControlEcograficas.SelectedIndex = 0;

                        break;
                }
            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "en la funcion cargarTabSeleccionado" + "\r";
                Utils.Informa += "Mensaje del error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private string EdadAtencion(DateTime Fa, DateTime FN)
        //{
        //    //Permite devolver la edad  a la fecha de la atención
        //    //'*********************** Modificada el 03 de febrero de 2007

        //    //'Esta función permite mostrar la edad de un paciente

        //    //Defina el total días corridos entre la fecha de nacimiento y la de hoy          
        //    try
        //    {
        //        string MesDias;
        //        int MesAcul, AnAcumul, TolMeses, TolDias;



        //        string AnActual = Fa.ToString("yyyy");
        //        string AnNace = FN.ToString("yyyy");

        //        string MesAcTual = Fa.ToString("MM");
        //        string MesNace = FN.ToString("MM");

        //        string DiaActual = Fa.ToString("dd");
        //        string DiaNace = FN.ToString("dd");


        //        TimeSpan ts = Fa - FN;

        //        int DiasCorridos = ts.Days;

        //        if (AnActual == AnNace)
        //        {
        //            //Es un menor de un año
        //            if (MesAcTual == MesNace)
        //            {
        //                //Menor de un mes de nacido
        //                int D = ts.Days;
        //                if (D == 0)
        //                {
        //                    MesDias = "1 " + "día";
        //                }
        //                else
        //                {
        //                    MesDias = D + "días";
        //                }
        //            }
        //            else
        //            {
        //                if (Convert.ToInt32(MesAcTual) > Convert.ToInt32(MesNace))
        //                {
        //                    if (Convert.ToInt32(DiaActual) > Convert.ToInt32(DiaNace))
        //                    {
        //                        MesAcul = Convert.ToInt32(MesAcTual) - Convert.ToInt32(MesNace);

        //                        switch (MesAcul)
        //                        {
        //                            case 1:
        //                                MesDias = MesAcul + " Mes";
        //                                break;
        //                            default:
        //                                MesDias = MesAcul + " Meses";
        //                                break;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        MesAcul = Convert.ToInt32(MesAcTual) - Convert.ToInt32(MesNace);
        //                        switch (MesAcul)
        //                        {
        //                            case 1: //Tiene son días de nacidos
        //                                MesDias = DiasCorridos + " días";
        //                                break;
        //                            default: //Meses
        //                                if ((MesAcul - 1) == 1)
        //                                {
        //                                    MesDias = 1 + " Mes";
        //                                }
        //                                else
        //                                {
        //                                    MesDias = (MesAcul - 1) + " Mes";
        //                                }

        //                                break;
        //                        }
        //                    }

        //                }
        //                else
        //                {
        //                    //Devuelva cero porque no ha nacido
        //                    MesDias = 0 + " días";
        //                }
        //            }
        //        }
        //        else
        //        {
        //            if (Convert.ToInt32(AnActual) > Convert.ToInt32(AnNace))
        //            {
        //                AnAcumul = Convert.ToInt32(AnActual) - Convert.ToInt32(AnNace);
        //                //Se revisa el mes de nacimiento
        //                if (Convert.ToInt32(MesAcTual) == Convert.ToInt32(MesNace))
        //                {
        //                    //Revisamos el día de nacimiento
        //                    if (Convert.ToInt32(DiaActual) >= Convert.ToInt32(DiaNace))
        //                    {
        //                        //Años cumplidos exactos
        //                        MesDias = AnAcumul + " Años";
        //                    }
        //                    else
        //                    {
        //                        if (AnAcumul == 1)
        //                        {
        //                            //No ha cumplido el año, por tanto se debe reportar en meses, con seguridad son 11 meses
        //                            MesDias = 11 + " Meses";
        //                        }
        //                        else
        //                        {
        //                            MesDias = (AnAcumul - 1) + " Años";
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    if (Convert.ToInt32(MesAcTual) < Convert.ToInt32(MesNace))
        //                    {
        //                        //No ha cumplido años, en el año actual
        //                        if (AnAcumul == 1)
        //                        {
        //                            //Está de meses, revisamos el día de nacido
        //                            if (Convert.ToInt32(DiaActual) >= Convert.ToInt32(DiaNace))
        //                            {
        //                                //Meses cumplidos exactos
        //                                MesDias = ((12 - Convert.ToInt32(MesNace)) + MesAcTual) + " Meses";
        //                            }

        //                            else
        //                            {
        //                                //******************** MOdificado el 03 de febrero de 2007 por Hernando en GUADALUPE *****************
        //                                //******************** Reeescrito en c# el 27 de agosto de 2021 por Juan Diego Pimentel en GUADALUPE *****************


        //                                TolMeses = ((12 - Convert.ToInt32(MesNace)) + (Convert.ToInt32(MesAcTual) - 1));

        //                                if (TolMeses == 0)
        //                                {
        //                                    //El nino nacio en diciembre y ha sido atendo en enero

        //                                    TolDias = (31 - Convert.ToInt32(DiaNace)) + Convert.ToInt32(DiaActual);
        //                                    if (TolDias < 30)
        //                                    {
        //                                        //El paciente tiene dias
        //                                        MesDias = TolDias + " días";
        //                                    }
        //                                    else
        //                                    {
        //                                        MesDias = "1 Meses";
        //                                    }
        //                                }
        //                                else
        //                                {
        //                                    MesDias = ((12 - Convert.ToInt32(MesNace)) + (Convert.ToInt32(MesAcTual) - 1)) + " Meses";
        //                                }
        //                            }
        //                        }
        //                        else
        //                        {
        //                            MesDias = (AnAcumul - 1) + " Años";
        //                        }//if (AnAcumul == 1)
        //                    }
        //                    else
        //                    {
        //                        //Ya cumplió años en el año actual
        //                        MesDias = AnAcumul + " Años";
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                //Devuelva edad cero porque el usuario no ha nacido
        //                MesDias = 0 + " días";
        //            }
        //        }//Final de AnActual = AnNace

        //        return MesDias;
        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.Titulo01 = "Control de errores de ejecución";
        //        Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
        //        Utils.Informa += "en la funcion EdadAtencion" + "\r";
        //        Utils.Informa += "Mensaje del error: " + ex.Message + " - " + ex.StackTrace;
        //        MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return "-1";
        //    }
        //}

        private void limpiarTextBoxes(Control parent)
        {
            //Limpiar de manera rapida
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

                //if (c is ComboBox)
                //{
                //    ComboBox cmb = c as ComboBox;
                //    cmb.SelectedIndex = 1;
                //}

                if (c.Controls.Count > 0)
                {
                    limpiarTextBoxes(c);
                }

            }
        }
        private void CalcularEdadFum(ComboBox CboConoceFUM, DateTimePicker DtFecTomaEco, DateTimePicker DtFUMEco, DateTimePicker DtFPPFUM, TextBox TxtEdadFum)
        {
            try
            {

                if (CboConoceFUM.SelectedIndex == 1)
                {

                    TxtEdadFum.Clear();

                    double DiasTrascur = 0, SemaGesta = 0, DiasSem = 0;
                    int SemEntera = 0;


                    DateTime FecEnAten = DtFecTomaEco.Value;
                    DateTime FUMDig = DtFUMEco.Value;

                    Utils.Titulo01 = "Control para registrar datos";

                    if (FUMDig > FecEnAten)
                    {
                        Utils.Informa = "Lo siento pero la fecha de la atención es" + "\r";
                        Utils.Informa += "requerida para calcular la FPP y le Edad Gestacional." + "\r";
                        Utils.Informa += "Por favor corrija la fecha o pulse [OK] para continuar." + "\r";
                        MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                    DateTime FecMenor = FecEnAten.AddDays(-280);

                    if (FUMDig < FecMenor)
                    {
                        Utils.Informa = "Lo siento pero la fecha de ultima Menstruación no" + "\r";
                        Utils.Informa += "puede ser menor al " + FecMenor.Date + ". Por favor corrija" + "\r";
                        Utils.Informa += "Por favor corrija la fecha o pulse [OK] para continuar." + "\r";
                        MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    //************************************** a partir del 15 de noviembre se debe mostrar es la edad actual y trimestre de acuerdo a la fecha de atención

                    DiasTrascur = Math.Abs((FUMDig - FecEnAten).Days); //cuantos días han trancurrido hasta el día de hoy


                    DtFPPFUM.Value = FUMDig.AddDays(280);

                    SemaGesta = Math.Round(DiasTrascur / 7, 1); //se divide en siete para presentar la información en semanas



                    SemEntera = Convert.ToInt32(SemaGesta); //******a  partir del 15 nov, Edad se muestra Semanas .Dias

                    DiasSem = ((SemaGesta - SemEntera) * 7) / 10;

                    switch (SemaGesta) //Lo decimales de este numeros son semanas y se quiere saber los días multiplique el decimal por 7
                    {

                        case double estado when SemaGesta <= 0:

                            Utils.Informa = "La semanas de gestación no pueden" + "\r";
                            Utils.Informa += "ser menores o iguales a Cero (0)" + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;

                        case double estado when SemaGesta > 0 && SemaGesta <= 13.9:

                            TxtEdadFum.Text = Math.Round(SemEntera + DiasSem, 1).ToString() + " Semanas (Trimestre No. 1 ) ";


                            break;
                        case double estado when SemaGesta >= 14 && SemaGesta <= 26.9:

                            TxtEdadFum.Text = Math.Round(SemEntera + DiasSem, 1).ToString() + " Semanas (Trimestre No. 2 ) ";


                            break;

                        case double estado when SemaGesta >= 27 && SemaGesta <= 45:

                            TxtEdadFum.Text = Math.Round(SemEntera + DiasSem, 1).ToString() + " Semanas (Trimestre No. 3 ) ";


                            break;
                        default:

                            Utils.Informa = "El sistema ha calculado " + SemaGesta + " semanas" + "\r";
                            Utils.Informa += "de gestación, pero no pudo definir el trimestre." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }

                }

            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error antes" + "\r";
                Utils.Informa = "de actualizar la fecha de la última menstruación" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #endregion

        #region Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.Titulo01 = "Control para GUARDAR datos";

                //*********************** Codigo asignado para la generación de consecutivos de ecografías en este sistema ************************

                string CodConseD = "28", T, H, M, UsaRegis, SqlRegEco, FunConEco, SqlBioFeto, ColCit = "";
                int ConoFum = 0, NFetos = 0, NFtol = 0;
                bool Insert;
                double NCEco;
                List<SqlParameter> parameters = new List<SqlParameter>();
                //Validamos datos

                if (string.IsNullOrWhiteSpace(TxtNumHistoEco.Text))
                {
                    Utils.Informa = "Lo siento pero usted aún no ha digitado el" + "\r";
                    Utils.Informa += "número de la historia clinica del usuario al" + "\r";
                    Utils.Informa += "cual quiere registrar los datos de una ecografía." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtNomUsaSin.Text))
                {
                    Utils.Informa = "Lo siento pero el número de historia digitado" + "\r";
                    Utils.Informa += "no corresponde a un nombre de usuario válido," + "\r";
                    Utils.Informa += "por lo tanto no se pueden registrar los datos." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Revisamos si el sexo del usuario

                if (string.IsNullOrWhiteSpace(TxtSexoSinAten.Text))
                {
                    Utils.Informa = "Lo siento pero el número de historia digitado" + "\r";
                    Utils.Informa += "no tiene definido el sexo, por lo tanto no se" + "\r";
                    Utils.Informa += "pueden registrar los datos." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CboEspecialidad1.SelectedIndex == -1)
                {
                    Utils.Informa = "Lo siento pero usted no ha seleccionado el" + "\r";
                    Utils.Informa += "nombre de la especialidad del profesional" + "\r";
                    Utils.Informa += "que realiza la toma de la ecografía," + "\r";
                    Utils.Informa += "por lo tanto no se pueden registrar los datos." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CboCodiMedi.SelectedIndex == -1)
                {
                    Utils.Informa = "Lo siento pero usted no ha seleccionado el nombre" + "\r";
                    Utils.Informa += "del profesional que realiza la toma de la ecografía," + "\r";
                    Utils.Informa += "por lo tanto no se pueden registrar los datos." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CboCodiAuxRegis.SelectedIndex == -1)
                {
                    Utils.Informa = "Lo siento pero usted no ha seleccionado el nombre" + "\r";
                    Utils.Informa += "del auxiliar que registra la toma de la ecografía," + "\r";
                    Utils.Informa += "por lo tanto no se pueden registrar los datos." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CboTipoEcoReal.SelectedIndex == -1)
                {
                    Utils.Informa = "Lo siento pero usted no ha seleccionado el" + "\r";
                    Utils.Informa += "tipo de ecografía a registrar, por lo tanto" + "\r";
                    Utils.Informa += "no se puede continuar con ell proceso." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Utils.SqlDatos = "SELECT CodEcoIps, NomEcogra, CodFacEco, SexApli FROM [DACONEXTSQL].[dbo].[Datos tipos de ecografias] WHERE RealizIPS = 'True' AND CodEcoIps = '" + CboTipoEcoReal.SelectedValue.ToString() + "'";

                SqlDataReader reader = Conexion.SQLDataReader(Utils.SqlDatos);

                if (reader.HasRows)
                {
                    reader.Read();

                    if (reader["SexApli"].ToString() == "A")
                    {
                        //NO se valida el sexo, porque es de ambos
                    }
                    else
                    {
                        if (reader["SexApli"].ToString() != TxtSexoSinAten.Text)
                        {
                            Utils.Informa = "Lo siento pero usted no puede registrar los datos" + "\r";
                            Utils.Informa += "de la ecografía " + CboTipoEcoReal.Text + "\r";
                            Utils.Informa += "al usuario " + TxtNomUsaSin.Text + "\r";
                            Utils.Informa += "ya que el sexo no es pertinente." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                if (Conexion.sqlConnection.State == ConnectionState.Open) Conexion.sqlConnection.Close();

                T = CboTipoEcoReal.SelectedValue.ToString();
                H = TxtNumHistoEco.Text;
                M = CboCodiMedi.SelectedValue.ToString();
                UsaRegis = lblCodigoUser.Text;


                //Revisamos que no se intente grabar una ecografía obstetrica temprana mayor 12 semanas y 5 dia

                switch (T)
                {
                    case "01":

                        if (CboConoceFUM.SelectedIndex == -1)
                        {
                            Utils.Informa = "Selecciona una opcion en FMU" + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            CboConoceFUM.Select();
                            return;
                        }

                        DateTime FecEnAten = DtFecTomaEco.Value;
                        ConoFum = CboConoceFUM.SelectedIndex;

                        if (ConoFum == 1)
                        {
                            DateTime FUMDig = DtFUMEco.Value;

                            double DiasTrascur = Math.Abs((FUMDig - FecEnAten).Days); //cuantos días han trancurrido hasta el día de hoy

                            double SemaGesta = Math.Round(DiasTrascur / 7, 1); //se divide en siete para presentar la información en semanas

                            int SemEntera = Convert.ToInt32(SemaGesta); //********************** a partir del 15 nov, Edad se muestra Semanas .Dias

                            double DiasSem = ((SemaGesta - SemEntera) * 7) / 10;

                            if (SemaGesta < 12)
                            {
                                Utils.Informa = "Lo siento pero usted no puede registrar una" + "\r";
                                Utils.Informa += "ecografía obstetrica, mientras el total de" + "\r";
                                Utils.Informa += "semanas transcurridos entre la FUM y la fecha" + "\r";
                                Utils.Informa += "de la atención sea menor a doce (12) semanas." + "\r";
                                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        //ConcluEcos

                        if (string.IsNullOrWhiteSpace(TxtConcluEcos.Text))
                        {
                            Utils.Informa = "Lo siento pero usted no puede registrar una" + "\r";
                            Utils.Informa += "ecografía obstetrica, si no ha registrado" + "\r";
                            Utils.Informa += "una conclusión." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TxtConcluEcos.Select();
                            return;
                        }

                        if (CboTipTranEco.SelectedIndex < 0)
                        {
                            Utils.Informa = "Lo siento pero usted no puede registrar una" + "\r";
                            Utils.Informa += "ecografía obstetrica, si no ha seleccionado" + "\r";
                            Utils.Informa += "un tipo de frecuencia." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            CboPresenta01.Select();
                            return;
                        }




                        break;

                    case "02": //Obstetrica pelvica
                        break;
                    case string estado when estado == "03" || estado == "04": //Obstetrica temprana

                        if (CboConoceFUM03.SelectedIndex == -1)
                        {
                            Utils.Informa = "Selecciona una opcion en FMU" + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            CboConoceFUM03.Select();
                            return;
                        }

                        FecEnAten = DtFecTomaEco03.Value;
                        ConoFum = CboConoceFUM03.SelectedIndex;
                        if (ConoFum == 1)
                        {
                            DateTime FUMDig = DtFUMEco03.Value;

                            double DiasTrascur = Math.Abs((FUMDig - FecEnAten).Days); //cuantos días han trancurrido hasta el día de hoy

                            double SemaGesta = Math.Round(DiasTrascur / 7, 1); //se divide en siete para presentar la información en semanas

                            int SemEntera = Convert.ToInt32(SemaGesta); //********************** a partir del 15 nov, Edad se muestra Semanas .Dias

                            double DiasSem = ((SemaGesta - SemEntera) * 7) / 10;

                            if (SemaGesta < 12)
                            {
                                Utils.Informa = "Lo siento pero usted no puede registrar una" + "\r";
                                Utils.Informa += "ecografía obstetrica, mientras el total de" + "\r";
                                Utils.Informa += "semanas transcurridos entre la FUM y la fecha" + "\r";
                                Utils.Informa += "de la atención sea menor a doce (12) semanas." + "\r";
                                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        break;
                    case "11":

                        if (CboConoceFUM11.SelectedIndex == -1)
                        {
                            Utils.Informa = "Selecciona una opcion en FMU" + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            CboConoceFUM11.Select();
                            return;
                        }

                        break;

                    default:
                        break;
                }

                //Revisamos si el usuario tiene abierta una ecografía o no

                SqlRegEco = "SELECT * " +
                "FROM [DACONEXTSQL].[dbo].[Datos registros de ecografias]" +
                "Where TipoEco = '" + T + "' and NumHisEco = '" + H + "' and " +
                "CodMedECO = '" + M + "' and ArchivEco = 'False' and AnulEco = 'False'";


                SqlDataReader TabRegEco;

                using (SqlConnection connection2 = new SqlConnection(Conexion.conexionSQL))
                {
                    SqlCommand command2 = new SqlCommand(SqlRegEco, connection2);
                    command2.Connection.Open();
                    TabRegEco = command2.ExecuteReader();

                    if (TabRegEco.HasRows == false)
                    {
                        Utils.Informa = "¿Usted desea registrar una NUEVA ecografía" + "\r";
                        Utils.Informa += CboTipoEcoReal.Text + " al usuario(a)" + "\r";
                        Utils.Informa += TxtNomUsaSin.Text + "?" + "\r";
                        var res = MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (res == DialogResult.Yes)
                        {
                            //Buscamos el consecutivo de ecografías
                            //Proceda a buscar el número consecutivo de la ecografias y actualizar

                            FunConEco = ConsecutivoDocumen(CodConseD, true, UsaRegis);

                            switch (FunConEco)
                            {
                                case "-3":
                                    Utils.Informa = "Lo siento pero en esta base de datos no" + "\r";
                                    Utils.Informa += "se pueden registrar más ecografías," + "\r";
                                    Utils.Informa += "porque pasó la longitud permitida del código." + "\r";
                                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                case "-2":
                                    Utils.Informa = "Lo siento pero en esta base de datos no se" + "\r";
                                    Utils.Informa += "pueden registrar más más ecografías, porque" + "\r";
                                    Utils.Informa += "la fecha del último generado es mayor a la del sistema." + "\r";
                                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                case "1":
                                    //Error en la funcion
                                    break;
                                case "0":
                                    //NO se ha definido el tipo de documento para generar cuentas
                                    Utils.Informa = "Lo siento pero en esta base de datos no se" + "\r";
                                    Utils.Informa += "pueden generar el consecutivo de ecografías," + "\r";
                                    Utils.Informa += "porque el número de comprobante no se encuentra definido." + "\r";
                                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                default:

                                    //Puede empezar el proceso de registro de la ecografía, tome los posible datos que se han registrado en cada formulario
                                    //De acuerdo a cada tipo de ecografía

                                    switch (T)
                                    {
                                        case "01": //Ecografía obstetrica
                                            //Muestre el número generado

                                            TxtEcoNumForm.Text = FunConEco;

                                            Utils.SqlDatos = "INSERT INTO [DACONEXTSQL].[dbo].[Datos registros de ecografias]" +
                                            "(" +
                                            "NumEcogra," +
                                            "TipoEco," +
                                            "Numaten," +
                                            "NumFactu," +
                                            "NumHisEco," +
                                            "FecRealECO," +
                                            "TransFrec," +
                                            "SeConoFUM," +
                                            "FUMEco," +
                                            "EdadGesFum," +
                                            "FPPFUM," +
                                            "NumFetos," +
                                            "Utero," +
                                            "Placenta," +
                                            "GraMaPla," +
                                            "EspePlace," +
                                            "NumSemECO," +
                                            "NumDiasECO," +
                                            "FPPEco," +
                                            "ConclusECO," +
                                            "CodMedECO," +
                                            "CodAuxECO," +
                                            "ArchivEco," +
                                            "CodRegis," +
                                            "FecRegis," +
                                            "FecModi," +
                                            "CodModi" +
                                            ")" +
                                            "VALUES" +
                                            "(" +
                                            "'" + FunConEco + "'," +
                                            "'" + T + "'," +
                                            "'" + TxtAtenNumEco.Text + "'," +
                                            "'" + TxtFactConsul.Text + "'," +
                                            "'" + TxtNumHistoEco.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFecTomaEco.Value.ToString())}" +
                                            "'" + CboTipTranEco.SelectedValue + "'," +
                                            "'" + CboConoceFUM.SelectedIndex + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFUMEco.Value.ToString())}" +
                                            "'" + TxtEdadFum.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFPPFUM.Value.ToString())}" +
                                            "'" + TxtNumFetosECO.Text + "'," +
                                            "'" + TxtDesUteroEco.Text + "'," +
                                            "'" + CboPlacenECO.SelectedValue + "'," +
                                            "'" + CboGradoMadECO.Text + "'," +
                                            "'" + TxtEspePlace.Value + "'," +
                                            "'" + TxtNumSemECO.Text + "'," +
                                            "'" + TxtNumDiasECO.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFFPECO.Value.ToString())}" +
                                            "'" + TxtConcluEcos.Text + "'," +
                                            "'" + CboCodiMedi.SelectedValue + "'," +
                                            "'" + CboCodiAuxRegis.SelectedValue + "'," +
                                            "'False'," +
                                            "'" + UsaRegis + "'," +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            "'" + UsaRegis + "'" +
                                            ")";


                                            Insert = Conexion.SqlInsert(Utils.SqlDatos);

                                            //Procedemos a agregar la biometria de los fetos

                                            NFetos = Convert.ToInt32(TxtNumFetosECO.Text);

                                            NFtol = 1;

                                            while (NFetos > 0)
                                            {
                                                SqlBioFeto = "SELECT NumEcoFeto, FetoNum, Presentacion, Situacion, Posicion, MovCardiacos, TotaPunt, ";
                                                SqlBioFeto = SqlBioFeto + "MovRespiratorios, MovFetales, TonoFetal, ILAFeto, CordonUmbi, SexFeto, ";
                                                SqlBioFeto = SqlBioFeto + "DBPFeto, HCFeto, ACFeto, LFFeto, PesoFeto, FCFFeto ";
                                                SqlBioFeto = SqlBioFeto + "FROM [DACONEXTSQL].[dbo].[Datos biometria de los fetos] ";
                                                SqlBioFeto = SqlBioFeto + "WHERE  NumEcoFeto = '" + FunConEco + "' AND FetoNum = " + NFtol;

                                                SqlDataReader TabBioFeto;

                                                using (SqlConnection connection = new SqlConnection(Conexion.conexionSQL))
                                                {
                                                    SqlCommand command = new SqlCommand(SqlBioFeto, connection);
                                                    command.Connection.Open();
                                                    TabBioFeto = command.ExecuteReader();


                                                    if (TabBioFeto.HasRows == false)
                                                    {
                                                        Utils.SqlDatos = "INSERT INTO [DACONEXTSQL].[dbo].[Datos biometria de los fetos] (NumEcoFeto, FetoNum, Presentacion, Situacion, Posicion, MovCardiacos, MovRespiratorios, MovFetales, TonoFetal, ILAFeto, CordonUmbi, SexFeto, DBPFeto, HCFeto, ACFeto,LFFeto, PesoFeto, FCFFeto) " +
                                                        "VALUES (@NumEcoFeto, @FetoNum,@Presentacion,@Situacion,@Posicion,@MovCardiacos,@MovRespiratorios,@MovFetales,@TonoFetal,@ILAFeto,@CordonUmbi,@SexFeto,@DBPFeto,@HCFeto,@ACFeto,@LFFeto,@PesoFeto,@FCFFeto)";

                                                        switch (NFtol)
                                                        {
                                                            case 1: //Agrega el primer feto


                                                                parameters = null;
                                                                parameters = new List<SqlParameter>
                                                                {
                                                                new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                new SqlParameter("@FetoNum", SqlDbType.Int){ Value = NFtol},
                                                                new SqlParameter("@Presentacion", SqlDbType.VarChar){ Value = CboPresenta01.Text},
                                                                new SqlParameter("@Situacion", SqlDbType.VarChar){ Value = TxtSituacion01.Text},
                                                                new SqlParameter("@Posicion", SqlDbType.VarChar){ Value = CboPosicion01.Text},
                                                                new SqlParameter("@MovCardiacos", SqlDbType.VarChar){ Value = TxtMovCardi01.Text},
                                                                new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovRespi01.Text},
                                                                new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMoviFeta01.Text},
                                                                new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoFetal01.Text},
                                                                new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtLiquiAm01.Text},
                                                                new SqlParameter("@CordonUmbi", SqlDbType.VarChar){ Value = TxtCordon01.Text},
                                                                new SqlParameter("@SexFeto", SqlDbType.VarChar){ Value = CboSexFeto01.Text},
                                                                new SqlParameter("@DBPFeto", SqlDbType.Int){ Value = TxtBDP01.Text},
                                                                new SqlParameter("@HCFeto", SqlDbType.Int){ Value = TxtHC01.Text},
                                                                new SqlParameter("@ACFeto", SqlDbType.Int){ Value = TxtAC01.Text},
                                                                new SqlParameter("@LFFeto", SqlDbType.Int){ Value = TxtLF01.Text},
                                                                new SqlParameter("@PesoFeto", SqlDbType.Int){ Value = TxtPeso01.Text},
                                                                new SqlParameter("@FCFFeto", SqlDbType.Int){ Value = TxtFCFFeto01.Text},
                                                                };

                                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);


                                                                break;
                                                            case 2:

                                                                parameters = null;

                                                                parameters = new List<SqlParameter>
                                                            {
                                                                new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                new SqlParameter("@Presentacion", SqlDbType.VarChar){ Value = CboPresenta02.Text},
                                                                new SqlParameter("@Situacion", SqlDbType.VarChar){ Value = TxtSituacion02.Text},
                                                                new SqlParameter("@Posicion", SqlDbType.VarChar){ Value = CboPosicion02.Text},
                                                                new SqlParameter("@MovCardiacos", SqlDbType.VarChar){ Value = TxtMovCardi02.Text},
                                                                new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovRespi02.Text},
                                                                new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMoviFeta02.Text},
                                                                new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoFetal02.Text},
                                                                new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtLiquiAm02.Text},
                                                                new SqlParameter("@CordonUmbi", SqlDbType.VarChar){ Value = TxtCordon02.Text},
                                                                new SqlParameter("@SexFeto", SqlDbType.VarChar){ Value = CboSexFeto02.Text},
                                                                new SqlParameter("@DBPFeto", SqlDbType.SmallInt){ Value = TxtBDP02.Text},
                                                                new SqlParameter("@HCFeto", SqlDbType.SmallInt){ Value = TxtHC02.Text},
                                                                new SqlParameter("@ACFeto", SqlDbType.SmallInt){ Value = TxtAC02.Text},
                                                                new SqlParameter("@LFFeto", SqlDbType.SmallInt){ Value = TxtLF02.Text},
                                                                new SqlParameter("@PesoFeto", SqlDbType.VarChar){ Value = TxtPeso02.Text},
                                                                new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCFFeto02.Text},
                                                            };

                                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                                break;
                                                            case 3:

                                                                parameters = null;

                                                                parameters = new List<SqlParameter>
                                                            {
                                                                new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                new SqlParameter("@Presentacion", SqlDbType.VarChar){ Value = CboPresenta03.Text},
                                                                new SqlParameter("@Situacion", SqlDbType.VarChar){ Value = TxtSituacion03.Text},
                                                                new SqlParameter("@Posicion", SqlDbType.VarChar){ Value = CboPosicion03.Text},
                                                                new SqlParameter("@MovCardiacos", SqlDbType.VarChar){ Value = TxtMovCardi03.Text},
                                                                new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovRespi03.Text},
                                                                new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMoviFeta03.Text},
                                                                new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoFetal03.Text},
                                                                new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtLiquiAm03.Text},
                                                                new SqlParameter("@CordonUmbi", SqlDbType.VarChar){ Value = TxtCordon03.Text},
                                                                new SqlParameter("@SexFeto", SqlDbType.VarChar){ Value = CboSexFeto03.Text},
                                                                new SqlParameter("@DBPFeto", SqlDbType.SmallInt){ Value = TxtBDP03.Text},
                                                                new SqlParameter("@HCFeto", SqlDbType.SmallInt){ Value = TxtHC03.Text},
                                                                new SqlParameter("@ACFeto", SqlDbType.SmallInt){ Value = TxtAC03.Text},
                                                                new SqlParameter("@LFFeto", SqlDbType.SmallInt){ Value = TxtLF03.Text},
                                                                new SqlParameter("@PesoFeto", SqlDbType.VarChar){ Value = TxtPeso03.Text},
                                                                new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCFFeto03.Text},
                                                            };

                                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);


                                                                break;

                                                            case 4:

                                                                parameters = null;

                                                                parameters = new List<SqlParameter>
                                                            {
                                                                 new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                new SqlParameter("@Presentacion", SqlDbType.VarChar){ Value = CboPresenta04.Text},
                                                                new SqlParameter("@Situacion", SqlDbType.VarChar){ Value = TxtSituacion04.Text},
                                                                new SqlParameter("@Posicion", SqlDbType.VarChar){ Value = CboPosicion04.Text},
                                                                new SqlParameter("@MovCardiacos", SqlDbType.VarChar){ Value = TxtMovCardi04.Text},
                                                                new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovRespi04.Text},
                                                                new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMoviFeta04.Text},
                                                                new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoFetal04.Text},
                                                                new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtLiquiAm04.Text},
                                                                new SqlParameter("@CordonUmbi", SqlDbType.VarChar){ Value = TxtCordon04.Text},
                                                                new SqlParameter("@SexFeto", SqlDbType.VarChar){ Value = CboSexFeto04.Text},
                                                                new SqlParameter("@DBPFeto", SqlDbType.SmallInt){ Value = TxtBDP04.Text},
                                                                new SqlParameter("@HCFeto", SqlDbType.SmallInt){ Value = TxtHC04.Text},
                                                                new SqlParameter("@ACFeto", SqlDbType.SmallInt){ Value = TxtAC04.Text},
                                                                new SqlParameter("@LFFeto", SqlDbType.SmallInt){ Value = TxtLF04.Text},
                                                                new SqlParameter("@PesoFeto", SqlDbType.VarChar){ Value = TxtPeso04.Text},
                                                                new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCFFeto04.Text},
                                                            };

                                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);


                                                                break;


                                                            case 5:



                                                                parameters = null;

                                                                parameters = new List<SqlParameter>
                                                            {
                                                                new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                new SqlParameter("@Presentacion", SqlDbType.VarChar){ Value = CboPresenta05.Text},
                                                                new SqlParameter("@Situacion", SqlDbType.VarChar){ Value = TxtSituacion05.Text},
                                                                new SqlParameter("@Posicion", SqlDbType.VarChar){ Value = CboPosicion05.Text},
                                                                new SqlParameter("@MovCardiacos", SqlDbType.VarChar){ Value = TxtMovCardi05.Text},
                                                                new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovRespi05.Text},
                                                                new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMoviFeta05.Text},
                                                                new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoFetal05.Text},
                                                                new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtLiquiAm05.Text},
                                                                new SqlParameter("@CordonUmbi", SqlDbType.VarChar){ Value = TxtCordon05.Text},
                                                                new SqlParameter("@SexFeto", SqlDbType.VarChar){ Value = CboSexFeto05.Text},
                                                                new SqlParameter("@DBPFeto", SqlDbType.SmallInt){ Value = TxtBDP05.Text},
                                                                new SqlParameter("@HCFeto", SqlDbType.SmallInt){ Value = TxtHC05.Text},
                                                                new SqlParameter("@ACFeto", SqlDbType.SmallInt){ Value = TxtAC05.Text},
                                                                new SqlParameter("@LFFeto", SqlDbType.SmallInt){ Value = TxtLF05.Text},
                                                                new SqlParameter("@PesoFeto", SqlDbType.VarChar){ Value = TxtPeso05.Text},
                                                                new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCFFeto05.Text},
                                                            };

                                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                                break;

                                                            default:
                                                                break;
                                                        }
                                                    }
                                                }

                                                NFtol += 1;
                                                NFetos -= 1;
                                            }

                                            //Defina que la eco se esta realizando, cambie de color cita programada


                                            if (string.IsNullOrWhiteSpace(TxtNumCitaProgra.Text) || Convert.ToInt32(TxtNumCitaProgra.Text) == 0)
                                            {
                                                //'No hace nada
                                            }
                                            else
                                            {
                                                NCEco = Convert.ToDouble(TxtNumCitaProgra.Text);

                                                ColCit = "006";  //Esta en atención, Color amarillo

                                                ActualizarCita(H, NCEco, ColCit);


                                            }

                                            Utils.Informa = "Los datos de la ecografía han sido grabado satisfactoriamente." + "\r";
                                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            break;

                                        case string estado when estado == "02" || estado == "10" || estado == "12":

                                            TxtEcoNumForm02.Text = FunConEco;


                                            Utils.SqlDatos = "INSERT INTO [DACONEXTSQL].[dbo].[Datos registros de ecografias]" +
                                            "(" +
                                            "NumEcogra," +
                                            "TipoEco," +
                                            "Numaten," +
                                            "NumFactu," +
                                            "NumHisEco," +
                                            "FecRealECO," +
                                            "TransFrec," +
                                            "SeConoFUM," +
                                            "FUMEco," +
                                            "EdadGesFum," +
                                            "FPPFUM," +
                                            "Utero," +
                                            "DiamLongi," +
                                            "DiamAntePos," +
                                            "DiamTras," +
                                            "Endometrio," +
                                            "DesEndometrio," +
                                            "OvarioDere," +
                                            "PorOvarioDere," +
                                            "OvarioIzquie," +
                                            "PorOvarioIzqui," +
                                            "Comenta," +
                                            "ConclusECO," +
                                            "CodMedECO," +
                                            "CodAuxECO," +
                                            "ArchivEco," +
                                            "CodRegis," +
                                            "FecRegis," +
                                            "FecModi," +
                                            "CodModi" +
                                            ")" +
                                            "VALUES" +
                                            "(" +
                                            "'" + FunConEco + "'," +
                                            "'" + T + "'," +
                                            "'" + TxtAtenNumEco.Text + "'," +
                                            "'" + TxtFactConsul.Text + "'," +
                                            "'" + TxtNumHistoEco.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFecTomaEco02.Value.ToString())}" +
                                            "'" + CboTipTranEco02.SelectedValue + "'," +
                                            "'" + CboConoceFUM02.SelectedIndex + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFUMEco02.Value.ToString())}" +
                                            "'" + TxtEdadFum02.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFPPFUM02.Value.ToString())}" +
                                            "'" + TxtDesUteroEco02.Text + "'," +
                                            "'" + TxtDiameLongi02.Text + "'," +
                                            "'" + TxtDiameAntePos02.Text + "'," +
                                            "'" + TxtDiameTras02.Text + "'," +
                                            "'" + TxtEndome02.Text + "'," +
                                            "'" + TxtDesEndome02.Text + "'," +
                                            "'" + TxtOvariDere02.Text + "'," +
                                            "'" + TxtPorOvariDere02.Text + "'," +
                                            "'" + TxtOvariIzquie02.Text + "'," +
                                            "'" + TxtPorOvariIzqui02.Text + "'," +
                                            "'" + TxtComentario02.Text + "'," +
                                            "'" + TxtConcluEcos02.Text + "'," +
                                            "'" + CboCodiMedi.SelectedValue + "'," +
                                            "'" + CboCodiAuxRegis.SelectedValue + "'," +
                                            "'False'," +
                                            "'" + UsaRegis + "'," +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            "'" + UsaRegis + "'" +
                                            ")";


                                            Insert = Conexion.SqlInsert(Utils.SqlDatos);

                                            //Defina que la eco se esta realizando, cambie de color cita programada

                                            if (string.IsNullOrWhiteSpace(TxtNumCitaProgra.Text) || Convert.ToInt32(TxtNumCitaProgra.Text) == 0)
                                            {
                                                //No hace nada
                                            }
                                            else
                                            {
                                                NCEco = Convert.ToDouble(TxtNumCitaProgra.Text);
                                                ColCit = "006";

                                                ActualizarCita(H, NCEco, ColCit);

                                            }


                                            if(T == "02")
                                            {
                                                Utils.Informa = "Los datos de la ecografía pelvica han sido grabado satisfactoriamente." + "\r";
                                                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }

                                            if(T == "10")
                                            {
                                                Utils.Informa = "Los datos de la ecografía obstetrica transvaginal han sido grabado satisfactoriamente." + "\r";
                                                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }

                                            if(T == "12")
                                            {
                                                Utils.Informa = "Los datos de la ecografía pelvica han sido grabado satisfactoriamente." + "\r";
                                                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }


                                            break;


                                        case string estado when estado == "03" || estado == "04":


                                            TxtEcoNumForm03.Text = FunConEco.ToString();

                                            Utils.SqlDatos = "INSERT INTO [DACONEXTSQL].[dbo].[Datos registros de ecografias]" +
                                            "(" +
                                            "NumEcogra," +
                                            "TipoEco," +
                                            "Numaten," +
                                            "NumFactu," +
                                            "NumHisEco," +
                                            "FecRealECO," +
                                            "TransFrec," +
                                            "SeConoFUM," +
                                            "FUMEco," +
                                            "EdadGesFum," +
                                            "FPPFUM," +
                                            "NumFetos," +
                                            "Utero," +
                                            "CervixEsta," +
                                            "NumSemECO," +
                                            "NumDiasECO," +
                                            "FPPEco," +
                                            "ConclusECO," +
                                            "CodMedECO," +
                                            "CodAuxECO," +
                                            "ArchivEco," +
                                            "CodRegis," +
                                            "FecRegis," +
                                            "FecModi," +
                                            "CodModi" +
                                            ")" +
                                            "VALUES" +
                                            "(" +
                                            "'" + FunConEco + "'," +
                                            "'" + T + "'," +
                                            "'" + TxtAtenNumEco.Text + "'," +
                                            "'" + TxtFactConsul.Text + "'," +
                                            "'" + TxtNumHistoEco.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFecTomaEco03.Value.ToString())}" +
                                            "'" + CboTipTranEco03.SelectedValue + "'," +
                                            "'" + CboConoceFUM03.SelectedIndex + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFUMEco03.Value.ToString())}" +
                                            "'" + TxtEdadFum03.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFPPFUM03.Value.ToString())}" +
                                            "'" + TxtNumFetosECO03.Text + "'," +
                                            "'" + TxtDesUteroEco03.Text + "'," +
                                            "'" + TxtCervixCerra.Text + "'," +
                                            "'" + TxtNumSemECO03.Text + "'," +
                                            "'" + TxtNumDiasECO03.Text + "'," +
                                             $"{Conexion.ValidarFechaNula(DtFFPECO03.Value.ToString())}" +
                                            "'" + TxtConcluEcos03.Text + "'," +
                                            "'" + CboCodiMedi.SelectedValue + "'," +
                                            "'" + CboCodiAuxRegis.SelectedValue + "'," +
                                            "'False'," +
                                            "'" + UsaRegis + "'," +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            "'" + UsaRegis + "'" +
                                            ")";

                                            Insert = Conexion.SqlInsert(Utils.SqlDatos);

                                            //Procedemos a agregar la biometria de los fetos


                                            NFetos = Convert.ToInt32(TxtNumFetosECO03.Text);
                                            NFtol = 1;


                                            while (NFetos > 0)
                                            {

                                                SqlBioFeto = "SELECT NumEcoFeto, FetoNum, Presentacion, Situacion, Posicion, MovCardiacos, TotaPunt, ";
                                                SqlBioFeto = SqlBioFeto + "MovRespiratorios, MovFetales, TonoFetal, ILAFeto, CordonUmbi, SexFeto, SacoGesta, ";
                                                SqlBioFeto = SqlBioFeto + "VesiVitelina, BotonEmbriona, DBPFeto, LCN, HCFeto, ACFeto, LFFeto, PesoFeto, FCFFeto ";
                                                SqlBioFeto = SqlBioFeto + "FROM [DACONEXTSQL].[dbo].[Datos biometria de los fetos] ";
                                                SqlBioFeto = SqlBioFeto + "WHERE  NumEcoFeto = '" + FunConEco + "' AND FetoNum = " + NFtol;

                                                SqlDataReader TabBioFeto;

                                                using (SqlConnection connection = new SqlConnection(Conexion.conexionSQL))
                                                {
                                                    SqlCommand command = new SqlCommand(SqlBioFeto, connection);
                                                    command.Connection.Open();
                                                    TabBioFeto = command.ExecuteReader();

                                                    if (TabBioFeto.HasRows == false)
                                                    {

                                                        Utils.SqlDatos = "INSERT [DACONEXTSQL].[dbo].[Datos biometria de los fetos] (NumEcoFeto,FetoNum,FCFFeto,SacoGesta,VesiVitelina,BotonEmbriona,LCN) ";
                                                        Utils.SqlDatos += "VALUES (@NumEcoFeto,@FetoNum,@FCFFeto,@SacoGesta,@VesiVitelina,@BotonEmbriona,@LCN)";

                                                        switch (NFtol)
                                                        {
                                                            case 1:

                                                                parameters = null;

                                                                parameters = new List<SqlParameter>
                                                                {

                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCF01.Text},
                                                                    new SqlParameter("@SacoGesta", SqlDbType.VarChar){ Value = TxtSacoGes01.Text},
                                                                    new SqlParameter("@VesiVitelina", SqlDbType.VarChar){ Value = TxtVesiVitelina01.Text},
                                                                    new SqlParameter("@BotonEmbriona", SqlDbType.VarChar){ Value = TxtBotonEmbriona01.Text},
                                                                    new SqlParameter("@LCN", SqlDbType.VarChar){ Value = TxtLCN01.Text},

                                                                };

                                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);


                                                                break;

                                                            case 2:

                                                                parameters = null;

                                                                parameters = new List<SqlParameter>
                                                                {

                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCF02.Text},
                                                                    new SqlParameter("@SacoGesta", SqlDbType.VarChar){ Value = TxtSacoGes02.Text},
                                                                    new SqlParameter("@VesiVitelina", SqlDbType.VarChar){ Value = TxtVesiVitelina02.Text},
                                                                    new SqlParameter("@BotonEmbriona", SqlDbType.VarChar){ Value = TxtBotonEmbriona02.Text},
                                                                    new SqlParameter("@LCN", SqlDbType.VarChar){ Value = TxtLCN02.Text},

                                                                };

                                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                                break;


                                                            case 3:

                                                                parameters = null;

                                                                parameters = new List<SqlParameter>
                                                                {

                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCF03.Text},
                                                                    new SqlParameter("@SacoGesta", SqlDbType.VarChar){ Value = TxtSacoGes03.Text},
                                                                    new SqlParameter("@VesiVitelina", SqlDbType.VarChar){ Value = TxtVesiVitelina03.Text},
                                                                    new SqlParameter("@BotonEmbriona", SqlDbType.VarChar){ Value = TxtBotonEmbriona03.Text},
                                                                    new SqlParameter("@LCN", SqlDbType.VarChar){ Value = TxtLCN03.Text},

                                                                };

                                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                                break;

                                                            case 4:

                                                                parameters = null;

                                                                parameters = new List<SqlParameter>
                                                                {

                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCF04.Text},
                                                                    new SqlParameter("@SacoGesta", SqlDbType.VarChar){ Value = TxtSacoGes04.Text},
                                                                    new SqlParameter("@VesiVitelina", SqlDbType.VarChar){ Value = TxtVesiVitelina04.Text},
                                                                    new SqlParameter("@BotonEmbriona", SqlDbType.VarChar){ Value = TxtBotonEmbriona04.Text},
                                                                    new SqlParameter("@LCN", SqlDbType.VarChar){ Value = TxtLCN04.Text},

                                                                };

                                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                                break;

                                                            case 5:

                                                                parameters = null;

                                                                parameters = new List<SqlParameter>
                                                                {

                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = TxtFCF05.Text},
                                                                    new SqlParameter("@SacoGesta", SqlDbType.VarChar){ Value = TxtSacoGes05.Text},
                                                                    new SqlParameter("@VesiVitelina", SqlDbType.VarChar){ Value = TxtVesiVitelina05.Text},
                                                                    new SqlParameter("@BotonEmbriona", SqlDbType.VarChar){ Value = TxtBotonEmbriona05.Text},
                                                                    new SqlParameter("@LCN", SqlDbType.VarChar){ Value = TxtLCN05.Text},

                                                                };

                                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                                break;

                                                            default:
                                                                break;
                                                        }// SWICH
                                                    }//TabBio
                                                }//Usiog

                                                NFtol += 1;
                                                NFetos -= 1;

                                            }//While

                                            //Defina que la eco se esta realizando, cambie de color cita programada


                                            if (string.IsNullOrWhiteSpace(TxtNumCitaProgra.Text) || Convert.ToInt32(TxtNumCitaProgra.Text) == 0)
                                            {
                                                //No hace nada
                                            }
                                            else
                                            {
                                                NCEco = Convert.ToDouble(TxtNumCitaProgra.Text);
                                                ColCit = "006";

                                                ActualizarCita(H, NCEco, ColCit);

                                            }

                                            Utils.Informa = "Los datos de la ecografía han sido grabado satisfactoriamente." + "\r";
                                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            break;

                                        case string estado when T == "05" || T == "07":

                                            TxtEcoNumForm05.Text = FunConEco;

                                            Utils.SqlDatos = "INSERT INTO [DACONEXTSQL].[dbo].[Datos registros de ecografias]" +
                                            "(" +
                                            "NumEcogra," +
                                            "TipoEco," +
                                            "Numaten," +
                                            "NumFactu," +
                                            "NumHisEco," +
                                            "FecRealECO," +
                                            "TransFrec," +
                                            "HigaAbdEco," +
                                            "VesicuAbdEco," +
                                            "PancreAbdEco," +
                                            "BazoAdbEco," +
                                            "RinonAbdEco," +
                                            "ConclusECO," +
                                            "CodMedECO," +
                                            "CodAuxECO," +
                                            "ArchivEco," +
                                            "CodRegis," +
                                            "FecRegis," +
                                            "FecModi," +
                                            "CodModi" +
                                            ")" +
                                            "VALUES" +
                                            "(" +
                                            "'" + FunConEco + "'," +
                                            "'" + T + "'," +
                                            "'" + TxtAtenNumEco.Text + "'," +
                                            "'" + TxtFactConsul.Text + "'," +
                                            "'" + TxtNumHistoEco.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFecTomaEco05.Value.ToString())}" +
                                            "'" + CboTipTranEco05.SelectedValue + "'," +
                                            "'" + TxtHigadoEco05.Text + "'," +
                                            "'" + TxtVesiculaEco05.Text + "'," +
                                            "'" + TxtPancreasEco05.Text + "'," +
                                            "'" + TxtBazoEco05.Text + "'," +
                                            "'" + txtRinonEco05.Text + "'," +
                                            "'" + TxtComentario05.Text + "'," +
                                            "'" + CboCodiMedi.SelectedValue + "'," +
                                            "'" + CboCodiAuxRegis.SelectedValue + "'," +
                                            "'False'," +
                                            "'" + UsaRegis + "'," +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            "'" + UsaRegis + "'" +
                                            ")";


                                            Insert = Conexion.SqlInsert(Utils.SqlDatos);


                                            //Defina que la eco se esta realizando, cambie de color cita programada


                                            if (string.IsNullOrWhiteSpace(TxtNumCitaProgra.Text) || Convert.ToInt32(TxtNumCitaProgra.Text) == 0)
                                            {
                                                //No hace nada
                                            }
                                            else
                                            {
                                                NCEco = Convert.ToDouble(TxtNumCitaProgra.Text);
                                                ColCit = "006";

                                                ActualizarCita(H, NCEco, ColCit);

                                            }

                                            if(T == "5")
                                            {
                                                Utils.Informa = "Los datos de la ecografía abdominal han sido grabado satisfactoriamente." + "\r";
                                                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                            {
                                                Utils.Informa = "Los datos de la ecografía hepatobiliar han sido grabado satisfactoriamente." + "\r";
                                                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }



                                            break;

                                        case "06":

                                            TxtEcoNumForm06.Text = FunConEco;

                                            Utils.SqlDatos = "INSERT INTO [DACONEXTSQL].[dbo].[Datos registros de ecografias]" +
                                            "(" +
                                            "NumEcogra," +
                                            "TipoEco," +
                                            "Numaten," +
                                            "NumFactu," +
                                            "NumHisEco," +
                                            "FecRealECO," +
                                            "TransFrec," +
                                            "FormaRiDere," +
                                            "DiamRinDer," +
                                            "DiamAntRinDer," +
                                            "DiamTraRinDer," +
                                            "DiamEpRinDer," +
                                            "ObserRinDere," +
                                            "FormaRinIzq," +
                                            "DiamRinIzq," +
                                            "DiamAntRinIzq," +
                                            "DiamTraRinIzq," +
                                            "DiamEpRinIzq," +
                                            "ObserRinIzquie," +
                                            "Comenta," +
                                            "ConclusECO," +
                                            "CodMedECO," +
                                            "CodAuxECO," +
                                            "ArchivEco," +
                                            "CodRegis," +
                                            "FecRegis," +
                                            "FecModi," +
                                            "CodModi" +
                                            ")" +
                                            "VALUES" +
                                            "(" +
                                            "'" + FunConEco + "'," +
                                            "'" + T + "'," +
                                            "'" + TxtAtenNumEco.Text + "'," +
                                            "'" + TxtFactConsul.Text + "'," +
                                            "'" + TxtNumHistoEco.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFecTomaEco06.Value.ToString())}" +
                                            "'" + CboTipTranEco06.SelectedValue + "'," +
                                            "'" + TxtFormaRiDerecho06.Text + "'," +
                                            "'" + TxtDiamRinDerecho06.Text + "'," +
                                            "'" + TxtDiamAntRinDerecho06.Text + "'," +
                                            "'" + TxtDiamTraRinDerecho06.Text + "'," +
                                            "'" + TxtDiamEpRinDerecho06.Text + "'," +
                                            "'" + TxtObservaRinDerecho06.Text + "'," +
                                            "'" + TxtFormaRinIzquie06.Text + "'," +
                                            "'" + TxtDiamRinIzquie06.Text + "'," +
                                            "'" + TxtDiamAntRinIzquie06.Text + "'," +
                                            "'" + TxtDiamTraRinIzquie06.Text + "'," +
                                            "'" + TxtDiamEpRinIzquie06.Text + "'," +
                                            "'" + TxtObservaRinIzquie06.Text + "'," +
                                            "'" + TxtComentario06.Text + "'," +
                                            "'" + TxtConcluEcos06.Text + "'," +
                                            "'" + CboCodiMedi.SelectedValue + "'," +
                                            "'" + CboCodiAuxRegis.SelectedValue + "'," +
                                            "'False'," +
                                            "'" + UsaRegis + "'," +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            "'" + UsaRegis + "'" +
                                            ")";


                                            Insert = Conexion.SqlInsert(Utils.SqlDatos);


                                            //Defina que la eco se esta realizando, cambie de color cita programada


                                            if (string.IsNullOrWhiteSpace(TxtNumCitaProgra.Text) || Convert.ToInt32(TxtNumCitaProgra.Text) == 0)
                                            {
                                                //No hace nada
                                            }
                                            else
                                            {
                                                NCEco = Convert.ToDouble(TxtNumCitaProgra.Text);
                                                ColCit = "006";

                                                ActualizarCita(H, NCEco, ColCit);

                                            }

                                            Utils.Informa = "Los datos de la ecografía renal bilateral han sido grabado satisfactoriamente." + "\r";
                                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);


                                            break;

                                        case "09":

                                            //Se hace con el formulario 7 ya que anterior mente 7 y 9 eran iguales pero ya no. 

                                            TxtEcoNumForm07.Text = FunConEco;

                                            Utils.SqlDatos = "INSERT INTO [DACONEXTSQL].[dbo].[Datos registros de ecografias]" +
                                            "(" +
                                            "NumEcogra," +
                                            "TipoEco," +
                                            "Numaten," +
                                            "NumFactu," +
                                            "NumHisEco," +
                                            "FecRealECO," +
                                            "TransFrec," +
                                            "HigaAbdEco," +
                                            "VesicuAbdEco," +
                                            "PancreAbdEco," +
                                            "ConclusECO," +
                                            "CodMedECO," +
                                            "CodAuxECO," +
                                            "ArchivEco," +
                                            "CodRegis," +
                                            "FecRegis," +
                                            "FecModi," +
                                            "CodModi" +
                                            ")" +
                                            "VALUES" +
                                            "(" +
                                            "'" + FunConEco + "'," +
                                            "'" + T + "'," +
                                            "'" + TxtAtenNumEco.Text + "'," +
                                            "'" + TxtFactConsul.Text + "'," +
                                            "'" + TxtNumHistoEco.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFecTomaEco07.Value.ToString())}" +
                                            "'" + CboTipTranEco07.SelectedValue + "'," +
                                            "'" + TxtHigadoEco07.Text + "'," +
                                            "'" + TxtVesiculaEco07.Text + "'," +
                                            "'" + TxtPancreasEco07.Text + "'," +
                                            "'" + TxtComentario07.Text + "'," +
                                            "'" + CboCodiMedi.SelectedValue + "'," +
                                            "'" + CboCodiAuxRegis.SelectedValue + "'," +
                                            "'False'," +
                                            "'" + UsaRegis + "'," +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            "'" + UsaRegis + "'" +
                                            ")";

                                            Insert = Conexion.SqlInsert(Utils.SqlDatos);


                                            //Defina que la eco se esta realizando, cambie de color cita programada


                                            if (string.IsNullOrWhiteSpace(TxtNumCitaProgra.Text) || Convert.ToInt32(TxtNumCitaProgra.Text) == 0)
                                            {
                                                //No hace nada
                                            }
                                            else
                                            {
                                                NCEco = Convert.ToDouble(TxtNumCitaProgra.Text);
                                                ColCit = "006";

                                                ActualizarCita(H, NCEco, ColCit);

                                            }

                        
                                                Utils.Informa = " Los datos de la ecografía abdominal superior han sido grabado satisfactoriamente." + "\r";
                                                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            


                                            break;

                                        case "08":

                                            TxtEcoNumForm08.Text = FunConEco;

                                            Utils.SqlDatos = "INSERT INTO [DACONEXTSQL].[dbo].[Datos registros de ecografias]" +
                                            "(" +
                                            "NumEcogra," +
                                            "TipoEco," +
                                            "Numaten," +
                                            "NumFactu," +
                                            "NumHisEco," +
                                            "FecRealECO," +
                                            "TransFrec," +
                                            "FormaRiDere," +
                                            "DiamRinDer," +
                                            "DiamAntRinDer," +
                                            "DiamTraRinDer," +
                                            "DiamEpRinDer," +
                                            "ObserRinDere," +
                                            "FormaRinIzq," +
                                            "DiamRinIzq," +
                                            "DiamAntRinIzq," +
                                            "DiamTraRinIzq," +
                                            "DiamEpRinIzq," +
                                            "ObserRinIzquie," +
                                            "AspecVeji," +
                                            "VoluPromVeji," +
                                            "ResiPostVeji," +
                                            "Comenta," +
                                            "ConclusECO," +
                                            "CodMedECO," +
                                            "CodAuxECO," +
                                            "ArchivEco," +
                                            "CodRegis," +
                                            "FecRegis," +
                                            "FecModi," +
                                            "CodModi" +
                                            ")" +
                                            "VALUES" +
                                            "(" +
                                            "'" + FunConEco + "'," +
                                            "'" + T + "'," +
                                            "'" + TxtAtenNumEco.Text + "'," +
                                            "'" + TxtFactConsul.Text + "'," +
                                            "'" + TxtNumHistoEco.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFecTomaEco08.Value.ToString())}" +
                                            "'" + CboTipTranEco08.SelectedValue + "'," +
                                            "'" + TxtFormaRiDerecho08.Text + "'," +
                                            "'" + TxtDiamRinDerecho08.Text + "'," +
                                            "'" + TxtDiamAntRinDerecho08.Text + "'," +
                                            "'" + TxtDiamTraRinDerecho08.Text + "'," +
                                            "'" + TxtDiamEpRinDerecho08.Text + "'," +
                                            "'" + TxtObservaRinDerecho08.Text + "'," +
                                            "'" + TxtFormaRinIzquie08.Text + "'," +
                                            "'" + TxtDiamRinIzquie08.Text + "'," +
                                            "'" + TxtDiamAntRinIzquie08.Text + "'," +
                                            "'" + TxtDiamTraRinIzquie08.Text + "'," +
                                            "'" + TxtDiamEpRinIzquie08.Text + "'," +
                                            "'" + TxtObservaRinIzquie08.Text + "'," +
                                            "'" + TxtAspecVejiga08.Text + "'," +
                                            "'" + TxtVoluPromVejiga08.Text + "'," +
                                            "'" + TxtResiPostVejiga08.Text + "'," +
                                            "'" + TxtComentario08.Text + "'," +
                                            "'" + TxtConcluEcos08.Text + "'," +
                                            "'" + CboCodiMedi.SelectedValue + "'," +
                                            "'" + CboCodiAuxRegis.SelectedValue + "'," +
                                            "'False'," +
                                            "'" + UsaRegis + "'," +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            "'" + UsaRegis + "'" +
                                            ")";

                                            Insert = Conexion.SqlInsert(Utils.SqlDatos);



                                            //Defina que la eco se esta realizando, cambie de color cita programada


                                            if (string.IsNullOrWhiteSpace(TxtNumCitaProgra.Text) || Convert.ToInt32(TxtNumCitaProgra.Text) == 0)
                                            {
                                                //No hace nada
                                            }
                                            else
                                            {
                                                NCEco = Convert.ToDouble(TxtNumCitaProgra.Text);
                                                ColCit = "006";

                                                ActualizarCita(H, NCEco, ColCit);

                                            }

                                            Utils.Informa = "Los datos de la ecografía renal bilateral han sido grabado satisfactoriamente." + "\r";
                                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);


                                            break;

                                        case "11":

                                            TxtEcoNumForm11.Text = FunConEco;

                                            Utils.SqlDatos = "INSERT INTO [DACONEXTSQL].[dbo].[Datos registros de ecografias]" +
                                            "(" +
                                            "NumEcogra," +
                                            "TipoEco," +
                                            "Numaten," +
                                            "NumFactu," +
                                            "NumHisEco," +
                                            "FecRealECO," +
                                            "TransFrec," +
                                            "SeConoFUM," +
                                            "FUMEco," +
                                            "EdadGesFum," +
                                            "FPPFUM," +
                                            "NumFetos," +
                                            "ConclusECO," +
                                            "CodMedECO," +
                                            "CodAuxECO," +
                                            "ArchivEco," +
                                            "CodRegis," +
                                            "FecRegis," +
                                            "FecModi," +
                                            "CodModi" +
                                            ")" +
                                            "VALUES" +
                                            "(" +
                                            "'" + FunConEco + "'," +
                                            "'" + T + "'," +
                                            "'" + TxtAtenNumEco.Text + "'," +
                                            "'" + TxtFactConsul.Text + "'," +
                                            "'" + TxtNumHistoEco.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFecTomaEco11.Value.ToString())}" +
                                            "'" + CboTipTranEco11.SelectedValue + "'," +
                                            "'" + CboConoceFUM11.SelectedIndex + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFUMEco11.Value.ToString())}" +
                                            "'" + TxtEdadFum11.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFPPFUM11.Value.ToString())}" +
                                            "'" + TxtNumFetosECO11.Text + "'," +
                                            "'" + TxtConcluEcos11.Text + "'," +
                                            "'" + CboCodiMedi.SelectedValue + "'," +
                                            "'" + CboCodiAuxRegis.SelectedValue + "'," +
                                            "'False'," +
                                            "'" + UsaRegis + "'," +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            "'" + UsaRegis + "'" +
                                            ")";

                                            Insert = Conexion.SqlInsert(Utils.SqlDatos);

                                            //Procedemos a agregar la biometria de los fetos

                                            NFetos = Convert.ToInt32(TxtNumFetosECO11.Text);
                                            NFtol = 1;


                                            Utils.SqlDatos = "INSERT [DACONEXTSQL].[dbo].[Datos biometria de los fetos] (NumEcoFeto,FetoNum,FCFFeto,ILAFeto,TotaPunt,MovFetales,MovRespiratorios,TonoFetal,PuntajeILA,PuntajeMovFet,PuntajeMovRes,PuntajeTonMusc) ";
                                            Utils.SqlDatos += "VALUES (@NumEcoFeto,@FetoNum,@FCFFeto,@ILAFeto,@TotaPunt,@MovFetales,@MovRespiratorios,@TonoFetal,@PuntajeILA,@PuntajeMovFet,@PuntajeMovRes,@PuntajeTonMusc)";


                                            while (NFetos > 0)
                                            {
                                                SqlBioFeto = "SELECT NumEcoFeto, FetoNum, Presentacion, Situacion, Posicion, MovCardiacos, TotaPunt, ";
                                                SqlBioFeto = SqlBioFeto + "MovRespiratorios, MovFetales, TonoFetal, ILAFeto, CordonUmbi, SexFeto, SacoGesta, ";
                                                SqlBioFeto = SqlBioFeto + "VesiVitelina, BotonEmbriona, DBPFeto, LCN, HCFeto, ACFeto, LFFeto, PesoFeto, FCFFeto, ";
                                                SqlBioFeto = SqlBioFeto + "PuntajeILA, PuntajeMovFet, PuntajeMovRes, PuntajeTonMusc ";
                                                SqlBioFeto = SqlBioFeto + "FROM [DACONEXTSQL].[dbo].[Datos biometria de los fetos] ";
                                                SqlBioFeto = SqlBioFeto + "WHERE  NumEcoFeto = '" + FunConEco + "' AND FetoNum = " + NFtol;

                                                SqlDataReader TabBioFeto;

                                                using (SqlConnection connection = new SqlConnection(Conexion.conexionSQL))
                                                {
                                                    SqlCommand command = new SqlCommand(SqlBioFeto, connection);
                                                    command.Connection.Open();
                                                    TabBioFeto = command.ExecuteReader();

                                                    if (TabBioFeto.HasRows == false)
                                                    {

                                                        switch (NFtol)
                                                        {

                                                            case 1: //Agrega el primer feto

                                                                parameters = null;

                                                                parameters = new List<SqlParameter>
                                                                {
                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = FCF01.Text},
                                                                    new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtILA01.Text},
                                                                    new SqlParameter("@TotaPunt", SqlDbType.VarChar){ Value = TxtTotal01.Text},
                                                                    new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMovFeta01.Text},
                                                                    new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovResp01.Text},
                                                                    new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoMusc01.Text},
                                                                    new SqlParameter("@PuntajeILA", SqlDbType.VarChar){ Value = TxtPuntaILA.Text},
                                                                    new SqlParameter("@PuntajeMovFet", SqlDbType.VarChar){ Value = TxtPuntaMovFet.Text},
                                                                    new SqlParameter("@PuntajeMovRes", SqlDbType.VarChar){ Value = TxtPuntaMovRes.Text},
                                                                    new SqlParameter("@PuntajeTonMusc", SqlDbType.VarChar){ Value = TxtPuntaTonMusc.Text},
                                                                };

                                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);


                                                                break;
                                                            case 2:

                                                                parameters = null;

                                                                parameters = new List<SqlParameter>
                                                                {
                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = FCF02.Text},
                                                                    new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtILA02.Text},
                                                                    new SqlParameter("@TotaPunt", SqlDbType.VarChar){ Value = TxtTotal02.Text},
                                                                    new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMovFeta02.Text},
                                                                    new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovResp02.Text},
                                                                    new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoMusc02.Text},
                                                                    new SqlParameter("@PuntajeILA", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovFet", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovRes", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeTonMusc", SqlDbType.VarChar){ Value = ""},
                                                                };

                                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                                break;

                                                            case 3:

                                                                parameters = null;

                                                                parameters = new List<SqlParameter>
                                                                {
                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = FCF03.Text},
                                                                    new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtILA03.Text},
                                                                    new SqlParameter("@TotaPunt", SqlDbType.VarChar){ Value = TxtTotal03.Text},
                                                                    new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMovFeta03.Text},
                                                                    new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovResp03.Text},
                                                                    new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoMusc03.Text},
                                                                    new SqlParameter("@PuntajeILA", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovFet", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovRes", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeTonMusc", SqlDbType.VarChar){ Value = ""},

                                                                };

                                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                                break;
                                                            case 4:

                                                                parameters = null;

                                                                parameters = new List<SqlParameter>
                                                                {
                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = FCF04.Text},
                                                                    new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtILA04.Text},
                                                                    new SqlParameter("@TotaPunt", SqlDbType.VarChar){ Value = TxtTotal04.Text},
                                                                    new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMovFeta04.Text},
                                                                    new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovResp04.Text},
                                                                    new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoMusc04.Text},
                                                                    new SqlParameter("@PuntajeILA", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovFet", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovRes", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeTonMusc", SqlDbType.VarChar){ Value = ""},
                                                                };

                                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);

                                                                break;
                                                            case 5:

                                                                parameters = null;

                                                                parameters = new List<SqlParameter>
                                                                {
                                                                    new SqlParameter("@NumEcoFeto", SqlDbType.VarChar){ Value = FunConEco},
                                                                    new SqlParameter("@FetoNum", SqlDbType.VarChar){ Value = NFtol},
                                                                    new SqlParameter("@FCFFeto", SqlDbType.VarChar){ Value = FCF05.Text},
                                                                    new SqlParameter("@ILAFeto", SqlDbType.VarChar){ Value = TxtILA05.Text},
                                                                    new SqlParameter("@TotaPunt", SqlDbType.VarChar){ Value = TxtTotal05.Text},
                                                                    new SqlParameter("@MovFetales", SqlDbType.VarChar){ Value = TxtMovFeta05.Text},
                                                                    new SqlParameter("@MovRespiratorios", SqlDbType.VarChar){ Value = TxtMovResp05.Text},
                                                                    new SqlParameter("@TonoFetal", SqlDbType.VarChar){ Value = TxtTonoMusc05.Text},
                                                                    new SqlParameter("@PuntajeILA", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovFet", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeMovRes", SqlDbType.VarChar){ Value = ""},
                                                                    new SqlParameter("@PuntajeTonMusc", SqlDbType.VarChar){ Value = ""},
                                                                };

                                                                Insert = Conexion.SqlInsert(Utils.SqlDatos, parameters);


                                                                break;
                                                            default:
                                                                break;
                                                        }

                                                    }
                                                }

                                                TabBioFeto.Close();

                                                NFtol += 1;
                                                NFetos -= 1;

                                            }//While

                                            //Defina que la eco se esta realizando, cambie de color cita programada

                                            if (string.IsNullOrWhiteSpace(TxtNumCitaProgra.Text) || Convert.ToInt32(TxtNumCitaProgra.Text) == 0)
                                            {
                                                //No hace nada
                                            }
                                            else
                                            {
                                                NCEco = Convert.ToDouble(TxtNumCitaProgra.Text);
                                                ColCit = "006";

                                                ActualizarCita(H, NCEco, ColCit);

                                            }


                                            Utils.Informa = "Los datos de la ecografía han sido grabado satisfactoriamente." + "\r";
                                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            break;

                                        case "13":

                                            TxtEcoNumForm13.Text = FunConEco;

                                            Utils.SqlDatos = "INSERT INTO [DACONEXTSQL].[dbo].[Datos registros de ecografias]" +
                                            "(" +
                                            "NumEcogra," +
                                            "TipoEco," +
                                            "Numaten," +
                                            "NumFactu," +
                                            "NumHisEco," +
                                            "FecRealECO," +
                                            "TransFrec," +
                                            "SeConoFUM," +
                                            "FUMEco," +
                                            "EdadGesFum," +
                                            "FPPFUM," +
                                            "Utero," +
                                            "DiamLongi," +
                                            "EspesorCer," +
                                            "DesCervix," +
                                            "ConclusECO," +
                                            "CodMedECO," +
                                            "CodAuxECO," +
                                            "ArchivEco," +
                                            "CodRegis," +
                                            "FecRegis," +
                                            "FecModi," +
                                            "CodModi" +
                                            ")" +
                                            "VALUES" +
                                            "(" +
                                            "'" + FunConEco + "'," +
                                            "'" + T + "'," +
                                            "'" + TxtAtenNumEco.Text + "'," +
                                            "'" + TxtFactConsul.Text + "'," +
                                            "'" + TxtNumHistoEco.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFecTomaEco13.Value.ToString())}" +
                                            "'" + CboTipTranEco13.SelectedValue + "'," +
                                            "'" + CboConoceFUM13.SelectedIndex + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFUMEco13.Value.ToString())}" +
                                            "'" + TxtEdadFum13.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFPPFUM13.Value.ToString())}" +
                                            "'" + TxtDesUteroEco13.Text + "'," +
                                            "'" + TxtDiameLongi13.Text + "'," +
                                            "'" + TxtEspeCervix13.Text + "'," +
                                            "'" + TxtDesCervixEco13.Text + "'," +
                                            "'" + TxtConcluEcos13.Text + "'," +
                                            "'" + CboCodiMedi.SelectedValue + "'," +
                                            "'" + CboCodiAuxRegis.SelectedValue + "'," +
                                            "'False'," +
                                            "'" + UsaRegis + "'," +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            "'" + UsaRegis + "'" +
                                            ")";

                                            Insert = Conexion.SqlInsert(Utils.SqlDatos);

                                            //Defina que la eco se esta realizando, cambie de color cita programada

                                            if (string.IsNullOrWhiteSpace(TxtNumCitaProgra.Text) || Convert.ToInt32(TxtNumCitaProgra.Text) == 0)
                                            {
                                                //No hace nada
                                            }
                                            else
                                            {
                                                NCEco = Convert.ToDouble(TxtNumCitaProgra.Text);
                                                ColCit = "006";

                                                ActualizarCita(H, NCEco, ColCit);

                                            }


                                            Utils.Informa = "Los datos de la ecografía cervicometria han sido grabado satisfactoriamente." + "\r";
                                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);


                                            break;


                                        case "14":

                                            TxtEcoNumForm14.Text = FunConEco;

                                            Utils.SqlDatos = "INSERT INTO [DACONEXTSQL].[dbo].[Datos registros de ecografias]" +
                                            "(" +
                                            "NumEcogra," +
                                            "TipoEco," +
                                            "Numaten," +
                                            "NumFactu," +
                                            "NumHisEco," +
                                            "FecRealECO," +
                                            "TransFrec," +
                                            "ProstataEco," +
                                            "VesicuSemiEco," +
                                            "AspecVeji," +
                                            "ConclusECO," +
                                            "CodMedECO," +
                                            "CodAuxECO," +
                                            "ArchivEco," +
                                            "CodRegis," +
                                            "FecRegis," +
                                            "FecModi," +
                                            "CodModi" +
                                            ")" +
                                            "VALUES" +
                                            "(" +
                                            "'" + FunConEco + "'," +
                                            "'" + T + "'," +
                                            "'" + TxtAtenNumEco.Text + "'," +
                                            "'" + TxtFactConsul.Text + "'," +
                                            "'" + TxtNumHistoEco.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFecTomaEco14.Value.ToString())}" +
                                            "'" + CboTipTranEco14.SelectedValue + "'," +
                                            "'" + TxtProstaEco14.Text + "'," +
                                            "'" + TxtVesiSeminal14.Text + "'," +
                                            "'" + TxtVesiSeminal14.Text + "'," +
                                            "'" + TxtComentario14.Text + "'," +
                                            "'" + CboCodiMedi.SelectedValue + "'," +
                                            "'" + CboCodiAuxRegis.SelectedValue + "'," +
                                            "'False'," +
                                            "'" + UsaRegis + "'," +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            "'" + UsaRegis + "'" +
                                            ")";


                                            Insert = Conexion.SqlInsert(Utils.SqlDatos);

                                            //Defina que la eco se esta realizando, cambie de color cita programada

                                            if (string.IsNullOrWhiteSpace(TxtNumCitaProgra.Text) || Convert.ToInt32(TxtNumCitaProgra.Text) == 0)
                                            {
                                                //No hace nada
                                            }
                                            else
                                            {
                                                NCEco = Convert.ToDouble(TxtNumCitaProgra.Text);
                                                ColCit = "006";

                                                ActualizarCita(H, NCEco, ColCit);

                                            }


                                            Utils.Informa = "Los datos de la ecografía transrectal han sido grabado satisfactoriamente." + "\r";
                                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            break;


                                        case "15":

                                            TxtEcoNumForm15.Text = FunConEco;

                                            Utils.SqlDatos = "INSERT INTO [DACONEXTSQL].[dbo].[Datos registros de ecografias]" +
                                            "(" +
                                            "NumEcogra," +
                                            "TipoEco," +
                                            "Numaten," +
                                            "NumFactu," +
                                            "NumHisEco," +
                                            "FecRealECO," +
                                            "TransFrec," +
                                            "RegisEcoGral," +
                                            "ConclusECO," +
                                            "CodMedECO," +
                                            "CodAuxECO," +
                                            "ArchivEco," +
                                            "CodRegis," +
                                            "FecRegis," +
                                            "FecModi," +
                                            "CodModi" +
                                            ")" +
                                            "VALUES" +
                                            "(" +
                                            "'" + FunConEco + "'," +
                                            "'" + T + "'," +
                                            "'" + TxtAtenNumEco.Text + "'," +
                                            "'" + TxtFactConsul.Text + "'," +
                                            "'" + TxtNumHistoEco.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFecTomaEco15.Value.ToString())}" +
                                            "'" + CboTipTranEco15.SelectedValue + "'," +
                                            "'" + TxtEcoGeneral15.Text + "'," +
                                            "'" + TxtComentario15.Text + "'," +
                                            "'" + CboCodiMedi.SelectedValue + "'," +
                                            "'" + CboCodiAuxRegis.SelectedValue + "'," +
                                            "'False'," +
                                            "'" + UsaRegis + "'," +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            "'" + UsaRegis + "'" +
                                            ")";


                                            Insert = Conexion.SqlInsert(Utils.SqlDatos);

                                            //Defina que la eco se esta realizando, cambie de color cita programada

                                            if (string.IsNullOrWhiteSpace(TxtNumCitaProgra.Text) || Convert.ToInt32(TxtNumCitaProgra.Text) == 0)
                                            {
                                                //No hace nada
                                            }
                                            else
                                            {
                                                NCEco = Convert.ToDouble(TxtNumCitaProgra.Text);
                                                ColCit = "006";

                                                ActualizarCita(H, NCEco, ColCit);

                                            }


                                            Utils.Informa = "Los datos de la ecografía de tejidos blandos han sido grabado satisfactoriamente." + "\r";
                                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);



                                            break;

                                        case "16":

                                            TxtEcoNumForm15.Text = FunConEco;

                                            Utils.SqlDatos = "INSERT INTO [DACONEXTSQL].[dbo].[Datos registros de ecografias]" +
                                            "(" +
                                            "NumEcogra," +
                                            "TipoEco," +
                                            "Numaten," +
                                            "NumFactu," +
                                            "NumHisEco," +
                                            "FecRealECO," +
                                            "TransFrec," +
                                            "RegisEcoGral," +
                                            "ConclusECO," +
                                            "CodMedECO," +
                                            "CodAuxECO," +
                                            "ArchivEco," +
                                            "CodRegis," +
                                            "FecRegis," +
                                            "FecModi," +
                                            "CodModi" +
                                            ")" +
                                            "VALUES" +
                                            "(" +
                                            "'" + FunConEco + "'," +
                                            "'" + T + "'," +
                                            "'" + TxtAtenNumEco.Text + "'," +
                                            "'" + TxtFactConsul.Text + "'," +
                                            "'" + TxtNumHistoEco.Text + "'," +
                                            $"{Conexion.ValidarFechaNula(DtFecTomaEco15.Value.ToString())}" +
                                            "'" + CboTipTranEco15.SelectedValue + "'," +
                                            "'" + TxtEcoGeneral15.Text + "'," +
                                            "'" + TxtComentario15.Text + "'," +
                                            "'" + CboCodiMedi.SelectedValue + "'," +
                                            "'" + CboCodiAuxRegis.SelectedValue + "'," +
                                            "'False'," +
                                            "'" + UsaRegis + "'," +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            $"{Conexion.ValidarFechaNula(DateTime.Now.ToString("yyyy-MM-dd"))}" +
                                            "'" + UsaRegis + "'" +
                                            ")";


                                            Insert = Conexion.SqlInsert(Utils.SqlDatos);

                                            //Defina que la eco se esta realizando, cambie de color cita programada

                                            if (string.IsNullOrWhiteSpace(TxtNumCitaProgra.Text) || Convert.ToInt32(TxtNumCitaProgra.Text) == 0)
                                            {
                                                //No hace nada
                                            }
                                            else
                                            {
                                                NCEco = Convert.ToDouble(TxtNumCitaProgra.Text);
                                                ColCit = "006";

                                                ActualizarCita(H, NCEco, ColCit);

                                            }


                                            Utils.Informa = "Los datos de la ecografía y ECODOPPLER han sido grabado satisfactoriamente." + "\r";
                                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);


                                            break;
                                        default:


                                            Utils.Informa = "Lo siento pero el tipo de ecografía no" + "\r";
                                            Utils.Informa += "se encuentra definido en el código de" + "\r";
                                            Utils.Informa += "programación de estes sistema, por lo" + "\r";
                                            Utils.Informa += "tanto no se puede realizar el registro" + "\r";
                                            Utils.Informa += "en la basee de datos." + "\r";
                                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);


                                            break;
                                    }

                                    //Actualizamos la lista de ecografías sin archivar

                                    MosEcosSinArchivar();

                                    break;
                            }//Fin swich de validaciones
                        }//Pregunta



                    }
                    else
                    {
                        TabRegEco.Read();

                        FunConEco = TabRegEco["NumEcogra"].ToString();

                        Utils.Informa = "¿Usted desea modificar la ecografía No. " + FunConEco + "\r";
                        Utils.Informa += CboTipoEcoReal.Text + " al usuario(a) " + "\r";
                        Utils.Informa += TxtNomUsaSin.Text + "? " + "\r";
                        var res = MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (res == DialogResult.Yes)
                        {
                            ModificaEco(T, H, M, FunConEco);
                        }

                    }

                    TabRegEco.Close();

                }
            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "al dar click en el boton guardar" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region DataGrid

        private void GridLisEcosSinArchivar_SelectionChanged(object sender, EventArgs e)
        {
            if (GridLisEcosSinArchivar.SelectedCells.Count != 0)
            {
                GridCitasProgramadas.ClearSelection();

                limpiarTextBoxes(this);

                TxtNumHistoEco.Text = GridLisEcosSinArchivar.SelectedCells[0].Value.ToString();



                CargarDatos(TxtNumHistoEco.Text);


            }
        }
            
        private void GridCitasProgramadas_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (GridCitasProgramadas.SelectedCells.Count != 0)
                {

                    GridLisEcosSinArchivar.ClearSelection();

                    limpiarTextBoxes(this);

                    TxtNumHistoEco.Text = GridCitasProgramadas.SelectedCells[2].Value.ToString();

                    TxtFactConsul.Text = GridCitasProgramadas.SelectedCells[3].Value.ToString();

                    TxtNumCitaProgra.Text = GridCitasProgramadas.SelectedCells[4].Value.ToString();

                    CargarDatos(TxtNumHistoEco.Text);

                }
            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "al seleccionar" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataPicker

        private void DtFUMEco_ValueChanged(object sender, EventArgs e)
        {
            CalcularEdadFum(CboConoceFUM, DtFecTomaEco, DtFUMEco, DtFPPFUM, TxtEdadFum);
        }


        private void DtFUMEco02_ValueChanged(object sender, EventArgs e)
        {
            CalcularEdadFum(CboConoceFUM02, DtFecTomaEco02, DtFUMEco02, DtFPPFUM02, TxtEdadFum02);
        }

        private void DtFUMEco03_ValueChanged(object sender, EventArgs e)
        {
            CalcularEdadFum(CboConoceFUM03, DtFecTomaEco03, DtFUMEco03, DtFPPFUM03, TxtEdadFum03);
        }

        private void DtFUMEco05_ValueChanged(object sender, EventArgs e)
        {
            CalcularEdadFum(CboConoceFUM05, DtFecTomaEco05, DtFUMEco05, DtFPPFUM05, TxtEdadFum05);
        }

        private void DtFUMEco06_ValueChanged(object sender, EventArgs e)
        {
            CalcularEdadFum(CboConoceFUM06, DtFecTomaEco06, DtFUMEco06, DtFPPFUM06, TxtEdadFum06);
        }

        private void DtFUMEco07_ValueChanged(object sender, EventArgs e)
        {
            CalcularEdadFum(CboConoceFUM07, DtFecTomaEco07, DtFUMEco07, DtFPPFUM07, TxtEdadFum07);
        }

        private void DtFPPFUM08_ValueChanged(object sender, EventArgs e)
        {
            CalcularEdadFum(CboConoceFUM08, DtFecTomaEco08, DtFUMEco08, DtFPPFUM08, TxtEdadFum08);
        }

        private void DtFUMEco11_ValueChanged(object sender, EventArgs e)
        {
            CalcularEdadFum(CboConoceFUM11, DtFecTomaEco11, DtFUMEco11, DtFPPFUM11, TxtEdadFum11);
        }

        private void DtFUMEco13_ValueChanged(object sender, EventArgs e)
        {
            CalcularEdadFum(CboConoceFUM13, DtFecTomaEco13, DtFUMEco13, DtFPPFUM13, TxtEdadFum13);
        }

        private void DtFUMEco14_ValueChanged(object sender, EventArgs e)
        {
            CalcularEdadFum(CboConoceFUM14, DtFecTomaEco14, DtFUMEco14, DtFPPFUM14, TxtEdadFum14);
        }

        private void DtFUMEco15_ValueChanged(object sender, EventArgs e)
        {
            CalcularEdadFum(CboConoceFUM15, DtFecTomaEco15, DtFUMEco15, DtFPPFUM15, TxtEdadFum15);
        }

        #endregion

        #region TabControl
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNumFetosECO.Text))
            {
                Utils.Titulo01 = "Control de ejecución";
                Utils.Informa = "Por favor digita el numero de fetos" + "\r";
                TxtNumFetosECO.Select();
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int IndexTabControl = TabControl.SelectedIndex;
                int NFetos = Convert.ToInt32(TxtNumFetosECO.Text);
                IndexTabControl += 1;

                if (IndexTabControl > NFetos)
                {
                    TabControl.SelectedIndex = 0;
                }

            }
        }

        private void Data_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNumFetosECO03.Text))
            {
                Utils.Titulo01 = "Control de ejecución";
                Utils.Informa = "Por favor digita el numero de fetos" + "\r";
                TxtNumFetosECO03.Select();
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int IndexTabControl = Data.SelectedIndex;
                int NFetos = Convert.ToInt32(TxtNumFetosECO03.Text);
                IndexTabControl += 1;

                if (IndexTabControl > NFetos)
                {
                    Data.SelectedIndex = 0;
                }

            }
        }

        private void tabControl8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNumFetosECO11.Text))
            {
                Utils.Titulo01 = "Control de ejecución";
                Utils.Informa = "Por favor digita el numero de fetos" + "\r";
                TxtNumFetosECO11.Select();
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int IndexTabControl = tabControl8.SelectedIndex;
                int NFetos = Convert.ToInt32(TxtNumFetosECO11.Text);
                IndexTabControl += 1;

                if (IndexTabControl > NFetos)
                {
                    tabControl8.SelectedIndex = 0;
                }

            }
        }

        #endregion

        int bandera = 0;
        private void FrmAtencionEcografiasObstreticas_Load(object sender, EventArgs e)
        {
            
            try
            {



                CargarComboBox();

                bandera = 1;         

                CargarDatosUser();

                CargaCitasProgramadas();

                DtFecTomaEco.Value = DateTime.Now;

                TabControlEcograficas.Appearance = TabAppearance.FlatButtons;
                TabControlEcograficas.ItemSize = new Size(0, 1);
                TabControlEcograficas.SizeMode = TabSizeMode.Fixed;

            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "al cargar el formulario FrmAtencionEcografiasObstreticas" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnArchivar_Click(object sender, EventArgs e)
        {
            try
            {
                string T, H, M, FunConEco, CodConseD, UsaRegis, NomInfor, Para01, ColCit, SqlRegEco;
                int NFetos, NFtol, InfoMues;
                double NCEco;
                var res = DialogResult.No; 
                Utils.Titulo01 = "Control para GRABAR datos";


                if (string.IsNullOrWhiteSpace(TxtNumHistoEco.Text))
                {
                    Utils.Informa = "Lo siento pero usted aún no ha digitado el" + "\r";
                    Utils.Informa += "número de la historia clinica del usuario al" + "\r";
                    Utils.Informa += "cual quiere registrar los datos de una ecografía." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtNomUsaSin.Text))
                {
                    Utils.Informa = "Lo siento pero el número de historia digitado" + "\r";
                    Utils.Informa += "no corresponde a un nombre de usuario válido," + "\r";
                    Utils.Informa += "por lo tanto no se pueden registrar los datos." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Revisamos si el sexo del usuario

                if (string.IsNullOrWhiteSpace(TxtSexoSinAten.Text))
                {
                    Utils.Informa = "Lo siento pero el número de historia digitado" + "\r";
                    Utils.Informa += "no tiene definido el sexo, por lo tanto no se" + "\r";
                    Utils.Informa += "pueden registrar los datos." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CboEspecialidad1.SelectedIndex == -1)
                {
                    Utils.Informa = "Lo siento pero usted no ha seleccionado el" + "\r";
                    Utils.Informa += "nombre de la especialidad del profesional" + "\r";
                    Utils.Informa += "que realiza la toma de la ecografía," + "\r";
                    Utils.Informa += "por lo tanto no se pueden registrar los datos." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CboCodiMedi.SelectedIndex == -1)
                {
                    Utils.Informa = "Lo siento pero usted no ha seleccionado el nombre" + "\r";
                    Utils.Informa += "del profesional que realiza la toma de la ecografía," + "\r";
                    Utils.Informa += "por lo tanto no se pueden registrar los datos." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CboCodiAuxRegis.SelectedIndex == -1)
                {
                    Utils.Informa = "Lo siento pero usted no ha seleccionado el nombre" + "\r";
                    Utils.Informa += "del auxiliar que registra la toma de la ecografía," + "\r";
                    Utils.Informa += "por lo tanto no se pueden registrar los datos." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CboTipoEcoReal.SelectedIndex == -1)
                {
                    Utils.Informa = "Lo siento pero usted no ha seleccionado el" + "\r";
                    Utils.Informa += "tipo de ecografía a registrar, por lo tanto" + "\r";
                    Utils.Informa += "no se puede continuar con ell proceso." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Utils.SqlDatos = "SELECT CodEcoIps, NomEcogra, CodFacEco, SexApli FROM [DACONEXTSQL].[dbo].[Datos tipos de ecografias] WHERE RealizIPS = 'True' AND CodEcoIps = '" + CboTipoEcoReal.SelectedValue.ToString() + "'";

                SqlDataReader reader = Conexion.SQLDataReader(Utils.SqlDatos);

                if (reader.HasRows)
                {
                    reader.Read();

                    if (reader["SexApli"].ToString() == "A")
                    {
                        //NO se valida el sexo, porque es de ambos
                    }
                    else
                    {
                        if (reader["SexApli"].ToString() != TxtSexoSinAten.Text)
                        {
                            Utils.Informa = "Lo siento pero usted no puede registrar los datos" + "\r";
                            Utils.Informa += "de la ecografía " + CboTipoEcoReal.Text + "\r";
                            Utils.Informa += "al usuario " + TxtNomUsaSin.Text + "\r";
                            Utils.Informa += "ya que el sexo no es pertinente." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                if (Conexion.sqlConnection.State == ConnectionState.Open) Conexion.sqlConnection.Close();

                T = CboTipoEcoReal.SelectedValue.ToString();
                H = TxtNumHistoEco.Text;
                M = CboCodiMedi.SelectedValue.ToString();
                UsaRegis = lblCodigoUser.Text;

                //Revisamos cual el tipo de ecografía que se quiere archivar y si realmente se tiene un número asignado

                switch (T)
                {
                    case "01": //Ecografía obstetrica
                        FunConEco = TxtEcoNumForm.Text;
                        NomInfor = "Informe ecografia obstetrica";
                        Para01 = "[DACONEXTSQL].[dbo].[Datos biometria de los fetos].[NumEcoFeto] = '" + FunConEco + "'";
                    break;
                    case "02": //ecografia pelvica transvaginal
                        FunConEco = TxtEcoNumForm02.Text;
                        NomInfor = "Informe ecografia pelvica transvaginal";
                        Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        break;
                    case "03": //ecografia obstetrica temprana
                        FunConEco = TxtEcoNumForm03.Text;
                        NomInfor = "Informe ecografia obstetrica temprana";
                        Para01 = "[DACONEXTSQL].[dbo].[Datos biometria de los fetos].[NumEcoFeto] = '" + FunConEco + "'";
                        break;
                    case "04": //Aborto retenido
                        FunConEco = TxtEcoNumForm03.Text;
                        NomInfor = "Informe ecografia obstetrica aborto";
                        Para01 = "[DACONEXTSQL].[dbo].[Datos biometria de los fetos].[NumEcoFeto] = '" + FunConEco + "'";
                        break;
                    case "05": //ecografia abdominal
                        FunConEco = TxtEcoNumForm05.Text;
                        NomInfor = "Informe ecografia abdominal";
                        Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        break;
                    case "06": //ecografia renal bilateral
                        FunConEco = TxtEcoNumForm06.Text;
                        NomInfor = "Informe ecografia renal bilateral";
                        Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        break;
                    case "07": //ecografia hepatobiliar
                        FunConEco = TxtEcoNumForm07.Text;
                        NomInfor = "Informe ecografia hepatobiliar";
                        Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        break;
                    case "08": //ecografia renal y vias urinarias
                        FunConEco = TxtEcoNumForm08.Text;
                        NomInfor = "Informe ecografia renal y vias urinarias ";
                        Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        break;
                    case "09": //ecografia abdomen superior
                        FunConEco = TxtEcoNumForm07.Text;
                        NomInfor = "Informe ecografia abdomen superior";
                        Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        break;
                    case "10": //ecografia obstetrica transvaginal
                        FunConEco = TxtEcoNumForm02.Text;
                        NomInfor = "Informe ecografia obstetrica transvaginal";
                        Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        break;
                    case "11": //ecografia perfil biofisico
                        FunConEco = TxtEcoNumForm11.Text;
                        NomInfor = "Informe ecografia perfil biofisico";
                        Para01 = "[DACONEXTSQL].[dbo].[Datos biometria de los fetos].[NumEcoFeto] = '" + FunConEco + "'";
                        break;
                    case "12": //ecografia pelvica transabdominal
                        FunConEco = TxtEcoNumForm02.Text;
                        NomInfor = "Informe ecografia pelvica transabdominal";
                        Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        break;
                    case "13": //ecografia cervicometria
                        FunConEco = TxtEcoNumForm13.Text;
                        NomInfor = "Informe ecografia cervicometria";
                        Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        break;
                    case "14": //ecografia transrectal
                        FunConEco = TxtEcoNumForm14.Text;
                        NomInfor = "Informe ecografia transrectal";
                        Para01 = "[DACONEXTSQL].[dbo].[atos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        break;
                    case "15": //ecografia tejidos blandos
                        FunConEco = TxtEcoNumForm15.Text;
                        NomInfor = "Informe ecografia general";
                        Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        break;
                    case "16": //cografia ecodoppler testicular
                        FunConEco = TxtEcoNumForm15.Text;
                        NomInfor = "Informe ecografia general";
                        Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
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

                //Buscamos el numero de ecografia

                SqlRegEco = "SELECT * ";
                SqlRegEco = SqlRegEco + "FROM [DACONEXTSQL].[dbo].[Datos registros de ecografias] ";
                SqlRegEco = SqlRegEco + "Where NumEcogra = '" + FunConEco + "' ";


                SqlDataReader TabRegEco;

                using (SqlConnection connection = new SqlConnection(Conexion.conexionSQL))
                {
                    SqlCommand command = new SqlCommand(SqlRegEco, connection);
                    command.Connection.Open();
                    TabRegEco = command.ExecuteReader();

                    if (TabRegEco.HasRows == false)
                    {
                        Utils.Informa = "Lo siento pero los datos de la ecografía ha" + "\r";
                        Utils.Informa += "cerrar, aún no han sido registrados en este" + "\r";
                        Utils.Informa += "sistema, por favor ejecute primero el proceso" + "\r";
                        Utils.Informa += "de grabar y luego el de archivar." + "\r";
                        MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                        return;
                    }
                    else
                    {
                        TabRegEco.Read();

                        //Revisamos si el número de historia es igual a la contenida en la eco grabada


                        if(TabRegEco["NumHisEco"].ToString() != H)
                        {
                            Utils.Informa = "Lo siento pero el informe de la ecografía No. " + FunConEco + "\r";
                            Utils.Informa += "no se puede archivar, porque el número de historia" + "\r";
                            Utils.Informa += "registrado previamente, es diferente al número" + "\r";
                            Utils.Informa += "de historia digitado por usted." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            //Revisamos si se encuentra anulada
                            if(Convert.ToBoolean(TabRegEco["AnulEco"]) == true)
                            {
                                Utils.Informa = "Lo siento pero el informe de la ecografía No. " + FunConEco + "\r";
                                Utils.Informa += "no se puede archivar, porque la misma se encuentra" + "\r";
                                Utils.Informa += "anulada en este sistema." + "\r";
                                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                //Preguntamos

                                Utils.Informa = "¿Usted desea ARCHIVAR la ecografía No" + FunConEco + "\r";
                                Utils.Informa += CboTipoEcoReal.Text + " al usuario(a) " + "\r";
                                Utils.Informa += TxtNomUsaSin.Text + "\r";
                                res = MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if(res == DialogResult.Yes)
                                {
                                    Utils.SqlDatos = "UPDATE [DACONEXTSQL].[dbo].[Datos registros de ecografias] SET ArchivEco = 'True', CodArchi = '" + UsaRegis + "', FecArchi = CONVERT(DATETIME,'" + DateTime.Now.ToString("yyyy-MM-dd") + "',102) " +
                                    "WHERE NumEcogra = '" + FunConEco + "'";

                                    bool estaAct = Conexion.SQLUpdate(Utils.SqlDatos);

                                    //Defina que la eco se esta realizando, cambie de color cita programada


                                    Utils.SqlDatos = "SELECT [Datos de citas programadas].ConsecutivoCita FROM  [DACITASXPSQL].[dbo].[Datos de citas programadas] INNER JOIN  [DACONEXTSQL].[dbo].[Datos registros de ecografias] ON NoFactura = NumFactu " +
                                    " WHERE [Datos de citas programadas].HistoriaCita = '"+ TxtNumHistoEco.Text + "'";

                                    SqlDataReader tabConseCita = Conexion.SQLDataReader(Utils.SqlDatos);

                                    if (tabConseCita.HasRows)
                                    {
                                        tabConseCita.Read();
                                        NCEco = Convert.ToDouble(tabConseCita["ConsecutivoCita"].ToString());
                                        ColCit = "001"; //Finalizada la atención, Color verde

                                        ActualizarCita(H, NCEco, ColCit);
                                    }

                                    tabConseCita.Close();

                                    if (Conexion.sqlConnection.State == ConnectionState.Open) Conexion.sqlConnection.Close();

                                    

                                }

                                Utils.Informa = "Los datos de la ecografía han sido " + FunConEco + "\r";
                                Utils.Informa += "archivado satisfactoriamente." + "\r";
                                Utils.Informa += "¿Desea mostrar el informe generado.?" + "\r";
                                res = MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                if(res == DialogResult.Yes)
                                {
                                    InfoMues = 1;
                                }
                                else
                                {
                                    InfoMues = 0;
                                }

                            }

                        }// if (TabRegEco["NumHisEco"].ToString() != H
                    }
                }
                TabRegEco.Close();

                MosEcosSinArchivar();

                if(InfoMues == 1)
                {
                    Utils.infNombreInforme = NomInfor;
                    Utils.NumECCo = FunConEco;
                    Report.FrmReporteEcografias frm = new Report.FrmReporteEcografias();
                    frm.ShowDialog();

                }

            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error al" + "\r";
                Utils.Informa += "hacer click sobre el botón Archivar" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BtnCopias_Click(object sender, EventArgs e)
        {
            try
            {
                string T = "", UsAten = "", HisAten = "", FunConEco = "", NomInfor = "", Para01 = "";
                var res = DialogResult.No;
                Utils.Titulo01 = "Control para generar copias de informess";


                if (string.IsNullOrWhiteSpace(TxtNumHistoEco.Text))
                {
                    Utils.Informa = "Lo siento pero usted aún no ha digitado el" + "\r";
                    Utils.Informa += "número de la historia clinica del usuario al" + "\r";
                    Utils.Informa += "cual quiere registrar los datos de una ecografía." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtNomUsaSin.Text))
                {
                    Utils.Informa = "Lo siento pero el número de historia digitado" + "\r";
                    Utils.Informa += "no corresponde a un nombre de usuario válido," + "\r";
                    Utils.Informa += "por lo tanto no se pueden registrar los datos." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                UsAten = TxtNomUsaSin.Text;

                //Revisamos si el sexo del usuario

                if (string.IsNullOrWhiteSpace(TxtSexoSinAten.Text))
                {
                    Utils.Informa = "Lo siento pero el número de historia digitado" + "\r";
                    Utils.Informa += "no tiene definido el sexo, por lo tanto no se" + "\r";
                    Utils.Informa += "pueden registrar los datos." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CboEspecialidad1.SelectedIndex == -1)
                {
                    Utils.Informa = "Lo siento pero usted no ha seleccionado el" + "\r";
                    Utils.Informa += "nombre de la especialidad del profesional" + "\r";
                    Utils.Informa += "que realiza la toma de la ecografía," + "\r";
                    Utils.Informa += "por lo tanto no se pueden registrar los datos." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CboCodiMedi.SelectedIndex == -1)
                {
                    Utils.Informa = "Lo siento pero usted no ha seleccionado el nombre" + "\r";
                    Utils.Informa += "del profesional que realiza la toma de la ecografía," + "\r";
                    Utils.Informa += "por lo tanto no se pueden registrar los datos." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CboCodiAuxRegis.SelectedIndex == -1)
                {
                    Utils.Informa = "Lo siento pero usted no ha seleccionado el nombre" + "\r";
                    Utils.Informa += "del auxiliar que registra la toma de la ecografía," + "\r";
                    Utils.Informa += "por lo tanto no se pueden registrar los datos." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CboTipoEcoReal.SelectedIndex == -1)
                {
                    Utils.Informa = "Lo siento pero usted no ha seleccionado el" + "\r";
                    Utils.Informa += "tipo de ecografía a registrar, por lo tanto" + "\r";
                    Utils.Informa += "no se puede continuar con ell proceso." + "\r";
                    MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                T = CboTipoEcoReal.SelectedValue.ToString();


                switch (T)
                {
                    case "01": //Ecografía obstetrica
                        FunConEco = TxtEcoNumForm.Text;

                        if(FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA OBSTETRICA No. " + FunConEco + "\r";
                            Utils.Informa += "realizada a la usuaria de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";

                            NomInfor = "Informe ecografia obstetrica";
                            Para01 = "[DACONEXTSQL].[dbo].[Datos biometria de los fetos].[NumEcoFeto] = '" + FunConEco + "'";
                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        break;
                    case "02": //ecografia pelvica transvaginal
                        FunConEco = TxtEcoNumForm02.Text;

                        if (FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA PELVICA No. " + FunConEco + "\r";
                            Utils.Informa += "realizada a la usuaria de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";

                            //Se llama a este informe ya que son lo mismo
                            NomInfor = "Informe ecografia obstetrica transvaginal";

                            Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                          
                        break;
                    case "03": //ecografia obstetrica temprana

                        FunConEco = TxtEcoNumForm03.Text;

                        if (FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA OBSTETRICA TEMPRANA No. " + FunConEco + "\r";
                            Utils.Informa += "realizada a la usuaria de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";

                            //Le paso el informe de obstetrica aborto ya que son el mismo

                            NomInfor = "Informe ecografia obstetrica aborto";

                            Para01 = "[DACONEXTSQL].[dbo].[Datos biometria de los fetos].[NumEcoFeto] = '" + FunConEco + "'";

                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                         
                        break;
                    case "04": //Aborto retenido

                        FunConEco = TxtEcoNumForm03.Text;

                        if (FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA OBSTETRICA DE ABORTO No. " + FunConEco + "\r";
                            Utils.Informa += "realizada a la usuaria de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";

                            NomInfor = "Informe ecografia obstetrica aborto";

                            Para01 = "[DACONEXTSQL].[dbo].[Datos biometria de los fetos].[NumEcoFeto] = '" + FunConEco + "'";

                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                          
                        break;
                    case "05": //ecografia abdominal
                        FunConEco = TxtEcoNumForm05.Text;

                        if (FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA ABDOMINAL No. " + FunConEco + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";

                            NomInfor = "Informe ecografia abdominal";
                            Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    case "06": //ecografia renal bilateral
                        FunConEco = TxtEcoNumForm06.Text;

                        if (FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA RENAL BILATERAL No. " + FunConEco + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";
                        
                            NomInfor = "Informe ecografia renal bilateral";
                            Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        break;
                    case "07": //ecografia hepatobiliar

                        FunConEco = TxtEcoNumForm05.Text;

                        if (FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA HEPATOBILIAR No. " + FunConEco + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";

                            //NomInfor = "Informe ecografia hepatobiliar"; Se llama al informe  ecografia abdomen superior ya que son el mismo y no veo la necesario

                            NomInfor = "Informe ecografia abdominal";

                            Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";

                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    case "08": //ecografia renal y vias urinarias
                        FunConEco = TxtEcoNumForm08.Text;

                        if (FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA RENAL BILATERAL Y VIAS URINARIAS No. " + FunConEco + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";

                            NomInfor = "Informe ecografia renal y vias urinarias";
                            Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    case "09": //ecografia abdomen superior
                        FunConEco = TxtEcoNumForm07.Text;

                        if (FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA ABDOMEN SUPERIOR No. " + FunConEco + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";

                            NomInfor = "Informe ecografia abdomen superior";
                            Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    case "10": //ecografia obstetrica transvaginal
                        FunConEco = TxtEcoNumForm02.Text;

                        if (FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA OBSTETRICA TRANSVAGINAL No. " + FunConEco + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";
                            NomInfor = "Informe ecografia obstetrica transvaginal";
                            Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        break;
                    case "11": //ecografia perfil biofisico
                        FunConEco = TxtEcoNumForm11.Text;

                        if (FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA DE PERFIL BIOFISICO  No. " + FunConEco + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";
                            NomInfor = "Informe ecografia perfil biofisico";
                            Para01 = "[DACONEXTSQL].[dbo].[Datos biometria de los fetos].[NumEcoFeto] = '" + FunConEco + "'";
                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        break;
                    case "12": //ecografia pelvica transabdominal
                        FunConEco = TxtEcoNumForm02.Text;

                        if (FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA PELVICA TRANSABDOMINAL No. " + FunConEco + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";
                            //Se llama a este informe ya que son lo mismo
                            NomInfor = "Informe ecografia obstetrica transvaginal";
                            Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    case "13": //ecografia cervicometria
                        FunConEco = TxtEcoNumForm13.Text;

                        if (FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA CERVICOMETRIA No. " + FunConEco + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";
                            NomInfor = "Informe ecografia cervicometria";
                            Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        break;
                    case "14": //ecografia transrectal
                        FunConEco = TxtEcoNumForm14.Text;

                        if (FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA TRANSRECTAL No. " + FunConEco + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";
                            NomInfor = "Informe ecografia transrectal";
                            Para01 = "[DACONEXTSQL].[dbo].[atos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    case "15": //ecografia tejidos blandos
                        FunConEco = TxtEcoNumForm15.Text;


                        if (FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA DE TEJIDOS BLANDOS No. " + FunConEco + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";
                            NomInfor = "Informe ecografia general";
                            Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    case "16": //cografia ecodoppler testicular
                        FunConEco = TxtEcoNumForm15.Text;

                        if (FunConEco != "0" || FunConEco != null)
                        {
                            Utils.Informa = "¿Usted desea generar una copia del informe" + "\r";
                            Utils.Informa += "de la ECOGRAFÍA Y ECODOPPLER TESTICULAR No. " + FunConEco + "\r";
                            Utils.Informa += "realizada al usuario (a) de nombre" + "\r";
                            Utils.Informa += UsAten + ".?" + "\r";
                            NomInfor = "Informe ecografia general";
                            Para01 = "[DACONEXTSQL].[dbo].[Datos registros de ecografias].[NumEcogra] = '" + FunConEco + "'";
                        }
                        else
                        {
                            Utils.Informa = "Lo siento pero usted no ha generado o seleccionado" + "\r";
                            Utils.Informa += "un número de ecografía válido, el cual le permita " + "\r";
                            Utils.Informa += "a este sistema generar la copia del informe." + "\r";
                            MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

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

                res = MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(res == DialogResult.Yes)
                {
                    Utils.infNombreInforme = NomInfor;
                    Utils.NumECCo = FunConEco;
                    Report.FrmReporteEcografias frm = new Report.FrmReporteEcografias();
                    frm.ShowDialog();
                }



            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error al" + "\r";
                Utils.Informa += "hacer click sobre el botón Copias" + "\r";
                Utils.Informa += "Error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
    }

}
