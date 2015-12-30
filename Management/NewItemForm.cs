using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Management
{
    public partial class NewItemForm : Form
    {
        public NewItemForm()
        {
            InitializeComponent();
        }

        private void NewItemForm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT typename FROM Itemtypetb;";
            DBConnector connector = new DBConnector();
            OdbcDataReader reader = connector.Select(sql);
            while (reader.Read())
            {
                string var = reader.GetString(0);
                typeComboBox.Items.Add(var);
            }
            reader.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DBConnector connector = new DBConnector();
            int id;
            string sql;
            sql = "SELECT typeid FROM Itemtypetb WHERE typename=\"" + typeComboBox.Text + "\";";
            OdbcDataReader reader = connector.Select(sql);
            if (reader.Read())
                id = reader.GetInt32(0);
            else
            {
                MessageBox.Show("商品类型不存在");
                return;
            }
            sql = "INSERT INTO Itemtb (itemname , price,typeid,depreciation,itemdescribe, available) VALUES ("
                + "\"" + nameTextBox.Text + "\"" + ", "
                + priceTextBox.Text + ", "
                + id.ToString() +", "
                + newTextBox.Text + ", "
                + "\"" + describeRichTextBox.Text +"\","
                + "1);";
            connector.Insert(sql);
            MessageBox.Show("插入成功！");
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
