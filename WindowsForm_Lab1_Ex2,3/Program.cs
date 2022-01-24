using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab1_2_3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new nForm());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);   
        }
    }
}
