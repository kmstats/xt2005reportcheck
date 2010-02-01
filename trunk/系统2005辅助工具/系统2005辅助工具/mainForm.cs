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
        com.echo.DB.IDataProvider db;

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
            try
            {
                db = com.echo.DB.DataProvider.CreateDataProvider(com.echo.DB.DataProvider.DataProviderType.KingbaseProvider); //连接数据库

                DataSet ds = db.RetriveDataSet("select D1601,D1601A from D16 order by D0107");
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    TreeNode node;
                    node =orgTree.Nodes.Find(row[0].ToString(), true)[0];
                    if (node != null)
                    {
                        node.Nodes.Add(row[0].ToString(), row[1].ToString());
                    }
                    else
                    {
                        orgTree.Nodes.Add(row[0].ToString(), row[1].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("连接系统2005出错，是否启动系统20005？:" + ex);
            }
        }

    }
}
