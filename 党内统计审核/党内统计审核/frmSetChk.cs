using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace com.echo.dntj
{
    public partial class frmSetChk : Form
    {
        private NumericUpDown n;
        public frmSetChk()
        {
            InitializeComponent();
        }

        private void frmSetChk_Load(object sender, EventArgs e)
        {
            //在toolStrip加入控件
            n = new NumericUpDown();
            n.TextAlign = HorizontalAlignment.Center;
            n.Minimum = 1;
            n.Value = 9;
            n.ValueChanged += new EventHandler(n_ValueChanged);
            ToolStripControlHost h = new ToolStripControlHost(n);
            toolStrip1.Items.Insert(1, h);
            CheckBox c = new CheckBox();
            c.BackColor = Color.Transparent;
            c.Text = "自动换行";
            c.CheckedChanged += new EventHandler(c_CheckedChanged);
            h = new ToolStripControlHost(c);
            toolStrip1.Items.Insert(3, h);


            //取得系统字体
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (System.Drawing.FontFamily family in fonts.Families)
            {
                cbFont.Items.Add(family.Name);
            }
            cbFont.SelectedIndex = cbFont.Items.IndexOf("宋体");

            richTextBox1.Text = GetChkStr();
        }

        private void n_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(cbFont.Text, (float)(sender as NumericUpDown).Value);
        }

        public void c_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = (sender as CheckBox).Checked;
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font((sender as ToolStripComboBox).Text, (float)n.Value);
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Util.chkFilePath);
            sw.Write(Util.Encrypt(richTextBox1.Text));
            sw.Close();
        }

        private string GetChkStr()
        {
            string result = "";
            StreamReader sr = new StreamReader(Util.chkFilePath);
            result = Util.Decrypt(sr.ReadToEnd());
            sr.Close();
            return result;
        }

        private void tbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}