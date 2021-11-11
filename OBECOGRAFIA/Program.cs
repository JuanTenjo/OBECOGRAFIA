﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBECOGRAFIA.Forms;

using System.Diagnostics;
namespace OBECOGRAFIA
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {


            // Obtiene todos los procesos en ejecución
            Process[] allRunningPrograms = Process.GetProcesses();

            // Obtiene los procesos en ejecución del programa pasado como parámetro
            Process[] myProgram = Process.GetProcessesByName("OBECOGRAFIA");

            //Y ahora si quieres hacer que deje de ejecutarse, sería tal que así:
            if (myProgram.Length > 1) return;
            //myProgram[0].Kill();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());

        }
    }
}
