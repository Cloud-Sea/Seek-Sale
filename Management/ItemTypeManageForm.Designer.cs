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
            this.itemtypeDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemTypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemtypeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemtypeDataGridView
            // 
            this.itemtypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemtypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemTypeid,
            this.ItemTypeName,
            this.Price});
            this.itemtypeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemtypeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.itemtypeDataGridView.Name = "itemtypeDataGridView";
            this.itemtypeDataGridView.RowTemplate.Height = 23;
            this.itemtypeDataGridView.Size = new System.Drawing.Size(377, 261);
            this.itemtypeDataGridView.TabIndex = 2;
            this.itemtypeDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemtypeDataGridView_CellValueChanged);
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
            // ItemTypeManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(377, 261);
            this.Controls.Add(this.itemtypeDataGridView);
            this.Name = "ItemTypeManageForm";
            this.Load += new System.EventHandler(this.ItemTypeManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemtypeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView itemtypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemTypeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}