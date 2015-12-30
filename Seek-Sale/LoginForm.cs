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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DBConnector connector = new DBConnector();
            string sql = "SELECT * FROM Userview WHERE username=\"" + usernameTextBox.Text + "\" AND passwd=\"" + passwordTextBox.Text + "\";";
            OdbcDataReader reader = connector.Select(sql);
            if(reader.Read())
            {
                UserInfo userinfo = UserInfo.instance;
                userinfo.logined = true;
                userinfo.userid = reader.GetInt32(0);
                userinfo.username = reader.GetString(1);
                this.Invoke(new MessageBoxShow(MessageBoxShow_F), new object[] { "登录成功" });
                this.Close();
            }
            else
            {
                this.Invoke(new MessageBoxShow(MessageBoxShow_F), new object[] { "登录失败，请重试" });
            }
        }

        delegate void MessageBoxShow(string msg);
        void MessageBoxShow_F(string msg)
        {
            MessageBox.Show(msg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void signinLabel_Click(object sender, EventArgs e)
        {
            RegisterForm regform = new RegisterForm(this);
            regform.ShowDialog();
        }
    }
}
