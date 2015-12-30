namespace Seek_Sale
{
    partial class PayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayForm));
            this.itemPanel = new System.Windows.Forms.Panel();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.payPanel = new System.Windows.Forms.Panel();
            this.positionPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemPanel
            // 
            this.itemPanel.AutoScroll = true;
            this.itemPanel.Location = new System.Drawing.Point(7, 24);
            this.itemPanel.Margin = new System.Windows.Forms.Padding(4);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(825, 97);
            this.itemPanel.TabIndex = 2;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(183, 670);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(4);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(112, 34);
            this.confirmBtn.TabIndex = 3;
            this.confirmBtn.Text = "确认支付";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(555, 670);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 34);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // payPanel
            // 
            this.payPanel.AutoScroll = true;
            this.payPanel.Location = new System.Drawing.Point(7, 36);
            this.payPanel.Margin = new System.Windows.Forms.Padding(4);
            this.payPanel.Name = "payPanel";
            this.payPanel.Size = new System.Drawing.Size(832, 157);
            this.payPanel.TabIndex = 0;
            // 
            // positionPanel
            // 
            this.positionPanel.AutoScroll = true;
            this.positionPanel.Location = new System.Drawing.Point(7, 28);
            this.positionPanel.Margin = new System.Windows.Forms.Padding(4);
            this.positionPanel.Name = "positionPanel";
            this.positionPanel.Size = new System.Drawing.Size(832, 175);
            this.positionPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.payPanel);
            this.groupBox1.Location = new System.Drawing.Point(12, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 215);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择支付方式";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.positionPanel);
            this.groupBox2.Location = new System.Drawing.Point(12, 427);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 222);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " 选择交易地点";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.itemPanel);
            this.groupBox3.Location = new System.Drawing.Point(19, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(839, 128);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " 购物车";
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 723);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PayForm";
            this.Text = "结算";
            this.Load += new System.EventHandler(this.PayForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel itemPanel;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel payPanel;
        private System.Windows.Forms.Panel positionPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}