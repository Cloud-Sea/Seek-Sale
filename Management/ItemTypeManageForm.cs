﻿using System;
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
    public partial class ItemTypeManageForm : Form
    {
        string conn_str = "server=localhost; uid=root; pwd=Try2BBest; dataset=leftover";
        MySqlConnection conn;
        MySqlDataAdapter adapter;
        DataSet dataset;
        BindingSource bdsrc = new BindingSource();
        public ItemTypeManageForm()
        {
            InitializeComponent();
        }

        private void ItemTypeManageForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = conn_str;
                conn.Open();
                string sql = "SELECT * from ???";
                adapter = new MySqlDataAdapter(sql, conn);
                dataset = new DataSet();
                adapter.Fill(dataset, "userview");
                bdsrc.DataSource = dataset.Tables["userview"];
                itemtypeDataGridView.DataSource = bdsrc;
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

        private void itemtypeDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            writeback();
        }

        private void writeback()
        {
            try
            {
                bdsrc.DataSource = dataset.Tables["userview"];
                itemtypeDataGridView.DataSource = bdsrc;
                MySqlCommandBuilder cmdbuilder = new MySqlCommandBuilder(adapter);
                adapter.Update(dataset, "userview");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
