namespace com.echo.XT2005
{
    partial class setForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.durationGrid = new System.Windows.Forms.DataGridView();
            this.dURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEGINTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db = new com.echo.XT2005.XT2007();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.templateGrid = new System.Windows.Forms.DataGridView();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationAdapter = new com.echo.XT2005.XT2007TableAdapters.T_RPT_DURATIONTableAdapter();
            this.templateAdapter = new com.echo.XT2005.XT2007TableAdapters.RPTTEMPLATECLASSTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templateGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.durationGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_DURATION;
            // 
            // durationGrid
            // 
            this.durationGrid.AllowUserToAddRows = false;
            this.durationGrid.AllowUserToDeleteRows = false;
            this.durationGrid.AllowUserToResizeColumns = false;
            this.durationGrid.AllowUserToResizeRows = false;
            this.durationGrid.AutoGenerateColumns = false;
            this.durationGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.durationGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.durationGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.durationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.durationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dURNAMEDataGridViewTextBoxColumn,
            this.bEGINTIMEDataGridViewTextBoxColumn,
            this.eNDTIMEDataGridViewTextBoxColumn});
            this.durationGrid.DataMember = "T_RPT_DURATION";
            this.durationGrid.DataSource = this.db;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.durationGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.durationGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.durationGrid.Location = new System.Drawing.Point(3, 17);
            this.durationGrid.MultiSelect = false;
            this.durationGrid.Name = "durationGrid";
            this.durationGrid.ReadOnly = true;
            this.durationGrid.RowHeadersVisible = false;
            this.durationGrid.RowTemplate.Height = 23;
            this.durationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.durationGrid.Size = new System.Drawing.Size(226, 197);
            this.durationGrid.TabIndex = 0;
            // 
            // dURNAMEDataGridViewTextBoxColumn
            // 
            this.dURNAMEDataGridViewTextBoxColumn.DataPropertyName = "DURNAME";
            this.dURNAMEDataGridViewTextBoxColumn.HeaderText = "报告期";
            this.dURNAMEDataGridViewTextBoxColumn.Name = "dURNAMEDataGridViewTextBoxColumn";
            this.dURNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dURNAMEDataGridViewTextBoxColumn.Width = 66;
            // 
            // bEGINTIMEDataGridViewTextBoxColumn
            // 
            this.bEGINTIMEDataGridViewTextBoxColumn.DataPropertyName = "BEGINTIME";
            this.bEGINTIMEDataGridViewTextBoxColumn.HeaderText = "开始时间";
            this.bEGINTIMEDataGridViewTextBoxColumn.Name = "bEGINTIMEDataGridViewTextBoxColumn";
            this.bEGINTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bEGINTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // eNDTIMEDataGridViewTextBoxColumn
            // 
            this.eNDTIMEDataGridViewTextBoxColumn.DataPropertyName = "ENDTIME";
            this.eNDTIMEDataGridViewTextBoxColumn.HeaderText = "结束时间";
            this.eNDTIMEDataGridViewTextBoxColumn.Name = "eNDTIMEDataGridViewTextBoxColumn";
            this.eNDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNDTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // db
            // 
            this.db.DataSetName = "XT2007";
            this.db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.templateGrid);
            this.groupBox2.Location = new System.Drawing.Point(247, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_TEMPLATE;
            // 
            // templateGrid
            // 
            this.templateGrid.AllowUserToAddRows = false;
            this.templateGrid.AllowUserToDeleteRows = false;
            this.templateGrid.AllowUserToResizeColumns = false;
            this.templateGrid.AllowUserToResizeRows = false;
            this.templateGrid.AutoGenerateColumns = false;
            this.templateGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.templateGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.templateGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.templateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.templateGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.cLASSIDDataGridViewTextBoxColumn});
            this.templateGrid.DataMember = "RPTTEMPLATECLASS";
            this.templateGrid.DataSource = this.db;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.templateGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.templateGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateGrid.Location = new System.Drawing.Point(3, 17);
            this.templateGrid.MultiSelect = false;
            this.templateGrid.Name = "templateGrid";
            this.templateGrid.ReadOnly = true;
            this.templateGrid.RowHeadersVisible = false;
            this.templateGrid.RowTemplate.Height = 23;
            this.templateGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.templateGrid.Size = new System.Drawing.Size(234, 197);
            this.templateGrid.TabIndex = 1;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn.Width = 54;
            // 
            // cLASSIDDataGridViewTextBoxColumn
            // 
            this.cLASSIDDataGridViewTextBoxColumn.DataPropertyName = "CLASSID";
            this.cLASSIDDataGridViewTextBoxColumn.HeaderText = "编号";
            this.cLASSIDDataGridViewTextBoxColumn.Name = "cLASSIDDataGridViewTextBoxColumn";
            this.cLASSIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLASSIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // durationAdapter
            // 
            this.durationAdapter.ClearBeforeFill = true;
            // 
            // templateAdapter
            // 
            this.templateAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(163, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_OK;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(256, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_CANCEL;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // setForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 276);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "setForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_SETRPTFORM;
            this.Load += new System.EventHandler(this.setForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.durationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.templateGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView durationGrid;
        private com.echo.XT2005.XT2007TableAdapters.T_RPT_DURATIONTableAdapter durationAdapter;
        private com.echo.XT2005.XT2007TableAdapters.RPTTEMPLATECLASSTableAdapter templateAdapter;
        private XT2007 db;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bEGINTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView templateGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}