using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace com.echo.XT2005
{
    public partial class setForm : Form
    {
        public setForm()
        {
            InitializeComponent();
        }

        private void setForm_Load(object sender, EventArgs e)
        {
            durationAdapter.Fill(db.T_RPT_DURATION);
            templateAdapter.Fill(db.RPTTEMPLATECLASS);
        }
    }
}
