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
    public partial class ModifyPayForm : Form
    {

        public ModifyPayForm()
        {
            InitializeComponent();
        }

        private void ModifyPayForm_Load(object sender, EventArgs e)
        {
            refresh();
        }
        public void refresh()
        {
            DBConnector connector = new DBConnector();
            string sql;
            sql = "SELECT payid FROM paytb WHERE payid IN (SELECT payid FROM userpayment WHERE userid =" + UserInfo.instance.userid
                + ");";
            OdbcDataReader reader = connector.Select(sql);
            int y = 0;
            panel.Controls.Clear();
            PayItem payitem;
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                payitem = new PayItem(id, this);
                payitem.Location = new Point(0, y);
                y += payitem.Size.Height;
                panel.Controls.Add(payitem);
            }
            payitem = new PayItem(-1, this);
            payitem.Location = new Point(0, y);
            panel.Controls.Add(payitem);
            connector.Close();
        }
    }
}
