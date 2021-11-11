using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBECOGRAFIA.Class
{
    class Utils
    {

        public static string EdadAtencion(DateTime Fa, DateTime FN)
        {
            //Permite devolver la edad  a la fecha de la atención
            //'*********************** Modificada el 03 de febrero de 2007

            //'Esta función permite mostrar la edad de un paciente

            //Defina el total días corridos entre la fecha de nacimiento y la de hoy          
            try
            {
                string MesDias;
                int MesAcul, AnAcumul, TolMeses, TolDias;



                string AnActual = Fa.ToString("yyyy");
                string AnNace = FN.ToString("yyyy");

                string MesAcTual = Fa.ToString("MM");
                string MesNace = FN.ToString("MM");

                string DiaActual = Fa.ToString("dd");
                string DiaNace = FN.ToString("dd");


                TimeSpan ts = Fa - FN;

                int DiasCorridos = ts.Days;

                if (AnActual == AnNace)
                {
                    //Es un menor de un año
                    if (MesAcTual == MesNace)
                    {
                        //Menor de un mes de nacido
                        int D = ts.Days;
                        if (D == 0)
                        {
                            MesDias = "1 " + "día";
                        }
                        else
                        {
                            MesDias = D + "días";
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(MesAcTual) > Convert.ToInt32(MesNace))
                        {
                            if (Convert.ToInt32(DiaActual) > Convert.ToInt32(DiaNace))
                            {
                                MesAcul = Convert.ToInt32(MesAcTual) - Convert.ToInt32(MesNace);

                                switch (MesAcul)
                                {
                                    case 1:
                                        MesDias = MesAcul + " Mes";
                                        break;
                                    default:
                                        MesDias = MesAcul + " Meses";
                                        break;
                                }
                            }
                            else
                            {
                                MesAcul = Convert.ToInt32(MesAcTual) - Convert.ToInt32(MesNace);
                                switch (MesAcul)
                                {
                                    case 1: //Tiene son días de nacidos
                                        MesDias = DiasCorridos + " días";
                                        break;
                                    default: //Meses
                                        if ((MesAcul - 1) == 1)
                                        {
                                            MesDias = 1 + " Mes";
                                        }
                                        else
                                        {
                                            MesDias = (MesAcul - 1) + " Mes";
                                        }

                                        break;
                                }
                            }

                        }
                        else
                        {
                            //Devuelva cero porque no ha nacido
                            MesDias = 0 + " días";
                        }
                    }
                }
                else
                {
                    if (Convert.ToInt32(AnActual) > Convert.ToInt32(AnNace))
                    {
                        AnAcumul = Convert.ToInt32(AnActual) - Convert.ToInt32(AnNace);
                        //Se revisa el mes de nacimiento
                        if (Convert.ToInt32(MesAcTual) == Convert.ToInt32(MesNace))
                        {
                            //Revisamos el día de nacimiento
                            if (Convert.ToInt32(DiaActual) >= Convert.ToInt32(DiaNace))
                            {
                                //Años cumplidos exactos
                                MesDias = AnAcumul + " Años";
                            }
                            else
                            {
                                if (AnAcumul == 1)
                                {
                                    //No ha cumplido el año, por tanto se debe reportar en meses, con seguridad son 11 meses
                                    MesDias = 11 + " Meses";
                                }
                                else
                                {
                                    MesDias = (AnAcumul - 1) + " Años";
                                }
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(MesAcTual) < Convert.ToInt32(MesNace))
                            {
                                //No ha cumplido años, en el año actual
                                if (AnAcumul == 1)
                                {
                                    //Está de meses, revisamos el día de nacido
                                    if (Convert.ToInt32(DiaActual) >= Convert.ToInt32(DiaNace))
                                    {
                                        //Meses cumplidos exactos
                                        MesDias = ((12 - Convert.ToInt32(MesNace)) + MesAcTual) + " Meses";
                                    }

                                    else
                                    {
                                        //******************** MOdificado el 03 de febrero de 2007 por Hernando en GUADALUPE *****************
                                        //******************** Reeescrito en c# el 27 de agosto de 2021 por Juan Diego Pimentel en GUADALUPE *****************


                                        TolMeses = ((12 - Convert.ToInt32(MesNace)) + (Convert.ToInt32(MesAcTual) - 1));

                                        if (TolMeses == 0)
                                        {
                                            //El nino nacio en diciembre y ha sido atendo en enero

                                            TolDias = (31 - Convert.ToInt32(DiaNace)) + Convert.ToInt32(DiaActual);
                                            if (TolDias < 30)
                                            {
                                                //El paciente tiene dias
                                                MesDias = TolDias + " días";
                                            }
                                            else
                                            {
                                                MesDias = "1 Meses";
                                            }
                                        }
                                        else
                                        {
                                            MesDias = ((12 - Convert.ToInt32(MesNace)) + (Convert.ToInt32(MesAcTual) - 1)) + " Meses";
                                        }
                                    }
                                }
                                else
                                {
                                    MesDias = (AnAcumul - 1) + " Años";
                                }//if (AnAcumul == 1)
                            }
                            else
                            {
                                //Ya cumplió años en el año actual
                                MesDias = AnAcumul + " Años";
                            }
                        }
                    }
                    else
                    {
                        //Devuelva edad cero porque el usuario no ha nacido
                        MesDias = 0 + " días";
                    }
                }//Final de AnActual = AnNace

                return MesDias;
            }
            catch (Exception ex)
            {
                Utils.Titulo01 = "Control de errores de ejecución";
                Utils.Informa = "Lo siento pero se ha presentado un error" + "\r";
                Utils.Informa += "en la funcion EdadAtencion" + "\r";
                Utils.Informa += "Mensaje del error: " + ex.Message + " - " + ex.StackTrace;
                MessageBox.Show(Utils.Informa, Utils.Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "-1";
            }

        }
        public static string codUsuario { get; set; }
        public static string nomUsuario { get; set; }
        public static string nivelPermiso { get; set; }
        public static string codUnicoEmpresa { get; set; }
        public static string CodEnti { get; set; }
        public static string CodEspecialidad { get; set; }

        public static string CodigoMedico { get; set; }
        public static string CodAplicacion { get; set; }

        public static string codMinSalud { get; set; }

        public static string tipoDocEmp { get; set; }
        public static string nitEmpresa { get; set; }
        public static string nomEmpresa { get; set; }
        public static string CateEmpresa { get; set; }
        public static string TelEmpresa { get; set; }


        public static string Titulo01 { get; set; }
        public static string Informa { get; set; }
        public static string SqlDatos { get; set; }

        public static string SqlUpdate { get; set; }

        public static string infNombreInforme { get; set; }

        public static string CarAdmin { get; set; }

        public static string CodRips { get; set; }
        public static string NomTerc { get; set; }


        //Para abrir la conexion principal de la base de datos 

        public static string BaseDeDatosPrincipal { get; set; }

        //Nombre del reporte
        public static string NumECCo { get; set; }

        //Logo de la empres
        public static byte[] LogoEmpresa { get; set; }

        //Reporte de atenciones

        public static string FecIncial { get; set; }

        public static string FecFinal { get; set; }

        public static string CodMedicoReport { get; set; }

        public static int ArchiEcoReport { get; set; }




    }
}
