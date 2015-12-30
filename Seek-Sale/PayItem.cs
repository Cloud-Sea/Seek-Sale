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
    public partial class PayItem : UserControl
    {
        bool PROCEDURE = true;
        int id;
        ModifyPayForm form;
        public PayItem(int id, ModifyPayForm form)
        {
            InitializeComponent();
            this.id = id;
            this.form = form;
        }

        private void PayItem_Load(object sender, EventArgs e)
        {
            modBtn.Location = new Point(radioButton.Location.X + radioButton.Size.Width + 10, 2);
            saveBtn.Location = modBtn.Location;
            delBtn.Location = new Point(modBtn.Location.X + modBtn.Size.Width + 10, modBtn.Location.Y);
            if (this.id == -1)
            {
                textBox.ReadOnly = false;
                modBtn.Visible = false;
                saveBtn.Visible = true;
                delBtn.Visible = false;
                radioButton.Enabled = true;
            }
            else
            {
                textBox.ReadOnly = true;
                modBtn.Visible = true;
                saveBtn.Visible = false;
                delBtn.Visible = true;
                radioButton.Enabled = false;
                DBConnector connector = new DBConnector();
                string sql = "SELECT * FROM paytb WHERE payid=" + this.id.ToString() + ";";
                OdbcDataReader reader = connector.Select(sql);
                if(reader.Read())
                {
                    string cardid = reader.GetString(1);
                    bool quickpay = reader.GetInt32(2) == 1 ? true : false;
                    textBox.Text = cardid;
                    radioButton.Checked = quickpay;
                }
                connector.Close();
            }
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            if(radioButton.Checked)
            {
                radioButton.Checked = false;
            }
            else
            {
                radioButton.Checked = true;
            }
        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            modBtn.Visible = false;
            saveBtn.Visible = true;
            textBox.ReadOnly = false;
            radioButton.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!PROCEDURE)
            {
                DBConnector connector = new DBConnector();
                string sql;
                if (id != -1)
                {
                    sql = "UPDATE Paytb SET cardid=\"" + textBox.Text + "\", "
                        + "quickpay = " + (radioButton.Checked ? "1" : "0")
                        + " WHERE payid = " + this.id.ToString() + ";";
                    connector.Update(sql);
                }
                else
                {
                    sql = "INSERT INTO Paytb (cardid, quickpay) VALUES ("
                        + "\"" + textBox.Text + "\","
                        + (radioButton.Checked ? "1" : "0") + ");";
                    connector.Insert(sql);
                    sql = "SELECT payid FROM Paytb WHERE cardid=" + "\"" + textBox.Text + "\""
                        + " AND quickpay=" + (radioButton.Checked ? "1" : "0") + ";";
                    OdbcDataReader reader = connector.Select(sql);
                    int payid = 0;
                    if (reader.Read())
                        payid = reader.GetInt32(0);
                    sql = "INSERT INTO UserPayment VALUES("
                        + UserInfo.instance.userid.ToString() + ", "
                        + payid.ToString() + ");";
                    connector.Insert(sql);
                }
                connector.Close();
            }
            else
            {
                OdbcConnection conn = new OdbcConnection(DBConnector.connect_str);
                conn.Open();
                OdbcCommand cmd = new OdbcCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "{CALL addpayment(?, ?, ?, ?)}";
                OdbcParameter pcardid = new OdbcParameter("icardid", textBox.Text);
                pcardid.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pcardid);
                OdbcParameter pquickpay = new OdbcParameter("iquickpay", (radioButton.Checked ? 1 : 0));
                pquickpay.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pquickpay);
                OdbcParameter puserid = new OdbcParameter("iuserid", UserInfo.instance.userid);
                puserid.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(puserid);
                OdbcParameter ppayid = new OdbcParameter("ipayid", this.id);
                ppayid.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(ppayid);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            form.refresh();
            saveBtn.Visible = false;
            modBtn.Visible = true;
            textBox.ReadOnly = true;
            radioButton.Enabled = false;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DBConnector connector = new DBConnector();
            string sql = "DELETE FROM Userpayment WHERE payid=" + this.id + ";";
            connector.Delete(sql);
            connector.Close();
            form.refresh();
        }


    }
}
