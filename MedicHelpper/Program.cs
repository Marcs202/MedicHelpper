using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicHelpper
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
            Farmaceuticos Primera = new Farmaceuticos();
            if (Primera.ShowDialog() == DialogResult.OK)
            {
                //Application.Run(new MenuAdministrador("Admin"));
                Application.Run(new LoginMedicHelppercs());
            }
        }
    }
}
