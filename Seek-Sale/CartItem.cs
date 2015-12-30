using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seek_Sale
{
    public partial class CartItem : UserControl
    {
        public bool selected;
        public int itemid;
        public string describe;
        public string price;
        private CartForm form;
        public CartItem(int itemid, string describe, float price, Form form)
        {
            InitializeComponent();
            this.itemid = itemid;
            this.describe = describe;
            this.price = price.ToString("0.00");
            this.selected = false;
            this.form = (CartForm)form;
        }

        private void CartItem_Load(object sender, EventArgs e)
        {
            this.nameTextBox.Text = this.describe;
            this.priceTextBox.Text = this.price;
            this.checkBox.Checked = this.selected;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DBConnector connector = new DBConnector();
            string sql = "DELETE FROM CartItem WHERE userid = "+UserInfo.instance.userid + " AND itemid="+this.itemid+";";
            connector.Delete(sql);
            connector.Close();
            form.refresh();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.selected = this.checkBox.Checked;
        }
    }
}
