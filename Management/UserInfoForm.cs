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
using System.Data.SqlClient;

namespace Management
{
    public partial class UserInfoForm : Form
    {

        int userid;
        string username;
        string password;
        int userrank, certified, nin, nout, inrank, outrank;
        string contact;
        float reliable;
        public UserInfoForm()
        {
            InitializeComponent();
        }

        private void searchable()
        {
            passwordTextBox.ReadOnly = true;
            userlevelTextBox.ReadOnly = true;
            yesRadioButton.Enabled = false;
            noRadioButton.Enabled = false;
            ninTextBox.ReadOnly = true;
            noutTextBox.ReadOnly = true;
            inrankTextBox.ReadOnly = true;
            outrankTextBox.ReadOnly = true;
            contactTextBox.ReadOnly = true;
            saveBtn.Enabled = false;
            saveBtn.Enabled = false;
        }

        private void editable()
        {
            passwordTextBox.ReadOnly = false;
            userlevelTextBox.ReadOnly = false;
            yesRadioButton.Enabled = true;
            noRadioButton.Enabled = true;
            ninTextBox.ReadOnly = false;
            noutTextBox.ReadOnly = false;
            inrankTextBox.ReadOnly = false;
            outrankTextBox.ReadOnly = false;
            contactTextBox.ReadOnly = false;
            saveBtn.Enabled = true;
            saveBtn.Enabled = true;
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            searchable();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
            string sql = "SELECT * FROM UserView WHERE username=\"" + username + "\";";
            DBConnector connector = new DBConnector();
            OdbcDataReader reader = connector.Select(sql);
            if (reader.Read())
            {
                userid = reader.GetInt32(0);
                useridLabel.Text = userid.ToString();
                password = reader.GetString(2);
                passwordTextBox.Text = password;
                userrank = reader.GetInt32(3);
                userlevelTextBox.Text = userrank.ToString();
                certified = reader.GetInt32(4);
                if(certified > 0)
                {
                    yesRadioButton.Checked = true;
                    noRadioButton.Checked = false;
                }
                else
                {
                    yesRadioButton.Checked = false;
                    noRadioButton.Checked = true;
                }
                nin = reader.GetInt32(5);
                ninTextBox.Text = nin.ToString();
                nout = reader.GetInt32(6);
                noutTextBox.Text = nout.ToString();
                inrank = reader.GetInt32(7);
                inrankTextBox.Text = inrank.ToString();
                outrank = reader.GetInt32(8);
                outrankTextBox.Text = outrank.ToString();
                contact = reader.GetString(9);
                contactTextBox.Text = contact.ToString();
                reliable = reader.GetFloat(10);
                reliableTextBox.Text = reliable.ToString();
                editable();
            }
            else
            {
                MessageBox.Show("用户未找到");
            }
            connector.Close();
        }

        private void yesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yesRadioButton.Checked)
                noRadioButton.Checked = false;
            else
                noRadioButton.Checked = true;
        }

        private void noRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (noRadioButton.Checked)
                yesRadioButton.Checked = false;
            else
                yesRadioButton.Checked = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string mark;
            if (yesRadioButton.Checked)
                mark = "1";
            else
                mark = "0";
            DBConnector connector = new DBConnector();
            string sql = "UPDATE UserView (passwd,userlevel,certified,inrank,outrank,nin,nout,contact,reliable) VALUES"
                + "\"" + passwordTextBox.Text + "\"" + ", " 
                + userlevelTextBox.Text + ", " 
                + mark + ", inrank=" 
                + inrankTextBox.Text + ", " 
                + outrankTextBox.Text + ", " 
                + ninTextBox.Text + ", " 
                + noutTextBox.Text + ", "
                + "\"" + contactTextBox.Text + "\"" + ", "
                + "\"" + reliableTextBox.Text + "\"" +
                "WHERE username=\"" + username + "\";";
            connector.Update(sql);
            connector.Close();
            searchable();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
