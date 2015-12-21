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
    public partial class PayForm : Form
    {
        public bool succeed;
        List<CartItem> items;
        List<PayItem> pays;
        List<PositionItem> positions;
        public PayForm(List<CartItem> selectedItem)
        {
            InitializeComponent();
            this.succeed = false;
            this.items = new List<CartItem>();
            this.pays = new List<PayItem>();
            this.positions = new List<PositionItem>();
            foreach (CartItem item in selectedItem)
            {
                this.items.Add(item);
            }
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            //load data
            DBConnector connector = new DBConnector();
            string sql;
            OdbcDataReader reader;
            sql = "SELECT * FROM ...";
            reader = connector.Select(sql);
            while(reader.Read())
            {

            }
            connector.Close();
            //fill panel
            foreach (CartItem item in this.items)
            {
                itemPanel.Controls.Add(item);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            this.succeed = true;
            DBConnector connector = new DBConnector();
            string sql;
            foreach (CartItem item in this.items)
            {
                sql = "DELETE...";
                connector.Delete(sql);
            }
            connector.Close();
            this.Invoke(new MessageBoxShow(MessageBoxShow_F), new object[] { "订单生成成功！" });
            this.Close();
        }

        delegate void MessageBoxShow(string msg);
        void MessageBoxShow_F(string msg)
        {
            MessageBox.Show(msg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
