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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            int userid = UserInfo.instance.userid;
            DBConnector connector = new DBConnector();
            string sql;
            sql = "SELECT oid FROM OrderRecord WHERE buyerid=" + userid.ToString() + ";";
            OdbcDataReader reader = connector.Select(sql);
            int y = 0;
            while (reader.Read())
            {
                int oid = reader.GetInt32(0);
                OrderItem item = new OrderItem(oid);
                item.Location = new Point(0, y);
                y += item.Size.Height;
                panel.Controls.Add(item);
            }
            connector.Close();
        }
    }
}
