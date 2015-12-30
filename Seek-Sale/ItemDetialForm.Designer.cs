namespace Seek_Sale
{
    partial class ItemDetialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDetialForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.detialTextBox = new System.Windows.Forms.RichTextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.newLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(40, 34);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(240, 240);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.priceLabel.Location = new System.Drawing.Point(340, 60);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(300, 38);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Price";
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.Location = new System.Drawing.Point(342, 124);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(450, 75);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // detialTextBox
            // 
            this.detialTextBox.Location = new System.Drawing.Point(40, 315);
            this.detialTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.detialTextBox.Name = "detialTextBox";
            this.detialTextBox.ReadOnly = true;
            this.detialTextBox.Size = new System.Drawing.Size(787, 266);
            this.detialTextBox.TabIndex = 3;
            this.detialTextBox.Text = "";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(346, 226);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(446, 48);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "添加到购物车";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Location = new System.Drawing.Point(618, 80);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(35, 18);
            this.newLabel.TabIndex = 5;
            this.newLabel.Text = "New";
            // 
            // ItemDetialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 618);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.detialTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemDetialForm";
            this.Text = "商品详情";
            this.Load += new System.EventHandler(this.ItemDetialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RichTextBox detialTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label newLabel;
    }
}