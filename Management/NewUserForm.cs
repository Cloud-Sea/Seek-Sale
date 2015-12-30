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

namespace Management
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {
            userlevelTextBox.Text = "0";
            ninTextBox.Text = "0";
            noutTextBox.Text = "0";
            inrankTextBox.Text = "0";
            outrankTextBox.Text = "0";
            reliableTextBox.Text = "0";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (userlevelTextBox.Text == "")
            {
                MessageBox.Show("用户名不可为空");
                return;
            }
            else if(passwordTextBox.Text == "")
            {
                MessageBox.Show("密码不可为空");
                return;
            }
            DBConnector connector = new DBConnector();
            string sql;
            sql = "INSERT INTO Userbasictb (username,passwd) VALUES ("
                + "\"" + usernameTextBox.Text + "\"" + ", "
                + "\"" + passwordTextBox.Text + "\");" ;
            connector.Insert(sql);
            sql = "SELECT userid FROM Userbasictb WHERE username = \"" + usernameTextBox.Text + "\";";
            OdbcDataReader reader = connector.Select(sql);
            reader.Read();
            int userid = reader.GetInt32(0);
            sql = "INSERT INTO Usertradetb VALUES ("
                + userid.ToString() + ", "
                + userlevelTextBox.Text + ", "
                + "0,"
                + inrankTextBox.Text + ", "
                + outrankTextBox.Text + ", "
                + ninTextBox.Text + ", "
                + noutTextBox.Text + ", "
                + "\"" + contactTextBox.Text + "\"" + ", "
                + reliableTextBox.Text + ");";
            connector.Insert(sql);
            connector.Close();
            MessageBox.Show("插入成功！");
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
