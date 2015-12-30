namespace Seek_Sale
{
    partial class MainSearchForm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.inLabel = new System.Windows.Forms.Label();
            this.outLabel = new System.Windows.Forms.Label();
            this.rankLabel = new System.Windows.Forms.Label();
            this.reliLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(35, 33);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(619, 28);
            this.textBox.TabIndex = 0;
            this.textBox.Click += new System.EventHandler(this.textBox_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(500, 79);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(112, 34);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "搜索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 155);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1136, 628);
            this.panel.TabIndex = 2;
            // 
            // inLabel
            // 
            this.inLabel.AutoSize = true;
            this.inLabel.Location = new System.Drawing.Point(18, 23);
            this.inLabel.Name = "inLabel";
            this.inLabel.Size = new System.Drawing.Size(62, 18);
            this.inLabel.TabIndex = 3;
            this.inLabel.Text = "买入量";
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.Location = new System.Drawing.Point(207, 23);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(62, 18);
            this.outLabel.TabIndex = 4;
            this.outLabel.Text = "卖出量";
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Location = new System.Drawing.Point(18, 62);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(80, 18);
            this.rankLabel.TabIndex = 5;
            this.rankLabel.Text = "用户等级";
            // 
            // reliLabel
            // 
            this.reliLabel.AutoSize = true;
            this.reliLabel.Location = new System.Drawing.Point(207, 62);
            this.reliLabel.Name = "reliLabel";
            this.reliLabel.Size = new System.Drawing.Size(62, 18);
            this.reliLabel.TabIndex = 6;
            this.reliLabel.Text = "好评率";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inLabel);
            this.groupBox1.Controls.Add(this.reliLabel);
            this.groupBox1.Controls.Add(this.outLabel);
            this.groupBox1.Controls.Add(this.rankLabel);
            this.groupBox1.Location = new System.Drawing.Point(737, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "价格升序",
            "价格降序",
            "新旧程度升序",
            "新旧程度降序"});
            this.comboBox.Location = new System.Drawing.Point(12, 116);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(256, 26);
            this.comboBox.TabIndex = 7;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // MainSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1136, 783);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.textBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainSearchForm";
            this.Load += new System.EventHandler(this.MainSearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label inLabel;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Label reliLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox;
    }
}