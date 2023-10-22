using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpAutomotriz
{
    public static class Program
    {
        /* TP Laboratorio de Computación II - Programación II
                Grupo 5 - Sistema de Venta y Control de Stock de una Automotriz
         * Brane, Uri Tevye - 405513.
         * Brunelli, Jazmín - 405318.
         * Ledezma Unser, Victoria Yara - 404998.
         * Martínez Schroeder, Andrés - 112787.
         * Mina, Pablo - 404908.
         * Moro, Benjamin - 405786. */


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenuPrincipal());
        }
    }
}
