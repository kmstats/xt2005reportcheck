using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Diagnostics;

namespace com.echo.dntj
{
    public partial class frmMain : Form
    {
        IUIService UIservice;       
        private string curFilePath;

        public frmMain()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Util.SetTmpChkFile();
            UIservice = (IUIService)this.GetService(typeof(System.Windows.Forms.Design.IUIService));
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            //打开任务文件
            if (OD.ShowDialog() == DialogResult.OK && OD.FileName.Length != 0)
            {
                if (Util.DecompressRAR(OD.FileName, Application.StartupPath + "\\WinRar.exe", Util.curPath))  //解压缩cur年报文件
                    if (NeedSetNB())
                    {
                        frmSet form1 = new frmSet(Util.comPath);
                        form1.ShowDialog();
                        curFilePath = OD.FileName;
                    }
                RWOpened();
            }
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            RWClosed();
        }

        /// <summary>
        /// 检查是否需要设置对比报表文件
        /// </summary>
        /// <returns></returns>
        private Boolean NeedSetNB()
        { 
            try 
	        {	        
                List<string> chkSections = new List<string>();
                Util.tempChkFile.ReadSections(chkSections);
                foreach (string  s in chkSections)
                {
                    List<string> chkSectionValues = new List<string>();
                    Util.tempChkFile.ReadSectionValues(s, chkSectionValues);
                    foreach (string i in chkSectionValues)
                    {
                        if (i.IndexOf('[') > 0)
                            return true;
                    }
                }
                return false;
	        }
	        catch (Exception ex)
	        {
                throw new Exception(ex.Message);
                return false;
	        }
        }

        /// <summary>
        /// 任务打开后的操作
        /// </summary>
        private void RWOpened()
        {
            //菜单切换
            menuOpen.Enabled = false;
            menuClose.Enabled = true;
            //按钮切换
            tbOpen.Enabled = false;
            tbClose.Enabled = true;

            tbChk.Enabled = true;
            tbSM.Enabled = true;

            //当前文件目录
            lblPath.Text = curFilePath;

            //显示组织信息
            ShowOrgInfo();

            //取得审核公式Sections
            GetChkSections();

            //取得审核结果
            Util.SetSM();
            List<string> sections = new List<string>();
            Util.smFile.ReadSections(sections);
            foreach (string s in sections)
            {
                List<string> keys = new List<string>();
                Util.smFile.ReadSection(s, keys);
                foreach (string k in keys)
                {
                    lbResult.Items.Add(s + "-" + k);
                }
            }
        }

        /// <summary>
        /// 任务关闭后的操作
        /// </summary>
        private void RWClosed()
        { 
            //菜单切换
            menuOpen.Enabled = true;
            menuClose.Enabled = false;
            //按钮切换
            tbOpen.Enabled = true;
            tbClose.Enabled = false;
            tbChk.Enabled = false;
            tbSM.Enabled = false;
            //当前文件目录
            lblPath.Text = "";
            //关闭组织信息
            CloseOrgInfo();
            //注销审核公式
            cbKeys.Items.Clear();
            cbSections.Items.Clear();
            //清除消息提示
            rbMsg.Text = "";
            //清除审核公式
            lblChk.Text = "";
            //消除详细数据
            rbDetail.Text = "";
            //清除审核结果
            lbResult.Items.Clear();
            //清除审核说明
            rbSM.Text = "";
        }

        /// <summary>
        /// 从当前年报取得组织信息——内部方法
        /// </summary>
        private void ShowOrgInfo()
        {
            Util.Org o = Util.GetOrg();
            lblOrgId.Text = "组织代码：" + o.Id;
            lblOrgName.Text = "组织名称：" + o.Name;
            lblDate.Text = "报告期：" + o.NbStart + "-" + o.NbEnd;
        }

        private void CloseOrgInfo()
        {
            lblOrgId.Text = "";
            lblOrgName.Text = "";
            lblDate.Text = "";
        }

        /// <summary>
        /// 取得审核公式 Sections——内部方法
        /// </summary>
        private void GetChkSections()
        {
            List<string> l = new List<string>();
            Util.tempChkFile.ReadSections(l);
            cbSections.Items.AddRange(l.ToArray());
        }

        private void GetChk()
        {
            lblChk.Text = Util.tempChkFile.ReadString(cbSections.Text, cbKeys.Text, "");
        }

        /// <summary>
        /// 取得审核公式 Keys——内部方法
        /// </summary>
        private void GetChkKeys()
        {
            cbKeys.Items.Clear();
            cbKeys.Text = "";
            List<string> l = new List<string>();
            Util.tempChkFile.ReadSection(cbSections.Text, l);
            cbKeys.Items.AddRange(l.ToArray());
        }

