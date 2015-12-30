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
    public partial class SearchItemForm : Form
    {
        List<ItemCard> itemcards;
        public SearchItemForm()
        {
            InitializeComponent();
            itemcards = new List<ItemCard>();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string text = textBox.Text;
            string sql = "SELECT * FROM Itemtb WHERE itemname LIKE \"%" + text + "%\";";
            DBConnector connector = new DBConnector();
            OdbcDataReader reader = connector.Select(sql);
            int x = 0, y = 0;
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string describe = reader.GetString(2);
                float depreciation = reader.GetFloat(3);
                float price = reader.GetFloat(4);
                ItemCard itemcard = new ItemCard(id, name, price, describe, depreciation);
                itemcards.Add(itemcard);
                itemcard.Location = new Point(x, y);
                x += itemcard.Size.Width;
                if(x+itemcard.Size.Width > panel.Size.Width)
                {
                    x = 0;
                    y += itemcard.Size.Height;
                }
            }
            foreach (ItemCard itemcard in this.itemcards)
            {
                this.panel.Controls.Add(itemcard);
            }
        }

        private void MainSearchForm_Load(object sender, EventArgs e)
        {
            this.textBox.Text = "搜索...";
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }
    }
}
