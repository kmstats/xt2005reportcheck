using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace com.echo.dntj
{
    public partial class frmSN : Form
    {
        public frmSN()
        {
            InitializeComponent();
        }

        private void frmSN_Load(object sender, EventArgs e)
        {
            lbSLH.Text = Util.HDVal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbSN.Text == Util.GetSN() || tbSN.Text == Util.GetSN2())
            {
                Util.SaveLicense(tbSN.Text);
                Close();
            }
        }
    }
}