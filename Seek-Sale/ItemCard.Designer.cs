namespace Seek_Sale
{
    partial class ItemCard
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemCard));
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(24, 277);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(203, 48);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "description";
            this.nameLabel.Click += new System.EventHandler(this.detial_Click);
            this.nameLabel.MouseLeave += new System.EventHandler(this.color_Reverse);
            this.nameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.color_Change);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.priceLabel.Location = new System.Drawing.Point(23, 242);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(59, 20);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "price";
            this.priceLabel.Click += new System.EventHandler(this.detial_Click);
            this.priceLabel.MouseLeave += new System.EventHandler(this.color_Reverse);
            this.priceLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.color_Change);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(27, 17);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.detial_Click);
            this.pictureBox.MouseLeave += new System.EventHandler(this.color_Reverse);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.color_Change);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBox);
            this.groupBox.Controls.Add(this.priceLabel);
            this.groupBox.Controls.Add(this.nameLabel);
            this.groupBox.Location = new System.Drawing.Point(1, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(264, 342);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Click += new System.EventHandler(this.detial_Click);
            this.groupBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.color_Change);
            this.groupBox.MouseLeave += new System.EventHandler(this.color_Reverse);
            // 
            // ItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemCard";
            this.Size = new System.Drawing.Size(263, 347);
            this.Load += new System.EventHandler(this.ItemCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox;

    }
}
