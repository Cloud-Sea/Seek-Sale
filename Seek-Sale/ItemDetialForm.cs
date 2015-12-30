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
    public partial class ItemDetialForm : Form
    {
        int id;
        string name;
        float price;
        float oriprice;
        string describe;
        float depreciation;
        public ItemDetialForm(int id, string name, float price, float oriprice, string describe, float depreciation)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.price = price;
            this.oriprice = oriprice;
            this.describe = describe;
            this.depreciation = depreciation;
        }

        private void ItemDetialForm_Load(object sender, EventArgs e)
        {
            this.nameLabel.Text = name;
            this.priceLabel.Text = "￥" + price.ToString("0.00") + "(原价 : " + oriprice.ToString() + ")";
            this.detialTextBox.Text = describe;
            this.newLabel.Text = depreciation.ToString("新旧程度 : 0.00");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DBConnector connector = new DBConnector();
            string sql;
            sql = "SELECT * FROM CartItem WHERE userid=" + UserInfo.instance.userid + " AND itemid=" + this.id + ";";
            OdbcDataReader reader = connector.Select(sql);
            if (reader.Read())
            {
                MessageBox.Show("您已添加，请勿重复操作");
            }
            else
            {
                sql = "INSERT INTO CartItem VALUES ("
                    + UserInfo.instance.userid + ","
                    + this.id + ");";
                connector.Insert(sql);
                connector.Close();
                MainForm.mainForm.cartForm.refresh();
                MessageBox.Show("添加成功！");
            }
        }
    }
}
