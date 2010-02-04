namespace com.echo.XT2005
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainToolbar = new System.Windows.Forms.ToolStrip();
            this.mainStatusbar = new System.Windows.Forms.StatusStrip();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rptPanel = new System.Windows.Forms.SplitContainer();
            this.rptLeftPanel = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orgTree = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rptGrid = new System.Windows.Forms.DataGridView();
            this.rptToolbar = new System.Windows.Forms.ToolStrip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.db = new com.echo.XT2005.XT2007();
            this.d01Adapter = new com.echo.XT2005.XT2007TableAdapters.D01TableAdapter();
            this.rptAdapter = new com.echo.XT2005.XT2007TableAdapters.RPTREPORTTableAdapter();
            this.d01_dictAdapter = new com.echo.XT2005.XT2007TableAdapters.D01_dictTableAdapter();
            this.menuLinkDB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainAction = new com.echo.Controls.Actions.ActionList();
            this.acLinkDB = new com.echo.Controls.Actions.Action();
            this.acSet = new com.echo.Controls.Actions.Action();
            this.acExit = new com.echo.Controls.Actions.Action();
            this.axCell1 = new AxCELL50Lib.AxCell();
            this.mainMenu.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.rptPanel.Panel1.SuspendLayout();
            this.rptPanel.Panel2.SuspendLayout();
            this.rptPanel.SuspendLayout();
            this.rptLeftPanel.Panel1.SuspendLayout();
            this.rptLeftPanel.Panel2.SuspendLayout();
            this.rptLeftPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rptGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCell1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(798, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLinkDB,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.退出XToolStripMenuItem});
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(59, 20);
            this.menuSystem.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_SYSTEM;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // mainToolbar
            // 
            this.mainToolbar.Location = new System.Drawing.Point(0, 24);
            this.mainToolbar.Name = "mainToolbar";
            this.mainToolbar.Size = new System.Drawing.Size(798, 25);
            this.mainToolbar.TabIndex = 1;
            this.mainToolbar.Text = "toolStrip1";
            // 
            // mainStatusbar
            // 
            this.mainStatusbar.Location = new System.Drawing.Point(0, 460);
            this.mainStatusbar.Name = "mainStatusbar";
            this.mainStatusbar.Size = new System.Drawing.Size(798, 22);
            this.mainStatusbar.TabIndex = 2;
            this.mainStatusbar.Text = "statusStrip1";
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.tabPage1);
            this.mainTab.Controls.Add(this.tabPage2);
            this.mainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTab.Location = new System.Drawing.Point(0, 49);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(798, 411);
            this.mainTab.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rptPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_RPTCHECK;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rptPanel
            // 
            this.rptPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptPanel.Location = new System.Drawing.Point(3, 3);
            this.rptPanel.Name = "rptPanel";
            // 
            // rptPanel.Panel1
            // 
            this.rptPanel.Panel1.Controls.Add(this.rptLeftPanel);
            // 
            // rptPanel.Panel2
            // 
            this.rptPanel.Panel2.Controls.Add(this.axCell1);
            this.rptPanel.Panel2.Controls.Add(this.rptGrid);
            this.rptPanel.Panel2.Controls.Add(this.rptToolbar);
            this.rptPanel.Size = new System.Drawing.Size(784, 380);
            this.rptPanel.SplitterDistance = 174;
            this.rptPanel.TabIndex = 0;
            // 
            // rptLeftPanel
            // 
            this.rptLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.rptLeftPanel.Name = "rptLeftPanel";
            this.rptLeftPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // rptLeftPanel.Panel1
            // 
            this.rptLeftPanel.Panel1.Controls.Add(this.groupBox1);
            // 
            // rptLeftPanel.Panel2
            // 
            this.rptLeftPanel.Panel2.Controls.Add(this.groupBox2);
            this.rptLeftPanel.Size = new System.Drawing.Size(174, 380);
            this.rptLeftPanel.SplitterDistance = 203;
            this.rptLeftPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orgTree);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_ORGTREE;
            // 
            // orgTree
            // 
            this.orgTree.CheckBoxes = true;
            this.orgTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orgTree.HotTracking = true;
            this.orgTree.Indent = 14;
            this.orgTree.Location = new System.Drawing.Point(3, 17);
            this.orgTree.Name = "orgTree";
            this.orgTree.ShowLines = false;
            this.orgTree.ShowNodeToolTips = true;
            this.orgTree.ShowRootLines = false;
            this.orgTree.Size = new System.Drawing.Size(168, 183);
            this.orgTree.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 173);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_CHECKRULE;
            // 
            // rptGrid
            // 
            this.rptGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rptGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptGrid.Location = new System.Drawing.Point(0, 25);
            this.rptGrid.Name = "rptGrid";
            this.rptGrid.RowTemplate.Height = 23;
            this.rptGrid.Size = new System.Drawing.Size(606, 355);
            this.rptGrid.TabIndex = 1;
            // 
            // rptToolbar
            // 
            this.rptToolbar.Location = new System.Drawing.Point(0, 0);
            this.rptToolbar.Name = "rptToolbar";
            this.rptToolbar.Size = new System.Drawing.Size(606, 25);
            this.rptToolbar.TabIndex = 0;
            this.rptToolbar.Text = "toolStrip1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // db
            // 
            this.db.DataSetName = "XT2007";
            this.db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // d01Adapter
            // 
            this.d01Adapter.ClearBeforeFill = true;
            // 
            // rptAdapter
            // 
            this.rptAdapter.ClearBeforeFill = true;
            // 
            // d01_dictAdapter
            // 
            this.d01_dictAdapter.ClearBeforeFill = true;
            // 
            // menuLinkDB
            // 
            this.mainAction.SetAction(this.menuLinkDB, this.acLinkDB);
            this.menuLinkDB.Name = "menuLinkDB";
            this.menuLinkDB.Size = new System.Drawing.Size(160, 22);
            this.menuLinkDB.Text = "连接到数据库(&L)";
            // 
            // toolStripMenuItem2
            // 
            this.mainAction.SetAction(this.toolStripMenuItem2, this.acSet);
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem2.Text = "设置报表参数(&O)";
            // 
            // 退出XToolStripMenuItem
            // 
            this.mainAction.SetAction(this.退出XToolStripMenuItem, this.acExit);
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            // 
            // mainAction
            // 
            this.mainAction.Actions.Add(this.acExit);
            this.mainAction.Actions.Add(this.acLinkDB);
            this.mainAction.Actions.Add(this.acSet);
            this.mainAction.ContainerControl = this;
            // 
            // acLinkDB
            // 
            this.acLinkDB.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_LINKDB;
            this.acLinkDB.ToolTipText = global::com.echo.XT2005.Properties.Settings.Default.STR_LINKDB;
            this.acLinkDB.Update += new System.EventHandler(this.acLinkDB_Update);
            this.acLinkDB.Execute += new System.EventHandler(this.OnLinkDB);
            // 
            // acSet
            // 
            this.acSet.Enabled = false;
            this.acSet.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_SETRPT;
            this.acSet.ToolTipText = global::com.echo.XT2005.Properties.Settings.Default.STR_SETRPT;
            this.acSet.Update += new System.EventHandler(this.acSet_Update);
            this.acSet.Execute += new System.EventHandler(this.OnSet);
            // 
            // acExit
            // 
            this.acExit.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_EXIT;
            this.acExit.ToolTipText = global::com.echo.XT2005.Properties.Settings.Default.STR_EXIT;
            this.acExit.Execute += new System.EventHandler(this.OnExit);
            // 
            // axCell1
            // 
            this.axCell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axCell1.Enabled = true;
            this.axCell1.Location = new System.Drawing.Point(0, 25);
            this.axCell1.Name = "axCell1";
            this.axCell1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCell1.OcxState")));
            this.axCell1.Size = new System.Drawing.Size(606, 355);
            this.axCell1.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(798, 482);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.mainStatusbar);
            this.Controls.Add(this.mainToolbar);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_TITLE;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.rptPanel.Panel1.ResumeLayout(false);
            this.rptPanel.Panel2.ResumeLayout(false);
            this.rptPanel.Panel2.PerformLayout();
            this.rptPanel.ResumeLayout(false);
            this.rptLeftPanel.Panel1.ResumeLayout(false);
            this.rptLeftPanel.Panel2.ResumeLayout(false);
            this.rptLeftPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rptGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCell1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStrip mainToolbar;
        private System.Windows.Forms.StatusStrip mainStatusbar;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private com.echo.Controls.Actions.ActionList mainAction;
        private com.echo.Controls.Actions.Action acExit;
        private System.Windows.Forms.ToolStripMenuItem menuLinkDB;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private com.echo.Controls.Actions.Action acLinkDB;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer rptPanel;
        private System.Windows.Forms.SplitContainer rptLeftPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView rptGrid;
        private System.Windows.Forms.ToolStrip rptToolbar;
        private XT2007 db;
        private com.echo.XT2005.XT2007TableAdapters.D01TableAdapter d01Adapter;
        private com.echo.Controls.Actions.Action acSet;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private com.echo.XT2005.XT2007TableAdapters.RPTREPORTTableAdapter rptAdapter;
        private com.echo.XT2005.XT2007TableAdapters.D01_dictTableAdapter d01_dictAdapter;
        private System.Windows.Forms.TreeView orgTree;
        private AxCELL50Lib.AxCell axCell1;
    }
}

