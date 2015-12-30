using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.Odbc;

namespace Seek_Sale
{
    public partial class CartForm : Form
    {
        int userid;
        List<CartItem> items;
        public CartForm(int userid)
        {
            InitializeComponent();
            this.userid = userid;
            this.items = new List<CartItem>();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            DBConnector connection = new DBConnector();
            string sql = "SELECT * FROM Itemtb WHERE Itemtb.itemid IN ( SELECT itemid FROM CartItem WHERE userid = " + UserInfo.instance.userid + ");";
            OdbcDataReader reader = connection.Select(sql);
            items.Clear();
            while (reader.Read())
            {
                int itemid = reader.GetInt32(0);
                string name = reader.GetString(2);
                float price = reader.GetFloat(3);
                CartItem item = new CartItem(itemid, name, price, this);
                items.Add(item);
            }
            connection.Close();
            itemPanel.Controls.Clear();
            int y = 0;
            foreach (CartItem item in items)
            {
                item.Location = new Point(0, y);
                y += item.Size.Height;
                itemPanel.Controls.Add(item);
            }
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            List<CartItem> selectedItem = new List<CartItem>();
            foreach (CartItem item in items)
            {
                if(item.selected && item.Visible)
                {
                    selectedItem.Add(item);
                }
            }
            PayForm payForm = new PayForm(selectedItem);
            payForm.ShowDialog();
            this.refresh();
        }
    }
}
