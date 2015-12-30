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
    public partial class MainModifyForm : Form
    {
        bool certified;
        public MainModifyForm()
        {
            InitializeComponent();
        }

        private void MainModifyForm_Load(object sender, EventArgs e)
        {
            DBConnector connector = new DBConnector();
            string sql = "SELECT * FROM Userview WHERE userid=\"" + UserInfo.instance.userid + "\";";
            OdbcDataReader reader = connector.Select(sql);
            if(reader.Read())
            {
                usernameTextBox.Text = reader.GetString(1);
                passwordTextBox.Text = "******";
                userlevelTextBox.Text = reader.GetInt32(3).ToString();
                this.certified = reader.GetInt32(4) == 1 ? true : false;
                yesRadioButton.Checked = certified ? true : false;
                noRadioButton.Checked = certified ? false : true;
                ninTextBox.Text = reader.GetInt32(5).ToString();
                noutTextBox.Text = reader.GetInt32(6).ToString();
                inrankTextBox.Text = reader.GetFloat(7).ToString();
                outrankTextBox.Text = reader.GetFloat(8).ToString();
                contactTextBox.Text = reader.GetString(9);
                reliableTextBox.Text = reader.GetFloat(10).ToString();
            }
            connector.Close();
        }

        private void yesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            yesRadioButton.Checked = this.certified;
            noRadioButton.Checked = !this.certified;
        }

        private void noRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            yesRadioButton.Checked = this.certified;
            noRadioButton.Checked = !this.certified;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DBConnector connector = new DBConnector();
            string sql;
            if(passwordTextBox.Text != "******")
            {
                sql = "UPDATE Userbasictb SET passwd = \"" + passwordTextBox.Text+"\";";
                connector.Update(sql);
            }
            sql = "UPDATE Usertradetb SET contact =\"" + contactTextBox.Text + "\";";
            connector.Update(sql);
            connector.Close();
            MessageBox.Show("修改成功");
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            DBConnector connector = new DBConnector();
            string sql = "SELECT * FROM Userview WHERE userid=\"" + UserInfo.instance.userid + "\";";
            OdbcDataReader reader = connector.Select(sql);
            if (reader.Read())
            {
                usernameTextBox.Text = reader.GetString(1);
                passwordTextBox.Text = "******";
                userlevelTextBox.Text = reader.GetInt32(3).ToString();
                this.certified = reader.GetInt32(4) == 1 ? true : false;
                yesRadioButton.Checked = certified ? true : false;
                noRadioButton.Checked = certified ? false : true;
                ninTextBox.Text = reader.GetInt32(5).ToString();
                noutTextBox.Text = reader.GetInt32(6).ToString();
                inrankTextBox.Text = reader.GetFloat(7).ToString();
                outrankTextBox.Text = reader.GetFloat(8).ToString();
                contactTextBox.Text = reader.GetString(9);
                reliableTextBox.Text = reader.GetFloat(10).ToString();
            }
            connector.Close();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            ModifyPayForm modifypayform = new ModifyPayForm();
            modifypayform.ShowDialog();

        }

        private void posBtn_Click(object sender, EventArgs e)
        {
            ModifyPosForm modifyposform = new ModifyPosForm();
            modifyposform.ShowDialog();
        }
    }
}
