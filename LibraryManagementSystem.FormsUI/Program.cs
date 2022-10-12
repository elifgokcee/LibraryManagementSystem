
using LibraryManagamentSystem.FormsUI;
using LibraryManagementSystem.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using log4net;
using PostSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.FormsUI
{
    internal static class Program
    {
    
        /// <summary>
        /// The main ent
        /// ry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         
            Application.Run(new LoginForm());

        }
    }
}