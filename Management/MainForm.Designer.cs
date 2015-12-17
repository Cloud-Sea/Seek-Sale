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
            this.UserTab = new System.Windows.Forms.TabPage();
            this.ItemTypeTab = new System.Windows.Forms.TabPage();
            this.ItemTab = new System.Windows.Forms.TabPage();
            this.ManageTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManageTab
            // 
            this.ManageTab.Controls.Add(this.UserTab);
            this.ManageTab.Controls.Add(this.ItemTypeTab);
            this.ManageTab.Controls.Add(this.ItemTab);
            this.ManageTab.Location = new System.Drawing.Point(0, 28);
            this.ManageTab.Name = "ManageTab";
            this.ManageTab.SelectedIndex = 0;
            this.ManageTab.Size = new System.Drawing.Size(586, 340);
            this.ManageTab.TabIndex = 0;
            // 
            // UserTab
            // 
            this.UserTab.Location = new System.Drawing.Point(4, 22);
            this.UserTab.Name = "UserTab";
            this.UserTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserTab.Size = new System.Drawing.Size(578, 314);
            this.UserTab.TabIndex = 0;
            this.UserTab.Text = "用户管理";
            this.UserTab.UseVisualStyleBackColor = true;
            // 
            // ItemTypeTab
            // 
            this.ItemTypeTab.Location = new System.Drawing.Point(4, 22);
            this.ItemTypeTab.Name = "ItemTypeTab";
            this.ItemTypeTab.Padding = new System.Windows.Forms.Padding(3);
            this.ItemTypeTab.Size = new System.Drawing.Size(578, 342);
            this.ItemTypeTab.TabIndex = 1;
            this.ItemTypeTab.Text = "商品类别管理";
            this.ItemTypeTab.UseVisualStyleBackColor = true;
            // 
            // ItemTab
            // 
            this.ItemTab.Location = new System.Drawing.Point(4, 22);
            this.ItemTab.Name = "ItemTab";
            this.ItemTab.Size = new System.Drawing.Size(578, 342);
            this.ItemTab.TabIndex = 2;
            this.ItemTab.Text = "商品管理";
            this.ItemTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.ManageTab);
            this.Name = "MainForm";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ManageTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ManageTab;
        private System.Windows.Forms.TabPage UserTab;
        private System.Windows.Forms.TabPage ItemTypeTab;
        private System.Windows.Forms.TabPage ItemTab;

    }
}

