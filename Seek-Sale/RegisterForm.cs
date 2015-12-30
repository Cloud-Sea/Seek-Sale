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
    public partial class RegisterForm : Form
    {
        LoginForm loginform;
        public RegisterForm(LoginForm loginform)
        {
            InitializeComponent();
            this.loginform = loginform;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            loginform.Visible = false;
            passwordTextBox.PasswordChar = '*';
            repasswordTextBox.PasswordChar = '*';
            this.StartPosition = loginform.StartPosition;
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            if(passwordTextBox.Text != repasswordTextBox.Text)
            {
                this.Invoke(new MessageBoxShow(MessageBoxShow_F), new object[] { "两次密码不相同，请重试" });
                return;
            }
            DBConnector connector = new DBConnector();
            string sql = "SELECT * FROM Userview WHERE username=\"" + usernameTextBox.Text + "\";";
            OdbcDataReader reader = connector.Select(sql);
            if (reader.Read())
            {
                this.Invoke(new MessageBoxShow(MessageBoxShow_F), new object[] { "用户名已被使用，请重试" });
                loginform.Visible = true;
                this.Close();
            }
            else
            {
                sql = "INSERT INTO Userbasictb (username,passwd) VALUES ("
                    + "\"" + usernameTextBox.Text + "\"" + ", "
                    + "\"" + passwordTextBox.Text + "\");";
                connector.Insert(sql);
                sql = "SELECT userid FROM userbasictb WHERE username = \"" + usernameTextBox.Text + "\";";
                reader = connector.Select(sql);
                reader.Read();
                int userid = reader.GetInt32(0);
                sql = "INSERT INTO Usertradetb VALUES ("
                    + userid.ToString() + ", "
                    + "0" + ", "
                    + "0, "
                    + "0" + ", "
                    + "0" + ", "
                    + "0" + ", "
                    + "0" + ", "
                    + "\"" + contactTextBox.Text + "\"" + ", "
                    + "0" + ");";
                connector.Insert(sql);
                this.Invoke(new MessageBoxShow(MessageBoxShow_F), new object[] { "注册成功！" });
                loginform.Visible = true;
                this.Close();
            }
        }

        delegate void MessageBoxShow(string msg);
        void MessageBoxShow_F(string msg)
        {
            MessageBox.Show(msg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            loginform.Visible = true;
            this.Close();

        }
    }
}
