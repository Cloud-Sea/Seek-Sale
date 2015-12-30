using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Seek_Sale
{
    public partial class OrderItem : UserControl
    {
        int id;
        public OrderItem(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void OrderItem_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            DBConnector connector = new DBConnector();
            string sql = "SELECT * FROM Orderview WHERE oid=" + this.id.ToString() + ";";
            OdbcDataReader reader = connector.Select(sql);
            if (reader.Read())
            {
                string date = reader.GetDate(1).ToShortDateString();
                string sellername = reader.GetString(2);
                string itemname = reader.GetString(3);
                float price = reader.GetFloat(4);
                nameTextBox.Text = itemname;
                priceTextBox.Text = price.ToString();
                timeTextBox.Text = date;
                sellerTextBox.Text = sellername;
                commentBtn.Location = new Point(sellerTextBox.Location.X + sellerTextBox.Size.Width + 10, sellerTextBox.Location.Y);
                checkBtn.Location = commentBtn.Location;
                checkBtn.Size = commentBtn.Size;
                sql = "SELECT * FROM commenttb WHERE commentid =" + id.ToString() + ";";
                OdbcDataReader reader_com = connector.Select(sql);
                if (!reader_com.Read())
                {
                    commentBtn.Visible = true;
                    checkBtn.Visible = false;
                }
                else
                {
                    commentBtn.Visible = false;
                    checkBtn.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Error occure");
            }
            connector.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            AddCommentForm form = new AddCommentForm(this.id, this);
            form.ShowDialog();
        }
    }
}
