namespace Seek_Sale
{
    partial class CartForm
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
            this.calcBtn = new System.Windows.Forms.Button();
            this.itemPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(710, 490);
            this.calcBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(112, 34);
            this.calcBtn.TabIndex = 0;
            this.calcBtn.Text = "结算";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // itemPanel
            // 
            this.itemPanel.AutoScroll = true;
            this.itemPanel.Location = new System.Drawing.Point(18, 18);
            this.itemPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(840, 450);
            this.itemPanel.TabIndex = 1;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 543);
            this.Controls.Add(this.itemPanel);
            this.Controls.Add(this.calcBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Panel itemPanel;

    }
}