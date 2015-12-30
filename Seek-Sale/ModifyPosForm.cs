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
    public partial class ModifyPosForm : Form
    {
        public ModifyPosForm()
        {
            InitializeComponent();
        }

        private void ModifyPosForm_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            DBConnector connector = new DBConnector();
            string sql;
            sql = "SELECT positionid FROM userpos WHERE userid = " + UserInfo.instance.userid + ";";
            OdbcDataReader reader = connector.Select(sql);
            panel.Controls.Clear();
            int y = 0;
            PosItem positem;
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                positem = new PosItem(id, this);
                positem.Location = new Point(0, y);
                y += positem.Size.Height;
                panel.Controls.Add(positem);
                positem.Show();
            }
            positem = new PosItem(-1, this);
            positem.Location = new Point(0, y);
            panel.Controls.Add(positem);
            positem.Show();
            connector.Close();
        }
    }
}
