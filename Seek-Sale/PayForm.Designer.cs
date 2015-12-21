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
            this.itemPanel = new System.Windows.Forms.Panel();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.payPpanel = new System.Windows.Forms.Panel();
            this.positionPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // itemPanel
            // 
            this.itemPanel.AutoScroll = true;
            this.itemPanel.Location = new System.Drawing.Point(12, 12);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(560, 200);
            this.itemPanel.TabIndex = 2;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(122, 447);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 3;
            this.confirmBtn.Text = "确认支付";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(370, 447);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // payPpanel
            // 
            this.payPpanel.AutoScroll = true;
            this.payPpanel.Location = new System.Drawing.Point(12, 218);
            this.payPpanel.Name = "payPpanel";
            this.payPpanel.Size = new System.Drawing.Size(560, 100);
            this.payPpanel.TabIndex = 0;
            // 
            // positionPanel
            // 
            this.positionPanel.AutoScroll = true;
            this.positionPanel.Location = new System.Drawing.Point(12, 324);
            this.positionPanel.Name = "positionPanel";
            this.positionPanel.Size = new System.Drawing.Size(560, 100);
            this.positionPanel.TabIndex = 1;
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 482);
            this.Controls.Add(this.positionPanel);
            this.Controls.Add(this.payPpanel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.itemPanel);
            this.MaximizeBox = false;
            this.Name = "PayForm";
            this.Text = "PayForm";
            this.Load += new System.EventHandler(this.PayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel itemPanel;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel payPpanel;
        private System.Windows.Forms.Panel positionPanel;
    }
}