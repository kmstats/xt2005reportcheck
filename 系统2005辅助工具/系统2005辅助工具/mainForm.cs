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
    public partial class mainForm : Form
    {
        Boolean IsLinked = false;

        public mainForm()
        {
            InitializeComponent();
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("regsvr32", " /s kdbole6.dll");
            p.WaitForInputIdle();

            axCell1.OpenFile(@"D:\系统2005(V2.0)\measureremark\11000300.cll", "");
        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }

        private void OnLinkDB(object sender, EventArgs e)
        {
            if (IsLinked==false)
            {
                GetRptOrg();
                IsLinked = true;
            }
            else
            {
                IsLinked = false;
                orgTree.Nodes.Clear();
            }
        }

        //取得报表组织数
        private void GetRptOrg()
        {
            orgTree.Nodes.Clear();
            rptAdapter.FillByDuration(db.RPTREPORT, Settings.Default.USER_RPTID, Settings.Default.USER_BEGIN, Settings.Default.USER_END);
            if (db.RPTREPORT != null)
            {
                d01_dictAdapter.Fill(db.D01_dict);
                foreach (XT2007.RPTREPORTRow row in db.RPTREPORT)
                {
                    TreeNode node = orgTree.Nodes.Add(row.ORGID, row.D01_dictRow.D0101 + "(" + row.ORGID + ")");
                    node.ToolTipText = row.D01_dictRow.D0101 + "(" + row.ORGID + ")";
                }
            }
        }


        //取得组织树
        //private void GetOrg()
        //{
        //    try
        //    {
        //        TreeNode pNode = null;
        //        d01Adapter.FillByTopOrg(db.D01);
        //        if (db.D01 != null)
        //        {
        //            XT2007.D01Row row = (XT2007.D01Row)db.D01.Rows[0];
        //            pNode = orgTree.Nodes.Add(row.D0107, row.D0101 + "(" + row.D0107 + ")");
        //            pNode.Name = row.D0107;
        //            pNode.ToolTipText = row.D0101 + "(" + row.D0107 + ")";
        //        }

        //        d01Adapter.FillByPID(db.D01, pNode.Name);
        //        foreach (XT2007.D01Row row in db.D01)
        //        {
        //            TreeNode node = pNode.Nodes.Add(row.D0107, row.D0101 + "(" + row.D0107 + ")");
        //            node.Name = row.D0107;
        //            node.ToolTipText = row.D0101 + "(" + row.D0107 + ")";
        //        }
        //        IsLinked = true;
        //    }
        //    catch (System.Data.OleDb.OleDbException)
        //    {
        //        MessageBox.Show(Settings.Default.STR_NOLINK);
        //    }
        //}

        //在展开node前，添加孙级节点
        private void orgTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            foreach (TreeNode node in e.Node.Nodes)
            {
                if (node.Nodes.Count == 0)
                {
                    d01Adapter.FillByPID(db.D01,node.Name);
                    if (db.D01.Rows.Count > 0)
                    {
                        foreach (XT2007.D01Row row in db.D01.Rows)
                        {
                            TreeNode subNode = node.Nodes.Add(row.D0107, row.D0101 + "(" + row.D0107 + ")");
                            subNode.Name = row.D0107;
                            subNode.ToolTipText = row.D0101 + "(" + row.D0107 + ")";
                        }
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void OnSet(object sender, EventArgs e)
        {
            setForm form = new setForm();
            form.ShowDialog();
            GetRptOrg();
        }

        private void acSet_Update(object sender, EventArgs e)
        {
            acSet.Enabled = IsLinked;
        }

        private void acLinkDB_Update(object sender, EventArgs e)
        {
            acLinkDB.Text = IsLinked ? Settings.Default.STR_CLOSEDB : Settings.Default.STR_LINKDB;
            acLinkDB.ToolTipText = IsLinked ? Settings.Default.STR_CLOSEDB : Settings.Default.STR_LINKDB;
        }
    }
}
