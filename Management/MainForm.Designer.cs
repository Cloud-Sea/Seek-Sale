namespace Management
{
    partial class MainForm
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
            this.ManageTab = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.itemStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManageTab
            // 
            this.ManageTab.Location = new System.Drawing.Point(0, 28);
            this.ManageTab.Name = "ManageTab";
            this.ManageTab.SelectedIndex = 0;
            this.ManageTab.Size = new System.Drawing.Size(586, 340);
            this.ManageTab.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userStrip,
            this.itemStrip,
            this.addStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userStrip
            // 
            this.userStrip.Name = "userStrip";
            this.userStrip.Size = new System.Drawing.Size(68, 21);
            this.userStrip.Text = "查找用户";
            this.userStrip.Click += new System.EventHandler(this.userStrip_Click);
            // 
            // itemStrip
            // 
            this.itemStrip.Name = "itemStrip";
            this.itemStrip.Size = new System.Drawing.Size(68, 21);
            this.itemStrip.Text = "查找商品";
            this.itemStrip.Click += new System.EventHandler(this.itemStrip_Click);
            // 
            // addStrip
            // 
            this.addStrip.Name = "addStrip";
            this.addStrip.Size = new System.Drawing.Size(68, 21);
            this.addStrip.Text = "添加记录";
            this.addStrip.Click += new System.EventHandler(this.addStrip_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.ManageTab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ManageTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userStrip;
        private System.Windows.Forms.ToolStripMenuItem itemStrip;
        private System.Windows.Forms.ToolStripMenuItem addStrip;

    }
}

