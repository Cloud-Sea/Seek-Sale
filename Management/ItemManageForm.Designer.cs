namespace Management
{
    partial class ItemManageForm
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
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.Itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Itemid,
            this.ItemName,
            this.Price,
            this.Description});
            this.itemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemDataGridView.Location = new System.Drawing.Point(0, 0);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowTemplate.Height = 23;
            this.itemDataGridView.Size = new System.Drawing.Size(505, 261);
            this.itemDataGridView.TabIndex = 4;
            this.itemDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDataGridView_CellValueChanged);
            // 
            // Itemid
            // 
            this.Itemid.HeaderText = "Itemid";
            this.Itemid.Name = "Itemid";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // ItemManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(505, 261);
            this.Controls.Add(this.itemDataGridView);
            this.Name = "ItemManageForm";
            this.Load += new System.EventHandler(this.ItemManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}