        /// <summary>
        /// 取得消息提示——内部方法
        /// </summary>
        private void GetMsg()
        {
            rbMsg.Text = Util.msgFile.ReadString(cbSections.Text, cbKeys.Text, ""); 
        }

        /// <summary>
        /// 取得填报说明——方法
        /// </summary>
        private void GetSM()
        {
            rbSM.Text = Util.smFile.ReadString(cbSections.Text, cbKeys.Text, "");
        }

        private void cbSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetChkKeys();       //取得Keys
        }

        private void cbKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetChk();           //取得审核公式
            GetMsg();           //取得消息提示

            chk(lblChk.Text, cbSections.Text, cbKeys.Text);   //单项审核

            GetSM();            //取得填报说明
        }

        private void chk(string chkStr, string section, string key)
        {
            //提取数据，取得公式详细数据
            rbDetail.Text = Util.GetValue(chkStr);
            if (Util.GetBooleanValue(rbDetail.Text))
            {
                if (lbResult.Items.IndexOf(section + "-" + key) < 0)
                {
                    lbResult.Items.Add(section + "-" + key);
                    Util.smFile.WriteString(section, key, chkStr + " || " + Util.GetValue(chkStr) + " || " + rbSM.Text);
                }
            }
            else
            {
                Util.smFile.DeleteKey(section, key);  //删除说明
                lbResult.Items.Remove(section + "-" + key);  //删除结果
            }
        }

        private void cmSaveMsg_Click(object sender, EventArgs e)
        {
            Util.msgFile.WriteString(cbSections.Text, cbKeys.Text, rbMsg.Text);
        }

        private void cmMsg_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = (cbKeys.Text == "" || rbMsg.Text.Trim() == "");
        }

        private void tbMsg_Click(object sender, EventArgs e)
        {
            gpMsg.Visible = !gpMsg.Visible;
            if (gpMsg.Visible)
            {
                tbMsg.Image = imgMain.Images[3];
                tbMsg.Text = "关闭消息提示(&N)";
            }
            else
            {
                tbMsg.Image = imgMain.Images[4];
                tbMsg.Text = "打开消息提示(&M)";
            }
        }

        private void sbResult_Click(object sender, EventArgs e)
        {
            gbResult.Visible = !gbResult.Visible;
            if (gbResult.Visible)
            {
                tbResult.Image = imgMain.Images[9];
                tbResult.Text = "关闭审核结果(&E)";
            }
            else
            {
                tbResult.Image = imgMain.Images[10];
                tbResult.Text = "打开审核结果(&R)";
            }
        }

        private void cmSM_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = (lbResult.SelectedItem == null || rbSM.Text.Trim() == "");
        }

        private void menuSaveSM_Click(object sender, EventArgs e)
        {
           Util.smFile.WriteString(cbSections.Text, cbKeys.Text, rbSM.Text);
        }

        private void lbResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbResult.SelectedItem != null)
            {
                string[] s = lbResult.SelectedItem.ToString().Split('-');
                cbSections.SelectedIndex = cbSections.Items.IndexOf(s[0]);
                cbKeys.SelectedIndex = cbKeys.Items.IndexOf(s[1]);
            }
        }

        private void tbChk_Click(object sender, EventArgs e)
        {
            frmPrograss f = new frmPrograss();
            f.Show();
            foreach (string section in cbSections.Items)
            {
                int i = 0;
                f.lblSection.Text = section;
                f.Update();
                List<string> keys = new List<string>();
                Util.tempChkFile.ReadSection(section, keys);
                foreach (string key in keys)
                {
                    i += 1;
                    f.lblKey.Text = key;
                    f.Update();
                    string chkStr = Util.tempChkFile.ReadString(section, key, "");
                    chk(chkStr, section, key);
                    f.pgBar.Value = 100 / keys.Count * i;
                }
            }
            f.Close();
        }

        private void tbSM_Click(object sender, EventArgs e)
        {
            List<string> sections = new List<string>();
            Util.smFile.ReadSections(sections);
            if (sections.Count > 0)
            {
                Util.Org o = new Util.Org();
                o = Util.GetOrg();
                SD.FileName = o.Id + o.Name + o.NbStart + "-" + o.NbEnd;
                if (SD.ShowDialog() == DialogResult.OK && SD.FileName.Length > 0)
                {
                    System.IO.File.Copy(Util.smFilePath, SD.FileName);
                }
            }
        }

        private void menuSetChk_Click(object sender, EventArgs e)
        {
            frmSetChk f = new frmSetChk();
            f.ShowDialog();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
        }

        private void menuCHM_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\党内统计审核.chm");
        }
    }
}