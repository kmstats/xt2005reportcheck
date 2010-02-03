using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace com.echo.XT2005
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }

        private void OnLinkDB(object sender, EventArgs e)
        {
            orgTree.Nodes.Clear();
            try
            {
                TreeNode pNode = null;
                d01Adapter.FillByTopOrg(db.D01);
                if (db.D01 != null)
                {
                    XT2007.D01Row row = (XT2007.D01Row)db.D01.Rows[0];
                    pNode = orgTree.Nodes.Add(row.D0107, row.D0101 + "(" + row.D0107 + ")");
                    pNode.Name = row.D0107;
                    pNode.ToolTipText = row.D0101 + "(" + row.D0107 + ")";
                }

                d01Adapter.FillByPID(db.D01, pNode.Name);
                foreach (XT2007.D01Row row in db.D01)
                {
                    TreeNode node = pNode.Nodes.Add(row.D0107, row.D0101 + "(" + row.D0107 + ")");
                    node.Name = row.D0107;
                    node.ToolTipText = row.D0101 + "(" + row.D0107 + ")";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("连接系统2005出错，是否启动系统20005？:" + ex);
            }
        }

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
        }

    }
}
