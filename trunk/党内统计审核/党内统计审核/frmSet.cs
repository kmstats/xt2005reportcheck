using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace com.echo.dntj
{
    public partial class frmSet : Form
    {
        private string savePath;

        public frmSet(string path)
        {
            savePath = path;
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (OD.ShowDialog() == DialogResult.OK && OD.FileName.Length > 0)
                if (Util.DecompressRAR(OD.FileName, Application.StartupPath + "\\WinRar.exe", savePath))
                {
                    tbFile.Text = OD.FileName;
                    btOK.Enabled = true;
                }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}