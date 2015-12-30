namespace Seek_Sale
{
    partial class PosItem
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
            this.modBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.posTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modBtn
            // 
            this.modBtn.Location = new System.Drawing.Point(916, 10);
            this.modBtn.Name = "modBtn";
            this.modBtn.Size = new System.Drawing.Size(75, 30);
            this.modBtn.TabIndex = 12;
            this.modBtn.Text = "修改";
            this.modBtn.UseVisualStyleBackColor = true;
            this.modBtn.Click += new System.EventHandler(this.modBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(964, 10);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 30);
            this.delBtn.TabIndex = 11;
            this.delBtn.Text = "删除";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(883, 6);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 30);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "保存";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "交易地点";
            // 
            // posTextBox
            // 
            this.posTextBox.Location = new System.Drawing.Point(102, 7);
            this.posTextBox.Name = "posTextBox";
            this.posTextBox.ReadOnly = true;
            this.posTextBox.Size = new System.Drawing.Size(502, 28);
            this.posTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "邮编";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(698, 6);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(100, 28);
            this.codeTextBox.TabIndex = 14;
            // 
            // PosItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posTextBox);
            this.Name = "PosItem";
            this.Size = new System.Drawing.Size(1200, 65);
            this.Load += new System.EventHandler(this.PosItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox posTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codeTextBox;
    }
}
