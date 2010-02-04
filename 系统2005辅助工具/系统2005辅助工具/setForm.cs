using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.echo.XT2005.Properties;

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

            //移动选择到预置报告期
            foreach (DataGridViewRow row in durationGrid.Rows)
            {
                if ((row.Cells[1].Value.ToString() == Settings.Default.USER_BEGIN) && (row.Cells[2].Value.ToString() == Settings.Default.USER_END))
                {
                    int i = durationGrid.Rows.IndexOf(row);
                    durationGrid.Rows[i].Selected = true;
                }
            }

            //移动选择到预置报表模板
            foreach (DataGridViewRow row in templateGrid.Rows)
            {
                if (row.Cells[1].Value.ToString() == Settings.Default.USER_RPTID)
                    templateGrid.Rows[templateGrid.Rows.IndexOf(row)].Selected = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow durationRow = durationGrid.SelectedRows[0];
            DataGridViewRow templateRow = templateGrid.SelectedRows[0];
            Settings.Default.USER_DURATION = durationRow.Cells[0].Value.ToString();
            Settings.Default.USER_BEGIN = durationRow.Cells[1].Value.ToString();
            Settings.Default.USER_END = durationRow.Cells[2].Value.ToString();
            Settings.Default.USER_RPTID = templateRow.Cells[1].Value.ToString();

        }
    }
}
