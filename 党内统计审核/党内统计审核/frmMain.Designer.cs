namespace com.echo.dntj
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuTask = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetChk = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCHM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMain = new System.Windows.Forms.ToolStrip();
            this.tbOpen = new System.Windows.Forms.ToolStripButton();
            this.tbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbMsg = new System.Windows.Forms.ToolStripButton();
            this.tbResult = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbChk = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSM = new System.Windows.Forms.ToolStripButton();
            this.sbMain = new System.Windows.Forms.StatusStrip();
            this.lblPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOrgId = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOrgName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbCondition = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbSections = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbKeys = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lblChk = new System.Windows.Forms.ToolStripLabel();
            this.imgMain = new System.Windows.Forms.ImageList(this.components);
            this.gpMsg = new System.Windows.Forms.GroupBox();
            this.rbMsg = new System.Windows.Forms.RichTextBox();
            this.cmMsg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmSaveMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbSM = new System.Windows.Forms.RichTextBox();
            this.cmSM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSaveSM = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDetail = new System.Windows.Forms.RichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.OD = new System.Windows.Forms.OpenFileDialog();
            this.SD = new System.Windows.Forms.SaveFileDialog();
            this.menuMain.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.sbMain.SuspendLayout();
            this.tbCondition.SuspendLayout();
            this.gpMsg.SuspendLayout();
            this.cmMsg.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.cmSM.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTask,
            this.menuSet,
            this.menuHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(893, 25);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuTask
            // 
            this.menuTask.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.menuClose,
            this.toolStripMenuItem1,
            this.menuExit});
            this.menuTask.Name = "menuTask";
            this.menuTask.Size = new System.Drawing.Size(60, 21);
            this.menuTask.Text = "任务(&R)";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(151, 22);
            this.menuOpen.Text = "打开任务(&O)...";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuClose
            // 
            this.menuClose.Enabled = false;
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(151, 22);
            this.menuClose.Text = "关闭任务(&C)";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(151, 22);
            this.menuExit.Text = "退出(&X)";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuSet
            // 
            this.menuSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSetChk});
            this.menuSet.Name = "menuSet";
            this.menuSet.Size = new System.Drawing.Size(59, 21);
            this.menuSet.Text = "设置(&S)";
            // 
            // menuSetChk
            // 
            this.menuSetChk.Name = "menuSetChk";
            this.menuSetChk.Size = new System.Drawing.Size(165, 22);
            this.menuSetChk.Text = "设置审核公式(&G)";
            this.menuSetChk.Click += new System.EventHandler(this.menuSetChk_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCHM,
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(61, 21);
            this.menuHelp.Text = "帮助(&H)";
            // 
            // menuCHM
            // 
            this.menuCHM.Name = "menuCHM";
            this.menuCHM.Size = new System.Drawing.Size(144, 22);
            this.menuCHM.Text = "使用手册(&M)";
            this.menuCHM.Click += new System.EventHandler(this.menuCHM_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(144, 22);
            this.menuAbout.Text = "关于(&A)...";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // tbMain
            // 
            this.tbMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbOpen,
            this.tbClose,
            this.toolStripSeparator1,
            this.tbMsg,
            this.tbResult,
            this.toolStripSeparator2,
            this.tbChk,
            this.toolStripSeparator3,
            this.tbSM});
            this.tbMain.Location = new System.Drawing.Point(0, 25);
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(893, 31);
            this.tbMain.TabIndex = 1;
            this.tbMain.Text = "toolStrip1";
            // 
            // tbOpen
            // 
            this.tbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbOpen.Image")));
            this.tbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Size = new System.Drawing.Size(28, 28);
            this.tbOpen.Text = "打开任务(&O)...";
            this.tbOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // tbClose
            // 
            this.tbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbClose.Enabled = false;
            this.tbClose.Image = ((System.Drawing.Image)(resources.GetObject("tbClose.Image")));
            this.tbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbClose.Name = "tbClose";
            this.tbClose.Size = new System.Drawing.Size(28, 28);
            this.tbClose.Text = "关闭任务(&C)";
            this.tbClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tbMsg
            // 
            this.tbMsg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbMsg.Image = ((System.Drawing.Image)(resources.GetObject("tbMsg.Image")));
            this.tbMsg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(28, 28);
            this.tbMsg.Text = "关闭消息提示(&N)";
            this.tbMsg.Click += new System.EventHandler(this.tbMsg_Click);
            // 
            // tbResult
            // 
            this.tbResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbResult.Image = ((System.Drawing.Image)(resources.GetObject("tbResult.Image")));
            this.tbResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(28, 28);
            this.tbResult.Text = "关闭审核结果(&E)";
            this.tbResult.Click += new System.EventHandler(this.sbResult_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tbChk
            // 
            this.tbChk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbChk.Enabled = false;
            this.tbChk.Image = ((System.Drawing.Image)(resources.GetObject("tbChk.Image")));
            this.tbChk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbChk.Name = "tbChk";
            this.tbChk.Size = new System.Drawing.Size(28, 28);
            this.tbChk.Text = "批量审核(&P)";
            this.tbChk.Click += new System.EventHandler(this.tbChk_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // tbSM
            // 
            this.tbSM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSM.Enabled = false;
            this.tbSM.Image = ((System.Drawing.Image)(resources.GetObject("tbSM.Image")));
            this.tbSM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSM.Name = "tbSM";
            this.tbSM.Size = new System.Drawing.Size(28, 28);
            this.tbSM.Text = "导出填报说明(&D)";
            this.tbSM.Click += new System.EventHandler(this.tbSM_Click);
            // 
            // sbMain
            // 
            this.sbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPath,
            this.lblOrgId,
            this.lblOrgName,
            this.lblDate});
            this.sbMain.Location = new System.Drawing.Point(0, 588);
            this.sbMain.Name = "sbMain";
            this.sbMain.Size = new System.Drawing.Size(893, 22);
            this.sbMain.TabIndex = 2;
            this.sbMain.Text = "statusStrip1";
            // 
            // lblPath
            // 
            this.lblPath.AutoToolTip = true;
            this.lblPath.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblPath.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(866, 17);
            this.lblPath.Spring = true;
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrgId
            // 
            this.lblOrgId.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblOrgId.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblOrgId.Name = "lblOrgId";
            this.lblOrgId.Size = new System.Drawing.Size(4, 17);
            // 
            // lblOrgName
            // 
            this.lblOrgName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblOrgName.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblOrgName.Name = "lblOrgName";
            this.lblOrgName.Size = new System.Drawing.Size(4, 17);
            // 
            // lblDate
            // 
            this.lblDate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblDate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(4, 17);
            // 
            // tbCondition
            // 
            this.tbCondition.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cbSections,
            this.toolStripLabel2,
            this.cbKeys,
            this.toolStripLabel3,
            this.lblChk});
            this.tbCondition.Location = new System.Drawing.Point(0, 56);
            this.tbCondition.Name = "tbCondition";
            this.tbCondition.Size = new System.Drawing.Size(893, 25);
            this.tbCondition.TabIndex = 3;
            this.tbCondition.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "审核分类：";
            // 
            // cbSections
            // 
            this.cbSections.AutoToolTip = true;
            this.cbSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSections.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbSections.Name = "cbSections";
            this.cbSections.Size = new System.Drawing.Size(121, 25);
            this.cbSections.SelectedIndexChanged += new System.EventHandler(this.cbSections_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(84, 22);
            this.toolStripLabel2.Text = "    数据检查：";
            // 
            // cbKeys
            // 
            this.cbKeys.AutoToolTip = true;
            this.cbKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeys.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbKeys.Name = "cbKeys";
            this.cbKeys.Size = new System.Drawing.Size(300, 25);
            this.cbKeys.SelectedIndexChanged += new System.EventHandler(this.cbKeys_SelectedIndexChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(84, 22);
            this.toolStripLabel3.Text = "    审核公式：";
            // 
            // lblChk
            // 
            this.lblChk.ForeColor = System.Drawing.Color.Red;
            this.lblChk.Name = "lblChk";
            this.lblChk.Size = new System.Drawing.Size(0, 22);
            // 
            // imgMain
            // 
            this.imgMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMain.ImageStream")));
            this.imgMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMain.Images.SetKeyName(0, "0.bmp");
            this.imgMain.Images.SetKeyName(1, "1.bmp");
            this.imgMain.Images.SetKeyName(2, "2.bmp");
            this.imgMain.Images.SetKeyName(3, "3.bmp");
            this.imgMain.Images.SetKeyName(4, "4.bmp");
            this.imgMain.Images.SetKeyName(5, "5.bmp");
            this.imgMain.Images.SetKeyName(6, "6.bmp");
            this.imgMain.Images.SetKeyName(7, "7.bmp");
            this.imgMain.Images.SetKeyName(8, "8.bmp");
            this.imgMain.Images.SetKeyName(9, "9.bmp");
            this.imgMain.Images.SetKeyName(10, "10.bmp");
            // 
            // gpMsg
            // 
            this.gpMsg.Controls.Add(this.rbMsg);
            this.gpMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpMsg.Location = new System.Drawing.Point(0, 81);
            this.gpMsg.Name = "gpMsg";
            this.gpMsg.Size = new System.Drawing.Size(893, 100);
            this.gpMsg.TabIndex = 4;
            this.gpMsg.TabStop = false;
            this.gpMsg.Text = "消息提示";
            // 
            // rbMsg
            // 
            this.rbMsg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rbMsg.ContextMenuStrip = this.cmMsg;
            this.rbMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbMsg.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbMsg.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rbMsg.Location = new System.Drawing.Point(3, 17);
            this.rbMsg.Name = "rbMsg";
            this.rbMsg.Size = new System.Drawing.Size(887, 80);
            this.rbMsg.TabIndex = 0;
            this.rbMsg.Text = "";
            // 
            // cmMsg
            // 
            this.cmMsg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmSaveMsg});
            this.cmMsg.Name = "cmMsg";
            this.cmMsg.Size = new System.Drawing.Size(116, 26);
            this.cmMsg.Opening += new System.ComponentModel.CancelEventHandler(this.cmMsg_Opening);
            // 
            // cmSaveMsg
            // 
            this.cmSaveMsg.Name = "cmSaveMsg";
            this.cmSaveMsg.Size = new System.Drawing.Size(115, 22);
            this.cmSaveMsg.Text = "保存(&S)";
            this.cmSaveMsg.Click += new System.EventHandler(this.cmSaveMsg_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 181);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(893, 5);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.gbResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 402);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.splitter3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(205, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 402);
            this.panel2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbSM);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(688, 297);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "情况说明";
            // 
            // rbSM
            // 
            this.rbSM.ContextMenuStrip = this.cmSM;
            this.rbSM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbSM.Location = new System.Drawing.Point(3, 17);
            this.rbSM.Name = "rbSM";
            this.rbSM.Size = new System.Drawing.Size(682, 277);
            this.rbSM.TabIndex = 0;
            this.rbSM.Text = "";
            // 
            // cmSM
            // 
            this.cmSM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSaveSM});
            this.cmSM.Name = "cmSM";
            this.cmSM.Size = new System.Drawing.Size(116, 26);
            this.cmSM.Opening += new System.ComponentModel.CancelEventHandler(this.cmSM_Opening);
            // 
            // menuSaveSM
            // 
            this.menuSaveSM.Name = "menuSaveSM";
            this.menuSaveSM.Size = new System.Drawing.Size(115, 22);
            this.menuSaveSM.Text = "保存(&S)";
            this.menuSaveSM.Click += new System.EventHandler(this.menuSaveSM_Click);
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 100);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(688, 5);
            this.splitter3.TabIndex = 1;
            this.splitter3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDetail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "详细数据";
            // 
            // rbDetail
            // 
            this.rbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbDetail.Location = new System.Drawing.Point(3, 17);
            this.rbDetail.Name = "rbDetail";
            this.rbDetail.ReadOnly = true;
            this.rbDetail.Size = new System.Drawing.Size(682, 80);
            this.rbDetail.TabIndex = 0;
            this.rbDetail.Text = "";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(200, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 402);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.lbResult);
            this.gbResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbResult.Location = new System.Drawing.Point(0, 0);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(200, 402);
            this.gbResult.TabIndex = 0;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "审核结果";
            // 
            // lbResult
            // 
            this.lbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 12;
            this.lbResult.Location = new System.Drawing.Point(3, 17);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(194, 376);
            this.lbResult.TabIndex = 0;
            this.lbResult.SelectedIndexChanged += new System.EventHandler(this.lbResult_SelectedIndexChanged);
            // 
            // OD
            // 
            this.OD.Filter = "党内统计年报表(*.rar)|*.rar";
            // 
            // SD
            // 
            this.SD.DefaultExt = "sm";
            this.SD.Filter = "填报说明文件(*.sm)|*.sm";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.gpMsg);
            this.Controls.Add(this.tbCondition);
            this.Controls.Add(this.sbMain);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "党内统计审核 2009年报";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.tbMain.ResumeLayout(false);
            this.tbMain.PerformLayout();
            this.sbMain.ResumeLayout(false);
            this.sbMain.PerformLayout();
            this.tbCondition.ResumeLayout(false);
            this.tbCondition.PerformLayout();
            this.gpMsg.ResumeLayout(false);
            this.cmMsg.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.cmSM.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuTask;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStrip tbMain;
        private System.Windows.Forms.StatusStrip sbMain;
        private System.Windows.Forms.ToolStrip tbCondition;
        private System.Windows.Forms.ToolStripMenuItem menuSet;
        private System.Windows.Forms.ToolStripMenuItem menuSetChk;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuCHM;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripButton tbOpen;
        private System.Windows.Forms.ToolStripButton tbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbMsg;
        private System.Windows.Forms.ToolStripButton tbResult;
        private System.Windows.Forms.ToolStripStatusLabel lblPath;
        private System.Windows.Forms.ToolStripStatusLabel lblOrgId;
        private System.Windows.Forms.ToolStripStatusLabel lblOrgName;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ImageList imgMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbChk;
        private System.Windows.Forms.ToolStripButton tbSM;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbSections;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cbKeys;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lblChk;
        private System.Windows.Forms.GroupBox gpMsg;
        private System.Windows.Forms.RichTextBox rbMsg;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rbDetail;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.RichTextBox rbSM;
        private System.Windows.Forms.OpenFileDialog OD;
        private System.Windows.Forms.ContextMenuStrip cmMsg;
        private System.Windows.Forms.ToolStripMenuItem cmSaveMsg;
        private System.Windows.Forms.ContextMenuStrip cmSM;
        private System.Windows.Forms.ToolStripMenuItem menuSaveSM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.SaveFileDialog SD;
    }
}

