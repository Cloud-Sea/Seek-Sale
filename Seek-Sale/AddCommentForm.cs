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
    public partial class AddCommentForm : Form
    {
        int id;
        OrderItem item;

        public AddCommentForm(int id, OrderItem item)
        {
            InitializeComponent();
            this.id = id;
            this.item = item;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DBConnector connector = new DBConnector();
            string sql;
            sql = "INSERT INTO Commenttb(commentid,content,score) VALUES ("
                + this.id.ToString() + ","
                + "\"" + commentTextBox.Text + "\","
                + scoreComboBox.Text.ToString() + ");";
            connector.Insert(sql);
            connector.Close();
            this.item.refresh();
            MessageBox.Show("保存成功！");
            MainForm.mainForm.mainSearchForm.refresh();
            this.Close();
        }

        private void AddCommentForm_Load(object sender, EventArgs e)
        {
            DBConnector connector = new DBConnector();
            string sql = "SELECT * FROM Commenttb WHERE commentid = " + this.id.ToString() + ";";
            OdbcDataReader reader = connector.Select(sql);
            if(reader.Read())
            {
                string score = reader.GetInt32(2).ToString();
                scoreComboBox.Text = score;
                string content = reader.GetString(1);
                commentTextBox.Text = content;
                scoreComboBox.Enabled = false;
                commentTextBox.ReadOnly = true;
                saveBtn.Visible = false;
            }
            else
            {
                commentTextBox.ReadOnly = false;
                scoreComboBox.Enabled = true;
                saveBtn.Visible = true;
            }
            connector.Close();
        }
    }
}
