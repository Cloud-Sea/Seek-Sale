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
    public partial class ItemCard : UserControl
    {
        public int id;
        public string name;
        public float price;
        public string describe;
        public float depreciation;
        public float oriprice;
        public ItemCard(int id, string name, float price, float oriprice, string describe,float depreciation)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.price = price;
            this.oriprice = oriprice;
            this.describe = describe;
            this.depreciation = depreciation;
        }

        private void ItemCard_Load(object sender, EventArgs e)
        {
            this.priceLabel.Text = "价格：" + this.price.ToString("0.00");
            this.nameLabel.Text = "商品名称：" + this.name;
        }

        private void detial_Click(object sender, EventArgs e)
        {
            ItemDetialForm detailForm = new ItemDetialForm(this.id, this.name, this.price, this.oriprice, this.describe, this.depreciation);
            detailForm.Show();
        }

        private void color_Change(object sender, EventArgs e)
        {
            nameLabel.ForeColor = Color.Orange;
        }

        private void color_Reverse(object sender, EventArgs e)
        {
            nameLabel.ForeColor = Color.Black;
        }
    }
}
