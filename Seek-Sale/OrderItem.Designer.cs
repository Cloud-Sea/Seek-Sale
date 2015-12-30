namespace Seek_Sale
{
    partial class OrderItem
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.sellerTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.商品名 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.commentBtn = new System.Windows.Forms.Button();
            this.checkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(71, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(825, 28);
            this.nameTextBox.TabIndex = 0;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(364, 48);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.Size = new System.Drawing.Size(100, 28);
            this.timeTextBox.TabIndex = 1;
            // 
            // sellerTextBox
            // 
            this.sellerTextBox.Location = new System.Drawing.Point(548, 48);
            this.sellerTextBox.Name = "sellerTextBox";
            this.sellerTextBox.ReadOnly = true;
            this.sellerTextBox.Size = new System.Drawing.Size(100, 28);
            this.sellerTextBox.TabIndex = 2;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(157, 48);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(100, 28);
            this.priceTextBox.TabIndex = 3;
            // 
            // 商品名
            // 
            this.商品名.AutoSize = true;
            this.商品名.Location = new System.Drawing.Point(3, 8);
            this.商品名.Name = "商品名";
            this.商品名.Size = new System.Drawing.Size(62, 18);
            this.商品名.TabIndex = 4;
            this.商品名.Text = "商品名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "成交价格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "交易时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = " 卖家";
            // 
            // commentBtn
            // 
            this.commentBtn.Location = new System.Drawing.Point(675, 48);
            this.commentBtn.Name = "commentBtn";
            this.commentBtn.Size = new System.Drawing.Size(100, 32);
            this.commentBtn.TabIndex = 8;
            this.commentBtn.Text = "添加评论";
            this.commentBtn.UseVisualStyleBackColor = true;
            this.commentBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(675, 64);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(100, 32);
            this.checkBtn.TabIndex = 9;
            this.checkBtn.Text = " 查看评论";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.commentBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.商品名);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.sellerTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(957, 122);
            this.Load += new System.EventHandler(this.OrderItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox sellerTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label 商品名;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button commentBtn;
        private System.Windows.Forms.Button checkBtn;
    }
}
