using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class ItemCard : UserControl
    {
        public int id;
        public string name;
        public float price;
        public string describe;
        public float depreciation;
        public ItemCard(int id, string name, float price, string describe, float depreciation)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.price = price;
            this.describe = describe;
            this.depreciation = depreciation;
        }

        private void ItemCard_Load(object sender, EventArgs e)
        {
            this.priceLabel.Text = this.price.ToString("0.00");
            this.nameLabel.Text = this.name;
        }
    }
}
