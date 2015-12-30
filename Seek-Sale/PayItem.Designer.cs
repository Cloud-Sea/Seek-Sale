namespace Seek_Sale
{
    partial class PayItem
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.saveBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.modBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(53, 6);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(502, 28);
            this.textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "卡号";
            // 
            // radioButton
            // 
            this.radioButton.AutoCheck = false;
            this.radioButton.AutoSize = true;
            this.radioButton.Location = new System.Drawing.Point(584, 9);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(141, 22);
            this.radioButton.TabIndex = 3;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "是否快捷支付";
            this.radioButton.UseVisualStyleBackColor = true;
            this.radioButton.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(758, 7);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 30);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "保存";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(839, 11);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 30);
            this.delBtn.TabIndex = 5;
            this.delBtn.Text = "删除";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // modBtn
            // 
            this.modBtn.Location = new System.Drawing.Point(791, 11);
            this.modBtn.Name = "modBtn";
            this.modBtn.Size = new System.Drawing.Size(75, 30);
            this.modBtn.TabIndex = 6;
            this.modBtn.Text = "修改";
            this.modBtn.UseVisualStyleBackColor = true;
            this.modBtn.Click += new System.EventHandler(this.modBtn_Click);
            // 
            // PayItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.radioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Name = "PayItem";
            this.Size = new System.Drawing.Size(1000, 42);
            this.Load += new System.EventHandler(this.PayItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button modBtn;
    }
}
