using System;
using System.Windows.Forms;

namespace Pagina_Principal
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Seccion_vuelos(147, "Kevin")); //Form1()  int cedula, string nombre  147,"Kevin"
        }
    }
}
