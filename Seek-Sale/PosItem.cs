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
    public partial class PosItem : UserControl
    {
        bool PROCEDURE = true;
        int id;
        ModifyPosForm form;
        public PosItem(int id, ModifyPosForm form)
        {
            InitializeComponent();
            this.id = id;
            this.form = form;
        }

        private void PosItem_Load(object sender, EventArgs e)
        {
            modBtn.Location = new Point(codeTextBox.Location.X + codeTextBox.Size.Width + 10, 2);
            saveBtn.Location = modBtn.Location;
            delBtn.Location = new Point(modBtn.Location.X + modBtn.Size.Width + 10, modBtn.Location.Y);
            if (this.id == -1)
            {
                posTextBox.ReadOnly = false;
                codeTextBox.ReadOnly = false;
                modBtn.Visible = false;
                saveBtn.Visible = true;
                delBtn.Visible = false;
            }
            else
            {
                posTextBox.ReadOnly = true;
                codeTextBox.ReadOnly = true;
                modBtn.Visible = true;
                saveBtn.Visible = false;
                delBtn.Visible = true;
                DBConnector connector = new DBConnector();
                string sql = "SELECT * FROM positiontb WHERE positionid=" + this.id.ToString() + ";";
                OdbcDataReader reader = connector.Select(sql);
                if (reader.Read())
                {
                    string posdescribe = reader.GetString(2);
                    string postcode = reader.GetString(1);
                    posTextBox.Text = posdescribe;
                    codeTextBox.Text = postcode;
                }
                connector.Close();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!PROCEDURE)
            {
                DBConnector connector = new DBConnector();
                string sql;
                if (id != -1)
                {
                    sql = "UPDATE positiontb SET posdescribe=\"" + posTextBox.Text + "\", "
                        + "postcode = \"" + codeTextBox.Text + "\""
                        + " WHERE positionid = " + this.id.ToString() + ";";
                    connector.Update(sql);
                }
                else
                {
                    sql = "INSERT INTO positiontb (postcode, posdescribe) VALUES ("
                        + "\"" + codeTextBox.Text + "\","
                        + "\"" + posTextBox.Text + "\");";
                    connector.Insert(sql);
                    sql = "SELECT positionid FROM positiontb WHERE posdescribe=" + "\"" + posTextBox.Text + "\""
                        + " AND postcode=\"" + codeTextBox.Text + "\";";
                    OdbcDataReader reader = connector.Select(sql);
                    int positionid = 0;
                    if (reader.Read())
                        positionid = reader.GetInt32(0);
                    sql = "INSERT INTO userpos VALUES("
                        + UserInfo.instance.userid.ToString() + ", "
                        + positionid.ToString() + ");";
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
                cmd.CommandText = "{CALL addposition(?, ?, ?, ?)}";
                OdbcParameter pposdescribe = new OdbcParameter("Iposdescribe", posTextBox.Text);
                pposdescribe.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pposdescribe);
                OdbcParameter ppostcode = new OdbcParameter("Icode", codeTextBox.Text);
                ppostcode.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(ppostcode);
                OdbcParameter puserid = new OdbcParameter("iuserid", UserInfo.instance.userid);
                puserid.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(puserid);
                OdbcParameter pposid = new OdbcParameter("Iposid", this.id);
                pposid.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pposid);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            form.refresh();
            saveBtn.Visible = false;
            modBtn.Visible = true;
            posTextBox.ReadOnly = true;
            codeTextBox.ReadOnly = true;
        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            modBtn.Visible = false;
            saveBtn.Visible = true;
            posTextBox.ReadOnly = false;
            codeTextBox.ReadOnly = false;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DBConnector connector = new DBConnector();
            string sql = "DELETE FROM userpos WHERE positionid=" + this.id + ";";
            connector.Delete(sql);
            connector.Close();
            form.refresh();
        }
    }
}
