namespace com.echo.dntj
{
    partial class frmPrograss
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
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(12, 62);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(252, 23);
            this.pgBar.TabIndex = 0;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(13, 13);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(0, 12);
            this.lblSection.TabIndex = 1;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(13, 38);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(0, 12);
            this.lblKey.TabIndex = 2;
            // 
            // frmPrograss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(279, 113);
            this.ControlBox = false;
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.pgBar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrograss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrograss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ProgressBar pgBar;
        public System.Windows.Forms.Label lblSection;
        public System.Windows.Forms.Label lblKey;
    }
}