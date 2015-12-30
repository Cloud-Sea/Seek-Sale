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

namespace Seek_Sale
{
    public partial class MainSearchForm : Form
    {
        List<ItemCard> itemcards;
        public MainSearchForm()
        {
            InitializeComponent();
            this.itemcards = new List<ItemCard>();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string text = textBox.Text;
            string sql = "SELECT * FROM Itemtb WHERE itemname LIKE \"%" + text + "%\""
                + " AND " + "available = 1" + ";";
            DBConnector connector = new DBConnector();
            OdbcDataReader reader = connector.Select(sql);
            int x = 20;
            int y = 20;
            itemcards.Clear();
            this.panel.Controls.Clear();
            if (!reader.Read())
            {
                MessageBox.Show("未找到商品");
            }
            else
            {
                do
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string describe = reader.GetString(2);
                    float depreciation = reader.GetFloat(3);
                    float price = reader.GetFloat(4);
                    int itemtype = reader.GetInt32(6);
                    sql = "SELECT price FROM Itemtypetb WHERE typeid = " + itemtype.ToString() + ";";
                    OdbcDataReader sub_reader = connector.Select(sql);
                    int oriprice = 0;
                    if (sub_reader.Read())
                        oriprice = sub_reader.GetInt32(0);
                    ItemCard itemcard = new ItemCard(id, name, price, oriprice, describe, depreciation);
                    itemcard.Click += new EventHandler(this.ItemCard_Click);
                    itemcards.Add(itemcard);
                    itemcard.Location = new Point(x, y);
                    x += itemcard.Size.Width+20;
                    if (x + itemcard.Size.Width > panel.Size.Width+20)
                    {
                        x = 20;
                        y += itemcard.Size.Height+20;
                    }
                } while (reader.Read());
            }
            foreach (ItemCard itemcard in this.itemcards)
            {
                this.panel.Controls.Add(itemcard);
            }
        }

        private void MainSearchForm_Load(object sender, EventArgs e)
        {
            this.textBox.Text = "搜索...";
            refresh();
        }

        public void refresh()
        {
            DBConnector connector = new DBConnector();
            string sql = "SELECT * FROM Usertradetb WHERE userid = " + UserInfo.instance.userid;
            OdbcDataReader reader = connector.Select(sql);
            if (reader.Read())
            {
                int nin = reader.GetInt32(5);
                int nout = reader.GetInt32(6);
                int rank = reader.GetInt32(1);
                float reliable = reader.GetFloat(8);
                inLabel.Text = "买入量 : " + nin.ToString();
                outLabel.Text = "卖出量 : " + nout.ToString();
                rankLabel.Text = "用户等级 : " + rank.ToString();
                reliLabel.Text = "好评率 : " + reliable.ToString();
            }
            connector.Close();
        }

        public void reload()
        {
            int x = 20, y = 20;
            foreach (ItemCard itemcard in this.itemcards)
            {
                itemcard.Location = new Point(x, y);
                x += itemcard.Size.Width + 20;
                if (x + itemcard.Size.Width > panel.Size.Width + 20)
                {
                    x = 20;
                    y += itemcard.Size.Height + 20;
                }
                this.panel.Controls.Add(itemcard);
            }
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        private void ItemCard_Click(object sender, EventArgs e)
        {
            /*
            ItemCard card = (ItemCard)sender;
            ItemDetialForm detailForm = new ItemDetialForm(card.id, card.name, card.price, card.describe, card.depreciation);
            detailForm.Show();
             * */
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                itemcards.Sort(priceinc);
            }
            else if(comboBox.SelectedIndex == 1)
            {
                itemcards.Sort(pricedec);
            }
            else if(comboBox.SelectedIndex == 2)
            {
                itemcards.Sort(depinc);
            }
            else
            {
                itemcards.Sort(depdec);
            }
            reload();
        }

        private static int priceinc(ItemCard x, ItemCard y)
        {
            return x.price.CompareTo(y.price);
        }

        private static int pricedec(ItemCard x, ItemCard y)
        {
            return y.price.CompareTo(x.price);
        }

        private static int depinc(ItemCard x, ItemCard y)
        {
            return x.depreciation.CompareTo(y.depreciation);
        }

        private static int depdec(ItemCard x, ItemCard y)
        {
            return y.depreciation.CompareTo(x.depreciation);
        }

    }
}
