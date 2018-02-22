using NPP.DbCnxt;
using NPP.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NPP
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
            using (PrintViewerContext cntx = new PrintViewerContext())
                //(PrintViewerContext cntx = new PrintViewerContext(ConfigurationManager.ConnectionStrings["PrintViewerContext"].ConnectionString))
            {
                IRepository repository = new CntxRepository(cntx);
                Application.Run(new MainForm(repository));
            }
        }
    }
}
