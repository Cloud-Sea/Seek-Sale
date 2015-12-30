namespace Seek_Sale
{
    partial class AddCommentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCommentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.scoreComboBox = new System.Windows.Forms.ComboBox();
            this.commentTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = " 评分";
            // 
            // scoreComboBox
            // 
            this.scoreComboBox.FormattingEnabled = true;
            this.scoreComboBox.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.scoreComboBox.Location = new System.Drawing.Point(139, 75);
            this.scoreComboBox.Name = "scoreComboBox";
            this.scoreComboBox.Size = new System.Drawing.Size(121, 26);
            this.scoreComboBox.TabIndex = 1;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(139, 195);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(497, 142);
            this.commentTextBox.TabIndex = 2;
            this.commentTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = " 评论";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(468, 390);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(116, 41);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "保存";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // AddCommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 461);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.scoreComboBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCommentForm";
            this.Text = "添加评论";
            this.Load += new System.EventHandler(this.AddCommentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox scoreComboBox;
        private System.Windows.Forms.RichTextBox commentTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBtn;
    }
}