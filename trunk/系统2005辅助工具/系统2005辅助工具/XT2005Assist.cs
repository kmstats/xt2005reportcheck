using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace com.echo.XT2005
{
    static class XT2005Assist
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
