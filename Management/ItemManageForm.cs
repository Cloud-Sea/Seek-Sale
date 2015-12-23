using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Management
{
    public partial class ItemManageForm : Form
    {
        string conn_str = "server=localhost;user id=root;password=690111;database=leftover";
        MySqlConnection conn;
        MySqlDataAdapter adapter;
        DataSet dataset;
        BindingSource bdsrc = new BindingSource();
        public ItemManageForm()
        {
            InitializeComponent();
        }
        private void ItemManageForm_Load(object sender, EventArgs e)
        {
            refresh();
        }
        public void refresh()
        {
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = conn_str;
                conn.Open();
                string sql = "SELECT * from Itemtb;";
                adapter = new MySqlDataAdapter(sql, conn);
                dataset = new DataSet();
                adapter.Fill(dataset, "ItemTb");
                bdsrc.DataSource = dataset.Tables["ItemTb"];
                itemDataGridView.DataSource = bdsrc;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("不能连接到数据库");
                        break;
                    case 1045:
                        MessageBox.Show("用户名或密码错误");
                        break;
                    case 1049:
                        MessageBox.Show("数据库不存在或数据库名错误");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
            }
        }

        private void itemDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            writeback();
        }

        private void writeback()
        {
            try
            {
                bdsrc.DataSource = dataset.Tables["ItemTb"];
                itemDataGridView.DataSource = bdsrc;
                MySqlCommandBuilder cmdbuilder = new MySqlCommandBuilder(adapter);
                adapter.Update(dataset, "ItemTb");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
