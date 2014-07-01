using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NumberGenerator
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
            /* This is being commented out for new startup form
            Application.Run(new RawForm());
             */
            Application.Run(new MainMenu());
            //Application.Run(new CoinFlipForm());
        }
    }
}
