using Fiszki.Model;
using Fiszki.View;
using Fiszki.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiszki
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

            DataBase DataBase = new DataBase(); //Model
            WindowFiszki FormFiszki = new WindowFiszki(); //View
            PresenterFiszki Presenter = new PresenterFiszki(DataBase, FormFiszki); //Presenter

            Application.Run(FormFiszki);
        }
    }
}
