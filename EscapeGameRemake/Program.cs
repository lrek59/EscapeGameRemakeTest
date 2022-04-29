using System;
using System.Windows.Forms;
using EscapeGameRemake.src;

namespace EscapeGameRemake
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Utility.OpenForm(new StartingMenu());
            Application.Run();
        }
    }
}
