using Secretaria.Formularios;
using Secretaria.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretaria
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginSenha ls = new LoginSenha();
            if (ls.EstaVasio())
            {
                Application.Run(new PrimeiroAcesso());
                Application.Run(new Login());
            }
            else
            {
                Application.Run(new Login());
            }
        }
    }
}
