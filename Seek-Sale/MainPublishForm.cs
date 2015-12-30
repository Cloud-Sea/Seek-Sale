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
    public partial class MainPublishForm : Form
    {
        const bool PROCEDURE = true;
        static string username = "root";
        static string password = "690111";
        string connect_str = "dsn=seeksale;DRIVER={MySQL ODBC 5.3 Unicode Driver};" +
                                "SERVER=localhost;" +
                                "DATABASE=leftover;" +
                                "UID=" + username + ";" +
                                "PASSWORD=" + password + ";";
        public MainPublishForm()
        {
            InitializeComponent();
        }

        private void MainPublishForm_Load(object sender, EventArgs e)
        {
            DBConnector connector = new DBConnector();
            string sql;
            sql = "SELECT typename FROM Itemtypetb ";
            OdbcDataReader reader = connector.Select(sql);
            while(reader.Read())
            {
                typeComboBox.Items.Add(reader.GetString(0));
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (PROCEDURE)
            {
                OdbcConnection conn = new OdbcConnection(connect_str);
                conn.Open();
                OdbcCommand cmd = new OdbcCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "{CALL publish(?, ?, ?, ?, ?, ?)}";
                OdbcParameter ptypename = new OdbcParameter("itypename", typeComboBox.Text);
                ptypename.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(ptypename);
                OdbcParameter pitemname = new OdbcParameter("iitemname", nameTextBox.Text);
                pitemname.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pitemname);
                OdbcParameter pprice = new OdbcParameter("iprice", float.Parse(priceTextBox.Text));
                pprice.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pprice);
                OdbcParameter pdepreciation = new OdbcParameter("idepreciation", float.Parse(newTextBox.Text));
                pdepreciation.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pdepreciation);
                OdbcParameter pitemdescribe = new OdbcParameter("iitemdescribe", describeRichTextBox.Text);
                pitemdescribe.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pitemdescribe);
                OdbcParameter puserid = new OdbcParameter("iuserid", UserInfo.instance.userid);
                puserid.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(puserid);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                DBConnector connector = new DBConnector();
                int typeid;
                string sql;
                sql = "SELECT typeid FROM Itemtypetb WHERE typename=\"" + typeComboBox.Text + "\";";
                OdbcDataReader reader = connector.Select(sql);
                if (reader.Read())
                    typeid = reader.GetInt32(0);
                else
                {
                    MessageBox.Show("商品类型不存在");
                    return;
                }
                sql = "INSERT INTO Itemtb (itemname,price,typeid,depreciation,itemdescribe,available) VALUES ("
                    + "\"" + nameTextBox.Text + "\"" + ", "
                    + priceTextBox.Text + ", "
                    + typeid.ToString() + ", "
                    + newTextBox.Text + ", "
                    + "\"" + describeRichTextBox.Text + "\","
                    + "1" + ");";
                connector.Insert(sql);
                int itemid = -1;
                sql = "SELECT itemid FROM Itemtb WHERE itemname = \"" + nameTextBox.Text + "\";";
                reader = connector.Select(sql);
                if (reader.Read())
                    itemid = reader.GetInt32(0);
                sql = "INSERT INTO Post (userid, itemid) VALUES (" + UserInfo.instance.userid + ", "
                    + itemid.ToString() + ");";
                connector.Insert(sql);
                connector.Close();
            }
            this.Invoke(new MessageBoxShow(MessageBoxShow_F), new object[] { "商品发布成功" });
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            newTextBox.Text = "";
            describeRichTextBox.Text = "";
        }
       
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认重置?", "Confirm Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nameTextBox.Text = "";
                priceTextBox.Text = "";
                newTextBox.Text = "";
                describeRichTextBox.Text = "";
            }
        }
        delegate void MessageBoxShow(string msg);
        void MessageBoxShow_F(string msg)
        {
            MessageBox.Show(msg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
