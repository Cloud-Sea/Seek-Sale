using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class NewItemTypeForm : Form
    {
        public NewItemTypeForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text == "")
            {
                MessageBox.Show("商品名不可为空");
                return;
            }
            string sql = "INSERT INTO Itemtypetb (itemname,price,itemtype,description) VALUES"
                + "\"" + nameTextBox.Text + "\"" + ", "
                + "\"" + priceTextBox.Text + "\"" + ","
                + "\"" + typeComboBox.Text + "\"" + ", "
                + "\"" + describeRichTextBox.Text + "\"" + ";";
            DBConnector connector = new DBConnector();
            connector.Insert(sql);
            connector.Close();
            MessageBox.Show("插入成功！");
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
