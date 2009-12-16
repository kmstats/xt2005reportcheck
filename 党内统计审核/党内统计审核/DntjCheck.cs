using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace com.echo.dntj
{
    static class DntjCheck
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Util.SetPath(Application.StartupPath);


            //if (Util.GetLicense() != Util.GetSN() && Util.GetLicense() != Util.GetSN2())
            //{
            //    frmSN f = new frmSN();
            //    f.ShowDialog();
            //}

            Application.Run(new frmMain());
        }
    }
}