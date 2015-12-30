namespace Management
{
    partial class ItemTypeManageForm
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
            this.UserInfo = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ItemTypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInfo
            // 
            this.UserInfo.AutoSize = true;
            this.UserInfo.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserInfo.Location = new System.Drawing.Point(109, 34);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(142, 21);
            this.UserInfo.TabIndex = 3;
            this.UserInfo.Text = "ItemTypeInfo";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemTypeid,
            this.ItemTypeName,
            this.Price});
            this.dataGridView2.Location = new System.Drawing.Point(17, 76);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(343, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // ItemTypeid
            // 
            this.ItemTypeid.HeaderText = "ItemTypeid";
            this.ItemTypeid.Name = "ItemTypeid";
            // 
            // ItemTypeName
            // 
            this.ItemTypeName.HeaderText = "ItemTypeName";
            this.ItemTypeName.Name = "ItemTypeName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // ItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(377, 261);
            this.Controls.Add(this.UserInfo);
            this.Controls.Add(this.dataGridView2);
            this.Name = "ItemType";
            this.Text = " ItemTypeManageForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserInfo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemTypeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}