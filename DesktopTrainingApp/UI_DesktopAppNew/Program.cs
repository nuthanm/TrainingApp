using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UI_DesktopAppNew.Security;
using UI_DesktopAppNew.Fees;
using UI_DesktopAppNew.Enquiry;
namespace UI_DesktopAppNew
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
